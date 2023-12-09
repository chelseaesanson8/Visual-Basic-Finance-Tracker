<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BudgetForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Label1 = New Label()
        Label2 = New Label()
        txtCategory = New TextBox()
        txtBudgetAmount = New TextBox()
        Label3 = New Label()
        submitBudgetBtn = New Button()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(163, 108)
        Label1.Name = "Label1"
        Label1.Size = New Size(119, 25)
        Label1.TabIndex = 0
        Label1.Text = "Add Budget"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(117, 158)
        Label2.Name = "Label2"
        Label2.Size = New Size(86, 21)
        Label2.TabIndex = 1
        Label2.Text = "Category: "
        ' 
        ' txtCategory
        ' 
        txtCategory.Location = New Point(225, 158)
        txtCategory.Name = "txtCategory"
        txtCategory.Size = New Size(100, 23)
        txtCategory.TabIndex = 2
        ' 
        ' txtBudgetAmount
        ' 
        txtBudgetAmount.Location = New Point(225, 203)
        txtBudgetAmount.Name = "txtBudgetAmount"
        txtBudgetAmount.Size = New Size(100, 23)
        txtBudgetAmount.TabIndex = 4
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(117, 203)
        Label3.Name = "Label3"
        Label3.Size = New Size(73, 21)
        Label3.TabIndex = 3
        Label3.Text = "Amount:"
        ' 
        ' submitBudgetBtn
        ' 
        submitBudgetBtn.Location = New Point(163, 258)
        submitBudgetBtn.Name = "submitBudgetBtn"
        submitBudgetBtn.Size = New Size(115, 23)
        submitBudgetBtn.TabIndex = 5
        submitBudgetBtn.Text = "Add Budget"
        submitBudgetBtn.UseVisualStyleBackColor = True
        ' 
        ' BudgetForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(457, 450)
        Controls.Add(submitBudgetBtn)
        Controls.Add(txtBudgetAmount)
        Controls.Add(Label3)
        Controls.Add(txtCategory)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Name = "BudgetForm"
        Text = "Form4"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCategory As TextBox
    Friend WithEvents txtBudgetAmount As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents submitBudgetBtn As Button
End Class
