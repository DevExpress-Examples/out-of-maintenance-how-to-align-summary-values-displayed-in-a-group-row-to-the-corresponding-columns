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
            for ( int i = 1; i < 7; i++){
               GridGroupSummaryItem item = new GridGroupSummaryItem();
               item.FieldName = "Column" + i.ToString();
               item.SummaryType = DevExpress.Data.SummaryItemType.Sum;
               item.DisplayFormat = "Sum {0:n0}";
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

        private void gridView1_CustomDrawGroupRow(object sender, DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs e) {
           GridView view = sender as GridView;
            ArrayList items = ExtractSummaryItems(view);
            if (items.Count == 0) return;
            DrawBackground(e, view);
            DrawSummaryValues(e, view, items);
            e.Handled = true;
        }
        private ArrayList ExtractSummaryItems(GridView view) {
            ArrayList items = new ArrayList();
            foreach(GridSummaryItem si in view.GroupSummary)
                if(si is GridGroupSummaryItem && si.SummaryType != DevExpress.Data.SummaryItemType.None)
                    items.Add(si);
            return items;
        }

        private void DrawBackground(RowObjectCustomDrawEventArgs e, GridView view) {
            GridGroupRowPainter painter;
            GridGroupRowInfo info;
            painter = e.Painter as GridGroupRowPainter;
            info = e.Info as GridGroupRowInfo;
            int level = view.GetRowLevel(e.RowHandle);
            int row = view.GetDataRowHandleByGroupRowHandle(e.RowHandle);
            info.GroupText = string.Format("{0}: {1}", view.GroupedColumns[level].Caption,
                view.GetRowCellDisplayText(row, view.GroupedColumns[level]));
            e.Appearance.DrawBackground(e.Cache, info.Bounds);
            painter.ElementsPainter.GroupRow.DrawObject(info);
        }

        private void DrawSummaryValues(RowObjectCustomDrawEventArgs e, GridView view, ArrayList items) {
            Hashtable values = view.GetGroupSummaryValues(e.RowHandle);
            foreach(GridGroupSummaryItem item in items) {
                Rectangle rect = GetColumnBounds(view, item);
                if(rect.IsEmpty) continue;
                string text = item.GetDisplayText(values[item], false);
                rect = CalcSummaryRect(text, e, view.Columns[item.FieldName]);
                e.Appearance.DrawString(e.Cache, text, rect);
            }
        }

        private Rectangle GetColumnBounds(GridView view, GridGroupSummaryItem item) {
            GridColumn column = view.Columns[item.FieldName];
            return GetColumnBounds(column);
        }
        GridViewInfo gridInfo = null;
        private Rectangle GetColumnBounds(GridColumn column) {
            gridInfo = (GridViewInfo)column.View.GetViewInfo();
            GridColumnInfoArgs colInfo = gridInfo.ColumnsInfo[column];

            if(colInfo != null)
                return colInfo.Bounds;
            else
                return Rectangle.Empty;
        }

        private Rectangle CalcSummaryRect(string text, RowObjectCustomDrawEventArgs e, GridColumn column) {
            Rectangle result = GetColumnBounds(column);
            SizeF sz = TextUtils.GetStringSize(e.Graphics, text, e.Appearance.Font);
            int width = Convert.ToInt32(sz.Width) + 1;
            if(!gridInfo.ViewRects.FixedLeft.IsEmpty) {
                int fixedLeftRight = gridInfo.ViewRects.FixedLeft.Right;
                int marginLeft = result.Right - width - fixedLeftRight;
                if(marginLeft < 0 && column.Fixed == FixedStyle.None)
                    return Rectangle.Empty;
            }
            if(!gridInfo.ViewRects.FixedRight.IsEmpty) {
                int fixedRightLeft = gridInfo.ViewRects.FixedRight.Left;
                if(fixedRightLeft <= result.Right && column.Fixed == FixedStyle.None)
                    return Rectangle.Empty;
            }
            result = FixLeftEdge(width, result);
            result.Width = result.Width;
            result.Y = e.Bounds.Y;
            result.Height = e.Bounds.Height - 2;

            return PreventSummaryTextOverlapping(e, result);
        }

        private Rectangle FixLeftEdge(int width, Rectangle result) {
            int delta = result.Width - width - 2;
            if(delta > 0) {
                result.X += delta;
                result.Width -= delta;
            }
            return result;
        }

        private Rectangle PreventSummaryTextOverlapping(RowObjectCustomDrawEventArgs e, Rectangle rect) {
            GridGroupRowInfo gInfo = (GridGroupRowInfo)e.Info;
            int groupTextLocation = gInfo.ButtonBounds.Right + 10;
            int groupTextWidth = TextUtils.GetStringSize(e.Graphics, gInfo.GroupText, e.Appearance.Font).Width;
            int fixedLeft = gInfo.ViewInfo.ViewRects.FixedLeft.Left;
            Rectangle r = new Rectangle(groupTextLocation, 0, groupTextWidth, e.Info.Bounds.Height);
            if(r.Right > rect.X) {
                if(r.Right > rect.Right)
                    rect.Width = 0;
                else {
                    rect.Width -= r.Right - rect.X;
                    rect.X = r.Right;
                }
            }
            return rect;
        }
    }
}
