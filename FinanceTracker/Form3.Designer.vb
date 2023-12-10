<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransactionForm
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
        txtAmount = New TextBox()
        submitBtn = New Button()
        Label3 = New Label()
        txtCategory = New TextBox()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(199, 124)
        Label1.Name = "Label1"
        Label1.Size = New Size(185, 25)
        Label1.TabIndex = 0
        Label1.Text = "Transaction Update"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(199, 214)
        Label2.Name = "Label2"
        Label2.Size = New Size(73, 21)
        Label2.TabIndex = 3
        Label2.Text = "Amount:"
        ' 
        ' txtAmount
        ' 
        txtAmount.Location = New Point(284, 214)
        txtAmount.Name = "txtAmount"
        txtAmount.Size = New Size(100, 23)
        txtAmount.TabIndex = 4
        ' 
        ' submitBtn
        ' 
        submitBtn.Location = New Point(202, 303)
        submitBtn.Name = "submitBtn"
        submitBtn.Size = New Size(182, 23)
        submitBtn.TabIndex = 5
        submitBtn.Text = "Add Transaction"
        submitBtn.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Location = New Point(149, 159)
        Label3.Name = "Label3"
        Label3.Size = New Size(303, 45)
        Label3.TabIndex = 6
        Label3.Text = "Please specify Deposits as normal (as a positive number)" & vbCrLf & "and Withdrawals as negative numbers (-10.00)." & vbCrLf & vbCrLf
        Label3.TextAlign = ContentAlignment.TopCenter
        ' 
        ' txtCategory
        ' 
        txtCategory.Location = New Point(284, 254)
        txtCategory.Name = "txtCategory"
        txtCategory.Size = New Size(100, 23)
        txtCategory.TabIndex = 8
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(199, 254)
        Label4.Name = "Label4"
        Label4.Size = New Size(82, 21)
        Label4.TabIndex = 7
        Label4.Text = "Category:"
        ' 
        ' TransactionForm
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(594, 493)
        Controls.Add(txtCategory)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(submitBtn)
        Controls.Add(txtAmount)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "TransactionForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Transaction Update"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtAmount As TextBox
    Friend WithEvents submitBtn As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCategory As TextBox
    Friend WithEvents Label4 As Label
End Class
