using System;
using System.Globalization;
using System.Windows.Forms;
using DevExpress.XtraPivotGrid;

namespace XtraPivotGrid_HidingColumnsAndRows {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
            pivotGridControl1.CustomFieldValueCells += 
                new PivotCustomFieldValueCellsEventHandler(pivotGrid_CustomFieldValueCells);
        }
        void Form1_Load(object sender, EventArgs e) {
            PivotHelper.FillPivot(pivotGridControl1);
            pivotGridControl1.DataSource = PivotHelper.GetDataTable();
            pivotGridControl1.BestFit();
        }

        // Handles the CustomFieldValueCells event to remove
        // specific rows.
        protected void pivotGrid_CustomFieldValueCells(object sender,
                             PivotCustomFieldValueCellsEventArgs e) {
            if (pivotGridControl1.DataSource == null) return;
            if (radioGroup1.SelectedIndex == 0) return;

            // Iterates through all row headers.
            for (int i = e.GetCellCount(false) - 1; i >= 0; i--) {
                FieldValueCell cell = e.GetCell(false, i);
                if (cell == null) continue;

                // If the current header corresponds to the "Employee B"
                // field value, and is not the Total Row header,
                // it is removed with all corresponding rows.
                if (object.Equals(cell.Value, "Employee B") &&
                    cell.ValueType != PivotGridValueType.Total)
                    e.Remove(cell);
            }
        }
        void pivotGridControl1_FieldValueDisplayText(object sender, 
                                    PivotFieldDisplayTextEventArgs e) {
            if(e.Field == pivotGridControl1.Fields[PivotHelper.Month]) {
                e.DisplayText = CultureInfo.CurrentCulture.DateTimeFormat.GetMonthName((int)e.Value);
            }
        }
        void radioGroup1_SelectedIndexChanged(object sender, EventArgs e) {
            this.pivotGridControl1.LayoutChanged();
            pivotGridControl1.BestFit();
        }        
    }
}