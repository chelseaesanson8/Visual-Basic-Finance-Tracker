<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class UserDashboard
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
        components = New ComponentModel.Container()
        welcome = New Label()
        Timer1 = New Timer(components)
        Label2 = New Label()
        Label1 = New Label()
        ListBox1 = New ListBox()
        addWithdrawl = New Button()
        Button1 = New Button()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        Label3 = New Label()
        ListBox2 = New ListBox()
        Button2 = New Button()
        Button3 = New Button()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' welcome
        ' 
        welcome.AutoSize = True
        welcome.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        welcome.Location = New Point(313, 9)
        welcome.Name = "welcome"
        welcome.Size = New Size(109, 30)
        welcome.TabIndex = 0
        welcome.Text = "Welcome,"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label2.Location = New Point(414, 9)
        Label2.Name = "Label2"
        Label2.Size = New Size(77, 30)
        Label2.TabIndex = 1
        Label2.Text = "Label2"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label1.Location = New Point(91, 135)
        Label1.Name = "Label1"
        Label1.Size = New Size(206, 30)
        Label1.TabIndex = 2
        Label1.Text = "Recent Transactions"
        ' 
        ' ListBox1
        ' 
        ListBox1.FormattingEnabled = True
        ListBox1.ItemHeight = 15
        ListBox1.Location = New Point(93, 184)
        ListBox1.Name = "ListBox1"
        ListBox1.Size = New Size(206, 304)
        ListBox1.TabIndex = 3
        ' 
        ' addWithdrawl
        ' 
        addWithdrawl.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        addWithdrawl.Location = New Point(327, 184)
        addWithdrawl.Name = "addWithdrawl"
        addWithdrawl.Size = New Size(139, 23)
        addWithdrawl.TabIndex = 5
        addWithdrawl.Text = "Add Widthdrawl"
        addWithdrawl.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button1.Location = New Point(327, 222)
        Button1.Name = "Button1"
        Button1.Size = New Size(139, 23)
        Button1.TabIndex = 6
        Button1.Text = "Add Deposit"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label3.Location = New Point(508, 135)
        Label3.Name = "Label3"
        Label3.Size = New Size(173, 30)
        Label3.TabIndex = 7
        Label3.Text = "Current Budgets"
        ' 
        ' ListBox2
        ' 
        ListBox2.FormattingEnabled = True
        ListBox2.ItemHeight = 15
        ListBox2.Location = New Point(491, 184)
        ListBox2.Name = "ListBox2"
        ListBox2.Size = New Size(206, 304)
        ListBox2.TabIndex = 8
        ' 
        ' Button2
        ' 
        Button2.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button2.Location = New Point(527, 494)
        Button2.Name = "Button2"
        Button2.Size = New Size(139, 23)
        Button2.TabIndex = 9
        Button2.Text = "Create A New Budget"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        Button3.Location = New Point(12, 9)
        Button3.Name = "Button3"
        Button3.Size = New Size(139, 23)
        Button3.TabIndex = 10
        Button3.Text = "Logout"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(152, 68)
        Label4.Name = "Label4"
        Label4.Size = New Size(180, 30)
        Label4.TabIndex = 11
        Label4.Text = "Current Balance: "
        ' 
        ' UserDashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 532)
        Controls.Add(Label4)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(ListBox2)
        Controls.Add(Label3)
        Controls.Add(Button1)
        Controls.Add(addWithdrawl)
        Controls.Add(ListBox1)
        Controls.Add(Label1)
        Controls.Add(Label2)
        Controls.Add(welcome)
        Name = "UserDashboard"
        Text = "User Dashboard"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents welcome As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents addWithdrawl As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label3 As Label
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label4 As Label
End Class
