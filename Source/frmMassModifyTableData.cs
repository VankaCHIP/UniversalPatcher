﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Windows.Forms;
using static upatcher;

namespace UniversalPatcher
{
    public partial class frmMassModifyTableData : Form
    {
        public frmMassModifyTableData()
        {
            InitializeComponent();
        }

        public class TunerFile
        {
            public List<TableData> tableDatas = new List<TableData>();
            public string fileName { get; set; }
        }

        private class ClibBrd
        {
            public string Property { get; set; }
            public string Value { get; set; }
        }
        private class TableDataPointer
        {
            public int tunerFile { get; set; }
            public int tableData { get; set; }
        }

        private class MassModProperties : TableData
        {
            public MassModProperties()
            {
                UsingTableDatas = new List<TableDataPointer>();
            }
            public string UsedInOS { get; set; }
            public List<TableDataPointer> UsingTableDatas;
            public TableData td;
        }

        public class TableDataExtended : TableData
        {
            public bool Select { get; set; }
            public string File { get; set; }
            public int fileId { get; set; }
        }

        private List<TunerFile> tunerFiles = new List<TunerFile>();
        private List<int> modifiedFiles = new List<int>();
        private List<string> tableRows = new List<string>();
        private List<MassModProperties> displayDatas = new List<MassModProperties>();
        private BindingSource bindingSource = new BindingSource();
        SortOrder strSortOrder = SortOrder.Ascending;
        private string sortBy = "TableName";
        private int sortIndex = 1;
        private List<ClibBrd> clipBrd = new List<ClibBrd>();

