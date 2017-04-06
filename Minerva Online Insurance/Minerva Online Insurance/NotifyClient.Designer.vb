<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NotifyClient
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NotifyClient))
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.walle = New System.Windows.Forms.TextBox()
        Me.msgtime = New System.Windows.Forms.TextBox()
        Me.msgdate = New System.Windows.Forms.TextBox()
        Me.msgfrom = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.t2 = New System.Windows.Forms.Label()
        Me.t1 = New DevExpress.XtraWaitForm.ProgressPanel()
        Me.insurance = New DevExpress.XtraEditors.TextEdit()
        Me.cellnum = New DevExpress.XtraEditors.TextEdit()
        Me.namesurname = New DevExpress.XtraEditors.TextEdit()
        Me.amount = New DevExpress.XtraEditors.TextEdit()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.SimpleButton7 = New DevExpress.XtraEditors.SimpleButton()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.txtQuote = New DevExpress.XtraEditors.TextEdit()
        CType(Me.PictureBox8,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.insurance.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.cellnum.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.namesurname.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.amount.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.txtQuote.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = Global.Minerva_Online_Insurance.My.Resources.Resources.download__1_
        Me.PictureBox8.Location = New System.Drawing.Point(530, -1)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(296, 78)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox8.TabIndex = 328
        Me.PictureBox8.TabStop = false
        '
        'Panel4
        '
        Me.Panel4.Font = New System.Drawing.Font("Corbel", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Panel4.Location = New System.Drawing.Point(494, 304)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(332, 100)
        Me.Panel4.TabIndex = 403
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Corbel", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label2.Location = New System.Drawing.Point(584, 81)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(134, 15)
        Me.Label2.TabIndex = 402
        Me.Label2.Text = "MONITOR PAYMENTS"
        '
        'Label5
        '
        Me.Label5.AutoSize = true
        Me.Label5.Font = New System.Drawing.Font("Corbel", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label5.Location = New System.Drawing.Point(549, 247)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 14)
        Me.Label5.TabIndex = 401
        Me.Label5.Text = "Amount"
        '
        'Label6
        '
        Me.Label6.AutoSize = true
        Me.Label6.Font = New System.Drawing.Font("Corbel", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label6.Location = New System.Drawing.Point(549, 200)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(79, 14)
        Me.Label6.TabIndex = 397
        Me.Label6.Text = "Payment Time"
        '
        'Label7
        '
        Me.Label7.AutoSize = true
        Me.Label7.Font = New System.Drawing.Font("Corbel", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label7.Location = New System.Drawing.Point(549, 151)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(78, 14)
        Me.Label7.TabIndex = 398
        Me.Label7.Text = "Payment Date"
        '
        'Label8
        '
        Me.Label8.AutoSize = true
        Me.Label8.Font = New System.Drawing.Font("Corbel", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label8.Location = New System.Drawing.Point(549, 106)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(80, 14)
        Me.Label8.TabIndex = 399
        Me.Label8.Text = "Payment From"
        '
        'walle
        '
        Me.walle.Font = New System.Drawing.Font("Corbel", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.walle.Location = New System.Drawing.Point(552, 263)
        Me.walle.Name = "walle"
        Me.walle.Size = New System.Drawing.Size(212, 22)
        Me.walle.TabIndex = 393
        '
        'msgtime
        '
        Me.msgtime.Font = New System.Drawing.Font("Corbel", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.msgtime.Location = New System.Drawing.Point(552, 216)
        Me.msgtime.Name = "msgtime"
        Me.msgtime.Size = New System.Drawing.Size(212, 22)
        Me.msgtime.TabIndex = 394
        '
        'msgdate
        '
        Me.msgdate.Font = New System.Drawing.Font("Corbel", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.msgdate.Location = New System.Drawing.Point(552, 167)
        Me.msgdate.Name = "msgdate"
        Me.msgdate.Size = New System.Drawing.Size(212, 22)
        Me.msgdate.TabIndex = 395
        '
        'msgfrom
        '
        Me.msgfrom.Font = New System.Drawing.Font("Corbel", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.msgfrom.Location = New System.Drawing.Point(552, 122)
        Me.msgfrom.Name = "msgfrom"
        Me.msgfrom.Size = New System.Drawing.Size(212, 22)
        Me.msgfrom.TabIndex = 396
        '
        'TextBox1
        '
        Me.TextBox1.Font = New System.Drawing.Font("Corbel", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.TextBox1.Location = New System.Drawing.Point(552, 318)
        Me.TextBox1.Multiline = true
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(293, 74)
        Me.TextBox1.TabIndex = 400
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.Location = New System.Drawing.Point(516, -1)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(6, 538)
        Me.Panel1.TabIndex = 404
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Corbel", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 14)
        Me.Label1.TabIndex = 408
        Me.Label1.Text = "Insurance Type"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("Corbel", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(68, 14)
        Me.Label3.TabIndex = 409
        Me.Label3.Text = "Cell Number"
        '
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Font = New System.Drawing.Font("Corbel", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(104, 14)
        Me.Label4.TabIndex = 410
        Me.Label4.Text = "Name and Surname"
        '
        't2
        '
        Me.t2.AutoSize = true
        Me.t2.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.t2.ForeColor = System.Drawing.SystemColors.InfoText
        Me.t2.Location = New System.Drawing.Point(2, 5)
        Me.t2.Name = "t2"
        Me.t2.Size = New System.Drawing.Size(279, 13)
        Me.t2.TabIndex = 412
        Me.t2.Text = "Connected to the Minerva Online Insurance System"
        Me.t2.Visible = false
        '
        't1
        '
        Me.t1.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.t1.Appearance.Options.UseBackColor = true
        Me.t1.BarAnimationElementThickness = 2
        Me.t1.Caption = ""
        Me.t1.Description = ""
        Me.t1.Location = New System.Drawing.Point(287, 5)
        Me.t1.Name = "t1"
        Me.t1.Size = New System.Drawing.Size(201, 13)
        Me.t1.TabIndex = 411
        Me.t1.Text = "ProgressPanel1"
        Me.t1.Visible = false
        Me.t1.WaitAnimationType = DevExpress.Utils.Animation.WaitingAnimatorType.Line
        '
        'insurance
        '
        Me.insurance.Location = New System.Drawing.Point(15, 147)
        Me.insurance.Name = "insurance"
        Me.insurance.Properties.Appearance.Font = New System.Drawing.Font("Corbel", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.insurance.Properties.Appearance.Options.UseFont = true
        Me.insurance.Size = New System.Drawing.Size(386, 20)
        Me.insurance.TabIndex = 413
        '
        'cellnum
        '
        Me.cellnum.Location = New System.Drawing.Point(15, 98)
        Me.cellnum.Name = "cellnum"
        Me.cellnum.Properties.Appearance.Font = New System.Drawing.Font("Corbel", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.cellnum.Properties.Appearance.Options.UseFont = true
        Me.cellnum.Size = New System.Drawing.Size(386, 20)
        Me.cellnum.TabIndex = 414
        '
        'namesurname
        '
        Me.namesurname.Location = New System.Drawing.Point(15, 53)
        Me.namesurname.Name = "namesurname"
        Me.namesurname.Properties.Appearance.Font = New System.Drawing.Font("Corbel", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.namesurname.Properties.Appearance.Options.UseFont = true
        Me.namesurname.Size = New System.Drawing.Size(386, 20)
        Me.namesurname.TabIndex = 415
        '
        'amount
        '
        Me.amount.Location = New System.Drawing.Point(15, 197)
        Me.amount.Name = "amount"
        Me.amount.Properties.Appearance.Font = New System.Drawing.Font("Corbel", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.amount.Properties.Appearance.Options.UseFont = true
        Me.amount.Size = New System.Drawing.Size(386, 20)
        Me.amount.TabIndex = 417
        '
        'Label9
        '
        Me.Label9.AutoSize = true
        Me.Label9.Font = New System.Drawing.Font("Corbel", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 180)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(79, 14)
        Me.Label9.TabIndex = 416
        Me.Label9.Text = "Amount to pay"
        '
        'SimpleButton7
        '
        Me.SimpleButton7.Appearance.BackColor = System.Drawing.Color.White
        Me.SimpleButton7.Appearance.Options.UseBackColor = true
        Me.SimpleButton7.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.SimpleButton7.Image = CType(resources.GetObject("SimpleButton7.Image"),System.Drawing.Image)
        Me.SimpleButton7.Location = New System.Drawing.Point(15, 232)
        Me.SimpleButton7.Name = "SimpleButton7"
        Me.SimpleButton7.Size = New System.Drawing.Size(113, 29)
        Me.SimpleButton7.TabIndex = 418
        Me.SimpleButton7.TabStop = false
        Me.SimpleButton7.Text = "Send Quote"
        '
        'SerialPort1
        '
        '
        'txtQuote
        '
        Me.txtQuote.Location = New System.Drawing.Point(15, 318)
        Me.txtQuote.Name = "txtQuote"
        Me.txtQuote.Properties.Appearance.Font = New System.Drawing.Font("Corbel", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.txtQuote.Properties.Appearance.Options.UseFont = true
        Me.txtQuote.Size = New System.Drawing.Size(87, 20)
        Me.txtQuote.TabIndex = 419
        '
        'NotifyClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(822, 296)
        Me.Controls.Add(Me.txtQuote)
        Me.Controls.Add(Me.SimpleButton7)
        Me.Controls.Add(Me.amount)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.namesurname)
        Me.Controls.Add(Me.cellnum)
        Me.Controls.Add(Me.insurance)
        Me.Controls.Add(Me.t2)
        Me.Controls.Add(Me.t1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.walle)
        Me.Controls.Add(Me.msgtime)
        Me.Controls.Add(Me.msgdate)
        Me.Controls.Add(Me.msgfrom)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.PictureBox8)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "NotifyClient"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Respond Quote"
        CType(Me.PictureBox8,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.insurance.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.cellnum.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.namesurname.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.amount.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.txtQuote.Properties,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label2 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents walle As TextBox
    Friend WithEvents msgtime As TextBox
    Friend WithEvents msgdate As TextBox
    Friend WithEvents msgfrom As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents t2 As Label
    Friend WithEvents t1 As DevExpress.XtraWaitForm.ProgressPanel
    Friend WithEvents insurance As DevExpress.XtraEditors.TextEdit
    Friend WithEvents cellnum As DevExpress.XtraEditors.TextEdit
    Friend WithEvents namesurname As DevExpress.XtraEditors.TextEdit
    Friend WithEvents amount As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label9 As Label
    Friend WithEvents SimpleButton7 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents txtQuote As DevExpress.XtraEditors.TextEdit
End Class
