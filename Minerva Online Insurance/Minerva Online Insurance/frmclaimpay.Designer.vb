<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmclaimpay
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmclaimpay))
        Me.t2 = New System.Windows.Forms.Label()
        Me.t1 = New DevExpress.XtraWaitForm.ProgressPanel()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.c2 = New DevExpress.XtraEditors.TextEdit()
        Me.c1 = New DevExpress.XtraEditors.TextEdit()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.c3 = New DevExpress.XtraEditors.TextEdit()
        Me.SimpleButton7 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.c4 = New DevExpress.XtraEditors.TextEdit()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.c2.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.c1.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.c3.Properties,System.ComponentModel.ISupportInitialize).BeginInit
        CType(Me.c4.Properties,System.ComponentModel.ISupportInitialize).BeginInit
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
        Me.Label4.Size = New System.Drawing.Size(26, 14)
        Me.Label4.TabIndex = 410
        Me.Label4.Text = "Cell"
        '
        'Label1
        '
        Me.Label1.AutoSize = true
        Me.Label1.Font = New System.Drawing.Font("Corbel", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 14)
        Me.Label1.TabIndex = 408
        Me.Label1.Text = "Claim ID"
        '
        'c2
        '
        Me.c2.Location = New System.Drawing.Point(15, 98)
        Me.c2.Name = "c2"
        Me.c2.Properties.Appearance.Font = New System.Drawing.Font("Corbel", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.c2.Properties.Appearance.Options.UseFont = true
        Me.c2.Properties.Mask.EditMask = "n0"
        Me.c2.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric
        Me.c2.Properties.ReadOnly = true
        Me.c2.Size = New System.Drawing.Size(386, 20)
        Me.c2.TabIndex = 413
        '
        'c1
        '
        Me.c1.Location = New System.Drawing.Point(15, 53)
        Me.c1.Name = "c1"
        Me.c1.Properties.Appearance.Font = New System.Drawing.Font("Corbel", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.c1.Properties.Appearance.Options.UseFont = true
        Me.c1.Properties.ReadOnly = true
        Me.c1.Size = New System.Drawing.Size(386, 20)
        Me.c1.TabIndex = 415
        '
        'Label9
        '
        Me.Label9.AutoSize = true
        Me.Label9.Font = New System.Drawing.Font("Corbel", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 131)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(92, 14)
        Me.Label9.TabIndex = 416
        Me.Label9.Text = "Police report path"
        '
        'c3
        '
        Me.c3.Location = New System.Drawing.Point(15, 148)
        Me.c3.Name = "c3"
        Me.c3.Properties.Appearance.Font = New System.Drawing.Font("Corbel", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.c3.Properties.Appearance.Options.UseFont = true
        Me.c3.Properties.ReadOnly = true
        Me.c3.Size = New System.Drawing.Size(386, 20)
        Me.c3.TabIndex = 417
        '
        'SimpleButton7
        '
        Me.SimpleButton7.Appearance.BackColor = System.Drawing.Color.White
        Me.SimpleButton7.Appearance.Options.UseBackColor = true
        Me.SimpleButton7.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.SimpleButton7.Image = CType(resources.GetObject("SimpleButton7.Image"),System.Drawing.Image)
        Me.SimpleButton7.Location = New System.Drawing.Point(119, 213)
        Me.SimpleButton7.Name = "SimpleButton7"
        Me.SimpleButton7.Size = New System.Drawing.Size(97, 29)
        Me.SimpleButton7.TabIndex = 418
        Me.SimpleButton7.TabStop = false
        Me.SimpleButton7.Text = "Pay Claim"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.BackColor = System.Drawing.Color.White
        Me.SimpleButton1.Appearance.Options.UseBackColor = true
        Me.SimpleButton1.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.SimpleButton1.Image = CType(resources.GetObject("SimpleButton1.Image"),System.Drawing.Image)
        Me.SimpleButton1.Location = New System.Drawing.Point(407, 138)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(133, 39)
        Me.SimpleButton1.TabIndex = 422
        Me.SimpleButton1.TabStop = false
        Me.SimpleButton1.Text = "View Police report"
        '
        'c4
        '
        Me.c4.Location = New System.Drawing.Point(12, 218)
        Me.c4.Name = "c4"
        Me.c4.Properties.Appearance.Font = New System.Drawing.Font("Corbel", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.c4.Properties.Appearance.Options.UseFont = true
        Me.c4.Size = New System.Drawing.Size(101, 20)
        Me.c4.TabIndex = 423
        '
        'Label2
        '
        Me.Label2.AutoSize = true
        Me.Label2.Font = New System.Drawing.Font("Corbel", 9!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0,Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 196)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 14)
        Me.Label2.TabIndex = 416
        Me.Label2.Text = "Pay Amount"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Appearance.BackColor = System.Drawing.Color.White
        Me.SimpleButton2.Appearance.Options.UseBackColor = true
        Me.SimpleButton2.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.SimpleButton2.Image = CType(resources.GetObject("SimpleButton2.Image"),System.Drawing.Image)
        Me.SimpleButton2.Location = New System.Drawing.Point(304, 213)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(109, 29)
        Me.SimpleButton2.TabIndex = 424
        Me.SimpleButton2.TabStop = false
        Me.SimpleButton2.Text = "Reject Claim"
        '
        'frmclaimpay
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6!, 13!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(840, 257)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.c4)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.SimpleButton7)
        Me.Controls.Add(Me.c3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.c1)
        Me.Controls.Add(Me.c2)
        Me.Controls.Add(Me.t2)
        Me.Controls.Add(Me.t1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label4)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"),System.Drawing.Icon)
        Me.Name = "frmclaimpay"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Vehicle Claim Payment"
        CType(Me.c2.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.c1.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.c3.Properties,System.ComponentModel.ISupportInitialize).EndInit
        CType(Me.c4.Properties,System.ComponentModel.ISupportInitialize).EndInit
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub
    Friend WithEvents t2 As Label
    Friend WithEvents t1 As DevExpress.XtraWaitForm.ProgressPanel
    Friend WithEvents SimpleButton7 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Label4 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents c2 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents c1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label9 As Label
    Friend WithEvents c3 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents c4 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label2 As Label
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
End Class
