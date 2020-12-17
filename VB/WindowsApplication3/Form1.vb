Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraBars
Imports DevExpress.XtraGrid.Views.Grid.ViewInfo
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.Utils.Drawing
Imports DevExpress.Utils
Imports DevExpress.XtraVerticalGrid
Imports System.Reflection
Imports DevExpress.XtraVerticalGrid.Painters
Imports System.Collections
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Drawing
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.Utils.Text

Namespace WindowsApplication3
	Partial Public Class Form1
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub
		Public Sub InitData()
			For i As Integer = 0 To 4
				If i Mod 2 = 0 Then
					dataSet11.Tables(0).Rows.Add(New Object() { i, i * 10, 0, i+100, i+10, i*100})
				Else
					dataSet11.Tables(0).Rows.Add(New Object() { i, i, 1, i, i, i })
				End If
			Next i
		End Sub



		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles Me.Load
			Me.InitData()
			gridControl1.ForceInitialize()
			gridView1.OptionsView.ShowFooter = True
			gridView1.OptionsBehavior.AlignGroupSummaryInGroupRow = DefaultBoolean.True
			For i As Integer = 1 To 6
				Dim item As New GridGroupSummaryItem()
				item.FieldName = "Column" & i.ToString()
				item.SummaryType = DevExpress.Data.SummaryItemType.Sum
				item.DisplayFormat = "Sum {0:n0}"
				item.ShowInGroupColumnFooter = gridView1.Columns(item.FieldName)
				gridView1.GroupSummary.Add(item)
			Next i
			gridView1.BeginSort()
			Try
				gridView1.ClearGrouping()
				gridView1.Columns("Column3").GroupIndex = 0
			Finally
				gridView1.EndSort()
			End Try
		End Sub
	End Class
End Namespace
