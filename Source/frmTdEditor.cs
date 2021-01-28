﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using static upatcher;

namespace UniversalPatcher
{
    public partial class frmTdEditor : Form
    {
        public frmTdEditor()
        {
            InitializeComponent();
        }

        public TableData td;
        private void frmTdEditor_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.MainWindowPersistence)
            {
                if (Properties.Settings.Default.frmTdWindowSize.Width > 0 || Properties.Settings.Default.frmTdWindowSize.Height > 0)
                {
                    this.WindowState = Properties.Settings.Default.frmTdWindowState;
                    if (this.WindowState == FormWindowState.Minimized)
                    {
                        this.WindowState = FormWindowState.Normal;
                    }
                    this.Location = Properties.Settings.Default.frmTdWindowLocaction;
                    this.Size = Properties.Settings.Default.frmTdWindowSize;
                }
            }
            this.ResizeEnd += FrmTdEditor_ResizeEnd;
        }
        private void FrmTdEditor_FormClosing(object sender, System.Windows.Forms.FormClosingEventArgs e)
        {
            if (Properties.Settings.Default.MainWindowPersistence)
            {
                Properties.Settings.Default.frmTdWindowState = this.WindowState;
                if (this.WindowState == FormWindowState.Normal)
                {
                    Properties.Settings.Default.frmTdWindowLocaction = this.Location;
                    Properties.Settings.Default.frmTdWindowSize = this.Size;
                }
                else
                {
                    Properties.Settings.Default.frmTdWindowLocaction = this.RestoreBounds.Location;
                    Properties.Settings.Default.frmTdWindowSize = this.RestoreBounds.Size;
                }
            }
        }

        public void loadTd()
        {
            int row = 0;
            dataGridView1.ColumnCount = 1;
            dataGridView1.RowHeadersWidth = 150;
            foreach (var prop in td.GetType().GetProperties())
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[row].HeaderCell.Value = prop.Name;
                if (prop.PropertyType.IsEnum)
                {
                    DataGridViewComboBoxCell c = new DataGridViewComboBoxCell();
                    c.ValueType = prop.PropertyType;
                    c.ValueMember = "Value";
                    c.DisplayMember = "Name";
                    c.DataSource = Enum.GetValues(prop.PropertyType).Cast<object>().Select(v => new
                    {
                        Value = (int)v,
                        Name = Enum.GetName(prop.PropertyType, v) /* or any other logic to get text */
                    }).ToList();
                    c.Value = (int) prop.GetValue(td, null);
                    dataGridView1.Rows[row].Cells[0] = c;
                }
                else if (prop.PropertyType == typeof(System.Boolean))
                {
                    DataGridViewCheckBoxCell c = new DataGridViewCheckBoxCell();
                    dataGridView1.Rows[row].Cells[0] = c;
                    c.Value = prop.GetValue(td, null);
                }
                else
                {
                    dataGridView1.Rows[row].Cells[0].Value = prop.GetValue(td, null);
                }
                row++;
            }
            dataGridView1.Columns[0].Width = 1000;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            for (int i=0; i< dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].HeaderCell.Value != null)
                {
                    string propertyName = dataGridView1.Rows[i].HeaderCell.Value.ToString();
                    var propertyInfo = td.GetType().GetProperty(propertyName, System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static | System.Reflection.BindingFlags.Instance);
                    if (propertyInfo != null && propertyInfo.CanWrite)
                    {
                        if (dataGridView1.Rows[i].Cells[0].GetType() == typeof(DataGridViewComboBoxCell))
                            propertyInfo.SetValue(td, Enum.ToObject(propertyInfo.PropertyType, dataGridView1.Rows[i].Cells[0].Value), null);
                        else
                            propertyInfo.SetValue(td, Convert.ChangeType(dataGridView1.Rows[i].Cells[0].Value, propertyInfo.PropertyType), null);
                    }
                }
            }
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
        private void DataGridView1_DataError(object sender, System.Windows.Forms.DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
        private void FrmTdEditor_ResizeEnd(object sender, System.EventArgs e)
        {
            dataGridView1.Columns[0].Width = this.Width - 200;
        }

    }
}