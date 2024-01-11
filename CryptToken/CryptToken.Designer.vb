<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CryptToken
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
        Me.RichTextPublicKey = New System.Windows.Forms.RichTextBox()
        Me.RichTextPrivateKey = New System.Windows.Forms.RichTextBox()
        Me.InputValue = New System.Windows.Forms.TextBox()
        Me.OutputValue = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.EncryptBtn = New System.Windows.Forms.Button()
        Me.DecryptBtn = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ClearBtn = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'RichTextPublicKey
        '
        Me.RichTextPublicKey.Location = New System.Drawing.Point(12, 36)
        Me.RichTextPublicKey.Name = "RichTextPublicKey"
        Me.RichTextPublicKey.Size = New System.Drawing.Size(334, 127)
        Me.RichTextPublicKey.TabIndex = 0
        Me.RichTextPublicKey.Text = ""
        '
        'RichTextPrivateKey
        '
        Me.RichTextPrivateKey.Location = New System.Drawing.Point(454, 36)
        Me.RichTextPrivateKey.Name = "RichTextPrivateKey"
        Me.RichTextPrivateKey.Size = New System.Drawing.Size(334, 127)
        Me.RichTextPrivateKey.TabIndex = 1
        Me.RichTextPrivateKey.Text = ""
        '
        'InputValue
        '
        Me.InputValue.Location = New System.Drawing.Point(12, 203)
        Me.InputValue.Name = "InputValue"
        Me.InputValue.Size = New System.Drawing.Size(776, 20)
        Me.InputValue.TabIndex = 2
        '
        'OutputValue
        '
        Me.OutputValue.Location = New System.Drawing.Point(12, 260)
        Me.OutputValue.Name = "OutputValue"
        Me.OutputValue.Size = New System.Drawing.Size(776, 20)
        Me.OutputValue.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(13, 184)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(31, 13)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Input"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(13, 244)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 13)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Output"
        '
        'EncryptBtn
        '
        Me.EncryptBtn.Location = New System.Drawing.Point(170, 354)
        Me.EncryptBtn.Name = "EncryptBtn"
        Me.EncryptBtn.Size = New System.Drawing.Size(176, 39)
        Me.EncryptBtn.TabIndex = 6
        Me.EncryptBtn.Text = "Encrypt"
        Me.EncryptBtn.UseVisualStyleBackColor = True
        '
        'DecryptBtn
        '
        Me.DecryptBtn.Location = New System.Drawing.Point(454, 354)
        Me.DecryptBtn.Name = "DecryptBtn"
        Me.DecryptBtn.Size = New System.Drawing.Size(176, 39)
        Me.DecryptBtn.TabIndex = 7
        Me.DecryptBtn.Text = "Decrypt"
        Me.DecryptBtn.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 13)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 13)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Public key"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(451, 20)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(60, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Private key"
        '
        'ClearBtn
        '
        Me.ClearBtn.Location = New System.Drawing.Point(12, 354)
        Me.ClearBtn.Name = "ClearBtn"
        Me.ClearBtn.Size = New System.Drawing.Size(95, 39)
        Me.ClearBtn.TabIndex = 11
        Me.ClearBtn.Text = "Clear"
        Me.ClearBtn.UseVisualStyleBackColor = True
        '
        'CryptToken
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ClearBtn)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.DecryptBtn)
        Me.Controls.Add(Me.EncryptBtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.OutputValue)
        Me.Controls.Add(Me.InputValue)
        Me.Controls.Add(Me.RichTextPrivateKey)
        Me.Controls.Add(Me.RichTextPublicKey)
        Me.Name = "CryptToken"
        Me.Text = "CryptToken"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RichTextPublicKey As RichTextBox
    Friend WithEvents RichTextPrivateKey As RichTextBox
    Friend WithEvents InputValue As TextBox
    Friend WithEvents OutputValue As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents EncryptBtn As Button
    Friend WithEvents DecryptBtn As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ClearBtn As Button
End Class
