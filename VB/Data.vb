Imports Microsoft.VisualBasic
Imports System.Data
Imports DevExpress.XtraPivotGrid

Namespace XtraPivotGrid_HidingColumnsAndRows
	Public NotInheritable Class PivotHelper
		Public Const Employee As String = "Employee"
		Public Const Widget As String = "Widget"
		Public Const Month As String = "Month"
		Public Const RetailPrice As String = "Retail Price"
		Public Const WholesalePrice As String = "Wholesale Price"
		Public Const Quantity As String = "Quantity"
		Public Const Remains As String = "Remains"

		Public Const EmployeeA As String = "Employee A"
		Public Const EmployeeB As String = "Employee B"
		Public Const WidgetA As String = "Widget A"
		Public Const WidgetB As String = "Widget B"
		Public Const WidgetC As String = "Widget C"

		Private Sub New()
		End Sub
		Public Shared Sub FillPivot(ByVal pivot As PivotGridControl)
			pivot.Fields.Add(Employee, PivotArea.RowArea)
			pivot.Fields.Add(Widget, PivotArea.RowArea)
			pivot.Fields.Add(Month, PivotArea.ColumnArea).AreaIndex = 0
			pivot.Fields.Add(RetailPrice, PivotArea.DataArea)
			pivot.Fields.Add(WholesalePrice, PivotArea.DataArea)
			pivot.Fields.Add(Quantity, PivotArea.DataArea)
			pivot.Fields.Add(Remains, PivotArea.DataArea)
			For Each field As PivotGridField In pivot.Fields
				field.AllowedAreas = GetAllowedArea(field.Area)
			Next field
			pivot.OptionsView.RowTotalsLocation = PivotRowTotalsLocation.Near
			pivot.OptionsView.ShowRowGrandTotals = False
			pivot.OptionsView.ColumnTotalsLocation = PivotTotalsLocation.Far
			pivot.OptionsDataField.Area = PivotDataArea.ColumnArea
			pivot.OptionsDataField.AreaIndex = 1
		End Sub
		Private Shared Function GetAllowedArea(ByVal area As PivotArea) As PivotGridAllowedAreas
			Select Case area
				Case PivotArea.ColumnArea
					Return PivotGridAllowedAreas.ColumnArea
				Case PivotArea.RowArea
					Return PivotGridAllowedAreas.RowArea
				Case PivotArea.DataArea
					Return PivotGridAllowedAreas.DataArea
				Case PivotArea.FilterArea
					Return PivotGridAllowedAreas.FilterArea
				Case Else
					Return PivotGridAllowedAreas.All
			End Select
		End Function
		Public Shared Function GetDataTable() As DataTable
			Dim table As New DataTable()
			table.Columns.Add(Employee, GetType(String))
			table.Columns.Add(Widget, GetType(String))
			table.Columns.Add(Month, GetType(Integer))
			table.Columns.Add(RetailPrice, GetType(Double))
			table.Columns.Add(WholesalePrice, GetType(Double))
			table.Columns.Add(Quantity, GetType(Integer))
			table.Columns.Add(Remains, GetType(Integer))
			table.Rows.Add(EmployeeA, WidgetA, 6, 45.6, 40, 3, 0)
			table.Rows.Add(EmployeeA, WidgetA, 7, 38.9, 30, 6, 1)
			table.Rows.Add(EmployeeA, WidgetB, 6, 24.7, 20, 7, 0)
			table.Rows.Add(EmployeeA, WidgetB, 7, 8.3, 7.5, 5, 1)
			table.Rows.Add(EmployeeA, WidgetC, 6, 10.0, 9, 4, 0)
			table.Rows.Add(EmployeeA, WidgetC, 7, 20.0, 18.5, 5, 1)
			table.Rows.Add(EmployeeB, WidgetA, 6, 77.8, 70, 2, 0)
			table.Rows.Add(EmployeeB, WidgetA, 7, 32.5, 30, 1, 1)
			table.Rows.Add(EmployeeB, WidgetB, 6, 12, 11, 10, 0)
			table.Rows.Add(EmployeeB, WidgetB, 7, 6.7, 5.5, 4, 1)
			table.Rows.Add(EmployeeB, WidgetC, 6, 30.0, 28.7, 6, 0)
			table.Rows.Add(EmployeeB, WidgetC, 7, 40.0, 38.3, 7, 1)
			Return table
		End Function
	End Class

End Namespace
