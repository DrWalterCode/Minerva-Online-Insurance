<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmClaim
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmClaim))
        Me.t2 = New System.Windows.Forms.Label()
        Me.t1 = New DevExpress.XtraWaitForm.ProgressPanel()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.c3 = New DevExpress.XtraEditors.TextEdit()
        Me.c1 = New DevExpress.XtraEditors.TextEdit()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.c4 = New DevExpress.XtraEditors.TextEdit()
        Me.c2 = New System.Windows.Forms.ComboBox()
        Me.c5 = New DevExpress.XtraEditors.TextEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton7 = New DevExpress.XtraEditors.SimpleButton()
        Me.PictureBox8 = New System.Windows.Forms.PictureBox()
        CType(Me.c3.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.c1.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.c4.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.c5.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.PictureBox8,System.ComponentModel.ISupportInitialize).BeginInit
        Me.SuspendLayout
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
        'Label4
        '
        Me.Label4.AutoSize = true
        Me.Label4.Font = New System.Drawing.Font("Corbel", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 36)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(83, 14)
        Me.Label4.TabIndex = 410
        Me.Label4.Text = "Incident Details"
        '
        'Label3
        '
        Me.Label3.AutoSize = true
        Me.Label3.Font = New System.Drawing.Font("Corbel", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 81)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(72, 14)
        Me.Label3.TabIndex = 409
        Me.Label3.Text = "Road Surface"
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Corbel", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 14)
        Me.Label1.TabIndex = 408
        Me.Label1.Text = "Number of Vehicles Involved"
        '
        'c3
        '
        Me.c3.Location = New System.Drawing.Point(15, 147)
        Me.c3.Name = "c3"
        Me.c3.Properties.Appearance.Font = New System.Drawing.Font("Corbel", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.c3.Properties.Appearance.Options.UseFont = true
        Me.c3.Properties.Mask.EditMask = "n0"
        Me.c3.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.c3.Size = New System.Drawing.Size(386, 20)
        Me.c3.TabIndex = 2
        '
        'c1
        '
        Me.c1.Location = New System.Drawing.Point(15, 53)
        Me.c1.Name = "c1"
        Me.c1.Properties.Appearance.Font = New System.Drawing.Font("Corbel", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.c1.Properties.Appearance.Options.UseFont = true
        Me.c1.Size = New System.Drawing.Size(386, 20)
        Me.c1.TabIndex = 0
        '
        'Label9
        '
        Me.Label9.AutoSize = true
        Me.Label9.Font = New System.Drawing.Font("Corbel", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 180)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(98, 14)
        Me.Label9.TabIndex = 416
        Me.Label9.Text = "Damage to vehicle"
        '
        'c4
        '
        Me.c4.Location = New System.Drawing.Point(15, 197)
        Me.c4.Name = "c4"
        Me.c4.Properties.Appearance.Font = New System.Drawing.Font("Corbel", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.c4.Properties.Appearance.Options.UseFont = true
        Me.c4.Size = New System.Drawing.Size(386, 20)
        Me.c4.TabIndex = 3
        '
        'c2
        '
        Me.c2.FormattingEnabled = true
        Me.c2.Items.AddRange(New Object() {"Wet ", "Dry"})
        Me.c2.Location = New System.Drawing.Point(15, 98)
        Me.c2.Name = "c2"
        Me.c2.Size = New System.Drawing.Size(121, 21)
        Me.c2.TabIndex = 1
        '
        'c5
        '
        Me.c5.Location = New System.Drawing.Point(496, 96)
        Me.c5.Name = "c5"
        Me.c5.Properties.Appearance.Font = New System.Drawing.Font("Corbel", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.c5.Properties.Appearance.Options.UseFont = true
        Me.c5.Size = New System.Drawing.Size(311, 20)
        Me.c5.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Corbel", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.Location = New System.Drawing.Point(493, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 14)
        Me.Label2.TabIndex = 423
        Me.Label2.Text = "File Path"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.BackColor = System.Drawing.Color.White
        Me.SimpleButton1.Appearance.Options.UseBackColor = true
        Me.SimpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"),System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(642, 56)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(165, 39)
        Me.SimpleButton1.TabIndex = 422
        Me.SimpleButton1.TabStop = false
        Me.SimpleButton1.Text = "Attach Police report"
        '
        'SimpleButton7
        '
        Me.SimpleButton7.Appearance.BackColor = System.Drawing.Color.White
        Me.SimpleButton7.Appearance.Options.UseBackColor = true
        Me.SimpleButton7.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.SimpleButton7.Image = CType(resources.GetObject("SimpleButton7.Image"),System.Drawing.Image)
        Me.SimpleButton7.Location = New System.Drawing.Point(694, 122)
        Me.SimpleButton7.Name = "SimpleButton7"
        Me.SimpleButton7.Size = New System.Drawing.Size(113, 29)
        Me.SimpleButton7.TabIndex = 418
        Me.SimpleButton7.TabStop = false
        Me.SimpleButton7.Text = "Send Claim"
        '
        'PictureBox8
        '
        Me.PictureBox8.Image = Global.Minerva_Online_Insurance.My.Resources.Resources.delaration
        Me.PictureBox8.Location = New System.Drawing.Point(12, 239)
        Me.PictureBox8.Name = "PictureBox8"
        Me.PictureBox8.Size = New System.Drawing.Size(700, 153)
        Me.PictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox8.TabIndex = 328
        Me.PictureBox8.TabStop = false
        '
        'frmClaim
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(840, 423)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.c5)
        Me.Controls.Add(Me.c2)
        Me.Controls.Add(Me.SimpleButton7)
        Me.Controls.Add(Me.c4)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.c1)
        Me.Controls.Add(Me.c3)
        Me.Controls.Add(Me.t2)
        Me.Controls.Add(Me.t1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox8)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "frmClaim"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vehicle Claim"
        CType(Me.c3.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.c1.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.c4.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.c5.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.PictureBox8,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents PictureBox8 As PictureBox
    Friend WithEvents t2 As Label
    Friend WithEvents t1 As DevExpress.XtraWaitForm.ProgressPanel
    Friend WithEvents SimpleButton7 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents c3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents c1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label9 As Label
    Friend WithEvents c4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents c2 As ComboBox
    Friend WithEvents c5 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Label2 As Label
End Class
