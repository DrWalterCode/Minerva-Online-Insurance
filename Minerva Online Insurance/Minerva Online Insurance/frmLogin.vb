Imports System.Configuration
Imports MySql.Data.MySqlClient
Imports System.Configuration.ConfigurationManager
Imports Microsoft.Win32
Imports System.Runtime.InteropServices
Public Class frmLogin
     Dim _con As MySqlConnection
    Dim _cmd As MySqlCommand
    Dim _timercount As Integer = 60 'The number of seconds 
    Dim _lastrecordday As String
    Dim _resultnumber As Integer
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       Changeformat
        checkconnection()
        txtusername.Select()
    End Sub
    Private Sub Checkconnection()
        Try
            Dim connectionString = ConnectionStrings("myConnection").ConnectionString
            _con = New MySqlConnection(connectionString)
            _con.Open()
        Catch ex As Exception
            MsgBox("Failed to establish cloud connection")
            FrmDatabaseSetup.ShowDialog()
        End Try
    End Sub

    Private Sub Changeformat
        Try
             Dim keyName As String =
                Registry.CurrentUser.ToString() & "\Control Panel\International"

        Dim valueName As String = "sShortDate"

        Dim s As String =
                Registry.GetValue(keyName, valueName, String.Empty).ToString()

        Registry.SetValue(keyName, valueName, "dd.MM.yyyy")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Try
            MsgBox("Address cannot be changed for this cloud application",vbInformation,"Notification")
        Catch ex As Exception

        End Try
    End Sub
    Private Sub txtpwd_TextChanged(sender As Object, e As EventArgs) Handles txtpwd.TextChanged
        Login()
    End Sub
    Private Sub Login()
        Try
            Dim connectionString = ConfigurationManager.ConnectionStrings("myConnection").ConnectionString
            _con = New mySqlConnection(connectionString)
            _con.Open()
            _cmd =
                New MySqlCommand(
                    "Select * from users where username like '%" + txtusername.Text.ToString.Replace("'", "''") + "%' and Password = '" + txtpwd.Text.ToString.Replace("'", "''") + "'",
                    _con)
            Dim reader = _cmd.ExecuteReader()
            if reader.Read() = True
                _cmd.Dispose()
                _con.Close()
                lblerror.Visible = True
                lblerror.Text = "Login Successful"
                ProgressPanel1.Visible = True
                Timer2.Interval = 1000
                Timer2.Start()
            Else
                lblerror.Visible = True
                lblerror.Text = "Login Details not yet verified !! "
            End If
            _cmd.Dispose()
            _con.Close()
        Catch ex As Exception
            '_cmd.Dispose()
            _con.Close()
            MsgBox(ex.Message)
        End Try
        _cmd.Dispose()
        _con.Close()
    End Sub
     Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MsgBox("Contact info@minerva.co.zw for assistance")
    End Sub
     Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Label7.Text = _timercount.ToString() 'show the countdown in the label
        If _timercount = 0 Then 'Check to see if it has reached 0, if yes then stop timer and display done
            Timer1.Enabled = False
            Label7.Text = "Done"
        Else 'If timercount is higher then 0 then subtract one from it
            _timercount -= 1
        End If
    End Sub
    Private Sub Label7_TextChanged(sender As Object, e As EventArgs) Handles Label7.TextChanged
        try
             If Label7.Text = "58" Then
            Timer2.Stop()
            _timercount = 60
            ProgressPanel1.Visible = False
            frmHomePage.lblUsername.Text = txtusername.Text
            Label7.Text = ""
            txtusername.Select()
            txtpwd.Text = ""
            txtusername.Text = ""
            txtusername.Text = ""
            lblerror.Visible = False
            Timer2.Stop()
            frmHomePage.ShowDialog()
        End If
       Catch ex As Exception

       End Try
    End Sub

    Private Sub txtusername_TextChanged(sender As Object, e As EventArgs) Handles txtusername.TextChanged
         Try
             _con.Close()
            _con.open
            _cmd = New MySqlCommand("select distinct(usergroup) from users where username='"& txtusername.Text  &"'  ", _con)
            Dim dr as MySqlDataReader = _cmd.ExecuteReader()
           while dr.Read()
               Dim str As String = dr.GetString("usergroup").ToString()
               If String.IsNullOrEmpty(str) Then
               Else
                    frmHomePage.txtusergroup.Text = str
                  End If
                End While
           _cmd.Dispose()
            _con.Close()
        Catch ex As Exception
 '         _cmd.Dispose()
            _con.Close()
        End Try
    End Sub

    Private Sub TileItem1_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem1.ItemClick
        try
            frmQuote.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub
End Class
