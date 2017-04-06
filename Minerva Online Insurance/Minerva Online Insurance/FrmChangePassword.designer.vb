<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmChangePassword
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmChangePassword))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtConNewPwd = New System.Windows.Forms.TextBox()
        Me.txtNewPwd = New System.Windows.Forms.TextBox()
        Me.txtUsername = New System.Windows.Forms.TextBox()
        Me.txtOldPwd = New System.Windows.Forms.TextBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SuspendLayout
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.BackColor = System.Drawing.Color.White
        Me.Label2.Font = New System.Drawing.Font("Corbel", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.Location = New System.Drawing.Point(1, 83)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(104, 14)
        Me.Label2.TabIndex = 23
        Me.Label2.Text = "Confirm New Pass. :"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.BackColor = System.Drawing.Color.White
        Me.Label4.Font = New System.Drawing.Font("Corbel", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label4.Location = New System.Drawing.Point(1, 59)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(85, 14)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "New Password :"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.BackColor = System.Drawing.Color.White
        Me.Label3.Font = New System.Drawing.Font("Corbel", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label3.Location = New System.Drawing.Point(1, 10)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 14)
        Me.Label3.TabIndex = 21
        Me.Label3.Text = "Username :"
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.BackColor = System.Drawing.Color.White
        Me.Label5.Font = New System.Drawing.Font("Corbel", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label5.Location = New System.Drawing.Point(1, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(80, 14)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Old Password :"
        '
        'txtConNewPwd
        '
        Me.txtConNewPwd.BackColor = System.Drawing.Color.White
        Me.txtConNewPwd.Font = New System.Drawing.Font("Corbel", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtConNewPwd.Location = New System.Drawing.Point(106, 80)
        Me.txtConNewPwd.Name = "txtConNewPwd"
        Me.txtConNewPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtConNewPwd.Size = New System.Drawing.Size(132, 21)
        Me.txtConNewPwd.TabIndex = 3
        '
        'txtNewPwd
        '
        Me.txtNewPwd.BackColor = System.Drawing.Color.White
        Me.txtNewPwd.Font = New System.Drawing.Font("Corbel", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtNewPwd.Location = New System.Drawing.Point(106, 56)
        Me.txtNewPwd.Name = "txtNewPwd"
        Me.txtNewPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPwd.Size = New System.Drawing.Size(132, 21)
        Me.txtNewPwd.TabIndex = 2
        '
        'txtUsername
        '
        Me.txtUsername.BackColor = System.Drawing.Color.White
        Me.txtUsername.Enabled = false
        Me.txtUsername.Font = New System.Drawing.Font("Corbel", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtUsername.Location = New System.Drawing.Point(106, 7)
        Me.txtUsername.Name = "txtUsername"
        Me.txtUsername.Size = New System.Drawing.Size(132, 21)
        Me.txtUsername.TabIndex = 0
        '
        'txtOldPwd
        '
        Me.txtOldPwd.BackColor = System.Drawing.Color.White
        Me.txtOldPwd.Font = New System.Drawing.Font("Corbel", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtOldPwd.Location = New System.Drawing.Point(106, 32)
        Me.txtOldPwd.Name = "txtOldPwd"
        Me.txtOldPwd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtOldPwd.Size = New System.Drawing.Size(132, 21)
        Me.txtOldPwd.TabIndex = 1
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.Red
        Me.Panel4.Location = New System.Drawing.Point(-712, -3)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1796, 7)
        Me.Panel4.TabIndex = 272
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Corbel", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.SimpleButton1.Appearance.Options.UseFont = true
        Me.SimpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"),System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(167, 107)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(71, 21)
        Me.SimpleButton1.TabIndex = 4
        Me.SimpleButton1.Text = "&Change"
        '
        'FrmChangePassword
        '
        Me.AcceptButton = Me.SimpleButton1
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(243, 133)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtConNewPwd)
        Me.Controls.Add(Me.txtNewPwd)
        Me.Controls.Add(Me.txtUsername)
        Me.Controls.Add(Me.txtOldPwd)
        Me.Font = New System.Drawing.Font("Corbel", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.KeyPreview = true
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "FrmChangePassword"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Change Password"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtConNewPwd As TextBox
    Friend WithEvents txtNewPwd As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtOldPwd As TextBox
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Panel4 As Panel
End Class
