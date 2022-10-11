<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2769)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Data.cs](./CS/Data.cs) (VB: [Data.vb](./VB/Data.vb))
* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))
* [Program.cs](./CS/Program.cs) (VB: [Program.vb](./VB/Program.vb))
<!-- default file list end -->
# How to hide particular rows and columns


<p>The following example demonstrates how to hide particular rows and columns by handling the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraPivotGridPivotGridControl_CustomFieldValueCellstopic">CustomFieldValueCells </a>event.</p>
<p>In this example, the event handler iterates through all row headers and removes rows that correspond to the "Employee B" field value, and that are not Total Rows.</p>

<br/>


