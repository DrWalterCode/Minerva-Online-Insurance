Imports System.Configuration
Imports System.IO
Imports MySql.Data.MySqlClient
Imports System.Net.Mail
Public Class frmclaimpay
    Dim _con As New MySqlConnection(ConfigurationManager.ConnectionStrings("myConnection").ConnectionString)
    Dim _cmd As MySqlCommand
    Private Sub SimpleButton7_Click(sender As Object, e As EventArgs) Handles SimpleButton7.Click
        dim cell as String
        if c3.Text="" or c2.Text="" or c4.Text=""
            MsgBox("Missing Parameters")
            Exit Sub
        End If

       Try
             _con.Close()
                    _con.Open()
                    _cmd = New mysqlCommand("Update claims set paid='" + c4.Text + "' , status='Paid' where claim_ID='" + c2.Text + "' ", _con)
                    _cmd.ExecuteNonQuery()
                    _con.Close()
        Catch ex As Exception

        End Try

         

        Try
  
            Try
                With SerialPort1
                    .WriteLine("AT" & vbCrLf)
                    Threading.Thread.Sleep(1000)
                    .WriteLine("AT+CMGF=1" & vbCrLf) 'Instruct the GSM / GPRS modem to operate in SMS text mode
                    Threading.Thread.Sleep(1000)
                    .WriteLine("AT+CMGS=""" & c1.Text & """" & vbCr) 'sender ko no. rakhne ho tyo txtnumber ma 
                    Threading.Thread.Sleep(1000) 'thapeko
                    .WriteLine("Your claim has been paid. Your account has been credited with $ " & c4.Text & vbCrLf & Chr(26)) 'txtmessage automatic huna parchha haina?
                    'did you get my message?
                End With
            Catch ex As Exception
                MsgBox(ex.Message)
            End try
          Catch ex As Exception
           MsgBox(ex.Message)
        End Try

        MsgBox("claim paid successfully")
        frmHomePage.Loadgridpendingclaims
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
        c1.Text=frmHomePage.cellnum
        c2.Text=frmHomePage.claimid
        c3.Text=frmHomePage.policepath

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
        If System.IO.File.Exists(c3.Text) = True Then
            Process.Start(c3.Text)
        Else
            MsgBox("Police File Does Not Exist")
        End If
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        dim cell as String
        if c3.Text="" or c2.Text="" or c1.Text=""
            MsgBox("Missing Parameters")
            Exit Sub
        End If

       Try
             _con.Close()
                    _con.Open()
                    _cmd = New mysqlCommand("Update claims set paid='0' , status='Rejected' where claim_ID='" + c2.Text + "' ", _con)
                    _cmd.ExecuteNonQuery()
                    _con.Close()
        Catch ex As Exception

        End Try

         

        Try
  
            Try
                With SerialPort1
                    .WriteLine("AT" & vbCrLf)
                    Threading.Thread.Sleep(1000)
                    .WriteLine("AT+CMGF=1" & vbCrLf) 'Instruct the GSM / GPRS modem to operate in SMS text mode
                    Threading.Thread.Sleep(1000)
                    .WriteLine("AT+CMGS=""" & c1.Text & """" & vbCr) 'sender ko no. rakhne ho tyo txtnumber ma 
                    Threading.Thread.Sleep(1000) 'thapeko
                    .WriteLine("Your claim has been rejected. Your account has been credited with $0.00" & vbCrLf & Chr(26)) 'txtmessage automatic huna parchha haina?
                    'did you get my message?
                End With
            Catch ex As Exception
                MsgBox(ex.Message)
            End try
          Catch ex As Exception
           MsgBox(ex.Message)
        End Try

        MsgBox("claim rejected successfully")
        frmHomePage.Loadgridpendingclaims
        dispose
    End Sub
End Class