using System.Data;
using DevExpress.XtraPivotGrid;

namespace XtraPivotGrid_HidingColumnsAndRows {
    public static class PivotHelper {
        public const string Employee = "Employee";
        public const string Widget = "Widget";
        public const string Month = "Month";
        public const string RetailPrice = "Retail Price";
        public const string WholesalePrice = "Wholesale Price";
        public const string Quantity = "Quantity";
        public const string Remains = "Remains";

        public const string EmployeeA = "Employee A";
        public const string EmployeeB = "Employee B";
        public const string WidgetA = "Widget A";
        public const string WidgetB = "Widget B";
        public const string WidgetC = "Widget C";

        public static void FillPivot(PivotGridControl pivot) {
            pivot.Fields.AddDataSourceColumn(Employee, PivotArea.RowArea);
            pivot.Fields.AddDataSourceColumn(Widget, PivotArea.RowArea);
            pivot.Fields.AddDataSourceColumn(Month, PivotArea.ColumnArea).AreaIndex = 0;
            pivot.Fields.AddDataSourceColumn(RetailPrice, PivotArea.DataArea);
            pivot.Fields.AddDataSourceColumn(WholesalePrice, PivotArea.DataArea);
            pivot.Fields.AddDataSourceColumn(Quantity, PivotArea.DataArea);
            pivot.Fields.AddDataSourceColumn(Remains, PivotArea.DataArea);
            foreach (PivotGridField field in pivot.Fields) {
                field.AllowedAreas = GetAllowedArea(field.Area);
            }
            pivot.OptionsView.RowTotalsLocation = PivotRowTotalsLocation.Near;
            pivot.OptionsView.ShowRowGrandTotals = false;
            pivot.OptionsView.ColumnTotalsLocation = PivotTotalsLocation.Far;
            pivot.OptionsDataField.Area = PivotDataArea.ColumnArea;
            pivot.OptionsDataField.AreaIndex = 1;
        }
        static PivotGridAllowedAreas GetAllowedArea(PivotArea area) {
            switch (area) {
                case PivotArea.ColumnArea:
                    return PivotGridAllowedAreas.ColumnArea;
                case PivotArea.RowArea:
                    return PivotGridAllowedAreas.RowArea;
                case PivotArea.DataArea:
                    return PivotGridAllowedAreas.DataArea;
                case PivotArea.FilterArea:
                    return PivotGridAllowedAreas.FilterArea;
                default:
                    return PivotGridAllowedAreas.All;
            }
        }
        public static DataTable GetDataTable() {
            DataTable table = new DataTable();
            table.Columns.Add(Employee, typeof(string));
            table.Columns.Add(Widget, typeof(string));
            table.Columns.Add(Month, typeof(int));
            table.Columns.Add(RetailPrice, typeof(double));
            table.Columns.Add(WholesalePrice, typeof(double));
            table.Columns.Add(Quantity, typeof(int));
            table.Columns.Add(Remains, typeof(int));
            table.Rows.Add(EmployeeA, WidgetA, 6, 45.6, 40, 3, 0);
            table.Rows.Add(EmployeeA, WidgetA, 7, 38.9, 30, 6, 1);
            table.Rows.Add(EmployeeA, WidgetB, 6, 24.7, 20, 7, 0);
            table.Rows.Add(EmployeeA, WidgetB, 7, 8.3, 7.5, 5, 1);
            table.Rows.Add(EmployeeA, WidgetC, 6, 10.0, 9, 4, 0);
            table.Rows.Add(EmployeeA, WidgetC, 7, 20.0, 18.5, 5, 1);
            table.Rows.Add(EmployeeB, WidgetA, 6, 77.8, 70, 2, 0);
            table.Rows.Add(EmployeeB, WidgetA, 7, 32.5, 30, 1, 1);
            table.Rows.Add(EmployeeB, WidgetB, 6, 12, 11, 10, 0);
            table.Rows.Add(EmployeeB, WidgetB, 7, 6.7, 5.5, 4, 1);
            table.Rows.Add(EmployeeB, WidgetC, 6, 30.0, 28.7, 6, 0);
            table.Rows.Add(EmployeeB, WidgetC, 7, 40.0, 38.3, 7, 1);
            return table;
        }
    }

}
