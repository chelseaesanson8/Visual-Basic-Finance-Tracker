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
        usernameLbl = New Label()
        Label1 = New Label()
        transactionsLst = New ListBox()
        addWithdrawalBtn = New Button()
        addDepositBtn = New Button()
        BackgroundWorker1 = New ComponentModel.BackgroundWorker()
        Label3 = New Label()
        budgetsLst = New ListBox()
        addBudgetBtn = New Button()
        logoutBtn = New Button()
        Label4 = New Label()
        lblCurrentBalance = New Label()
        SuspendLayout()
        ' 
        ' welcome
        ' 
        welcome.AutoSize = True
        welcome.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        welcome.Location = New Point(274, 9)
        welcome.Name = "welcome"
        welcome.Size = New Size(109, 30)
        welcome.TabIndex = 0
        welcome.Text = "Welcome,"
        ' 
        ' usernameLbl
        ' 
        usernameLbl.AutoSize = True
        usernameLbl.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        usernameLbl.Location = New Point(375, 9)
        usernameLbl.Name = "usernameLbl"
        usernameLbl.Size = New Size(0, 30)
        usernameLbl.TabIndex = 1
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
        ' transactionsLst
        ' 
        transactionsLst.FormattingEnabled = True
        transactionsLst.ItemHeight = 15
        transactionsLst.Location = New Point(93, 184)
        transactionsLst.Name = "transactionsLst"
        transactionsLst.Size = New Size(206, 304)
        transactionsLst.TabIndex = 3
        ' 
        ' addWithdrawalBtn
        ' 
        addWithdrawalBtn.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        addWithdrawalBtn.Location = New Point(327, 184)
        addWithdrawalBtn.Name = "addWithdrawalBtn"
        addWithdrawalBtn.Size = New Size(139, 23)
        addWithdrawalBtn.TabIndex = 5
        addWithdrawalBtn.Text = "Add Withdrawal"
        addWithdrawalBtn.UseVisualStyleBackColor = True
        ' 
        ' addDepositBtn
        ' 
        addDepositBtn.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        addDepositBtn.Location = New Point(327, 222)
        addDepositBtn.Name = "addDepositBtn"
        addDepositBtn.Size = New Size(139, 23)
        addDepositBtn.TabIndex = 6
        addDepositBtn.Text = "Add Deposit"
        addDepositBtn.UseVisualStyleBackColor = True
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
        ' budgetsLst
        ' 
        budgetsLst.FormattingEnabled = True
        budgetsLst.ItemHeight = 15
        budgetsLst.Location = New Point(491, 184)
        budgetsLst.Name = "budgetsLst"
        budgetsLst.Size = New Size(206, 304)
        budgetsLst.TabIndex = 8
        ' 
        ' addBudgetBtn
        ' 
        addBudgetBtn.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        addBudgetBtn.Location = New Point(327, 262)
        addBudgetBtn.Name = "addBudgetBtn"
        addBudgetBtn.Size = New Size(139, 23)
        addBudgetBtn.TabIndex = 9
        addBudgetBtn.Text = "Create A New Budget"
        addBudgetBtn.UseVisualStyleBackColor = True
        ' 
        ' logoutBtn
        ' 
        logoutBtn.Font = New Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point)
        logoutBtn.Location = New Point(12, 9)
        logoutBtn.Name = "logoutBtn"
        logoutBtn.Size = New Size(139, 23)
        logoutBtn.TabIndex = 10
        logoutBtn.Text = "Logout"
        logoutBtn.UseVisualStyleBackColor = True
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        Label4.Location = New Point(152, 68)
        Label4.Name = "Label4"
        Label4.Size = New Size(0, 30)
        Label4.TabIndex = 11
        ' 
        ' lblCurrentBalance
        ' 
        lblCurrentBalance.AutoSize = True
        lblCurrentBalance.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point)
        lblCurrentBalance.Location = New Point(248, 68)
        lblCurrentBalance.Name = "lblCurrentBalance"
        lblCurrentBalance.Size = New Size(0, 30)
        lblCurrentBalance.TabIndex = 12
        ' 
        ' UserDashboard
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(809, 676)
        Controls.Add(lblCurrentBalance)
        Controls.Add(Label4)
        Controls.Add(logoutBtn)
        Controls.Add(addBudgetBtn)
        Controls.Add(budgetsLst)
        Controls.Add(Label3)
        Controls.Add(addDepositBtn)
        Controls.Add(addWithdrawalBtn)
        Controls.Add(transactionsLst)
        Controls.Add(Label1)
        Controls.Add(usernameLbl)
        Controls.Add(welcome)
        Name = "UserDashboard"
        StartPosition = FormStartPosition.CenterScreen
        Text = "User Dashboard"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents welcome As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents usernameLbl As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents transactionsLst As ListBox
    Friend WithEvents addWithdrawalBtn As Button
    Friend WithEvents addDepositBtn As Button
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label3 As Label
    Friend WithEvents ListBox2 As ListBox
    Friend WithEvents Button2 As Button
    Friend WithEvents logoutBtn As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents lblCurrentBalance As Label
    Friend WithEvents budgetsLst As ListBox
    Friend WithEvents addBudgetBtn As Button
End Class
