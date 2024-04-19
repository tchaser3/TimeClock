<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CreateID
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
        Me.cboTransactionID = New System.Windows.Forms.ComboBox()
        Me.txtCreatedTransactionID = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cboTransactionID
        '
        Me.cboTransactionID.FormattingEnabled = True
        Me.cboTransactionID.Location = New System.Drawing.Point(41, 23)
        Me.cboTransactionID.Margin = New System.Windows.Forms.Padding(2)
        Me.cboTransactionID.Name = "cboTransactionID"
        Me.cboTransactionID.Size = New System.Drawing.Size(125, 21)
        Me.cboTransactionID.TabIndex = 45
        '
        'txtCreatedTransactionID
        '
        Me.txtCreatedTransactionID.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCreatedTransactionID.Location = New System.Drawing.Point(41, 52)
        Me.txtCreatedTransactionID.Margin = New System.Windows.Forms.Padding(2)
        Me.txtCreatedTransactionID.Name = "txtCreatedTransactionID"
        Me.txtCreatedTransactionID.Size = New System.Drawing.Size(125, 26)
        Me.txtCreatedTransactionID.TabIndex = 44
        '
        'CreateID
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(206, 101)
        Me.Controls.Add(Me.cboTransactionID)
        Me.Controls.Add(Me.txtCreatedTransactionID)
        Me.Name = "CreateID"
        Me.Text = "CreateID"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cboTransactionID As System.Windows.Forms.ComboBox
    Friend WithEvents txtCreatedTransactionID As System.Windows.Forms.TextBox
End Class
