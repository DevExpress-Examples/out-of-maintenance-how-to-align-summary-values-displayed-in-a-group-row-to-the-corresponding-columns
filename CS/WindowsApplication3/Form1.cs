using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraBars;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Columns;
using DevExpress.Utils.Drawing;
using DevExpress.Utils;
using DevExpress.XtraVerticalGrid;
using System.Reflection;
using DevExpress.XtraVerticalGrid.Painters;
using System.Collections;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Drawing;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.Utils.Text;

namespace WindowsApplication3 {
    public partial class Form1: Form {
        public Form1() {
            InitializeComponent();
        }
        public void InitData() {
            for(int i = 0;i < 5;i++)
                if (i% 2 == 0)
                    dataSet11.Tables[0].Rows.Add(new object[] { i, i * 10, 0, i+100, i+10, i*100});
                else
                    dataSet11.Tables[0].Rows.Add(new object[] { i, i, 1, i, i, i });
        }
       
        

        private void Form1_Load(object sender, EventArgs e) {
            this.InitData();
            gridControl1.ForceInitialize();
            gridView1.OptionsView.ShowFooter = true;
            gridView1.OptionsBehavior.AlignGroupSummaryInGroupRow = DefaultBoolean.True;
            for ( int i = 1; i < 7; i++){
               GridGroupSummaryItem item = new GridGroupSummaryItem();
               item.FieldName = "Column" + i.ToString();
               item.SummaryType = DevExpress.Data.SummaryItemType.Sum;
               item.DisplayFormat = "Sum {0:n0}";
               item.ShowInGroupColumnFooter = gridView1.Columns[item.FieldName];
               gridView1.GroupSummary.Add(item);
            }
            gridView1.BeginSort();
            try {
                gridView1.ClearGrouping();
                gridView1.Columns["Column3"].GroupIndex = 0;
            }
            finally {
                gridView1.EndSort();
            }

           
        }
    }
}
