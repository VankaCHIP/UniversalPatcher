﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Globalization;
using static upatcher;

namespace UniversalPatcher
{
    public class TableData
    {
        public TableData()
        {
            id = (uint)tableDatas.Count;
            OS = "";
            TableName = "";
            Address = "";
            Math = "";
            SavingMath = "";
            Units = "";
            Category = "";
            ColumnHeaders = "";
            RowHeaders = "";
            TableDescription = "";
            RowMajor = true;
            //DataType = TypeFloat;
            Floating = false;
            OutputType = TypeFloat;
        }
        public uint id { get; set; }
        public string OS { get; set; }
        public string TableName { get; set; }
        public uint AddrInt;
        public string Address { get; set; }
        public byte ElementSize { get; set; }
        public string Math { get; set; }
        public string SavingMath { get; set; }
        public string Units { get; set; }
        public ushort OutputType { get; set; }
        public ushort Decimals { get; set; }
        public bool Signed { get; set; }
        public bool Floating { get; set; }
        public ushort Columns { get; set; }
        public ushort Rows { get; set; }
        public bool RowMajor { get; set; }
        public string Category { get; set; }
        public string ColumnHeaders { get; set; }
        public string RowHeaders { get; set; }
        public string TableDescription { get; set; }
        public void importFoundTable(int tId, PcmFile PCM)
        {

            TableSeek tSeek = tableSeeks[foundTables[tId].configId];
            FoundTable ft = foundTables[tId];

            AddrInt = ft.addrInt;
            Address = ft.Address;
            Category = ft.Category;
            OutputType = tSeek.OutputType;
            Floating = tSeek.Floating;
            ElementSize = (byte)(tSeek.Bits / 8);
            Math = tSeek.Math;
            SavingMath = tSeek.SavingMath;
            OS = PCM.OS;
            RowMajor = tSeek.RowMajor;
            Rows = ft.Rows;
            Columns = ft.Columns;
            ColumnHeaders = tSeek.ColHeaders;
            RowHeaders = tSeek.RowHeaders;
            Decimals = tSeek.Decimals;
            Signed = tSeek.Signed;
            TableDescription = tSeek.Description;
            TableName = ft.Name;
            Units = tSeek.Units;
            if (!tableCategories.Contains(Category))
                tableCategories.Add(Category);

        }

    }
}