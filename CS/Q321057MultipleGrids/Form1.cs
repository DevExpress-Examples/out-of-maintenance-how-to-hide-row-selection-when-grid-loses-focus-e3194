using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraGrid.Views.Grid;

namespace Q321057MultipleGrids
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            gridControl1.DataSource = FillDataTable();
            gridControl2.DataSource = FillDataTable();
        }

        public static DataTable FillDataTable()
        {
            DataTable _dataTable = new DataTable();
            _dataTable.Columns.Add(new DataColumn("ID", typeof(int)));
            _dataTable.Columns.Add(new DataColumn("Name", typeof(string)));
            _dataTable.Rows.Add(new object[] { 1, "Apple" });
            _dataTable.Rows.Add(new object[] { 2, "Peach" });
            _dataTable.Rows.Add(new object[] { 3, "Banana" });
            return _dataTable;
        }
    }
}