        private void frmMassModifyTableData_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.MainWindowPersistence)
            {
                if (Properties.Settings.Default.MassModifyTableDataWindowSize.Width > 0 || Properties.Settings.Default.MassModifyTableDataWindowSize.Height > 0)
                {
                    this.WindowState = Properties.Settings.Default.MassModifyTableDataWindowState;
                    if (this.WindowState == FormWindowState.Minimized)
                    {
                        this.WindowState = FormWindowState.Normal;
                    }
                    this.Location = Properties.Settings.Default.MassModifyTableDataWindowLocation;
                    this.Size = Properties.Settings.Default.MassModifyTableDataWindowSize;
                }
                if (Properties.Settings.Default.MassModifyTableDataWindowSplitterDistance > 0)
                    splitContainer1.SplitterDistance = Properties.Settings.Default.MassModifyTableDataWindowSplitterDistance;
            }
            this.FormClosing += FrmMassModifyTableData_FormClosing;
            dataGridView1.CellMouseClick += DataGridView1_CellMouseClick;
            dataGridView1.DataBindingComplete += DataGridView1_DataBindingComplete;
            dataGridView1.DataError += DataGridView1_DataError;
        }

        private void DataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].Name == "id" || dataGridView1.Columns[e.ColumnIndex].Name == "UsedInOS")
                e.Cancel = true;
        }


        private void DataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            
        }

        private void DataGridView1_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            UseComboBoxForEnums(dataGridView1);
        }

        private void FrmMassModifyTableData_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Properties.Settings.Default.MainWindowPersistence)
            {
                Properties.Settings.Default.MassModifyTableDataWindowState = this.WindowState;
                if (this.WindowState == FormWindowState.Normal)
                {
                    Properties.Settings.Default.MassModifyTableDataWindowLocation = this.Location;
                    Properties.Settings.Default.MassModifyTableDataWindowSize = this.Size;
                }
                else
                {
                    Properties.Settings.Default.MassModifyTableDataWindowLocation = this.RestoreBounds.Location;
                    Properties.Settings.Default.MassModifyTableDataWindowSize = this.RestoreBounds.Size;
                }
                Properties.Settings.Default.MassModifyTableDataWindowSplitterDistance = splitContainer1.SplitterDistance;
            }
        }

        private void DataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (dataGridView1.Columns.Count < 4)
                    return;
                if (dataGridView1.Columns[e.ColumnIndex].Name == "id" || dataGridView1.Columns[e.ColumnIndex].Name == "UsedInOS")
                    return;
                int row = dataGridView2.Rows.Add();
                dataGridView2.Rows[row].Cells["Property"].Value = dataGridView1.Columns[e.ColumnIndex].Name;
                int mmid = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells["id"].Value);
                TableData td = displayDatas[mmid].td;
                if (td != null)
                {
                    Type type = td.GetType();
                    PropertyInfo prop = type.GetProperty(dataGridView1.Columns[e.ColumnIndex].Name);
                    if (prop != null)
                        dataGridView2.Rows[row].Cells["OldValue"].Value = prop.GetValue(td, null); 
                }
                dataGridView2.Rows[row].Cells["TableName"].Value = td.TableName;
                dataGridView2.Rows[row].Cells["OS"].Value = dataGridView1.Rows[e.RowIndex].Cells["UsedInOS"].Value;
                dataGridView2.Rows[row].Cells["OS"].Tag = displayDatas[mmid].UsingTableDatas;
                dataGridView2.Rows[row].Cells["NewValue"].Value = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
                if (dataGridView2.Rows.Count < 3)
                    dataGridView2.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            }
            catch (Exception ex)
            {
                LoggerBold(ex.Message);
            }
        }

        private void DataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {

                if (dataGridView1.SelectedCells.Count > 0 && e.Button == MouseButtons.Right)
                {
                    //lastSelectedId = Convert.ToInt32(dataGridView1.Rows[dataGridView1.SelectedCells[0].RowIndex].Cells["id"].Value);
                    contextMenuStrip1.Show(Cursor.Position.X, Cursor.Position.Y);
                }
            }
            catch { }
        }

        public void loadData(List<string> fileList)
        {
            dataGridView2.Columns.Add("TableName", "TableName");
            dataGridView2.Columns.Add("Property", "Property");
            dataGridView2.Columns.Add("OldValue", "OldValue");
            dataGridView2.Columns.Add("NewValue", "NewValue");
            dataGridView2.Columns.Add("OS", "OS");

            MassModProperties tmpMmp = new MassModProperties();
            foreach (var prop in tmpMmp.GetType().GetProperties())
            {
                //Add to filter by-combo
                comboFilterBy.Items.Add(prop.Name);
            }
            comboFilterBy.Text = "TableName";

            foreach (string fName in fileList)
            {
                long conFileSize = new FileInfo(fName).Length;
                if (conFileSize < 255 || Path.GetFileName(fName).ToLower() == "units.xml")
                    continue;
                TunerFile tf = new TunerFile();
                tf.tableDatas = loadTableDataFile(fName);
                tf.fileName = fName;
                tunerFiles.Add(tf);
                addTableListTodgrid(tf.tableDatas);
            }
            for (int i = 0; i < displayDatas.Count; i++)
                displayDatas[i].id = (uint)i;
            dataGridView1.DataSource = bindingSource;
            filterData();

            dataGridView1.ColumnHeaderMouseClick += DataGridView1_ColumnHeaderMouseClick;
            dataGridView1.CellValueChanged += DataGridView1_CellValueChanged;
            dataGridView1.CellBeginEdit += DataGridView1_CellBeginEdit;
            Application.DoEvents();
            
            dataGridView1.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.DisplayedCells);
            if (dataGridView1.Columns[0].Width > 500)
                dataGridView1.Columns[0].Width = 500;
            Logger("Files loaded");
        }

        private void addTableListTodgrid(List<TableData> tdList)
        {
            for (int t = 0; t < tdList.Count; t++)
            {
                MassModProperties mmp = new MassModProperties();
                mmp.td = tdList[t];
                //string ser = upatcher.SerializeObject<MassModProperties>(mmp);
                string ser = "";
                TableData td = tdList[t];
                foreach (var prop in td.GetType().GetProperties())
                {
                    if (prop.Name != "id" && prop.Name != "Address" && prop.Name != "CompatibleOS" && prop.Name != "OS")
                        ser += prop.GetValue(td, null);

                    Type type = mmp.GetType();
                    PropertyInfo mmpProp = type.GetProperty(prop.Name);
                    mmpProp.SetValue(mmp, prop.GetValue(td, null), null);
                }

                int ind = tableRows.IndexOf(ser);
                if (ind < 0)
                {
                    tableRows.Add(ser);
                    mmp.UsedInOS = tdList[t].OS;
                    //mmp.UsingTunerFiles.Add(tunerFiles.Count - 1);
                    TableDataPointer tdp = new TableDataPointer();
                    tdp.tableData = t;
                    tdp.tunerFile = tunerFiles.Count - 1;
                    mmp.UsingTableDatas.Add(tdp);
                    displayDatas.Add(mmp);
                }
                else
                {
                    displayDatas[ind].UsedInOS += "," + tdList[t].OS;
                    //displayDatas[ind].UsingTunerFiles.Add(tunerFiles.Count - 1);
                    TableDataPointer tdp = new TableDataPointer();
                    tdp.tableData = t;
                    tdp.tunerFile = tunerFiles.Count - 1;
                    displayDatas[ind].UsingTableDatas.Add(tdp);
                }
            }
        }


        private void DataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                //saveGridLayout(); //Save before reorder!
                sortBy = dataGridView1.Columns[e.ColumnIndex].Name;
                sortIndex = e.ColumnIndex;
                strSortOrder = getSortOrder(sortIndex);
                filterData();
            }
        }
        private SortOrder getSortOrder(int columnIndex)
        {
            try
            {
                if (dataGridView1.Columns[columnIndex].HeaderCell.SortGlyphDirection == SortOrder.Descending
                    || dataGridView1.Columns[columnIndex].HeaderCell.SortGlyphDirection == SortOrder.None)
                {
                    dataGridView1.Columns[columnIndex].HeaderCell.SortGlyphDirection = SortOrder.Ascending;
                    return SortOrder.Ascending;
                }
                else
                {
                    dataGridView1.Columns[columnIndex].HeaderCell.SortGlyphDirection = SortOrder.Descending;
                    return SortOrder.Descending;
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
            }
            return SortOrder.Ascending;
        }

        private void filterData()
        {
            List<MassModProperties> compareList = new List<MassModProperties>();
            if (strSortOrder == SortOrder.Ascending)
                compareList = displayDatas.OrderBy(x => typeof(MassModProperties).GetProperty(sortBy).GetValue(x, null)).ToList();
            else
                compareList = displayDatas.OrderByDescending(x => typeof(MassModProperties).GetProperty(sortBy).GetValue(x, null)).ToList();

            var results = compareList.Where(t => t.TableName != ""); //How should I define empty variable??

            if (txtSearch.Text.Length > 0)
            {
                string newStr = txtSearch.Text.Replace("OR", "|");
                if (newStr.Contains("|"))
                {
                    string[] orStr = newStr.Split('|');
                    if (orStr.Length == 2)
                        results = results.Where(t => typeof(MassModProperties).GetProperty(comboFilterBy.Text).GetValue(t, null).ToString().ToLower().Contains(orStr[0].Trim()) ||
                        typeof(MassModProperties).GetProperty(comboFilterBy.Text).GetValue(t, null).ToString().ToLower().Contains(orStr[1].Trim()));
                    if (orStr.Length == 3)
                        results = results.Where(t => typeof(MassModProperties).GetProperty(comboFilterBy.Text).GetValue(t, null).ToString().ToLower().Contains(orStr[0].Trim()) ||
                        typeof(MassModProperties).GetProperty(comboFilterBy.Text).GetValue(t, null).ToString().ToLower().Contains(orStr[1].Trim()) ||
                        typeof(MassModProperties).GetProperty(comboFilterBy.Text).GetValue(t, null).ToString().ToLower().Contains(orStr[2].Trim()));
                    if (orStr.Length == 4)
                        results = results.Where(t => typeof(MassModProperties).GetProperty(comboFilterBy.Text).GetValue(t, null).ToString().ToLower().Contains(orStr[0].Trim()) ||
                        typeof(MassModProperties).GetProperty(comboFilterBy.Text).GetValue(t, null).ToString().ToLower().Contains(orStr[1].Trim()) ||
                        typeof(MassModProperties).GetProperty(comboFilterBy.Text).GetValue(t, null).ToString().ToLower().Contains(orStr[2].Trim()) ||
                        typeof(MassModProperties).GetProperty(comboFilterBy.Text).GetValue(t, null).ToString().ToLower().Contains(orStr[3].Trim()));
                }
                else
                {
                    newStr = txtSearch.Text.Replace("AND", "&");
                    string[] andStr = newStr.Split('&');
                    foreach (string sStr in andStr)
                        results = results.Where(t => typeof(MassModProperties).GetProperty(comboFilterBy.Text).GetValue(t, null).ToString().ToLower().Contains(sStr.Trim()));
                }
            }
            bindingSource.DataSource = results;
            dataGridView1.Columns[sortIndex].HeaderCell.SortGlyphDirection = strSortOrder;
        }

/*        private void addToGrid(string Property, string oldVal, string newVal)
        {
            int row = dataGridView2.Rows.Add();
            dataGridView2.Rows[row].Cells["Property"].Value = Property;
            dataGridView2.Rows[row].Cells["OldValue"].Value = oldVal;
            dataGridView2.Rows[row].Cells["NewValue"].Value = newVal;
        }
*/
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            filterData();
        }

        private void btnExecute_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.EndEdit();
                dataGridView2.EndEdit();
                for (int row = 0; row < dataGridView2.Rows.Count; row++)
                {
                    if (dataGridView2.Rows[row].Cells["TableName"].Value == null)
                        break;
                    string tableName = dataGridView2.Rows[row].Cells["TableName"].Value.ToString();
                    string Property = dataGridView2.Rows[row].Cells["Property"].Value.ToString();
                    string oldVal = dataGridView2.Rows[row].Cells["OldValue"].Value.ToString();
                    string newVal = dataGridView2.Rows[row].Cells["NewValue"].Value.ToString();
                    List<TableDataPointer> tFiles = (List<TableDataPointer>)dataGridView2.Rows[row].Cells["OS"].Tag;
                    for (int ptr = 0; ptr < tFiles.Count; ptr++)
                    {
                        int tf = tFiles[ptr].tunerFile;
                        int t = tFiles[ptr].tableData;
                        Logger("File: " + tunerFiles[tf].fileName);
                        Logger("Modifying table: " + tableName + ", " + Property + ": " + oldVal + " => " + newVal);
                        if (!modifiedFiles.Contains(tf))
                            modifiedFiles.Add(tf);

                        Type type = tunerFiles[tf].tableDatas[t].GetType();
                        PropertyInfo prop = type.GetProperty(Property);
                        if (prop.PropertyType.IsEnum)
                            prop.SetValue(tunerFiles[tf].tableDatas[t], Enum.Parse(prop.PropertyType, newVal), null);
                        else
                            prop.SetValue(tunerFiles[tf].tableDatas[t], Convert.ChangeType(newVal, prop.PropertyType), null);
                    }
                }
                dataGridView2.Rows.Clear();
                Logger("Done");
            }
            catch (Exception ex)
            {
                LoggerBold(ex.Message);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            for (int modF = 0; modF < modifiedFiles.Count; modF++)
            {
                Logger("Saving file: " + modifiedFiles[modF], false);
                int tf = modifiedFiles[modF];
                using (FileStream stream = new FileStream(tunerFiles[tf].fileName, FileMode.Create))
                {
                    System.Xml.Serialization.XmlSerializer writer = new System.Xml.Serialization.XmlSerializer(typeof(List<TableData>));
                    writer.Serialize(stream, tunerFiles[tf].tableDatas);
                    stream.Close();
                }
                Logger(" [OK]");
                break;
            }
            modifiedFiles = new List<int>();
            Logger("Files saved");
        }
        private void Logger(string LogText, Boolean NewLine = true)
        {
            try
            {
                txtResult.AppendText(LogText);
                if (NewLine)
                    txtResult.AppendText(Environment.NewLine);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.InnerException);
            }
        }
        private void LoggerBold(string LogText, Boolean NewLine = true)
        {
            try
            {
                txtResult.SelectionFont = new Font(txtResult.Font, FontStyle.Bold);
                txtResult.AppendText(LogText);
                txtResult.SelectionFont = new Font(txtResult.Font, FontStyle.Regular);
                if (NewLine)
                    txtResult.AppendText(Environment.NewLine);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.InnerException);
            }
        }
        private List<TableData> loadTableDataFile(string fName)
        {
            List<TableData> tmpTableDatas = new List<TableData>();
            try
            {
                if (File.Exists(fName))
                {
                    Logger("Loading " + fName + "...", false);
                    System.Xml.Serialization.XmlSerializer reader = new System.Xml.Serialization.XmlSerializer(typeof(List<TableData>));
                    System.IO.StreamReader file = new System.IO.StreamReader(fName);
                    tmpTableDatas = (List<TableData>)reader.Deserialize(file);
                    file.Close();
                    Logger(" [OK]");
                    Application.DoEvents();
                }
            }
            catch (Exception ex)
            {
                LoggerBold(ex.Message);
            }
            return tmpTableDatas;
        }

        private void copyRowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int row = -1;
            if (dataGridView1.SelectedCells.Count > 0)
                row = dataGridView1.SelectedCells[0].RowIndex;
            else if (dataGridView1.SelectedRows.Count > 0)
                row = dataGridView1.SelectedRows[0].Index;
            else
                return;

            clipBrd = new List<ClibBrd>();
            for (int c = 0; c < dataGridView1.Columns.Count; c++)
            {
                if (dataGridView1.Columns[c].Name != "id"  && dataGridView1.Columns[c].Name != "UsedInOS" && dataGridView1.Columns[c].Name != "OS" && dataGridView1.Columns[c].Name != "Address" && dataGridView1.Rows[row].Cells[c].Value != null)
                {
                    ClibBrd cb = new ClibBrd();
                    cb.Property = dataGridView1.Columns[c].Name;
                    cb.Value = dataGridView1.Rows[row].Cells[c].Value.ToString();
                    clipBrd.Add(cb);
                }
            }
            dataClipBoard.DataSource = null;
            dataClipBoard.DataSource = clipBrd;

        }

        private void copyValueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clipBrd = new List<ClibBrd>();
            ClibBrd cb = new ClibBrd();
            cb.Property = dataGridView1.Columns[dataGridView1.SelectedCells[0].ColumnIndex].Name;
            cb.Value = dataGridView1.SelectedCells[0].Value.ToString();
            clipBrd.Add(cb);
            dataClipBoard.DataSource = null;
            dataClipBoard.DataSource = clipBrd;

        }

        private void copyValuesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int row = -1;
            if (dataGridView1.SelectedCells.Count > 0)
                row = dataGridView1.SelectedCells[0].RowIndex;
            else if (dataGridView1.SelectedRows.Count > 0)
                row = dataGridView1.SelectedRows[0].Index;
            else
                return;

            clipBrd = new List<ClibBrd>();
            frmSelectTableDataProperties fst = new frmSelectTableDataProperties();
            int mmid = Convert.ToInt32(dataGridView1.Rows[row].Cells["id"].Value);
            TableData td = displayDatas[mmid].td;
            fst.loadProperties(td);
            if (fst.ShowDialog() == DialogResult.OK)
            {
                for (int p=0; p< fst.chkBoxes.Count; p++)
                {
                    CheckBox chk = fst.chkBoxes[p];
                    if (chk.Checked && chk.Tag != null)
                    {
                        ClibBrd cb = new ClibBrd();
                        cb.Property = chk.Name;
                        cb.Value = chk.Tag.ToString();
                        clipBrd.Add(cb);
                    }
                }
                dataClipBoard.DataSource = null;
                dataClipBoard.DataSource = clipBrd;
            }
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int row = -1;
            if (dataGridView1.SelectedCells.Count > 0)
                row = dataGridView1.SelectedCells[0].RowIndex;
            else if (dataGridView1.SelectedRows.Count > 0)
                row = dataGridView1.SelectedRows[0].Index;
            else
                return;
            try
            {
                for (int r = 0; r < clipBrd.Count; r++)
                {
                    dataGridView1.Rows[row].Cells[clipBrd[r].Property].Value = clipBrd[r].Value;
                }
            }
            catch (Exception ex)
            {
                LoggerBold(ex.Message);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void copyRowToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int row = -1;
            if (dataGridView1.SelectedCells.Count > 0)
                row = dataGridView1.SelectedCells[0].RowIndex;
            else if (dataGridView1.SelectedRows.Count > 0)
                row = dataGridView1.SelectedRows[0].Index;
            else
                return;

            frmSelectTableDataProperties fst = new frmSelectTableDataProperties();
            int mmid = Convert.ToInt32(dataGridView1.Rows[row].Cells["id"].Value);
            TableData td = displayDatas[mmid].td;
            fst.loadProperties(td);
            fst.btnOK.Text = "Next >";
            if (fst.ShowDialog() != DialogResult.OK)
            {
                fst.Dispose();
                return;
            }
            fst.Dispose();

            List<ClibBrd> myClipBrd = new List<ClibBrd>();
            for (int p = 0; p < fst.chkBoxes.Count; p++)
            {
                CheckBox chk = fst.chkBoxes[p];
                if (chk.Checked && chk.Tag != null)
                {
                    ClibBrd cb = new ClibBrd();
                    cb.Property = chk.Name;
                    cb.Value = chk.Tag.ToString();
                    myClipBrd.Add(cb);
                }
            }


            fst = new frmSelectTableDataProperties();
            fst.loadProperties(td);
            for (int c=0; c < fst.chkBoxes.Count; c++)
            {
                if (fst.chkBoxes[c].Name == "TableName" )
                    fst.chkBoxes[c].Checked = true;
                else
                    fst.chkBoxes[c].Checked = false;
            }
            fst.btnOK.Text = "Next >";
            fst.Text = "Select table search criteria";
            fst.labelAction.Text = "Select table search criteria";
            if (fst.ShowDialog() != DialogResult.OK)
            {
                fst.Dispose();
                return;
            }
            fst.Dispose();

            List<ClibBrd> myCriteria = new List<ClibBrd>();
            for (int p = 0; p < fst.chkBoxes.Count; p++)
            {
                CheckBox chk = fst.chkBoxes[p];
                if (chk.Checked && chk.Tag != null)
                {
                    ClibBrd cb = new ClibBrd();
                    cb.Property = chk.Name;
                    cb.Value = chk.Tag.ToString();
                    myCriteria.Add(cb);
                }
            }

            List<TableDataExtended> tdeList = new List<TableDataExtended>();
            for (int tf=0; tf < tunerFiles.Count; tf++)
            {
                for (int t=0; t< tunerFiles[tf].tableDatas.Count; t++)
                {
                    bool match = true;
                    Type type = tunerFiles[tf].tableDatas[t].GetType();
                    for (int mc = 0; mc < myCriteria.Count; mc++)
                    {
                        PropertyInfo prop = type.GetProperty(myCriteria[mc].Property);
                        if ((string)prop.GetValue(tunerFiles[tf].tableDatas[t], null) != myCriteria[mc].Value)
                        {
                            match = false;
                            break;
                        }
                    }
                    if (match)
                    {
                        //This table definition match criteria
                        TableDataExtended tde = new TableDataExtended();
                        TableData tabledata = tunerFiles[tf].tableDatas[t];
                        foreach (var tdProp in tabledata.GetType().GetProperties())
                        {

                            Type tdeType = tde.GetType();
                            PropertyInfo tdeProp = tdeType.GetProperty(tdProp.Name);
                            tdeProp.SetValue(tde, tdProp.GetValue(tabledata, null), null);
                        }
                        tde.id = (uint)t;
                        tde.fileId = tf;
                        tde.File = tunerFiles[tf].fileName;
                        tde.Select = true;
                        tdeList.Add(tde);
                    }
                }
            }
            frmSelectMassTarget frmSmt = new frmSelectMassTarget();
            frmSmt.loadData(tdeList);
            if (frmSmt.ShowDialog() != DialogResult.OK)
            {
                frmSmt.Dispose();
                return;
            }

            for (int r = 0; r < frmSmt.dataGridView1.Rows.Count; r++)
            {
                if (Convert.ToBoolean(frmSmt.dataGridView1.Rows[r].Cells["Select"].Value) == true)
                {
                    int tf = Convert.ToInt32(frmSmt.dataGridView1.Rows[r].Cells["fileId"].Value);
                    int t = Convert.ToInt32(frmSmt.dataGridView1.Rows[r].Cells["id"].Value);
                    Logger("Updating table list: " + tunerFiles[tf].fileName);
                    for (int cb = 0; cb < myClipBrd.Count; cb++)
                    {
                        TableData tabledata = tunerFiles[tf].tableDatas[t];
                        Type tdType = tabledata.GetType();
                        PropertyInfo tdProp = tdType.GetProperty(myClipBrd[cb].Property);
                        if (tdProp.PropertyType.IsEnum)
                            tdProp.SetValue(tunerFiles[tf].tableDatas[t], Enum.Parse(tdProp.PropertyType, myClipBrd[cb].Value), null);
                        else
                            tdProp.SetValue(tunerFiles[tf].tableDatas[t], Convert.ChangeType(myClipBrd[cb].Value, tdProp.PropertyType), null);
                        Logger("Property: " + myClipBrd[cb].Property + ", value: " + myClipBrd[cb].Value);
                    }
                    modifiedFiles.Add(tf);
                }
            }
            Logger("Done. (Save files manually)");
        }
    }
}