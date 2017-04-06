Imports System.Configuration
Imports System.IO
Imports MySql.Data.MySqlClient
Imports System.Net.Mail
Public Class frmClaim
    Dim _con As New MySqlConnection(ConfigurationManager.ConnectionStrings("myConnection").ConnectionString)
    Dim _cmd As MySqlCommand
    Private Sub SimpleButton7_Click(sender As Object, e As EventArgs) Handles SimpleButton7.Click
        dim cell as String
        if c4.Text="" or c5.Text="" or c1.Text=""
            MsgBox("Missing Parameters")
            Exit Sub
        End If

        Try
             _con.Close()
                    _con.Open()
                    _cmd = New mysqlCommand("Select phone from users where username='" & frmHomePage.lblUsername.Text & "'", _con)
                    cell =_cmd.ExecuteScalar()
                    _con.Close()
        Catch ex As Exception
_con.Close()
            msgbox(ex.Message)
        End Try

        'Try
        '     _con.Close()
        '            _con.Open()
        '            _cmd = New mysqlCommand("Insert into claims(incident,surface,vehicles,damage,policefile,cell) values ('" + c1.Text + "','" + c2.Text + "','" + c3.Text + "','" + c4.Text + "','" + c5.Text + "','" + cell + "')", _con)
        '            _cmd.ExecuteNonQuery()
        '            _con.Close()
        'Catch ex As Exception

        'End Try
         Dim sql As String =
                   "Insert into claims(incident,surface,vehicles,damage,policefile,cell) values (@incident,@surface,@vehicles,@damage,@policefile,@cell)"
                    Dim params() As String =
                    {"incident","surface","vehicles","damage","policefile","cell"}
            Dim values() As String =
                    {c1.Text,c2.Text,c3.Text,c4.Text,c5.Text,cell}
            Dim saveupdate As New InsertUpdateData
            saveupdate.SaveUpdateDelete(sql, params, values)
            'MsgBox("Quote Sent Successfully")
         

        Try
  
            Try
                With SerialPort1
                    .WriteLine("AT" & vbCrLf)
                    Threading.Thread.Sleep(1000)
                    .WriteLine("AT+CMGF=1" & vbCrLf) 'Instruct the GSM / GPRS modem to operate in SMS text mode
                    Threading.Thread.Sleep(1000)
                    .WriteLine("AT+CMGS=""" & cell & """" & vbCr) 'sender ko no. rakhne ho tyo txtnumber ma 
                    Threading.Thread.Sleep(1000) 'thapeko
                    .WriteLine("Your  claim has been received and is being processed" & vbCrLf & Chr(26)) 'txtmessage automatic huna parchha haina?
                    'did you get my message?
                End With
            Catch ex As Exception
                MsgBox(ex.Message)
            End try
          Catch ex As Exception
           MsgBox(ex.Message)
        End Try

        MsgBox("claim sent successfully")
        dispose
    End Sub
     Private Sub openport()
        If SerialPort1.IsOpen Then
            SerialPort1.Close()
            ' BtnConnect.Text = "Connect"
        Else
            Try
                With SerialPort1
                    .PortName = Trim(Mid("COM4", 1, 5))
                    .BaudRate = 9600
                    .Parity = IO.Ports.Parity.None
                    .DataBits = 8
                    .StopBits = Ports.StopBits.One
                    .Handshake = Ports.Handshake.None
                    .RtsEnable = True
                    .DtrEnable = True
                    .Open()
                    .WriteLine("AT+CNMI=1,2,0,0,0" & vbCrLf) 'send whatever data that it receives to serial port  
                End With
                t1.Visible = True
                t2.Visible = True
                'BtnConnect.Text = "Disconnect"
            Catch ex As Exception
                t1.Visible = False
                t2.Visible = False
                MsgBox(ex.Message)
            End Try
        End If
    End Sub

    Private Sub NotifyClient_Load(sender As Object, e As EventArgs) Handles MyBase.Load
         openport()
        End Sub
    Public Function GetRandomString(ByVal iLength As Integer) As String
    Dim sResult As String = ""
    Dim rdm As New Random()

    For i As Integer = 1 To iLength
        sResult &= ChrW(rdm.Next(32, 126))
    Next

    Return sResult
End Function

    Private Sub NotifyClient_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
       Dispose()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
      Dim ofd As New OpenFileDialog
        If ofd.ShowDialog = DialogResult.OK AndAlso ofd.FileName <> "" Then
            c5.Text= ofd.FileName
            End If
    End Sub
End Class