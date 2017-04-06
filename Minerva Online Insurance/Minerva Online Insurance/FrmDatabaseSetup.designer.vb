<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmDatabaseSetup
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmDatabaseSetup))
        Me.groupBox11 = New System.Windows.Forms.GroupBox()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.txtport = New DevExpress.XtraEditors.TextEdit()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me.cbodatabase = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.txtpassword = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtuser = New DevExpress.XtraEditors.TextEdit()
        Me.txthost = New DevExpress.XtraEditors.TextEdit()
        Me.label38 = New System.Windows.Forms.Label()
        Me.label37 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.groupBox11.SuspendLayout
        CType(Me.txtport.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.CheckEdit1.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cbodatabase.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtpassword.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtuser.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txthost.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'groupBox11
        '
        Me.groupBox11.Controls.Add(Me.SimpleButton2)
        Me.groupBox11.Controls.Add(Me.txtport)
        Me.groupBox11.Controls.Add(Me.Label3)
        Me.groupBox11.Controls.Add(Me.SimpleButton1)
        Me.groupBox11.Controls.Add(Me.CheckEdit1)
        Me.groupBox11.Controls.Add(Me.cbodatabase)
        Me.groupBox11.Controls.Add(Me.txtpassword)
        Me.groupBox11.Controls.Add(Me.Label1)
        Me.groupBox11.Controls.Add(Me.Label2)
        Me.groupBox11.Controls.Add(Me.txtuser)
        Me.groupBox11.Controls.Add(Me.txthost)
        Me.groupBox11.Controls.Add(Me.label38)
        Me.groupBox11.Controls.Add(Me.label37)
        Me.groupBox11.Font = New System.Drawing.Font("Corbel", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.groupBox11.Location = New System.Drawing.Point(190, 12)
        Me.groupBox11.Name = "groupBox11"
        Me.groupBox11.Size = New System.Drawing.Size(280, 182)
        Me.groupBox11.TabIndex = 15
        Me.groupBox11.TabStop = false
        Me.groupBox11.Text = "Cloud Connection Details"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Appearance.BackColor = System.Drawing.Color.White
        Me.SimpleButton2.Appearance.Font = New System.Drawing.Font("Corbel", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.SimpleButton2.Appearance.Options.UseBackColor = true
        Me.SimpleButton2.Appearance.Options.UseFont = true
        Me.SimpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"),System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(221, 150)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(54, 29)
        Me.SimpleButton2.TabIndex = 28
        Me.SimpleButton2.TabStop = false
        Me.SimpleButton2.Text = "&Exit"
        '
        'txtport
        '
        Me.txtport.EditValue = "3306"
        Me.txtport.Location = New System.Drawing.Point(69, 16)
        Me.txtport.Name = "txtport"
        Me.txtport.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtport.Properties.Appearance.Font = New System.Drawing.Font("Corbel", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtport.Properties.Appearance.Options.UseBackColor = true
        Me.txtport.Properties.Appearance.Options.UseFont = true
        Me.txtport.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtport.Properties.Mask.BeepOnError = true
        Me.txtport.Properties.Mask.EditMask = "\p{Lu}\p{Ll}*(\s+\p{Lu}\p{Ll}*[A-Z]*[()]*)*"
        Me.txtport.Properties.Mask.ShowPlaceHolders = false
        Me.txtport.Size = New System.Drawing.Size(205, 20)
        Me.txtport.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("Corbel", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label3.Location = New System.Drawing.Point(7, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 14)
        Me.Label3.TabIndex = 26
        Me.Label3.Text = "Port"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.BackColor = System.Drawing.Color.White
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Corbel", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.SimpleButton1.Appearance.Options.UseBackColor = true
        Me.SimpleButton1.Appearance.Options.UseFont = true
        Me.SimpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"),System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(159, 150)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(56, 29)
        Me.SimpleButton1.TabIndex = 25
        Me.SimpleButton1.TabStop = false
        Me.SimpleButton1.Text = "&Save"
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Location = New System.Drawing.Point(10, 156)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Appearance.Font = New System.Drawing.Font("Corbel", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.CheckEdit1.Properties.Appearance.Options.UseFont = true
        Me.CheckEdit1.Properties.Caption = "Don't Show on Start_Up"
        Me.CheckEdit1.Size = New System.Drawing.Size(143, 19)
        Me.CheckEdit1.TabIndex = 24
        '
        'cbodatabase
        '
        Me.cbodatabase.Location = New System.Drawing.Point(70, 124)
        Me.cbodatabase.Name = "cbodatabase"
        Me.cbodatabase.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.cbodatabase.Properties.Appearance.Font = New System.Drawing.Font("Corbel", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cbodatabase.Properties.Appearance.Options.UseBackColor = true
        Me.cbodatabase.Properties.Appearance.Options.UseFont = true
        Me.cbodatabase.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cbodatabase.Properties.Sorted = true
        Me.cbodatabase.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor
        Me.cbodatabase.Size = New System.Drawing.Size(205, 20)
        Me.cbodatabase.TabIndex = 23
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(70, 98)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtpassword.Properties.Appearance.Font = New System.Drawing.Font("Corbel", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtpassword.Properties.Appearance.Options.UseBackColor = true
        Me.txtpassword.Properties.Appearance.Options.UseFont = true
        Me.txtpassword.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtpassword.Properties.Mask.BeepOnError = true
        Me.txtpassword.Properties.Mask.EditMask = "\p{Lu}\p{Ll}*(\s+\p{Lu}\p{Ll}*[A-Z]*[()]*)*"
        Me.txtpassword.Properties.Mask.ShowPlaceHolders = false
        Me.txtpassword.Properties.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.Size = New System.Drawing.Size(205, 20)
        Me.txtpassword.TabIndex = 18
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Corbel", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 14)
        Me.Label1.TabIndex = 21
        Me.Label1.Text = "Database"
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Corbel", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.Location = New System.Drawing.Point(7, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 14)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Password"
        '
        'txtuser
        '
        Me.txtuser.Location = New System.Drawing.Point(70, 70)
        Me.txtuser.Name = "txtuser"
        Me.txtuser.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtuser.Properties.Appearance.Font = New System.Drawing.Font("Corbel", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtuser.Properties.Appearance.Options.UseBackColor = true
        Me.txtuser.Properties.Appearance.Options.UseFont = true
        Me.txtuser.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txtuser.Properties.Mask.BeepOnError = true
        Me.txtuser.Properties.Mask.EditMask = "\p{Lu}\p{Ll}*(\s+\p{Lu}\p{Ll}*[A-Z]*[()]*)*"
        Me.txtuser.Properties.Mask.ShowPlaceHolders = false
        Me.txtuser.Size = New System.Drawing.Size(205, 20)
        Me.txtuser.TabIndex = 1
        '
        'txthost
        '
        Me.txthost.Location = New System.Drawing.Point(69, 43)
        Me.txthost.Name = "txthost"
        Me.txthost.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txthost.Properties.Appearance.Font = New System.Drawing.Font("Corbel", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txthost.Properties.Appearance.Options.UseBackColor = true
        Me.txthost.Properties.Appearance.Options.UseFont = true
        Me.txthost.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Office2003
        Me.txthost.Properties.Mask.BeepOnError = true
        Me.txthost.Properties.Mask.EditMask = "\p{Lu}\p{Ll}*(\s+\p{Lu}\p{Ll}*[A-Z]*[()]*)*"
        Me.txthost.Properties.Mask.ShowPlaceHolders = false
        Me.txthost.Size = New System.Drawing.Size(205, 20)
        Me.txthost.TabIndex = 0
        '
        'label38
        '
        Me.label38.AutoSize = true
        Me.label38.Font = New System.Drawing.Font("Corbel", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.label38.Location = New System.Drawing.Point(7, 76)
        Me.label38.Name = "label38"
        Me.label38.Size = New System.Drawing.Size(30, 14)
        Me.label38.TabIndex = 17
        Me.label38.Text = "User"
        '
        'label37
        '
        Me.label37.AutoSize = true
        Me.label37.Font = New System.Drawing.Font("Corbel", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.label37.Location = New System.Drawing.Point(7, 49)
        Me.label37.Name = "label37"
        Me.label37.Size = New System.Drawing.Size(30, 14)
        Me.label37.TabIndex = 15
        Me.label37.Text = "Host"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(46,Byte),Integer), CType(CType(86,Byte),Integer), CType(CType(161,Byte),Integer))
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(482, 4)
        Me.Panel1.TabIndex = 285
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Minerva_Online_Insurance.My.Resources.Resources.download__1_
        Me.PictureBox1.Location = New System.Drawing.Point(0, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(184, 177)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = false
        '
        'FrmDatabaseSetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(482, 197)
        Me.ControlBox = false
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.groupBox11)
        Me.Font = New System.Drawing.Font("Corbel", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "FrmDatabaseSetup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Minerva Cloud Connection Settings"
        Me.groupBox11.ResumeLayout(false)
        Me.groupBox11.PerformLayout
        CType(Me.txtport.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.CheckEdit1.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cbodatabase.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtpassword.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtuser.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txthost.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox1,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)

End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Private WithEvents groupBox11 As GroupBox
    Friend WithEvents txtpassword As DevExpress.XtraEditors.TextEdit
    Private WithEvents Label1 As Label
    Private WithEvents Label2 As Label
    Friend WithEvents txtuser As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txthost As DevExpress.XtraEditors.TextEdit
    Private WithEvents label38 As Label
    Private WithEvents label37 As Label
    Friend WithEvents cbodatabase As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtport As DevExpress.XtraEditors.TextEdit
    Private WithEvents Label3 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
End Class
