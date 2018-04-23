Imports Microsoft.VisualBasic
Imports System
Imports System.Globalization
Imports System.Windows.Forms
Imports DevExpress.XtraPivotGrid

Namespace XtraPivotGrid_HidingColumnsAndRows
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
            AddHandler pivotGridControl1.CustomFieldValueCells, _
                AddressOf pivotGrid_CustomFieldValueCells
		End Sub
		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			PivotHelper.FillPivot(pivotGridControl1)
			pivotGridControl1.DataSource = PivotHelper.GetDataTable()
			pivotGridControl1.BestFit()
		End Sub

		' Handles the CustomFieldValueCells event to remove
		' specific rows.
        Protected Sub pivotGrid_CustomFieldValueCells(ByVal sender As Object, _
                                                      ByVal e As PivotCustomFieldValueCellsEventArgs)
            If pivotGridControl1.DataSource Is Nothing Then
                Return
            End If
            If radioGroup1.SelectedIndex = 0 Then
                Return
            End If

            ' Iterates through all row headers.
            For i As Integer = e.GetCellCount(False) - 1 To 0 Step -1
                Dim cell As FieldValueCell = e.GetCell(False, i)
                If cell Is Nothing Then Continue For

                ' If the current header corresponds to the "Employee B"
                ' field value, and is not the Total Row header,
                ' it is removed with all corresponding rows.
                If Object.Equals(cell.Value, "Employee B") AndAlso _
                        cell.ValueType <> PivotGridValueType.Total Then
                    e.Remove(cell)
                End If
            Next i
        End Sub
        Private Sub pivotGridControl1_FieldValueDisplayText(ByVal sender As Object, _
                                                    ByVal e As PivotFieldDisplayTextEventArgs) _
                                                    Handles pivotGridControl1.FieldValueDisplayText
            If Object.Equals(e.Field, pivotGridControl1.Fields(PivotHelper.Month)) Then
                e.DisplayText = _
                    CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName(CInt(Fix(e.Value)))
            End If
        End Sub
        Private Sub radioGroup1_SelectedIndexChanged(ByVal sender As Object, _
                                                     ByVal e As EventArgs) _
                                                     Handles radioGroup1.SelectedIndexChanged
            Me.pivotGridControl1.LayoutChanged()
            pivotGridControl1.BestFit()
        End Sub
	End Class
End Namespace