Imports Microsoft.VisualBasic
Imports System
Imports System.Drawing
Imports System.Collections
Imports System.ComponentModel
Imports System.Windows.Forms
Imports System.Data
Imports DevExpress.Data
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Drawing
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.Utils.Text

Namespace AlignSummaries
	''' <summary>
	''' Summary description for Form1.
	''' </summary>
	Public Class Form1
		Inherits System.Windows.Forms.Form
		Private gridControl1 As DevExpress.XtraGrid.GridControl
		Private WithEvents gridView1 As DevExpress.XtraGrid.Views.Grid.GridView
		Private dataSet1 As System.Data.DataSet
		Private dataTable1 As System.Data.DataTable
		Private dataColumn1 As System.Data.DataColumn
		Private dataColumn2 As System.Data.DataColumn
		Private dataColumn3 As System.Data.DataColumn
		Private colName As DevExpress.XtraGrid.Columns.GridColumn
		Private colCity As DevExpress.XtraGrid.Columns.GridColumn
		Private colAge As DevExpress.XtraGrid.Columns.GridColumn
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.Container = Nothing

		Public Sub New()
			'
			' Required for Windows Form Designer support
			'
			InitializeComponent()

			'
			' TODO: Add any constructor code after InitializeComponent call
			'
		End Sub

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		Protected Overrides Overloads Sub Dispose(ByVal disposing As Boolean)
			If disposing Then
				If components IsNot Nothing Then
					components.Dispose()
				End If
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"
		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
			Me.dataTable1 = New System.Data.DataTable()
			Me.dataColumn1 = New System.Data.DataColumn()
			Me.dataColumn2 = New System.Data.DataColumn()
			Me.dataColumn3 = New System.Data.DataColumn()
			Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
			Me.colName = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colCity = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.colAge = New DevExpress.XtraGrid.Columns.GridColumn()
			Me.dataSet1 = New System.Data.DataSet()
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataTable1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).BeginInit()
			CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
			Me.SuspendLayout()
			' 
			' gridControl1
			' 
			Me.gridControl1.DataSource = Me.dataTable1
			Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
			Me.gridControl1.Location = New System.Drawing.Point(0, 0)
			Me.gridControl1.MainView = Me.gridView1
			Me.gridControl1.Name = "gridControl1"
			Me.gridControl1.Size = New System.Drawing.Size(464, 306)
			Me.gridControl1.TabIndex = 0
			Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() { Me.gridView1})
			' 
			' dataTable1
			' 
			Me.dataTable1.Columns.AddRange(New System.Data.DataColumn() { Me.dataColumn1, Me.dataColumn2, Me.dataColumn3})
			Me.dataTable1.TableName = "Table1"
			' 
			' dataColumn1
			' 
			Me.dataColumn1.ColumnName = "Name"
			' 
			' dataColumn2
			' 
			Me.dataColumn2.ColumnName = "City"
			' 
			' dataColumn3
			' 
			Me.dataColumn3.ColumnName = "Age"
			Me.dataColumn3.DataType = GetType(Integer)
			' 
			' gridView1
			' 
			Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() { Me.colName, Me.colCity, Me.colAge})
			Me.gridView1.GridControl = Me.gridControl1
			Me.gridView1.GroupSummary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() { New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Count, "Name", Nothing, "Count = {0}"), New DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Average, "Age", Nothing, "Average = {0}")})
			Me.gridView1.Name = "gridView1"
'			Me.gridView1.CustomDrawGroupRow += New DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventHandler(Me.gridView1_CustomDrawGroupRow);
			' 
			' colName
			' 
			Me.colName.Caption = "Name"
			Me.colName.FieldName = "Name"
			Me.colName.Name = "colName"
			Me.colName.Visible = True
			Me.colName.VisibleIndex = 0
			' 
			' colCity
			' 
			Me.colCity.Caption = "City"
			Me.colCity.FieldName = "City"
			Me.colCity.Name = "colCity"
			Me.colCity.Visible = True
			Me.colCity.VisibleIndex = 1
			' 
			' colAge
			' 
			Me.colAge.Caption = "Age"
			Me.colAge.FieldName = "Age"
			Me.colAge.Name = "colAge"
			Me.colAge.Visible = True
			Me.colAge.VisibleIndex = 2
			' 
			' dataSet1
			' 
			Me.dataSet1.DataSetName = "NewDataSet"
			Me.dataSet1.Locale = New System.Globalization.CultureInfo("en-US")
			Me.dataSet1.Tables.AddRange(New System.Data.DataTable() { Me.dataTable1})
			' 
			' Form1
			' 
			Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
			Me.ClientSize = New System.Drawing.Size(464, 306)
			Me.Controls.Add(Me.gridControl1)
			Me.Name = "Form1"
			Me.Text = "Form1"
'			Me.Load += New System.EventHandler(Me.Form1_Load);
			CType(Me.gridControl1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataTable1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.gridView1, System.ComponentModel.ISupportInitialize).EndInit()
			CType(Me.dataSet1, System.ComponentModel.ISupportInitialize).EndInit()
			Me.ResumeLayout(False)

		End Sub
		#End Region

		''' <summary>
		''' The main entry point for the application.
		''' </summary>
		<STAThread> _
		Shared Sub Main()
			Application.Run(New Form1())
		End Sub

		Private Sub FillTable()
			dataTable1.Rows.Add(New Object() { "Ann", "Washington", 30 })
			dataTable1.Rows.Add(New Object() { "Bill", "New York", 40 })
			dataTable1.Rows.Add(New Object() { "Clive", "New York", 50 })
			dataTable1.AcceptChanges()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
			FillTable()
			gridView1.Columns("City").GroupIndex = 0
		End Sub

		Private Sub gridView1_CustomDrawGroupRow(ByVal sender As Object, ByVal e As DevExpress.XtraGrid.Views.Base.RowObjectCustomDrawEventArgs) Handles gridView1.CustomDrawGroupRow
			Dim view As GridView = TryCast(sender, GridView)
			Dim items As ArrayList = ExtractSummaryItems(view)
			If items.Count = 0 Then
				Return
			End If
			DrawBackground(e, view)
			DrawSummaryValues(e, view, items)
			e.Handled = True
		End Sub

		Private Function ExtractSummaryItems(ByVal view As GridView) As ArrayList
			Dim items As New ArrayList()
			For Each si As GridSummaryItem In view.GroupSummary
				If TypeOf si Is GridGroupSummaryItem AndAlso si.SummaryType <> SummaryItemType.None Then
					items.Add(si)
				End If
			Next si
			Return items
		End Function

		Private Sub DrawBackground(ByVal e As RowObjectCustomDrawEventArgs, ByVal view As GridView)
			Dim painter As GridGroupRowPainter
			Dim info As GridGroupRowInfo
			painter = TryCast(e.Painter, GridGroupRowPainter)
			info = TryCast(e.Info, GridGroupRowInfo)
			Dim level As Integer = view.GetRowLevel(e.RowHandle)
			Dim row As Integer = view.GetDataRowHandleByGroupRowHandle(e.RowHandle)
			info.GroupText = String.Format("{0}: {1}", view.GroupedColumns(level).Caption, view.GetRowCellDisplayText(row, view.GroupedColumns(level)))
			e.Appearance.DrawBackground(e.Cache, info.Bounds)
			painter.ElementsPainter.GroupRow.DrawObject(info)
		End Sub

		Private Sub DrawSummaryValues(ByVal e As RowObjectCustomDrawEventArgs, ByVal view As GridView, ByVal items As ArrayList)
			Dim values As Hashtable = view.GetGroupSummaryValues(e.RowHandle)
			For Each item As GridGroupSummaryItem In items
				Dim rect As Rectangle = GetColumnBounds(view, item)
				If rect.IsEmpty Then
					Continue For
				End If
				Dim text As String = item.GetDisplayText(values(item), False)
				rect = CalcSummaryRect(text, e, view.Columns(item.FieldName))
				e.Appearance.DrawString(e.Cache, text, rect)
			Next item
		End Sub

		Private Function GetColumnBounds(ByVal view As GridView, ByVal item As GridGroupSummaryItem) As Rectangle
			Dim column As GridColumn = view.Columns(item.FieldName)
			Return GetColumnBounds(column)
		End Function

		Private Function GetColumnBounds(ByVal column As GridColumn) As Rectangle
			Dim gridInfo As GridViewInfo = CType(column.View.GetViewInfo(), GridViewInfo)
			Dim colInfo As GridColumnInfoArgs = gridInfo.ColumnsInfo(column)

			If colInfo IsNot Nothing Then
				Return colInfo.Bounds
			Else
				Return Rectangle.Empty
			End If
		End Function

		Private Function CalcSummaryRect(ByVal text As String, ByVal e As RowObjectCustomDrawEventArgs, ByVal column As GridColumn) As Rectangle
			Dim sz As SizeF = TextUtils.GetStringSize(e.Graphics, text, e.Appearance.Font)
			Dim width As Integer = Convert.ToInt32(sz.Width) + 1
			Dim result As Rectangle = GetColumnBounds(column)
			result = FixLeftEdge(width, result)
			result.Width = result.Width
			result.Y = e.Bounds.Y
			result.Height = e.Bounds.Height - 2
			Return PreventSummaryTextOverlapping(e, result)
		End Function

		Private Function FixLeftEdge(ByVal width As Integer, ByVal result As Rectangle) As Rectangle
			Dim delta As Integer = result.Width - width - 2
			If delta > 0 Then
				result.X += delta
				result.Width -= delta
			End If
			Return result
		End Function

		Private Function PreventSummaryTextOverlapping(ByVal e As RowObjectCustomDrawEventArgs, ByVal rect As Rectangle) As Rectangle
			Dim gInfo As GridGroupRowInfo = CType(e.Info, GridGroupRowInfo)
			Dim groupTextLocation As Integer = gInfo.ButtonBounds.Right + 10
			Dim groupTextWidth As Integer = TextUtils.GetStringSize(e.Graphics, gInfo.GroupText, e.Appearance.Font).Width
			Dim r As New Rectangle(groupTextLocation, 0, groupTextWidth, e.Info.Bounds.Height)
			If r.Right > rect.X Then
				If r.Right > rect.Right Then
					rect.Width = 0
				Else
					rect.Width -= r.Right - rect.X
					rect.X = r.Right
				End If
			End If
			Return rect
		End Function
	End Class
End Namespace
