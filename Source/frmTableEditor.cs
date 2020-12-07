﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static upatcher;
using MathParserTK;
using System.Diagnostics;
using System.Globalization;
using System.IO;

namespace UniversalPatcher
{
    public partial class frmTableEditor : Form
    {
        public frmTableEditor()
        {
            InitializeComponent();
        }

        private TableData td;
        private PcmFile PCM;
        private bool tableModified = false;
        private bool commaDecimal = true;
        MathParser parser = new MathParser();

        private void frmTableEditor_Load(object sender, EventArgs e)
        {
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);

            autoResizeToolStripMenuItem.Checked = Properties.Settings.Default.TableEditorAutoResize;
            if (Properties.Settings.Default.TableEditorAutoResize)
            {
                AutoResize();
            }
            else if (Properties.Settings.Default.MainWindowPersistence)
            {
                if (Properties.Settings.Default.TableEditorWindowSize.Width > 0 || Properties.Settings.Default.TableEditorWindowSize.Height > 0)
                {
                    this.WindowState = Properties.Settings.Default.TableEditorWindowState;
                    if (this.WindowState == FormWindowState.Minimized)
                    {
                        this.WindowState = FormWindowState.Normal;
                    }
                    this.Location = Properties.Settings.Default.TableEditorWindowLocation;
                    this.Size = Properties.Settings.Default.TableEditorWindowSize;
                }
            }
            tableModified = false;
            disableTooltipsToolStripMenuItem.Checked = false;
        }
        public void loadSeekTable(int tId, PcmFile PCM1)
        {

            var currentCulture = System.Threading.Thread.CurrentThread.CurrentCulture.Name;
            NumberFormatInfo nfi = new CultureInfo(currentCulture, false).NumberFormat;
            if (nfi.NumberDecimalSeparator == ",") commaDecimal = true;
            else commaDecimal = false;

            PCM = PCM1;
            TableSeek tSeek = tableSeeks[foundTables[tId].configId];
            this.Text = "Table Editor: " + foundTables[tId].Name;
            if (foundTables[tId].Description.Length > 0)
                this.Text += " - " + foundTables[tId].Description;

            FoundTable ft = foundTables[tId];

            td = new TableData();
            td.AddrInt = ft.addrInt;
            td.Address = ft.Address;
            td.Category = ft.Category;
            td.Floating = tSeek.Floating;
            td.ElementSize = (byte)(tSeek.Bits / 8);
            td.Math = tSeek.Math;
            td.SavingMath = tSeek.SavingMath;
            td.OS = PCM.OS;
            td.RowMajor = tSeek.RowMajor;
            td.Rows = ft.Rows;
            td.Columns = ft.Columns;
            td.ColumnHeaders = tSeek.ColHeaders;
            td.RowHeaders = tSeek.RowHeaders;
            td.Decimals = tSeek.Decimals;
            td.Signed = tSeek.Signed;
            td.TableDescription = tSeek.Description;
            td.TableName = ft.Name;
            td.Units = tSeek.Units;

            loadTable(td, PCM);
        }

        private double getFloatValue(uint addr)
        {
            double value = 0;
            try
            {
                if (td.ElementSize == 4 || td.ElementSize == 8)
                {
                    byte[] data = new byte[td.ElementSize];
                    Array.Copy(PCM.buf, addr, data, 0, td.ElementSize);
                    Array.Reverse(data);
                    if (td.ElementSize == 4)
                        value = BitConverter.ToSingle(data, 0);
                    else
                        value = BitConverter.ToDouble(data, 0);
                    string mathStr = td.Math.ToLower().Replace("x", value.ToString());
                    if (commaDecimal) mathStr = mathStr.Replace(".", ",");
                    value = parser.Parse(mathStr, false);
                }
                else
                {
                    throw new Exception("Floating point requires 4 or 8 bytes");
                }
            }
            catch (Exception ex)
            {
                var st = new StackTrace(ex, true);
                // Get the top stack frame
                var frame = st.GetFrame(st.FrameCount - 1);
                // Get the line number from the stack frame
                var line = frame.GetFileLineNumber();
                MessageBox.Show("Error, line " + line + ": " + ex.Message, "Error");
            }
            return value;
        }

