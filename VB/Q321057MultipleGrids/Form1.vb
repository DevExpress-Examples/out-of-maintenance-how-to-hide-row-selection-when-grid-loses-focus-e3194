Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Linq
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.XtraGrid.Views.Grid

Namespace Q321057MultipleGrids
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			gridControl1.DataSource = FillDataTable()
			gridControl2.DataSource = FillDataTable()
		End Sub

		Public Shared Function FillDataTable() As DataTable
			Dim _dataTable As New DataTable()
			_dataTable.Columns.Add(New DataColumn("ID", GetType(Integer)))
			_dataTable.Columns.Add(New DataColumn("Name", GetType(String)))
			_dataTable.Rows.Add(New Object() { 1, "Apple" })
			_dataTable.Rows.Add(New Object() { 2, "Peach" })
			_dataTable.Rows.Add(New Object() { 3, "Banana" })
			Return _dataTable
		End Function
	End Class
End Namespace
