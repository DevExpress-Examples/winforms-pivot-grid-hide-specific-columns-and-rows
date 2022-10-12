<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2769)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# Pivot Grid for WinForms - How to Hide Specific Rows and Columns

The following example demonstrates how handle the [CustomFieldValueCells](https://docs.devexpress.com/WindowsForms/DevExpress.XtraPivotGrid.PivotGridControl.CustomFieldValueCells) event to hide specific rows and columns. In this example, the event handler iterates through all row headers and removes rows that correspond to the "Employee B" field value, and that are not Total Rows.

![Pivot Grid](images/pivotgrid.png)

## Files to Review

* [Data.cs](./CS/Data.cs) (VB: [Data.vb](./VB/Data.vb))
* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
* [Program.cs](./CS/Program.cs) (VB: [Program.vb](./VB/Program.vb))

## More Examples 

- [Pivot Grid for WinForms - How to Hide Empty Field Values (Columns/Rows)](https://github.com/DevExpress-Examples/how-to-hide-empty-field-values-columns-rows-e2807)
