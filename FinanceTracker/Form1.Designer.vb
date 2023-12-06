<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtUsername = New TextBox()
        txtPassword = New TextBox()
        Label1 = New Label()
        Label2 = New Label()
        heading = New Label()
        loginBtn = New Button()
        SuspendLayout()
        ' 
        ' txtUsername
        ' 
        txtUsername.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtUsername.Location = New Point(390, 163)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(100, 22)
        txtUsername.TabIndex = 0
        ' 
        ' txtPassword
        ' 
        txtPassword.Font = New Font("Verdana", 9F, FontStyle.Regular, GraphicsUnit.Point)
        txtPassword.Location = New Point(390, 206)
        txtPassword.Name = "txtPassword"
        txtPassword.Size = New Size(100, 22)
        txtPassword.TabIndex = 1
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI Variable Display", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(285, 161)
        Label1.Name = "Label1"
        Label1.Size = New Size(90, 21)
        Label1.TabIndex = 2
        Label1.Text = "Username:"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI Variable Display", 12F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(285, 209)
        Label2.Name = "Label2"
        Label2.Size = New Size(85, 21)
        Label2.TabIndex = 3
        Label2.Text = "Password:"
        ' 
        ' heading
        ' 
        heading.AutoSize = True
        heading.Font = New Font("Segoe UI Variable Display Semib", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        heading.Location = New Point(317, 111)
        heading.Name = "heading"
        heading.Size = New Size(153, 28)
        heading.TabIndex = 4
        heading.Text = "FinanceTracker"
        ' 
        ' loginBtn
        ' 
        loginBtn.Location = New Point(354, 256)
        loginBtn.Name = "loginBtn"
        loginBtn.Size = New Size(75, 23)
        loginBtn.TabIndex = 5
        loginBtn.Text = "Login"
        loginBtn.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(loginBtn)
        Controls.Add(heading)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(txtPassword)
        Controls.Add(txtUsername)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtPassword As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents heading As Label
    Friend WithEvents loginBtn As Button
End Class