        private double getValue(uint addr)
        {
            double value = 0;
            if (td.ElementSize == 1)
            {
                if (td.Signed)
                    value = (byte)unchecked((sbyte)PCM.buf[addr]);
                else
                    value = PCM.buf[addr];
            }
            if (td.ElementSize == 2)
            {
                if (td.Signed)
                    value = BEToInt16(PCM.buf, addr);
                else
                    value = BEToUint16(PCM.buf, addr);
            }
            if (td.ElementSize == 4)
            {
                if (td.Signed)
                    value = BEToInt32(PCM.buf, addr);
                else
                    value = BEToUint32(PCM.buf, addr);
            }
            if (td.ElementSize == 8)
            {
                if (td.Signed)
                    value = BEToInt64(PCM.buf, addr);
                else
                    value = BEToUint64(PCM.buf, addr);
            }
            string mathStr = td.Math.ToLower().Replace("x", value.ToString());
            if (commaDecimal) mathStr = mathStr.Replace(".", ",");
            value = parser.Parse(mathStr, false);
            return value;
        }

        private UInt64 getRawValue(UInt32 addr)
        {
            if (td.ElementSize == 2)
                return BEToUint16(PCM.buf, addr);
            if (td.ElementSize == 4)
                return BEToUint32(PCM.buf, addr);
            if (td.ElementSize == 8)
                return BEToUint64(PCM.buf, addr);
            return PCM.buf[addr];
        }

        public void setCellValue(uint addr, int row, int col)
        {
            try
            {
                if (showRawHEXValuesToolStripMenuItem.Checked)
                    dataGridView1.Rows[row].Cells[col].Value = getRawValue(addr);
                else if (td.OutputType == TypeText)
                    dataGridView1.Rows[row].Cells[col].Value = Convert.ToChar((ushort)getValue(addr));
                else if (td.Floating == false)
                    dataGridView1.Rows[row].Cells[col].Value = getValue(addr);
                else
                    dataGridView1.Rows[row].Cells[col].Value = getFloatValue(addr);
                dataGridView1.Rows[row].Cells[col].Tag = addr;

                if (!disableTooltipsToolStripMenuItem.Checked && td.TableDescription != null)
                    dataGridView1.Rows[row].Cells[col].ToolTipText = td.TableDescription;

            }
            catch (Exception ex)
            {
                var st = new StackTrace(ex, true);
                // Get the top stack frame
                var frame = st.GetFrame(st.FrameCount - 1);
                // Get the line number from the stack frame
                var line = frame.GetFileLineNumber();
                MessageBox.Show("Error, line " + line + ": " + ex.Message, "Error");
            }
        }

