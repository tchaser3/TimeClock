<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnClose = New System.Windows.Forms.Button()
        Me.btnLogTime = New System.Windows.Forms.Button()
        Me.txtType = New System.Windows.Forms.TextBox()
        Me.txtActive = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtLogonLastName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.lblTestValue = New System.Windows.Forms.Label()
        Me.cboEmployeeID = New System.Windows.Forms.ComboBox()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.txtEmployeeID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboTransactionID = New System.Windows.Forms.ComboBox()
        Me.txtTransactionEmployeeID = New System.Windows.Forms.TextBox()
        Me.txtTransactionInOrOut = New System.Windows.Forms.TextBox()
        Me.txtTransactionTime = New System.Windows.Forms.TextBox()
        Me.rbtTimeIn = New System.Windows.Forms.RadioButton()
        Me.rbtTimeOut = New System.Windows.Forms.RadioButton()
        Me.SuspendLayout()
        '
        'btnClose
        '
        Me.btnClose.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnClose.Location = New System.Drawing.Point(344, 154)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(135, 59)
        Me.btnClose.TabIndex = 0
        Me.btnClose.Text = "Close"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'btnLogTime
        '
        Me.btnLogTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogTime.Location = New System.Drawing.Point(344, 81)
        Me.btnLogTime.Name = "btnLogTime"
        Me.btnLogTime.Size = New System.Drawing.Size(135, 59)
        Me.btnLogTime.TabIndex = 1
        Me.btnLogTime.Text = "Log Time"
        Me.btnLogTime.UseVisualStyleBackColor = True
        '
        'txtType
        '
        Me.txtType.AcceptsReturn = True
        Me.txtType.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtType.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtType.Location = New System.Drawing.Point(17, 306)
        Me.txtType.Margin = New System.Windows.Forms.Padding(2)
        Me.txtType.Name = "txtType"
        Me.txtType.Size = New System.Drawing.Size(106, 26)
        Me.txtType.TabIndex = 41
        Me.txtType.Visible = False
        '
        'txtActive
        '
        Me.txtActive.AcceptsReturn = True
        Me.txtActive.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtActive.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtActive.Location = New System.Drawing.Point(13, 246)
        Me.txtActive.Margin = New System.Windows.Forms.Padding(2)
        Me.txtActive.Name = "txtActive"
        Me.txtActive.Size = New System.Drawing.Size(106, 26)
        Me.txtActive.TabIndex = 39
        Me.txtActive.Visible = False
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(13, 114)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(137, 26)
        Me.Label3.TabIndex = 38
        Me.Label3.Text = "Last Name"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtLogonLastName
        '
        Me.txtLogonLastName.AcceptsReturn = True
        Me.txtLogonLastName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txtLogonLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLogonLastName.Location = New System.Drawing.Point(167, 115)
        Me.txtLogonLastName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtLogonLastName.Name = "txtLogonLastName"
        Me.txtLogonLastName.Size = New System.Drawing.Size(106, 26)
        Me.txtLogonLastName.TabIndex = 30
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(13, 65)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(137, 26)
        Me.Label2.TabIndex = 37
        Me.Label2.Text = "Employee ID"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblTestValue
        '
        Me.lblTestValue.Location = New System.Drawing.Point(27, 285)
        Me.lblTestValue.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblTestValue.Name = "lblTestValue"
        Me.lblTestValue.Size = New System.Drawing.Size(75, 19)
        Me.lblTestValue.TabIndex = 36
        Me.lblTestValue.Text = "Label2"
        Me.lblTestValue.Visible = False
        '
        'cboEmployeeID
        '
        Me.cboEmployeeID.FormattingEnabled = True
        Me.cboEmployeeID.Location = New System.Drawing.Point(17, 392)
        Me.cboEmployeeID.Margin = New System.Windows.Forms.Padding(2)
        Me.cboEmployeeID.Name = "cboEmployeeID"
        Me.cboEmployeeID.Size = New System.Drawing.Size(125, 21)
        Me.cboEmployeeID.TabIndex = 35
        Me.cboEmployeeID.Visible = False
        '
        'txtFirstName
        '
        Me.txtFirstName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFirstName.Location = New System.Drawing.Point(17, 364)
        Me.txtFirstName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(134, 26)
        Me.txtFirstName.TabIndex = 33
        Me.txtFirstName.Visible = False
        '
        'txtLastName
        '
        Me.txtLastName.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLastName.Location = New System.Drawing.Point(17, 335)
        Me.txtLastName.Margin = New System.Windows.Forms.Padding(2)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(134, 26)
        Me.txtLastName.TabIndex = 32
        Me.txtLastName.Visible = False
        '
        'txtEmployeeID
        '
        Me.txtEmployeeID.AcceptsReturn = True
        Me.txtEmployeeID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmployeeID.Location = New System.Drawing.Point(167, 66)
        Me.txtEmployeeID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtEmployeeID.Name = "txtEmployeeID"
        Me.txtEmployeeID.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtEmployeeID.Size = New System.Drawing.Size(106, 26)
        Me.txtEmployeeID.TabIndex = 28
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(11, 9)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(429, 41)
        Me.Label1.TabIndex = 29
        Me.Label1.Text = "Please Type Your Employee ID and Last Name"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cboTransactionID
        '
        Me.cboTransactionID.FormattingEnabled = True
        Me.cboTransactionID.Location = New System.Drawing.Point(167, 306)
        Me.cboTransactionID.Margin = New System.Windows.Forms.Padding(2)
        Me.cboTransactionID.Name = "cboTransactionID"
        Me.cboTransactionID.Size = New System.Drawing.Size(125, 21)
        Me.cboTransactionID.TabIndex = 43
        Me.cboTransactionID.Visible = False
        '
        'txtTransactionEmployeeID
        '
        Me.txtTransactionEmployeeID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransactionEmployeeID.Location = New System.Drawing.Point(167, 335)
        Me.txtTransactionEmployeeID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTransactionEmployeeID.Name = "txtTransactionEmployeeID"
        Me.txtTransactionEmployeeID.Size = New System.Drawing.Size(125, 26)
        Me.txtTransactionEmployeeID.TabIndex = 42
        Me.txtTransactionEmployeeID.Visible = False
        '
        'txtTransactionInOrOut
        '
        Me.txtTransactionInOrOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransactionInOrOut.Location = New System.Drawing.Point(167, 394)
        Me.txtTransactionInOrOut.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTransactionInOrOut.Name = "txtTransactionInOrOut"
        Me.txtTransactionInOrOut.Size = New System.Drawing.Size(134, 26)
        Me.txtTransactionInOrOut.TabIndex = 45
        Me.txtTransactionInOrOut.Visible = False
        '
        'txtTransactionTime
        '
        Me.txtTransactionTime.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTransactionTime.Location = New System.Drawing.Point(167, 365)
        Me.txtTransactionTime.Margin = New System.Windows.Forms.Padding(2)
        Me.txtTransactionTime.Name = "txtTransactionTime"
        Me.txtTransactionTime.Size = New System.Drawing.Size(134, 26)
        Me.txtTransactionTime.TabIndex = 44
        Me.txtTransactionTime.Visible = False
        '
        'rbtTimeIn
        '
        Me.rbtTimeIn.AutoSize = True
        Me.rbtTimeIn.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtTimeIn.Location = New System.Drawing.Point(167, 177)
        Me.rbtTimeIn.Name = "rbtTimeIn"
        Me.rbtTimeIn.Size = New System.Drawing.Size(79, 24)
        Me.rbtTimeIn.TabIndex = 46
        Me.rbtTimeIn.TabStop = True
        Me.rbtTimeIn.Text = "Time In"
        Me.rbtTimeIn.UseVisualStyleBackColor = True
        '
        'rbtTimeOut
        '
        Me.rbtTimeOut.AutoSize = True
        Me.rbtTimeOut.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rbtTimeOut.Location = New System.Drawing.Point(33, 177)
        Me.rbtTimeOut.Name = "rbtTimeOut"
        Me.rbtTimeOut.Size = New System.Drawing.Size(91, 24)
        Me.rbtTimeOut.TabIndex = 47
        Me.rbtTimeOut.TabStop = True
        Me.rbtTimeOut.Text = "Time Out"
        Me.rbtTimeOut.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(500, 458)
        Me.ControlBox = False
        Me.Controls.Add(Me.rbtTimeOut)
        Me.Controls.Add(Me.rbtTimeIn)
        Me.Controls.Add(Me.txtTransactionInOrOut)
        Me.Controls.Add(Me.txtTransactionTime)
        Me.Controls.Add(Me.cboTransactionID)
        Me.Controls.Add(Me.txtTransactionEmployeeID)
        Me.Controls.Add(Me.txtType)
        Me.Controls.Add(Me.txtActive)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtLogonLastName)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.lblTestValue)
        Me.Controls.Add(Me.cboEmployeeID)
        Me.Controls.Add(Me.txtFirstName)
        Me.Controls.Add(Me.txtLastName)
        Me.Controls.Add(Me.txtEmployeeID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnLogTime)
        Me.Controls.Add(Me.btnClose)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Time Clock"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents btnLogTime As System.Windows.Forms.Button
    Friend WithEvents txtType As System.Windows.Forms.TextBox
    Friend WithEvents txtActive As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtLogonLastName As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents lblTestValue As System.Windows.Forms.Label
    Friend WithEvents cboEmployeeID As System.Windows.Forms.ComboBox
    Friend WithEvents txtFirstName As System.Windows.Forms.TextBox
    Friend WithEvents txtLastName As System.Windows.Forms.TextBox
    Friend WithEvents txtEmployeeID As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboTransactionID As System.Windows.Forms.ComboBox
    Friend WithEvents txtTransactionEmployeeID As System.Windows.Forms.TextBox
    Friend WithEvents txtTransactionInOrOut As System.Windows.Forms.TextBox
    Friend WithEvents txtTransactionTime As System.Windows.Forms.TextBox
    Friend WithEvents rbtTimeIn As System.Windows.Forms.RadioButton
    Friend WithEvents rbtTimeOut As System.Windows.Forms.RadioButton

End Class
