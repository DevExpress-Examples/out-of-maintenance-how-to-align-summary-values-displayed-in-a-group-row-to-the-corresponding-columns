using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;
using System.Data;
using DevExpress.Data;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Drawing;
using DevExpress.XtraGrid.Columns;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.Utils.Text;

namespace AlignSummaries {
    /// <summary>
    /// Summary description for Form1.
    /// </summary>
    public class Form1 : System.Windows.Forms.Form {
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Data.DataSet dataSet1;
        private System.Data.DataTable dataTable1;
        private System.Data.DataColumn dataColumn1;
        private System.Data.DataColumn dataColumn2;
        private System.Data.DataColumn dataColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn colName;
        private DevExpress.XtraGrid.Columns.GridColumn colCity;
        private DevExpress.XtraGrid.Columns.GridColumn colAge;
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.Container components = null;

        public Form1() {
            //
            // Required for Windows Form Designer support
            //
            InitializeComponent();

            //
            // TODO: Add any constructor code after InitializeComponent call
            //
        }

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        protected override void Dispose(bool disposing) {
            if (disposing) {
                if (components != null) {
                    components.Dispose();
                }
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code
        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.dataTable1 = new System.Data.DataTable();
            this.dataColumn1 = new System.Data.DataColumn();
            this.dataColumn2 = new System.Data.DataColumn();
            this.dataColumn3 = new System.Data.DataColumn();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colAge = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dataSet1 = new System.Data.DataSet();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.dataTable1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(464, 306);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // dataTable1
            // 
            this.dataTable1.Columns.AddRange(new System.Data.DataColumn[] {
            this.dataColumn1,
            this.dataColumn2,
            this.dataColumn3});
            this.dataTable1.TableName = "Table1";
            // 
            // dataColumn1
            // 
            this.dataColumn1.ColumnName = "Name";
            // 
            // dataColumn2
            // 
            this.dataColumn2.ColumnName = "City";
            // 
            // dataColumn3
            // 
            this.dataColumn3.ColumnName = "Age";
            this.dataColumn3.DataType = typeof(int);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colName,
            this.colCity,
            this.colAge});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Name", null, "Count = {0}"),
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Average, "Age", null, "Average = {0}")});
            this.gridView1.Name = "gridView1";
            this.gridView1.CustomDrawGroupRow += new DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventHandler(this.gridView1_CustomDrawGroupRow);
            // 
            // colName
            // 
            this.colName.Caption = "Name";
            this.colName.FieldName = "Name";
            this.colName.Name = "colName";
            this.colName.Visible = true;
            this.colName.VisibleIndex = 0;
            // 
            // colCity
            // 
            this.colCity.Caption = "City";
            this.colCity.FieldName = "City";
            this.colCity.Name = "colCity";
            this.colCity.Visible = true;
            this.colCity.VisibleIndex = 1;
            // 
            // colAge
            // 
            this.colAge.Caption = "Age";
            this.colAge.FieldName = "Age";
            this.colAge.Name = "colAge";
            this.colAge.Visible = true;
            this.colAge.VisibleIndex = 2;
            // 
            // dataSet1
            // 
            this.dataSet1.DataSetName = "NewDataSet";
            this.dataSet1.Locale = new System.Globalization.CultureInfo("en-US");
            this.dataSet1.Tables.AddRange(new System.Data.DataTable[] {
            this.dataTable1});
            // 
            // Form1
            // 
            this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
            this.ClientSize = new System.Drawing.Size(464, 306);
            this.Controls.Add(this.gridControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTable1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSet1)).EndInit();
            this.ResumeLayout(false);

        }
        #endregion

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main() {
            Application.Run(new Form1());
        }

        private void FillTable() {
            dataTable1.Rows.Add(new object[] { "Ann", "Washington", 30 });
            dataTable1.Rows.Add(new object[] { "Bill", "New York", 40 });
            dataTable1.Rows.Add(new object[] { "Clive", "New York", 50 });
            dataTable1.AcceptChanges();
        }

        private void Form1_Load(object sender, System.EventArgs e) {
            FillTable();
            gridView1.Columns["City"].GroupIndex = 0;
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
            foreach (GridSummaryItem si in view.GroupSummary)
                if (si is GridGroupSummaryItem && si.SummaryType != SummaryItemType.None)
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
            foreach (GridGroupSummaryItem item in items) {
                Rectangle rect = GetColumnBounds(view, item);
                if (rect.IsEmpty) continue;
                string text = item.GetDisplayText(values[item], false);
                rect = CalcSummaryRect(text, e, view.Columns[item.FieldName]);
                e.Appearance.DrawString(e.Cache, text, rect);
            }
        }

        private Rectangle GetColumnBounds(GridView view, GridGroupSummaryItem item) {
            GridColumn column = view.Columns[item.FieldName];
            return GetColumnBounds(column);
        }

        private Rectangle GetColumnBounds(GridColumn column) {
            GridViewInfo gridInfo = (GridViewInfo)column.View.GetViewInfo();
            GridColumnInfoArgs colInfo = gridInfo.ColumnsInfo[column];

            if (colInfo != null)
                return colInfo.Bounds;
            else
                return Rectangle.Empty;
        }

        private Rectangle CalcSummaryRect(string text, RowObjectCustomDrawEventArgs e, GridColumn column) {
            SizeF sz = TextUtils.GetStringSize(e.Graphics, text, e.Appearance.Font);
            int width = Convert.ToInt32(sz.Width) + 1;
            Rectangle result = GetColumnBounds(column);
            result = FixLeftEdge(width, result);
            result.Width = result.Width;
            result.Y = e.Bounds.Y;
            result.Height = e.Bounds.Height - 2;
            return PreventSummaryTextOverlapping(e, result);
        }

        private Rectangle FixLeftEdge(int width, Rectangle result) {
            int delta = result.Width - width - 2;
            if (delta > 0) {
                result.X += delta;
                result.Width -= delta;
            }
            return result;
        }

        private Rectangle PreventSummaryTextOverlapping(RowObjectCustomDrawEventArgs e, Rectangle rect) {
            GridGroupRowInfo gInfo = (GridGroupRowInfo)e.Info;
            int groupTextLocation = gInfo.ButtonBounds.Right + 10;
            int groupTextWidth = TextUtils.GetStringSize(e.Graphics, gInfo.GroupText, e.Appearance.Font).Width;
            Rectangle r = new Rectangle(groupTextLocation, 0, groupTextWidth, e.Info.Bounds.Height);
            if (r.Right > rect.X) {
                if (r.Right > rect.Right)
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