        public void loadTable(TableData td1, PcmFile PCM1)
        {

            var currentCulture = System.Threading.Thread.CurrentThread.CurrentCulture.Name;
            NumberFormatInfo nfi = new CultureInfo(currentCulture, false).NumberFormat;
            if (nfi.NumberDecimalSeparator == ",") commaDecimal = true;
            else commaDecimal = false;

            PCM = PCM1;
            td = td1;

            this.Text = "Table Editor: " + td.TableName;
            if (td.TableDescription != null && td.TableDescription.Length > 0)
                this.Text += " - " + td.TableDescription;

            if (td.Units != null)
                labelUnits.Text = "Units: " + td.Units;

            int rowCount = td.Rows;
            int colCount = td.Columns;

            string[] colHeaders = td.ColumnHeaders.Split(',');
            string[] rowHeaders = td.RowHeaders.Split(',');
            if (swapXyToolStripMenuItem.Checked)
            {
                //Swap col/row
                rowCount = td.Columns;
                colCount = td.Rows;
                colHeaders = td.RowHeaders.Split(',');
                rowHeaders = td.ColumnHeaders.Split(',');
            }
            dataGridView1.Rows.Clear();
            dataGridView1.ColumnCount = colCount;

            //dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader; // .AutoResizeColumns(DataGridViewAutoSizeColumnsMode.Fill);
            uint addr = td.AddrInt;
            int step = (int)(td.ElementSize);

            if (swapXyToolStripMenuItem.Checked ^ td.RowMajor == false)
            {
                for (int r=0; r < rowCount; r++)
                    dataGridView1.Rows.Add();
                for (int c = 0; c < colCount; c++)
                {
                    for (int r = 0; r < rowCount; r++)
                    {
                        setCellValue(addr, r, c);
                        addr += (uint)step;
                    }
                }

            }
            else
            {
                for (int r = 0; r < rowCount; r++)
                {
                    var index = dataGridView1.Rows.Add();
                    for (int c = 0; c < colCount; c++)
                    {
                        setCellValue(addr, r, c);
                        addr += (uint)step;
                    }
                }
            }
            for (int c = 0; c < colCount; c++)
            {
                string headerTxt = "";
                if (c > colHeaders.Length - 1 || colHeaders[0].Length == 0)
                    headerTxt = "";
                else
                    headerTxt = colHeaders[c];
                dataGridView1.Columns[c].HeaderText = headerTxt;
            }
            for (int r = 0; r < rowHeaders.Length; r++)
            {
                if (r < rowCount)
                    dataGridView1.Rows[r].HeaderCell.Value = rowHeaders[r];
            }

            setDataGridLayout();
        }

