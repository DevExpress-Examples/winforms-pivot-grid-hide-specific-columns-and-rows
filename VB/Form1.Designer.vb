Namespace XtraPivotGrid_HidingColumnsAndRows
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.radioGroup1 = New DevExpress.XtraEditors.RadioGroup()
            Me.pivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
            DirectCast(Me.radioGroup1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
            DirectCast(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' radioGroup1
            ' 
            Me.radioGroup1.Anchor = (CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
            Me.radioGroup1.Location = New System.Drawing.Point(13, 12)
            Me.radioGroup1.Name = "radioGroup1"
            Me.radioGroup1.Properties.Columns = 1
            Me.radioGroup1.Properties.Items.AddRange(New DevExpress.XtraEditors.Controls.RadioGroupItem() { _
                New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Default Layout"), _
                New DevExpress.XtraEditors.Controls.RadioGroupItem(Nothing, "Delete All Rows Corresponding to ""Employee B"" except for the Total Row") _
            })
            Me.radioGroup1.Size = New System.Drawing.Size(919, 48)
            Me.radioGroup1.TabIndex = 6
            ' 
            ' pivotGridControl1
            ' 
            Me.pivotGridControl1.Anchor = (CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) Or System.Windows.Forms.AnchorStyles.Left) Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
            Me.pivotGridControl1.Location = New System.Drawing.Point(13, 66)
            Me.pivotGridControl1.Name = "pivotGridControl1"
            Me.pivotGridControl1.OptionsCustomization.AllowDrag = False
            Me.pivotGridControl1.OptionsCustomization.AllowFilter = False
            Me.pivotGridControl1.Size = New System.Drawing.Size(919, 320)
            Me.pivotGridControl1.TabIndex = 0
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(944, 398)
            Me.Controls.Add(Me.radioGroup1)
            Me.Controls.Add(Me.pivotGridControl1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            DirectCast(Me.radioGroup1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
            DirectCast(Me.pivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private WithEvents pivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
        Private WithEvents radioGroup1 As DevExpress.XtraEditors.RadioGroup
    End Class
End Namespace

