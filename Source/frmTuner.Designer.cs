﻿using System;
using System.Windows.Forms;

namespace UniversalPatcher
{
    partial class frmTuner
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTuner));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtSearchTableSeek = new System.Windows.Forms.TextBox();
            this.comboTableCategory = new System.Windows.Forms.ComboBox();
            this.labelCategory = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadBINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveBINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveBinAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openMultipleBINToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAllBINFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.showTablesWithEmptyAddressToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disableMultitableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unitsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enableConfigModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetTunerModeColumnsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disableConfigAutoloadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.caseSensitiveFilteringToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.moreSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.currentFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utilitiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dTCToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tableSeekToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xDFToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tinyTunerDBV6OnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMlgeneratorImportCSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cSVexperimentalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cSV2ExperimentalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.cSVToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xMLGeneratorExportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findDifferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findDifferencesHEXToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectFileToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.massModifyTableListsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.massModifyTableListsSelectFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.applyPatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xmlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadTablelistxmlTableseekImportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadTablelistnewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveXMLToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveXMLAsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importXDFToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.cutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pasteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchAndCompareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchAndCompareAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compareSelectedTablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copySelectedTablesToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.dToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.enumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.booleanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bitmaskToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.numberToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.editRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.insertRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deleteRowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.duplicateTableConfigToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createPatchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.comboFilterBy = new System.Windows.Forms.ComboBox();
            this.txtResult = new System.Windows.Forms.RichTextBox();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.txtDescription = new System.Windows.Forms.RichTextBox();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabDimensions = new System.Windows.Forms.TabPage();
            this.tabValueType = new System.Windows.Forms.TabPage();
            this.tabCategory = new System.Windows.Forms.TabPage();
            this.tabSegments = new System.Windows.Forms.TabPage();
            this.tabSettings = new System.Windows.Forms.TabPage();
            this.chkAutoMulti1d = new System.Windows.Forms.CheckBox();
            this.chkShowCategorySubfolder = new System.Windows.Forms.CheckBox();
            this.labelIconSize = new System.Windows.Forms.Label();
            this.numIconSize = new System.Windows.Forms.NumericUpDown();
            this.tabPatches = new System.Windows.Forms.TabPage();
            this.tabFileInfo = new System.Windows.Forms.TabPage();
            this.tabControlFileInfo = new System.Windows.Forms.TabControl();
            this.imageList3 = new System.Windows.Forms.ImageList(this.components);
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.timerFilter = new System.Windows.Forms.Timer(this.components);
            this.imageList2 = new System.Windows.Forms.ImageList(this.components);
            this.btnCollapse = new System.Windows.Forms.Button();
            this.btnExpand = new System.Windows.Forms.Button();
            this.radioListMode = new System.Windows.Forms.RadioButton();
            this.radioTreeMode = new System.Windows.Forms.RadioButton();
            this.imageList4 = new System.Windows.Forms.ImageList(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.labelTableName = new System.Windows.Forms.Label();
            this.labelBy = new System.Windows.Forms.Label();
            this.contextMenuStripTree = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.openInNewWindowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.compareSelectedTablesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabSettings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIconSize)).BeginInit();
            this.tabFileInfo.SuspendLayout();
            this.contextMenuStripTree.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1021, 409);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseClick);
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            this.dataGridView1.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_ColumnHeaderMouseClick);
            this.dataGridView1.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridView1_DataBindingComplete);
            this.dataGridView1.DataError += new System.Windows.Forms.DataGridViewDataErrorEventHandler(this.DataGridView1_DataError);
            this.dataGridView1.UserDeletingRow += new System.Windows.Forms.DataGridViewRowCancelEventHandler(this.DataGridView1_UserDeletingRow);
            this.dataGridView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DataGridView1_MouseDown);
            this.dataGridView1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DataGridView1_MouseUp);
            // 
            // txtSearchTableSeek
            // 
            this.txtSearchTableSeek.Location = new System.Drawing.Point(50, 29);
            this.txtSearchTableSeek.Name = "txtSearchTableSeek";
            this.txtSearchTableSeek.Size = new System.Drawing.Size(107, 20);
            this.txtSearchTableSeek.TabIndex = 14;
            this.txtSearchTableSeek.TextChanged += new System.EventHandler(this.txtSearchTableSeek_TextChanged);
            // 
            // comboTableCategory
            // 
            this.comboTableCategory.DropDownWidth = 300;
            this.comboTableCategory.FormattingEnabled = true;
            this.comboTableCategory.Location = new System.Drawing.Point(375, 30);
            this.comboTableCategory.Name = "comboTableCategory";
            this.comboTableCategory.Size = new System.Drawing.Size(190, 21);
            this.comboTableCategory.TabIndex = 13;
            // 
            // labelCategory
            // 
            this.labelCategory.AutoSize = true;
            this.labelCategory.Location = new System.Drawing.Point(317, 34);
            this.labelCategory.Name = "labelCategory";
            this.labelCategory.Size = new System.Drawing.Size(52, 13);
            this.labelCategory.TabIndex = 12;
            this.labelCategory.Text = "Category:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.settingsToolStripMenuItem,
            this.currentFileToolStripMenuItem,
            this.tableListToolStripMenuItem,
            this.utilitiesToolStripMenuItem,
            this.xmlToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1021, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadBINToolStripMenuItem,
            this.saveBINToolStripMenuItem,
            this.saveBinAsToolStripMenuItem,
            this.openMultipleBINToolStripMenuItem,
            this.saveAllBINFilesToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // loadBINToolStripMenuItem
            // 
            this.loadBINToolStripMenuItem.Name = "loadBINToolStripMenuItem";
            this.loadBINToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.loadBINToolStripMenuItem.Text = "Open BIN";
            this.loadBINToolStripMenuItem.Click += new System.EventHandler(this.loadBINToolStripMenuItem_Click);
            // 
            // saveBINToolStripMenuItem
            // 
            this.saveBINToolStripMenuItem.Name = "saveBINToolStripMenuItem";
            this.saveBINToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.saveBINToolStripMenuItem.Text = "&Save BIN";
            this.saveBINToolStripMenuItem.Click += new System.EventHandler(this.saveBINToolStripMenuItem_Click);
            // 
            // saveBinAsToolStripMenuItem
            // 
            this.saveBinAsToolStripMenuItem.Name = "saveBinAsToolStripMenuItem";
            this.saveBinAsToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.saveBinAsToolStripMenuItem.Text = "Save BIN &As...";
            this.saveBinAsToolStripMenuItem.Click += new System.EventHandler(this.saveBinAsToolStripMenuItem_Click);
            // 
            // openMultipleBINToolStripMenuItem
            // 
            this.openMultipleBINToolStripMenuItem.Name = "openMultipleBINToolStripMenuItem";
            this.openMultipleBINToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.openMultipleBINToolStripMenuItem.Text = "Open multiple BIN";
            this.openMultipleBINToolStripMenuItem.Click += new System.EventHandler(this.openMultipleBINToolStripMenuItem_Click);
            // 
            // saveAllBINFilesToolStripMenuItem
            // 
            this.saveAllBINFilesToolStripMenuItem.Name = "saveAllBINFilesToolStripMenuItem";
            this.saveAllBINFilesToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.saveAllBINFilesToolStripMenuItem.Text = "Save All BIN files";
            this.saveAllBINFilesToolStripMenuItem.Click += new System.EventHandler(this.saveAllBINFilesToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.showTablesWithEmptyAddressToolStripMenuItem,
            this.disableMultitableToolStripMenuItem,
            this.unitsToolStripMenuItem,
            this.enableConfigModeToolStripMenuItem,
            this.resetTunerModeColumnsToolStripMenuItem,
            this.disableConfigAutoloadToolStripMenuItem,
            this.caseSensitiveFilteringToolStripMenuItem,
            this.moreSettingsToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "&Settings";
            // 
            // showTablesWithEmptyAddressToolStripMenuItem
            // 
            this.showTablesWithEmptyAddressToolStripMenuItem.Name = "showTablesWithEmptyAddressToolStripMenuItem";
            this.showTablesWithEmptyAddressToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.showTablesWithEmptyAddressToolStripMenuItem.Text = "Show tables with empty address";
            this.showTablesWithEmptyAddressToolStripMenuItem.Click += new System.EventHandler(this.showTablesWithEmptyAddressToolStripMenuItem_Click);
            // 
            // disableMultitableToolStripMenuItem
            // 
            this.disableMultitableToolStripMenuItem.Name = "disableMultitableToolStripMenuItem";
            this.disableMultitableToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.disableMultitableToolStripMenuItem.Text = "Disable multitable";
            this.disableMultitableToolStripMenuItem.Click += new System.EventHandler(this.disableMultitableToolStripMenuItem_Click);
            // 
            // unitsToolStripMenuItem
            // 
            this.unitsToolStripMenuItem.Name = "unitsToolStripMenuItem";
            this.unitsToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.unitsToolStripMenuItem.Text = "Units";
            this.unitsToolStripMenuItem.Click += new System.EventHandler(this.unitsToolStripMenuItem_Click);
            // 
            // enableConfigModeToolStripMenuItem
            // 
            this.enableConfigModeToolStripMenuItem.Name = "enableConfigModeToolStripMenuItem";
            this.enableConfigModeToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.enableConfigModeToolStripMenuItem.Text = "Enable config mode";
            this.enableConfigModeToolStripMenuItem.Click += new System.EventHandler(this.enableConfigModeToolStripMenuItem_Click);
            // 
            // resetTunerModeColumnsToolStripMenuItem
            // 
            this.resetTunerModeColumnsToolStripMenuItem.Name = "resetTunerModeColumnsToolStripMenuItem";
            this.resetTunerModeColumnsToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.resetTunerModeColumnsToolStripMenuItem.Text = "Reset tuner mode columns";
            this.resetTunerModeColumnsToolStripMenuItem.Click += new System.EventHandler(this.resetTunerModeColumnsToolStripMenuItem_Click);
            // 
            // disableConfigAutoloadToolStripMenuItem
            // 
            this.disableConfigAutoloadToolStripMenuItem.Name = "disableConfigAutoloadToolStripMenuItem";
            this.disableConfigAutoloadToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.disableConfigAutoloadToolStripMenuItem.Text = "Disable config autoload";
            this.disableConfigAutoloadToolStripMenuItem.Click += new System.EventHandler(this.disableConfigAutoloadToolStripMenuItem_Click);
            // 
            // caseSensitiveFilteringToolStripMenuItem
            // 
            this.caseSensitiveFilteringToolStripMenuItem.Name = "caseSensitiveFilteringToolStripMenuItem";
            this.caseSensitiveFilteringToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.caseSensitiveFilteringToolStripMenuItem.Text = "Case sensitive filtering";
            this.caseSensitiveFilteringToolStripMenuItem.Click += new System.EventHandler(this.caseSensitiveFilteringToolStripMenuItem_Click);
            // 
            // moreSettingsToolStripMenuItem
            // 
            this.moreSettingsToolStripMenuItem.Name = "moreSettingsToolStripMenuItem";
            this.moreSettingsToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.moreSettingsToolStripMenuItem.Text = "More settings...";
            this.moreSettingsToolStripMenuItem.Click += new System.EventHandler(this.moreSettingsToolStripMenuItem_Click);
            // 
            // currentFileToolStripMenuItem
            // 
            this.currentFileToolStripMenuItem.Name = "currentFileToolStripMenuItem";
            this.currentFileToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.currentFileToolStripMenuItem.Text = "BIN file";
            // 
            // tableListToolStripMenuItem
            // 
            this.tableListToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem});
            this.tableListToolStripMenuItem.Name = "tableListToolStripMenuItem";
            this.tableListToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.tableListToolStripMenuItem.Text = "Tablelist";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.newToolStripMenuItem.Text = "New...";
            this.newToolStripMenuItem.Click += new System.EventHandler(this.newToolStripMenuItem_Click);
            // 
            // utilitiesToolStripMenuItem
            // 
            this.utilitiesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importToolStripMenuItem1,
            this.exportToolStripMenuItem1,
            this.findDifferencesToolStripMenuItem,
            this.findDifferencesHEXToolStripMenuItem,
            this.massModifyTableListsToolStripMenuItem,
            this.massModifyTableListsSelectFilesToolStripMenuItem,
            this.applyPatchToolStripMenuItem});
            this.utilitiesToolStripMenuItem.Name = "utilitiesToolStripMenuItem";
            this.utilitiesToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.utilitiesToolStripMenuItem.Text = "Utilities";
            // 
            // importToolStripMenuItem1
            // 
            this.importToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dTCToolStripMenuItem,
            this.tableSeekToolStripMenuItem,
            this.xDFToolStripMenuItem1,
            this.tinyTunerDBV6OnlyToolStripMenuItem,
            this.xMlgeneratorImportCSVToolStripMenuItem,
            this.cSVexperimentalToolStripMenuItem,
            this.cSV2ExperimentalToolStripMenuItem});
            this.importToolStripMenuItem1.Name = "importToolStripMenuItem1";
            this.importToolStripMenuItem1.Size = new System.Drawing.Size(219, 22);
            this.importToolStripMenuItem1.Text = "Import";
            // 
            // dTCToolStripMenuItem
            // 
            this.dTCToolStripMenuItem.Name = "dTCToolStripMenuItem";
            this.dTCToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.dTCToolStripMenuItem.Text = "DTC";
            this.dTCToolStripMenuItem.Click += new System.EventHandler(this.dTCToolStripMenuItem_Click);
            // 
            // tableSeekToolStripMenuItem
            // 
            this.tableSeekToolStripMenuItem.Name = "tableSeekToolStripMenuItem";
            this.tableSeekToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.tableSeekToolStripMenuItem.Text = "TableSeek";
            this.tableSeekToolStripMenuItem.Click += new System.EventHandler(this.tableSeekToolStripMenuItem_Click);
            // 
            // xDFToolStripMenuItem1
            // 
            this.xDFToolStripMenuItem1.Name = "xDFToolStripMenuItem1";
            this.xDFToolStripMenuItem1.Size = new System.Drawing.Size(196, 22);
            this.xDFToolStripMenuItem1.Text = "XDF";
            this.xDFToolStripMenuItem1.Click += new System.EventHandler(this.xDFToolStripMenuItem1_Click);
            // 
            // tinyTunerDBV6OnlyToolStripMenuItem
            // 
            this.tinyTunerDBV6OnlyToolStripMenuItem.Name = "tinyTunerDBV6OnlyToolStripMenuItem";
            this.tinyTunerDBV6OnlyToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.tinyTunerDBV6OnlyToolStripMenuItem.Text = "TinyTuner DB (V6 Only)";
            this.tinyTunerDBV6OnlyToolStripMenuItem.Click += new System.EventHandler(this.tinyTunerDBV6OnlyToolStripMenuItem_Click);
            // 
            // xMlgeneratorImportCSVToolStripMenuItem
            // 
            this.xMlgeneratorImportCSVToolStripMenuItem.Name = "xMlgeneratorImportCSVToolStripMenuItem";
            this.xMlgeneratorImportCSVToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.xMlgeneratorImportCSVToolStripMenuItem.Text = "XML-generator CSV";
            this.xMlgeneratorImportCSVToolStripMenuItem.Click += new System.EventHandler(this.xMlgeneratorImportCSVToolStripMenuItem_Click);
            // 
            // cSVexperimentalToolStripMenuItem
            // 
            this.cSVexperimentalToolStripMenuItem.Name = "cSVexperimentalToolStripMenuItem";
            this.cSVexperimentalToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.cSVexperimentalToolStripMenuItem.Text = "CSV (experimental)";
            this.cSVexperimentalToolStripMenuItem.Click += new System.EventHandler(this.cSVexperimentalToolStripMenuItem_Click);
            // 
            // cSV2ExperimentalToolStripMenuItem
            // 
            this.cSV2ExperimentalToolStripMenuItem.Name = "cSV2ExperimentalToolStripMenuItem";
            this.cSV2ExperimentalToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.cSV2ExperimentalToolStripMenuItem.Text = "CSV2 (Experimental)";
            this.cSV2ExperimentalToolStripMenuItem.Click += new System.EventHandler(this.cSV2ExperimentalToolStripMenuItem_Click);
            // 
            // exportToolStripMenuItem1
            // 
            this.exportToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cSVToolStripMenuItem,
            this.xDFToolStripMenuItem,
            this.xMLGeneratorExportToolStripMenuItem});
            this.exportToolStripMenuItem1.Name = "exportToolStripMenuItem1";
            this.exportToolStripMenuItem1.Size = new System.Drawing.Size(219, 22);
            this.exportToolStripMenuItem1.Text = "Export";
            // 
            // cSVToolStripMenuItem
            // 
            this.cSVToolStripMenuItem.Name = "cSVToolStripMenuItem";
            this.cSVToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.cSVToolStripMenuItem.Text = "CSV";
            this.cSVToolStripMenuItem.Click += new System.EventHandler(this.cSVToolStripMenuItem_Click);
            // 
            // xDFToolStripMenuItem
            // 
            this.xDFToolStripMenuItem.Name = "xDFToolStripMenuItem";
            this.xDFToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.xDFToolStripMenuItem.Text = "XDF";
            this.xDFToolStripMenuItem.Click += new System.EventHandler(this.xDFToolStripMenuItem_Click);
            // 
            // xMLGeneratorExportToolStripMenuItem
            // 
            this.xMLGeneratorExportToolStripMenuItem.Name = "xMLGeneratorExportToolStripMenuItem";
            this.xMLGeneratorExportToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.xMLGeneratorExportToolStripMenuItem.Text = "XML Generator CSV";
            this.xMLGeneratorExportToolStripMenuItem.Click += new System.EventHandler(this.xMLGeneratorExportToolStripMenuItem_Click);
            // 
            // findDifferencesToolStripMenuItem
            // 
            this.findDifferencesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectFileToolStripMenuItem});
            this.findDifferencesToolStripMenuItem.Name = "findDifferencesToolStripMenuItem";
            this.findDifferencesToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.findDifferencesToolStripMenuItem.Text = "Find differences";
            // 
            // selectFileToolStripMenuItem
            // 
            this.selectFileToolStripMenuItem.Name = "selectFileToolStripMenuItem";
            this.selectFileToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.selectFileToolStripMenuItem.Text = "Select file...";
            this.selectFileToolStripMenuItem.Click += new System.EventHandler(this.selectFileToolStripMenuItem_Click);
            // 
            // findDifferencesHEXToolStripMenuItem
            // 
            this.findDifferencesHEXToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectFileToolStripMenuItem1});
            this.findDifferencesHEXToolStripMenuItem.Name = "findDifferencesHEXToolStripMenuItem";
            this.findDifferencesHEXToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.findDifferencesHEXToolStripMenuItem.Text = "Find differences (HEX)";
            // 
            // selectFileToolStripMenuItem1
            // 
            this.selectFileToolStripMenuItem1.Name = "selectFileToolStripMenuItem1";
            this.selectFileToolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
            this.selectFileToolStripMenuItem1.Text = "Select file...";
            this.selectFileToolStripMenuItem1.Click += new System.EventHandler(this.selectFileToolStripMenuItem1_Click);
            // 
            // massModifyTableListsToolStripMenuItem
            // 
            this.massModifyTableListsToolStripMenuItem.Name = "massModifyTableListsToolStripMenuItem";
            this.massModifyTableListsToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.massModifyTableListsToolStripMenuItem.Text = "TableList editor";
            this.massModifyTableListsToolStripMenuItem.Click += new System.EventHandler(this.massModifyTableListsToolStripMenuItem_Click);
            // 
            // massModifyTableListsSelectFilesToolStripMenuItem
            // 
            this.massModifyTableListsSelectFilesToolStripMenuItem.Name = "massModifyTableListsSelectFilesToolStripMenuItem";
            this.massModifyTableListsSelectFilesToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.massModifyTableListsSelectFilesToolStripMenuItem.Text = "TableList editor (Select files)";
            this.massModifyTableListsSelectFilesToolStripMenuItem.Click += new System.EventHandler(this.massModifyTableListsSelectFilesToolStripMenuItem_Click);
            // 
            // applyPatchToolStripMenuItem
            // 
            this.applyPatchToolStripMenuItem.Name = "applyPatchToolStripMenuItem";
            this.applyPatchToolStripMenuItem.Size = new System.Drawing.Size(219, 22);
            this.applyPatchToolStripMenuItem.Text = "Apply patch...";
            this.applyPatchToolStripMenuItem.Click += new System.EventHandler(this.applyPatchToolStripMenuItem_Click);
            // 
            // xmlToolStripMenuItem
            // 
            this.xmlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadXMLToolStripMenuItem,
            this.loadTablelistxmlTableseekImportToolStripMenuItem,
            this.loadTablelistnewToolStripMenuItem,
            this.saveXMLToolStripMenuItem,
            this.saveXMLAsToolStripMenuItem,
            this.clearTableToolStripMenuItem,
            this.importXDFToolStripMenuItem});
            this.xmlToolStripMenuItem.Name = "xmlToolStripMenuItem";
            this.xmlToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
            this.xmlToolStripMenuItem.Text = "Xml";
            // 
            // loadXMLToolStripMenuItem
            // 
            this.loadXMLToolStripMenuItem.Name = "loadXMLToolStripMenuItem";
            this.loadXMLToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.loadXMLToolStripMenuItem.Text = "Load Tablelist";
            this.loadXMLToolStripMenuItem.Click += new System.EventHandler(this.loadXMLToolStripMenuItem_Click);
            // 
            // loadTablelistxmlTableseekImportToolStripMenuItem
            // 
            this.loadTablelistxmlTableseekImportToolStripMenuItem.Name = "loadTablelistxmlTableseekImportToolStripMenuItem";
            this.loadTablelistxmlTableseekImportToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.loadTablelistxmlTableseekImportToolStripMenuItem.Text = "Load tablelist(xml+Tableseek import)";
            this.loadTablelistxmlTableseekImportToolStripMenuItem.Click += new System.EventHandler(this.loadTablelistxmlTableseekImportToolStripMenuItem_Click);
            // 
            // loadTablelistnewToolStripMenuItem
            // 
            this.loadTablelistnewToolStripMenuItem.Name = "loadTablelistnewToolStripMenuItem";
            this.loadTablelistnewToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.loadTablelistnewToolStripMenuItem.Text = "Load tablelist (new)";
            this.loadTablelistnewToolStripMenuItem.Click += new System.EventHandler(this.loadTablelistnewToolStripMenuItem_Click);
            // 
            // saveXMLToolStripMenuItem
            // 
            this.saveXMLToolStripMenuItem.Name = "saveXMLToolStripMenuItem";
            this.saveXMLToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.saveXMLToolStripMenuItem.Text = "Save Tablelist";
            this.saveXMLToolStripMenuItem.Click += new System.EventHandler(this.saveXMLToolStripMenuItem_Click);
            // 
            // saveXMLAsToolStripMenuItem
            // 
            this.saveXMLAsToolStripMenuItem.Name = "saveXMLAsToolStripMenuItem";
            this.saveXMLAsToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.saveXMLAsToolStripMenuItem.Text = "Save Tablelist As...";
            this.saveXMLAsToolStripMenuItem.Click += new System.EventHandler(this.saveXMLAsToolStripMenuItem_Click);
            // 
            // clearTableToolStripMenuItem
            // 
            this.clearTableToolStripMenuItem.Name = "clearTableToolStripMenuItem";
            this.clearTableToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.clearTableToolStripMenuItem.Text = "&Clear Tablelist";
            this.clearTableToolStripMenuItem.Click += new System.EventHandler(this.clearTableToolStripMenuItem_Click);
            // 
            // importXDFToolStripMenuItem
            // 
            this.importXDFToolStripMenuItem.Name = "importXDFToolStripMenuItem";
            this.importXDFToolStripMenuItem.Size = new System.Drawing.Size(269, 22);
            this.importXDFToolStripMenuItem.Text = "Import XDF";
            this.importXDFToolStripMenuItem.Click += new System.EventHandler(this.importXDFToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cutToolStripMenuItem,
            this.copyToolStripMenuItem,
            this.pasteToolStripMenuItem,
            this.editTableToolStripMenuItem,
            this.searchAndCompareToolStripMenuItem,
            this.searchAndCompareAllToolStripMenuItem,
            this.compareSelectedTablesToolStripMenuItem,
            this.copySelectedTablesToToolStripMenuItem,
            this.selectToolStripMenuItem,
            this.toolStripSeparator1,
            this.editRowToolStripMenuItem,
            this.insertRowToolStripMenuItem,
            this.deleteRowToolStripMenuItem,
            this.duplicateTableConfigToolStripMenuItem,
            this.createPatchToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(206, 318);
            // 
            // cutToolStripMenuItem
            // 
            this.cutToolStripMenuItem.Name = "cutToolStripMenuItem";
            this.cutToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.cutToolStripMenuItem.Text = "Cut";
            this.cutToolStripMenuItem.Click += new System.EventHandler(this.cutToolStripMenuItem_Click);
            // 
            // copyToolStripMenuItem
            // 
            this.copyToolStripMenuItem.Name = "copyToolStripMenuItem";
            this.copyToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.copyToolStripMenuItem.Text = "Copy";
            this.copyToolStripMenuItem.Click += new System.EventHandler(this.copyToolStripMenuItem_Click);
            // 
            // pasteToolStripMenuItem
            // 
            this.pasteToolStripMenuItem.Name = "pasteToolStripMenuItem";
            this.pasteToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.pasteToolStripMenuItem.Text = "Paste";
            this.pasteToolStripMenuItem.Click += new System.EventHandler(this.pasteToolStripMenuItem_Click);
            // 
            // editTableToolStripMenuItem
            // 
            this.editTableToolStripMenuItem.Name = "editTableToolStripMenuItem";
            this.editTableToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.editTableToolStripMenuItem.Text = "Edit table(s)";
            this.editTableToolStripMenuItem.Click += new System.EventHandler(this.editTableToolStripMenuItem_Click);
            // 
            // searchAndCompareToolStripMenuItem
            // 
            this.searchAndCompareToolStripMenuItem.Name = "searchAndCompareToolStripMenuItem";
            this.searchAndCompareToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.searchAndCompareToolStripMenuItem.Text = "Search and compare";
            this.searchAndCompareToolStripMenuItem.Click += new System.EventHandler(this.searchAndCompareToolStripMenuItem_Click);
            // 
            // searchAndCompareAllToolStripMenuItem
            // 
            this.searchAndCompareAllToolStripMenuItem.Name = "searchAndCompareAllToolStripMenuItem";
            this.searchAndCompareAllToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.searchAndCompareAllToolStripMenuItem.Text = "Search and compare All";
            this.searchAndCompareAllToolStripMenuItem.Click += new System.EventHandler(this.searchAndCompareAllToolStripMenuItem_Click);
            // 
            // compareSelectedTablesToolStripMenuItem
            // 
            this.compareSelectedTablesToolStripMenuItem.Name = "compareSelectedTablesToolStripMenuItem";
            this.compareSelectedTablesToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.compareSelectedTablesToolStripMenuItem.Text = "Compare selected tables";
            this.compareSelectedTablesToolStripMenuItem.Click += new System.EventHandler(this.compareSelectedTablesToolStripMenuItem_Click);
            // 
            // copySelectedTablesToToolStripMenuItem
            // 
            this.copySelectedTablesToToolStripMenuItem.Name = "copySelectedTablesToToolStripMenuItem";
            this.copySelectedTablesToToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.copySelectedTablesToToolStripMenuItem.Text = "Copy selected tables to...";
            this.copySelectedTablesToToolStripMenuItem.Click += new System.EventHandler(this.copySelectedTablesToToolStripMenuItem_Click);
            // 
            // selectToolStripMenuItem
            // 
            this.selectToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dToolStripMenuItem,
            this.dToolStripMenuItem1,
            this.dToolStripMenuItem2,
            this.enumToolStripMenuItem,
            this.booleanToolStripMenuItem,
            this.bitmaskToolStripMenuItem,
            this.numberToolStripMenuItem});
            this.selectToolStripMenuItem.Enabled = false;
            this.selectToolStripMenuItem.Name = "selectToolStripMenuItem";
            this.selectToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.selectToolStripMenuItem.Text = "Select all...";
            this.selectToolStripMenuItem.Visible = false;
            // 
            // dToolStripMenuItem
            // 
            this.dToolStripMenuItem.Name = "dToolStripMenuItem";
            this.dToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.dToolStripMenuItem.Text = "1d";
            // 
            // dToolStripMenuItem1
            // 
            this.dToolStripMenuItem1.Name = "dToolStripMenuItem1";
            this.dToolStripMenuItem1.Size = new System.Drawing.Size(117, 22);
            this.dToolStripMenuItem1.Text = "2d";
            // 
            // dToolStripMenuItem2
            // 
            this.dToolStripMenuItem2.Name = "dToolStripMenuItem2";
            this.dToolStripMenuItem2.Size = new System.Drawing.Size(117, 22);
            this.dToolStripMenuItem2.Text = "3d";
            // 
            // enumToolStripMenuItem
            // 
            this.enumToolStripMenuItem.Name = "enumToolStripMenuItem";
            this.enumToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.enumToolStripMenuItem.Text = "enum";
            // 
            // booleanToolStripMenuItem
            // 
            this.booleanToolStripMenuItem.Name = "booleanToolStripMenuItem";
            this.booleanToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.booleanToolStripMenuItem.Text = "boolean";
            // 
            // bitmaskToolStripMenuItem
            // 
            this.bitmaskToolStripMenuItem.Name = "bitmaskToolStripMenuItem";
            this.bitmaskToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.bitmaskToolStripMenuItem.Text = "bitmask";
            // 
            // numberToolStripMenuItem
            // 
            this.numberToolStripMenuItem.Name = "numberToolStripMenuItem";
            this.numberToolStripMenuItem.Size = new System.Drawing.Size(117, 22);
            this.numberToolStripMenuItem.Text = "number";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(202, 6);
            // 
            // editRowToolStripMenuItem
            // 
            this.editRowToolStripMenuItem.Enabled = false;
            this.editRowToolStripMenuItem.Name = "editRowToolStripMenuItem";
            this.editRowToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.editRowToolStripMenuItem.Text = "Edit table config";
            this.editRowToolStripMenuItem.Click += new System.EventHandler(this.editRowToolStripMenuItem_Click);
            // 
            // insertRowToolStripMenuItem
            // 
            this.insertRowToolStripMenuItem.Enabled = false;
            this.insertRowToolStripMenuItem.Name = "insertRowToolStripMenuItem";
            this.insertRowToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.insertRowToolStripMenuItem.Text = "Insert table config";
            this.insertRowToolStripMenuItem.Click += new System.EventHandler(this.insertRowToolStripMenuItem_Click);
            // 
            // deleteRowToolStripMenuItem
            // 
            this.deleteRowToolStripMenuItem.Enabled = false;
            this.deleteRowToolStripMenuItem.Name = "deleteRowToolStripMenuItem";
            this.deleteRowToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.deleteRowToolStripMenuItem.Text = "Delete table config";
            this.deleteRowToolStripMenuItem.Click += new System.EventHandler(this.deleteRowToolStripMenuItem_Click);
            // 
            // duplicateTableConfigToolStripMenuItem
            // 
            this.duplicateTableConfigToolStripMenuItem.Enabled = false;
            this.duplicateTableConfigToolStripMenuItem.Name = "duplicateTableConfigToolStripMenuItem";
            this.duplicateTableConfigToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.duplicateTableConfigToolStripMenuItem.Text = "Duplicate table config";
            this.duplicateTableConfigToolStripMenuItem.Click += new System.EventHandler(this.duplicateTableConfigToolStripMenuItem_Click);
            // 
            // createPatchToolStripMenuItem
            // 
            this.createPatchToolStripMenuItem.Name = "createPatchToolStripMenuItem";
            this.createPatchToolStripMenuItem.Size = new System.Drawing.Size(205, 22);
            this.createPatchToolStripMenuItem.Text = "Create patch...";
            this.createPatchToolStripMenuItem.Click += new System.EventHandler(this.createPatchToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Filter:";
            // 
            // comboFilterBy
            // 
            this.comboFilterBy.FormattingEnabled = true;
            this.comboFilterBy.Location = new System.Drawing.Point(190, 29);
            this.comboFilterBy.Name = "comboFilterBy";
            this.comboFilterBy.Size = new System.Drawing.Size(121, 21);
            this.comboFilterBy.TabIndex = 18;
            this.comboFilterBy.SelectedIndexChanged += new System.EventHandler(this.comboFilterBy_SelectedIndexChanged);
            // 
            // txtResult
            // 
            this.txtResult.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtResult.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResult.HideSelection = false;
            this.txtResult.Location = new System.Drawing.Point(0, 0);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(508, 89);
            this.txtResult.TabIndex = 19;
            this.txtResult.Text = "";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.txtResult);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.txtDescription);
            this.splitContainer1.Size = new System.Drawing.Size(1021, 89);
            this.splitContainer1.SplitterDistance = 508;
            this.splitContainer1.TabIndex = 21;
            // 
            // txtDescription
            // 
            this.txtDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDescription.Location = new System.Drawing.Point(0, 0);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(509, 89);
            this.txtDescription.TabIndex = 0;
            this.txtDescription.Text = "";
            // 
            // splitContainer2
            // 
            this.splitContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer2.Location = new System.Drawing.Point(0, 57);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.tabControl1);
            this.splitContainer2.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.splitContainer1);
            this.splitContainer2.Size = new System.Drawing.Size(1021, 502);
            this.splitContainer2.SplitterDistance = 409;
            this.splitContainer2.TabIndex = 22;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabDimensions);
            this.tabControl1.Controls.Add(this.tabValueType);
            this.tabControl1.Controls.Add(this.tabCategory);
            this.tabControl1.Controls.Add(this.tabSegments);
            this.tabControl1.Controls.Add(this.tabSettings);
            this.tabControl1.Controls.Add(this.tabPatches);
            this.tabControl1.Controls.Add(this.tabFileInfo);
            this.tabControl1.ImageList = this.imageList3;
            this.tabControl1.Location = new System.Drawing.Point(8, 8);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(449, 371);
            this.tabControl1.TabIndex = 1;
            this.tabControl1.Visible = false;
            // 
            // tabDimensions
            // 
            this.tabDimensions.ImageKey = "Dimensions.ico";
            this.tabDimensions.Location = new System.Drawing.Point(4, 31);
            this.tabDimensions.Name = "tabDimensions";
            this.tabDimensions.Padding = new System.Windows.Forms.Padding(3);
            this.tabDimensions.Size = new System.Drawing.Size(441, 336);
            this.tabDimensions.TabIndex = 0;
            this.tabDimensions.UseVisualStyleBackColor = true;
            // 
            // tabValueType
            // 
            this.tabValueType.ImageKey = "valuetype.ico";
            this.tabValueType.Location = new System.Drawing.Point(4, 31);
            this.tabValueType.Name = "tabValueType";
            this.tabValueType.Padding = new System.Windows.Forms.Padding(3);
            this.tabValueType.Size = new System.Drawing.Size(441, 336);
            this.tabValueType.TabIndex = 1;
            this.tabValueType.UseVisualStyleBackColor = true;
            // 
            // tabCategory
            // 
            this.tabCategory.ImageKey = "category.ico";
            this.tabCategory.Location = new System.Drawing.Point(4, 31);
            this.tabCategory.Name = "tabCategory";
            this.tabCategory.Size = new System.Drawing.Size(441, 336);
            this.tabCategory.TabIndex = 2;
            this.tabCategory.UseVisualStyleBackColor = true;
            // 
            // tabSegments
            // 
            this.tabSegments.ImageKey = "segments.ico";
            this.tabSegments.Location = new System.Drawing.Point(4, 31);
            this.tabSegments.Name = "tabSegments";
            this.tabSegments.Size = new System.Drawing.Size(441, 336);
            this.tabSegments.TabIndex = 3;
            this.tabSegments.UseVisualStyleBackColor = true;
            // 
            // tabSettings
            // 
            this.tabSettings.Controls.Add(this.chkAutoMulti1d);
            this.tabSettings.Controls.Add(this.chkShowCategorySubfolder);
            this.tabSettings.Controls.Add(this.labelIconSize);
            this.tabSettings.Controls.Add(this.numIconSize);
            this.tabSettings.ImageKey = "modify.ico";
            this.tabSettings.Location = new System.Drawing.Point(4, 31);
            this.tabSettings.Name = "tabSettings";
            this.tabSettings.Size = new System.Drawing.Size(441, 336);
            this.tabSettings.TabIndex = 5;
            this.tabSettings.UseVisualStyleBackColor = true;
            // 
            // chkAutoMulti1d
            // 
            this.chkAutoMulti1d.AutoSize = true;
            this.chkAutoMulti1d.Location = new System.Drawing.Point(9, 52);
            this.chkAutoMulti1d.Name = "chkAutoMulti1d";
            this.chkAutoMulti1d.Size = new System.Drawing.Size(181, 17);
            this.chkAutoMulti1d.TabIndex = 28;
            this.chkAutoMulti1d.Text = "Automatic multitable for 1d tables";
            this.chkAutoMulti1d.UseVisualStyleBackColor = true;
            this.chkAutoMulti1d.CheckedChanged += new System.EventHandler(this.chkAutoMulti1d_CheckedChanged);
            // 
            // chkShowCategorySubfolder
            // 
            this.chkShowCategorySubfolder.AutoSize = true;
            this.chkShowCategorySubfolder.Location = new System.Drawing.Point(9, 29);
            this.chkShowCategorySubfolder.Name = "chkShowCategorySubfolder";
            this.chkShowCategorySubfolder.Size = new System.Drawing.Size(144, 17);
            this.chkShowCategorySubfolder.TabIndex = 0;
            this.chkShowCategorySubfolder.Text = "Show Category subfolder";
            this.chkShowCategorySubfolder.UseVisualStyleBackColor = true;
            this.chkShowCategorySubfolder.CheckedChanged += new System.EventHandler(this.chkShowCategorySubfolder_CheckedChanged);
            // 
            // labelIconSize
            // 
            this.labelIconSize.AutoSize = true;
            this.labelIconSize.Location = new System.Drawing.Point(6, 6);
            this.labelIconSize.Name = "labelIconSize";
            this.labelIconSize.Size = new System.Drawing.Size(52, 13);
            this.labelIconSize.TabIndex = 26;
            this.labelIconSize.Text = "Icon size:";
            // 
            // numIconSize
            // 
            this.numIconSize.Location = new System.Drawing.Point(64, 3);
            this.numIconSize.Maximum = new decimal(new int[] {
            128,
            0,
            0,
            0});
            this.numIconSize.Minimum = new decimal(new int[] {
            8,
            0,
            0,
            0});
            this.numIconSize.Name = "numIconSize";
            this.numIconSize.Size = new System.Drawing.Size(40, 20);
            this.numIconSize.TabIndex = 27;
            this.numIconSize.Value = new decimal(new int[] {
            16,
            0,
            0,
            0});
            this.numIconSize.ValueChanged += new System.EventHandler(this.numIconSize_ValueChanged);
            // 
            // tabPatches
            // 
            this.tabPatches.ImageKey = "patch.ico";
            this.tabPatches.Location = new System.Drawing.Point(4, 31);
            this.tabPatches.Name = "tabPatches";
            this.tabPatches.Size = new System.Drawing.Size(441, 336);
            this.tabPatches.TabIndex = 4;
            this.tabPatches.UseVisualStyleBackColor = true;
            // 
            // tabFileInfo
            // 
            this.tabFileInfo.Controls.Add(this.tabControlFileInfo);
            this.tabFileInfo.ImageKey = "info.ico";
            this.tabFileInfo.Location = new System.Drawing.Point(4, 31);
            this.tabFileInfo.Name = "tabFileInfo";
            this.tabFileInfo.Size = new System.Drawing.Size(441, 336);
            this.tabFileInfo.TabIndex = 6;
            this.tabFileInfo.UseVisualStyleBackColor = true;
            // 
            // tabControlFileInfo
            // 
            this.tabControlFileInfo.Location = new System.Drawing.Point(93, 89);
            this.tabControlFileInfo.Name = "tabControlFileInfo";
            this.tabControlFileInfo.SelectedIndex = 0;
            this.tabControlFileInfo.Size = new System.Drawing.Size(184, 138);
            this.tabControlFileInfo.TabIndex = 0;
            // 
            // imageList3
            // 
            this.imageList3.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList3.ImageStream")));
            this.imageList3.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList3.Images.SetKeyName(0, "Dimensions.ico");
            this.imageList3.Images.SetKeyName(1, "patch.ico");
            this.imageList3.Images.SetKeyName(2, "segments.ico");
            this.imageList3.Images.SetKeyName(3, "valuetype.ico");
            this.imageList3.Images.SetKeyName(4, "listmode.ico");
            this.imageList3.Images.SetKeyName(5, "category.ico");
            this.imageList3.Images.SetKeyName(6, "modify.ico");
            this.imageList3.Images.SetKeyName(7, "info.ico");
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "explorer.ico");
            this.imageList1.Images.SetKeyName(1, "1d.ico");
            this.imageList1.Images.SetKeyName(2, "2d.ico");
            this.imageList1.Images.SetKeyName(3, "3d.ico");
            this.imageList1.Images.SetKeyName(4, "enum.ico");
            this.imageList1.Images.SetKeyName(5, "enum1d.ico");
            this.imageList1.Images.SetKeyName(6, "enum2d.ico");
            this.imageList1.Images.SetKeyName(7, "enum3d.ico");
            this.imageList1.Images.SetKeyName(8, "flag.ico");
            this.imageList1.Images.SetKeyName(9, "flag1d.ico");
            this.imageList1.Images.SetKeyName(10, "flag2d.ico");
            this.imageList1.Images.SetKeyName(11, "flag3d.ico");
            this.imageList1.Images.SetKeyName(12, "mask.ico");
            this.imageList1.Images.SetKeyName(13, "mask1d.ico");
            this.imageList1.Images.SetKeyName(14, "mask2d.ico");
            this.imageList1.Images.SetKeyName(15, "mask3d.ico");
            this.imageList1.Images.SetKeyName(16, "num.ico");
            this.imageList1.Images.SetKeyName(17, "boolean.ico");
            this.imageList1.Images.SetKeyName(18, "bitmask.ico");
            this.imageList1.Images.SetKeyName(19, "number.ico");
            this.imageList1.Images.SetKeyName(20, "Dimensions.ico");
            this.imageList1.Images.SetKeyName(21, "valuetype.ico");
            this.imageList1.Images.SetKeyName(22, "segments.ico");
            this.imageList1.Images.SetKeyName(23, "category.ico");
            this.imageList1.Images.SetKeyName(24, "eeprom.ico");
            this.imageList1.Images.SetKeyName(25, "engine.ico");
            this.imageList1.Images.SetKeyName(26, "fuel.ico");
            this.imageList1.Images.SetKeyName(27, "os.ico");
            this.imageList1.Images.SetKeyName(28, "speedo.ico");
            this.imageList1.Images.SetKeyName(29, "system.ico");
            this.imageList1.Images.SetKeyName(30, "trans.ico");
            this.imageList1.Images.SetKeyName(31, "enginediag.ico");
            this.imageList1.Images.SetKeyName(32, "transdiag.ico");
            this.imageList1.Images.SetKeyName(33, "patch.ico");
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // timerFilter
            // 
            this.timerFilter.Tick += new System.EventHandler(this.timerFilter_Tick);
            // 
            // imageList2
            // 
            this.imageList2.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList2.ImageStream")));
            this.imageList2.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList2.Images.SetKeyName(0, "collapse.ico");
            this.imageList2.Images.SetKeyName(1, "expand.ico");
            this.imageList2.Images.SetKeyName(2, "Dimensions.ico");
            this.imageList2.Images.SetKeyName(3, "segments.ico");
            this.imageList2.Images.SetKeyName(4, "valuetype.ico");
            this.imageList2.Images.SetKeyName(5, "patch.ico");
            this.imageList2.Images.SetKeyName(6, "listmode.ico");
            this.imageList2.Images.SetKeyName(7, "Category.ico");
            this.imageList2.Images.SetKeyName(8, "pieces.ico");
            this.imageList2.Images.SetKeyName(9, "stapler.ico");
            // 
            // btnCollapse
            // 
            this.btnCollapse.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCollapse.ImageKey = "collapse.ico";
            this.btnCollapse.ImageList = this.imageList2;
            this.btnCollapse.Location = new System.Drawing.Point(196, 27);
            this.btnCollapse.Name = "btnCollapse";
            this.btnCollapse.Size = new System.Drawing.Size(24, 24);
            this.btnCollapse.TabIndex = 25;
            this.btnCollapse.UseVisualStyleBackColor = true;
            this.btnCollapse.Click += new System.EventHandler(this.btnCollapse_Click);
            // 
            // btnExpand
            // 
            this.btnExpand.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExpand.ImageKey = "expand.ico";
            this.btnExpand.ImageList = this.imageList2;
            this.btnExpand.Location = new System.Drawing.Point(166, 27);
            this.btnExpand.Name = "btnExpand";
            this.btnExpand.Size = new System.Drawing.Size(24, 24);
            this.btnExpand.TabIndex = 24;
            this.btnExpand.UseVisualStyleBackColor = true;
            this.btnExpand.Click += new System.EventHandler(this.btnExpand_Click);
            // 
            // radioListMode
            // 
            this.radioListMode.AutoSize = true;
            this.radioListMode.ImageKey = "listmode.ico";
            this.radioListMode.ImageList = this.imageList2;
            this.radioListMode.Location = new System.Drawing.Point(326, 1);
            this.radioListMode.MaximumSize = new System.Drawing.Size(40, 40);
            this.radioListMode.Name = "radioListMode";
            this.radioListMode.Padding = new System.Windows.Forms.Padding(4);
            this.radioListMode.Size = new System.Drawing.Size(38, 24);
            this.radioListMode.TabIndex = 1;
            this.radioListMode.UseVisualStyleBackColor = true;
            this.radioListMode.CheckedChanged += new System.EventHandler(this.radioListMode_CheckedChanged);
            // 
            // radioTreeMode
            // 
            this.radioTreeMode.AutoSize = true;
            this.radioTreeMode.Checked = true;
            this.radioTreeMode.ImageKey = "category.ico";
            this.radioTreeMode.ImageList = this.imageList3;
            this.radioTreeMode.Location = new System.Drawing.Point(370, -1);
            this.radioTreeMode.Name = "radioTreeMode";
            this.radioTreeMode.Padding = new System.Windows.Forms.Padding(2);
            this.radioTreeMode.Size = new System.Drawing.Size(42, 28);
            this.radioTreeMode.TabIndex = 0;
            this.radioTreeMode.TabStop = true;
            this.radioTreeMode.UseVisualStyleBackColor = true;
            this.radioTreeMode.CheckedChanged += new System.EventHandler(this.radioTreeMode_CheckedChanged);
            // 
            // imageList4
            // 
            this.imageList4.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList4.ImageStream")));
            this.imageList4.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList4.Images.SetKeyName(0, "1d.ico");
            this.imageList4.Images.SetKeyName(1, "2d.ico");
            this.imageList4.Images.SetKeyName(2, "3d.ico");
            this.imageList4.Images.SetKeyName(3, "bitmask.ico");
            this.imageList4.Images.SetKeyName(4, "boolean.ico");
            this.imageList4.Images.SetKeyName(5, "boot.ico");
            this.imageList4.Images.SetKeyName(6, "category.ico");
            this.imageList4.Images.SetKeyName(7, "Category_old.ico");
            this.imageList4.Images.SetKeyName(8, "Category2.ico");
            this.imageList4.Images.SetKeyName(9, "category3.ico");
            this.imageList4.Images.SetKeyName(10, "collapse.ico");
            this.imageList4.Images.SetKeyName(11, "Dimensions.ico");
            this.imageList4.Images.SetKeyName(12, "DTC.ico");
            this.imageList4.Images.SetKeyName(13, "eeprom.ico");
            this.imageList4.Images.SetKeyName(14, "engine.ico");
            this.imageList4.Images.SetKeyName(15, "enginediag.ico");
            this.imageList4.Images.SetKeyName(16, "enum.ico");
            this.imageList4.Images.SetKeyName(17, "enum1d.ico");
            this.imageList4.Images.SetKeyName(18, "enum2d.ico");
            this.imageList4.Images.SetKeyName(19, "enum3d.ico");
            this.imageList4.Images.SetKeyName(20, "expand.ico");
            this.imageList4.Images.SetKeyName(21, "explorer.ico");
            this.imageList4.Images.SetKeyName(22, "flag1d.ico");
            this.imageList4.Images.SetKeyName(23, "flag2d.ico");
            this.imageList4.Images.SetKeyName(24, "flag3d.ico");
            this.imageList4.Images.SetKeyName(25, "fuel.ico");
            this.imageList4.Images.SetKeyName(26, "mask1d.ico");
            this.imageList4.Images.SetKeyName(27, "mask2d.ico");
            this.imageList4.Images.SetKeyName(28, "mask3d.ico");
            this.imageList4.Images.SetKeyName(29, "number.ico");
            this.imageList4.Images.SetKeyName(30, "os.ico");
            this.imageList4.Images.SetKeyName(31, "patch.ico");
            this.imageList4.Images.SetKeyName(32, "segments.ico");
            this.imageList4.Images.SetKeyName(33, "speedo.ico");
            this.imageList4.Images.SetKeyName(34, "system.ico");
            this.imageList4.Images.SetKeyName(35, "trans.ico");
            this.imageList4.Images.SetKeyName(36, "transdiag.ico");
            this.imageList4.Images.SetKeyName(37, "valuetype.ico");
            this.imageList4.Images.SetKeyName(38, "listmode.ico");
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(422, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 29;
            this.label2.Text = "Table:";
            // 
            // labelTableName
            // 
            this.labelTableName.AutoSize = true;
            this.labelTableName.BackColor = System.Drawing.SystemColors.Window;
            this.labelTableName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTableName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTableName.Location = new System.Drawing.Point(465, 5);
            this.labelTableName.Name = "labelTableName";
            this.labelTableName.Size = new System.Drawing.Size(74, 18);
            this.labelTableName.TabIndex = 30;
            this.labelTableName.Text = "tablename";
            // 
            // labelBy
            // 
            this.labelBy.AutoSize = true;
            this.labelBy.Location = new System.Drawing.Point(163, 33);
            this.labelBy.Name = "labelBy";
            this.labelBy.Size = new System.Drawing.Size(21, 13);
            this.labelBy.TabIndex = 31;
            this.labelBy.Text = "by:";
            // 
            // contextMenuStripTree
            // 
            this.contextMenuStripTree.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openInNewWindowToolStripMenuItem,
            this.compareSelectedTablesToolStripMenuItem1});
            this.contextMenuStripTree.Name = "contextMenuStripTree";
            this.contextMenuStripTree.Size = new System.Drawing.Size(204, 48);
            // 
            // openInNewWindowToolStripMenuItem
            // 
            this.openInNewWindowToolStripMenuItem.Name = "openInNewWindowToolStripMenuItem";
            this.openInNewWindowToolStripMenuItem.Size = new System.Drawing.Size(203, 22);
            this.openInNewWindowToolStripMenuItem.Text = "Open in new window";
            this.openInNewWindowToolStripMenuItem.Click += new System.EventHandler(this.openInNewWindowToolStripMenuItem_Click);
            // 
            // compareSelectedTablesToolStripMenuItem1
            // 
            this.compareSelectedTablesToolStripMenuItem1.Name = "compareSelectedTablesToolStripMenuItem1";
            this.compareSelectedTablesToolStripMenuItem1.Size = new System.Drawing.Size(203, 22);
            this.compareSelectedTablesToolStripMenuItem1.Text = "Compare selected tables";
            this.compareSelectedTablesToolStripMenuItem1.Click += new System.EventHandler(this.compareSelectedTablesToolStripMenuItem1_Click);
            // 
            // frmTuner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 559);
            this.Controls.Add(this.radioListMode);
            this.Controls.Add(this.radioTreeMode);
            this.Controls.Add(this.labelBy);
            this.Controls.Add(this.txtSearchTableSeek);
            this.Controls.Add(this.labelTableName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCollapse);
            this.Controls.Add(this.btnExpand);
            this.Controls.Add(this.comboFilterBy);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboTableCategory);
            this.Controls.Add(this.labelCategory);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.splitContainer2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmTuner";
            this.Text = "Tuner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmTuner_FormClosing);
            this.Load += new System.EventHandler(this.frmTuner_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.tabSettings.ResumeLayout(false);
            this.tabSettings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numIconSize)).EndInit();
            this.tabFileInfo.ResumeLayout(false);
            this.contextMenuStripTree.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox txtSearchTableSeek;
        private System.Windows.Forms.ComboBox comboTableCategory;
        private System.Windows.Forms.Label labelCategory;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveBINToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pasteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editTableToolStripMenuItem;
        private Label label1;
        private ToolStripMenuItem settingsToolStripMenuItem;
        private ToolStripMenuItem showTablesWithEmptyAddressToolStripMenuItem;
        private ComboBox comboFilterBy;
        private ToolStripMenuItem disableMultitableToolStripMenuItem;
        private ToolStripMenuItem saveBinAsToolStripMenuItem;
        private ToolStripMenuItem unitsToolStripMenuItem;
        private RichTextBox txtResult;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private ToolStripMenuItem enableConfigModeToolStripMenuItem;
        private RichTextBox txtDescription;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem resetTunerModeColumnsToolStripMenuItem;
        private ToolStripMenuItem loadBINToolStripMenuItem;
        private ToolStripMenuItem currentFileToolStripMenuItem;
        private ToolStripMenuItem tableListToolStripMenuItem;
        private ToolStripMenuItem newToolStripMenuItem;
        private ToolStripMenuItem insertRowToolStripMenuItem;
        private ToolStripMenuItem deleteRowToolStripMenuItem;
        private ToolStripMenuItem editRowToolStripMenuItem;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripMenuItem duplicateTableConfigToolStripMenuItem;
        private ToolStripMenuItem searchAndCompareToolStripMenuItem;
        private ToolStripMenuItem utilitiesToolStripMenuItem;
        private ToolStripMenuItem importToolStripMenuItem1;
        private ToolStripMenuItem dTCToolStripMenuItem;
        private ToolStripMenuItem tableSeekToolStripMenuItem;
        private ToolStripMenuItem xDFToolStripMenuItem1;
        private ToolStripMenuItem tinyTunerDBV6OnlyToolStripMenuItem;
        private ToolStripMenuItem xMlgeneratorImportCSVToolStripMenuItem;
        private ToolStripMenuItem cSVexperimentalToolStripMenuItem;
        private ToolStripMenuItem cSV2ExperimentalToolStripMenuItem;
        private ToolStripMenuItem exportToolStripMenuItem1;
        private ToolStripMenuItem cSVToolStripMenuItem;
        private ToolStripMenuItem xDFToolStripMenuItem;
        private ToolStripMenuItem xMLGeneratorExportToolStripMenuItem;
        private ToolStripMenuItem xmlToolStripMenuItem;
        private ToolStripMenuItem loadXMLToolStripMenuItem;
        private ToolStripMenuItem saveXMLToolStripMenuItem;
        private ToolStripMenuItem saveXMLAsToolStripMenuItem;
        private ToolStripMenuItem clearTableToolStripMenuItem;
        private ToolStripMenuItem loadTablelistxmlTableseekImportToolStripMenuItem;
        private ToolStripMenuItem loadTablelistnewToolStripMenuItem;
        private ToolStripMenuItem openMultipleBINToolStripMenuItem;
        private ToolStripMenuItem saveAllBINFilesToolStripMenuItem;
        private ToolStripMenuItem disableConfigAutoloadToolStripMenuItem;
        private ToolStripMenuItem findDifferencesToolStripMenuItem;
        private ToolStripMenuItem searchAndCompareAllToolStripMenuItem;
        private ToolStripMenuItem compareSelectedTablesToolStripMenuItem;
        private ToolStripMenuItem massModifyTableListsToolStripMenuItem;
        private ToolStripMenuItem massModifyTableListsSelectFilesToolStripMenuItem;
        private ToolStripMenuItem moreSettingsToolStripMenuItem;
        private Timer timerFilter;
        private ToolStripMenuItem caseSensitiveFilteringToolStripMenuItem;
        private ToolStripMenuItem copySelectedTablesToToolStripMenuItem;
        private ToolStripMenuItem applyPatchToolStripMenuItem;
        private ToolStripMenuItem createPatchToolStripMenuItem;
        private TabControl tabControl1;
        private TabPage tabDimensions;
        private TabPage tabValueType;
        private TabPage tabCategory;
        private TabPage tabSegments;
        private TabPage tabPatches;
        private ImageList imageList2;
        private ImageList imageList3;
        private Button btnCollapse;
        private Button btnExpand;
        private ImageList imageList1;
        private NumericUpDown numIconSize;
        private Label labelIconSize;
        private RadioButton radioListMode;
        private RadioButton radioTreeMode;
        private ImageList imageList4;
        private ToolStripMenuItem selectToolStripMenuItem;
        private ToolStripMenuItem dToolStripMenuItem;
        private ToolStripMenuItem dToolStripMenuItem1;
        private ToolStripMenuItem dToolStripMenuItem2;
        private ToolStripMenuItem enumToolStripMenuItem;
        private ToolStripMenuItem booleanToolStripMenuItem;
        private ToolStripMenuItem bitmaskToolStripMenuItem;
        private ToolStripMenuItem numberToolStripMenuItem;
        private Label label2;
        public Label labelTableName;
        private Label labelBy;
        private TabPage tabSettings;
        private CheckBox chkShowCategorySubfolder;
        private ContextMenuStrip contextMenuStripTree;
        private ToolStripMenuItem openInNewWindowToolStripMenuItem;
        private CheckBox chkAutoMulti1d;
        private ToolStripMenuItem selectFileToolStripMenuItem;
        private ToolStripMenuItem findDifferencesHEXToolStripMenuItem;
        private ToolStripMenuItem selectFileToolStripMenuItem1;
        private TabPage tabFileInfo;
        private TabControl tabControlFileInfo;
        private ToolStripMenuItem compareSelectedTablesToolStripMenuItem1;
        private ToolStripMenuItem importXDFToolStripMenuItem;
    }
}