        private void setDataGridLayout()
        {
            try
            {
                string formatStr = "0";
                if (showRawHEXValuesToolStripMenuItem.Checked || td.OutputType == TypeHex)
                {
                    formatStr = "X" + (td.ElementSize * 2).ToString();
                }
                else if (td.OutputType == TypeText)
                {
                    formatStr = "";
                }
                else
                {
                    for (int f = 1; f <= td.Decimals; f++)
                    {
                        if (f == 1) formatStr += ".";
                        formatStr += "0";
                    }
                    formatStr += "#";
                }
                foreach (DataGridViewColumn dgvc in dataGridView1.Columns)
                {
                    dgvc.SortMode = DataGridViewColumnSortMode.NotSortable;
                    dgvc.DefaultCellStyle.Format = formatStr;
                }
                dataGridView1.AutoResizeColumns();
                dataGridView1.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
                if (autoResizeToolStripMenuItem.Checked) AutoResize();
            }
            catch (Exception ex)
            {
                var st = new StackTrace(ex, true);
                // Get the top stack frame
                var frame = st.GetFrame(st.FrameCount - 1);
                // Get the line number from the stack frame
                var line = frame.GetFileLineNumber();
                MessageBox.Show("Error, line " + line + ": " + ex.Message, "Error");
            }

        }
        private void DataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                tableModified = true;
                swapXyToolStripMenuItem.Enabled = false;
            }
        }

        private void SaveValue(uint addr,int r, int c)
        {
            MathParser parser = new MathParser();

            double value = Convert.ToDouble(dataGridView1.Rows[r].Cells[c].Value);
            string mathStr = td.SavingMath.ToLower().Replace("x", value.ToString());
            if (commaDecimal) mathStr = mathStr.Replace(".", ",");
            value = parser.Parse(mathStr, true);
            if (td.ElementSize == 1)
            {
                PCM.buf[addr] = (byte)value;
            }
            if (td.ElementSize == 2)
            {
                if (td.Signed)
                {
                    short newValue = (short)value;
                    PCM.buf[addr] = (byte)((newValue & 0xFF00) >> 8);
                    PCM.buf[addr + 1] = (byte)(newValue & 0xFF);
                }
                else
                {
                    ushort newValue = (ushort)value;
                    PCM.buf[addr] = (byte)((newValue & 0xFF00) >> 8);
                    PCM.buf[addr + 1] = (byte)(newValue & 0xFF);
                }

            }
            if (td.ElementSize == 4)
            {
                if (td.Floating)
                {
                    byte[] buffer = BitConverter.GetBytes((float)value);
                    PCM.buf[addr] = buffer[0];
                    PCM.buf[addr + 1] = buffer[1];
                    PCM.buf[addr + 2] = buffer[2];
                    PCM.buf[addr + 3] = buffer[3];
                }
                else
                {
                    if (td.Signed)
                    {
                        Int32 newValue = (Int32)value;
                        PCM.buf[addr] = (byte)((newValue & 0xFF000000) >> 24);
                        PCM.buf[addr + 1] = (byte)((newValue & 0xFF0000) >> 16);
                        PCM.buf[addr + 2] = (byte)((newValue & 0xFF00) >> 8);
                        PCM.buf[addr + 3] = (byte)(newValue & 0xFF);
                    }
                    else
                    {
                        UInt32 newValue = (UInt32)value;
                        PCM.buf[addr] = (byte)((newValue & 0xFF000000) >> 24);
                        PCM.buf[addr + 1] = (byte)((newValue & 0xFF0000) >> 16);
                        PCM.buf[addr + 2] = (byte)((newValue & 0xFF00) >> 8);
                        PCM.buf[addr + 3] = (byte)(newValue & 0xFF);
                    }
                }
            }

        }
        private void saveTable()
        {
            try
            {

                for (int r=0; r< dataGridView1.Rows.Count; r++)
                {
                    for (int c=0; c< dataGridView1.Columns.Count; c++)
                    {
                        SaveValue(Convert.ToUInt32(dataGridView1.Rows[r].Cells[c].Tag), r, c);
                    }
                }

            }
            catch (Exception ex)
            {
                var st = new StackTrace(ex, true);
                // Get the top stack frame
                var frame = st.GetFrame(st.FrameCount - 1);
                // Get the line number from the stack frame
                var line = frame.GetFileLineNumber();
                MessageBox.Show("Error, line " + line + ": " + ex.Message, "Error");
            }

        }
        private void btnExecute_Click(object sender, EventArgs e)
        {
            try
            {
                MathParser parser = new MathParser();

                foreach (DataGridViewCell cell in dataGridView1.SelectedCells)
                {
                    string mathStr = txtMath.Text.ToLower().Replace("x", cell.Value.ToString());
                    if (commaDecimal) mathStr = mathStr.Replace(".", ",");
                    double newvalue = parser.Parse(mathStr);
                    cell.Value = newvalue;
                }
                tableModified = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void AutoResize()
        {
            int dgv_width = dataGridView1.Columns.GetColumnsWidth(DataGridViewElementStates.Visible);
            if (dgv_width < 175) dgv_width = 175;
            int dgv_height = dataGridView1.Rows.GetRowsHeight(DataGridViewElementStates.Visible);
            Screen myScreen = Screen.FromPoint(Cursor.Position);
            System.Drawing.Rectangle area = myScreen.WorkingArea;
            if ((dgv_width + 125) > area.Width)
                this.Width = area.Width - 50;
            else
                this.Width = dgv_width + 125;
            if ((dgv_height + 100) > area.Height)
                this.Height = area.Height - 50;
            else
                this.Height = dgv_height + 150;

        }
        private void frmTableEditor_FormClosing(object sender, EventArgs e)
        {
            try
            {
                if (Properties.Settings.Default.MainWindowPersistence)
                {
                    Properties.Settings.Default.TableEditorWindowState = this.WindowState;
                    if (this.WindowState == FormWindowState.Normal)
                    {
                        Properties.Settings.Default.TableEditorWindowLocation = this.Location;
                        Properties.Settings.Default.TableEditorWindowSize = this.Size;
                    }
                    else
                    {
                        Properties.Settings.Default.TableEditorWindowLocation = this.RestoreBounds.Location;
                        Properties.Settings.Default.TableEditorWindowSize = this.RestoreBounds.Size;
                    }
                    Properties.Settings.Default.Save();
                }

                if (tableModified)
                {
                    DialogResult dialogResult = MessageBox.Show("Apply modifications?", "Apply modifications?", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        saveTable();
                        this.DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        this.DialogResult = DialogResult.Cancel;
                    }
                }
            }
            catch (Exception ex)
            {
                var st = new StackTrace(ex, true);
                // Get the top stack frame
                var frame = st.GetFrame(st.FrameCount - 1);
                // Get the line number from the stack frame
                var line = frame.GetFileLineNumber();
                MessageBox.Show("Error, line " + line + ": " + ex.Message, "Error");
            }
        }

        private void chkAutoResize_CheckedChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.TableEditorAutoResize = autoResizeToolStripMenuItem.Checked;
            Properties.Settings.Default.Save();
            if (autoResizeToolStripMenuItem.Checked)
            {
                AutoResize();
            }
        }

        private void chkTranspose_CheckedChanged(object sender, EventArgs e)
        {
            loadTable(td, PCM);
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoResizeRowHeadersWidth(DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders);
            if (autoResizeToolStripMenuItem.Checked) AutoResize();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Copy to clipboard
            CopyToClipboard();

            //Clear selected cells
            foreach (DataGridViewCell dgvCell in dataGridView1.SelectedCells)
                dgvCell.Value = string.Empty;
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CopyToClipboard();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Perform paste Operation
            PasteClipboardValue();
        }
        private void CopyToClipboard()
        {
            //Copy to clipboard
            DataObject dataObj = dataGridView1.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }

        private void PasteClipboardValue()
        {
            //Show Error if no cell is selected
            if (dataGridView1.SelectedCells.Count == 0)
            {
                MessageBox.Show("Please select a cell", "Paste",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Get the starting Cell
            DataGridViewCell startCell = GetStartCell(dataGridView1);
            //Get the clipboard value in a dictionary
            Dictionary<int, Dictionary<int, string>> cbValue =
                    ClipBoardValues(Clipboard.GetText());

            int iRowIndex = startCell.RowIndex;
            foreach (int rowKey in cbValue.Keys)
            {
                int iColIndex = startCell.ColumnIndex;
                foreach (int cellKey in cbValue[rowKey].Keys)
                {
                    //Check if the index is within the limit
                    if (iColIndex <= dataGridView1.Columns.Count - 1
                    && iRowIndex <= dataGridView1.Rows.Count - 1)
                    {
                        DataGridViewCell cell = dataGridView1[iColIndex, iRowIndex];

                        //Copy to selected cells if 'chkPasteToSelectedCells' is checked
                        //if ((chkPasteToSelectedCells.Checked && cell.Selected) || (!chkPasteToSelectedCells.Checked))
                            cell.Value = cbValue[rowKey][cellKey];
                    }
                    iColIndex++;
                }
                iRowIndex++;
            }
        }

        private DataGridViewCell GetStartCell(DataGridView dgView)
        {
            //get the smallest row,column index
            if (dgView.SelectedCells.Count == 0)
                return null;

            int rowIndex = dgView.Rows.Count - 1;
            int colIndex = dgView.Columns.Count - 1;

            foreach (DataGridViewCell dgvCell in dgView.SelectedCells)
            {
                if (dgvCell.RowIndex < rowIndex)
                    rowIndex = dgvCell.RowIndex;
                if (dgvCell.ColumnIndex < colIndex)
                    colIndex = dgvCell.ColumnIndex;
            }

            return dgView[colIndex, rowIndex];
        }

        private Dictionary<int, Dictionary<int, string>> ClipBoardValues(string clipboardValue)
        {
            Dictionary<int, Dictionary<int, string>>
            copyValues = new Dictionary<int, Dictionary<int, string>>();

            String[] lines = clipboardValue.Split('\n');

            for (int i = 0; i <= lines.Length - 1; i++)
            {
                copyValues[i] = new Dictionary<int, string>();
                String[] lineContent = lines[i].Split('\t');

                //if an empty cell value copied, then set the dictionary with an empty string
                //else Set value to dictionary
                if (lineContent.Length == 0)
                    copyValues[i][0] = string.Empty;
                else
                {
                    for (int j = 0; j <= lineContent.Length - 1; j++)
                        copyValues[i][j] = lineContent[j];
                }
            }
            return copyValues;
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
                dataGridView1.ContextMenuStrip = contextMenuStrip1;
        }

        private void exportCsv()
        {
            try
            {

                string FileName = SelectSaveFile("CSV files (*.csv)|*.csv|All files (*.*)|*.*");
                if (FileName.Length == 0)
                    return;
                using (StreamWriter writetext = new StreamWriter(FileName))
                {
                    string row = ";";
                    for (int i = 0; i < dataGridView1.Columns.Count; i++)
                    {
                        if (i > 0)
                            row += ";";
                        row += dataGridView1.Columns[i].HeaderText;
                    }
                    writetext.WriteLine(row);
                    for (int r = 0; r < (dataGridView1.Rows.Count - 1); r++)
                    {
                        row = dataGridView1.Rows[r].HeaderCell.Value.ToString() + ";";
                        for (int i = 0; i < dataGridView1.Columns.Count; i++)
                        {
                            if (i > 0)
                                row += ";";
                            if (dataGridView1.Rows[r].Cells[i].Value != null)
                                row += dataGridView1.Rows[r].Cells[i].Value.ToString();
                        }
                        writetext.WriteLine(row);
                    }
                }
                MessageBox.Show(FileName, "CSV Export done");
            }
            catch (Exception ex)
            {
                var st = new StackTrace(ex, true);
                // Get the top stack frame
                var frame = st.GetFrame(st.FrameCount - 1);
                // Get the line number from the stack frame
                var line = frame.GetFileLineNumber();
                MessageBox.Show("Error, line " + line + ": " + ex.Message, "Error");
            }

        }
        private void exportCsvToolStripMenuItem_Click(object sender, EventArgs e)
        {
            exportCsv();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveTable();
        }

        private void exportCSVToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            exportCsv();
        }

        private void autoResizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (autoResizeToolStripMenuItem.Checked)
                autoResizeToolStripMenuItem.Checked = false;
            else
                autoResizeToolStripMenuItem.Checked = true;
            Properties.Settings.Default.TableEditorAutoResize = autoResizeToolStripMenuItem.Checked;
            Properties.Settings.Default.Save();
            if (autoResizeToolStripMenuItem.Checked)
            {
                AutoResize();
            }

        }

        private void swapXyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (swapXyToolStripMenuItem.Checked)
                swapXyToolStripMenuItem.Checked = false;
            else
                swapXyToolStripMenuItem.Checked = true;
            chkSwapXY.Checked = swapXyToolStripMenuItem.Checked;
            loadTable(td, PCM);

        }

        private void chkSwapXY_CheckedChanged(object sender, EventArgs e)
        {
            swapXyToolStripMenuItem.Checked = chkSwapXY.Checked;
            loadTable(td, PCM);
        }

        private void showRawHEXValuesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (showRawHEXValuesToolStripMenuItem.Checked)
                showRawHEXValuesToolStripMenuItem.Checked = false;
            else
                showRawHEXValuesToolStripMenuItem.Checked = true;
            loadTable(td, PCM);

        }

        private void disableTooltipsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (disableTooltipsToolStripMenuItem.Checked)
                disableTooltipsToolStripMenuItem.Checked = false;
            else
                disableTooltipsToolStripMenuItem.Checked = true;
        }
    }
}