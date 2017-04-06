Imports System.Configuration
Imports System.IO
Imports MySql.Data.MySqlClient
Imports System.Net.Mail
Public Class NotifyClient
    Dim _con As New MySqlConnection(ConfigurationManager.ConnectionStrings("myConnection").ConnectionString)
    Dim _cmd As MySqlCommand
    Private Sub SimpleButton7_Click(sender As Object, e As EventArgs) Handles SimpleButton7.Click
        if amount.Text=""
            MsgBox("Missing Parameters")
            Exit Sub
        End If

        Try
  
            Try
                With SerialPort1
                    .WriteLine("AT" & vbCrLf)
                    Threading.Thread.Sleep(1000)
                    .WriteLine("AT+CMGF=1" & vbCrLf) 'Instruct the GSM / GPRS modem to operate in SMS text mode
                    Threading.Thread.Sleep(1000)
                    .WriteLine("AT+CMGS=""" & cellnum.text & """" & vbCr) 'sender ko no. rakhne ho tyo txtnumber ma 
                    Threading.Thread.Sleep(1000) 'thapeko
                    .WriteLine("With the Information provided you will be expected to pay $" & amount.Text & " Payments can be sent to this number" & vbCrLf & Chr(26)) 'txtmessage automatic huna parchha haina?
                    'did you get my message?
                End With
            Catch ex As Exception
                MsgBox(ex.Message)
            End try
          Catch ex As Exception
           MsgBox(ex.Message)
        End Try
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
        Try
            namesurname.Text=frmHomePage.namesurname
            cellnum.Text=frmHomePage.cellnum
            txtQuote.Text=frmHomePage.quoteid
            insurance.Text=frmHomePage.insurancetype
        Catch ex As Exception

        End Try
    End Sub
    Public Function GetRandomString(ByVal iLength As Integer) As String
    Dim sResult As String = ""
    Dim rdm As New Random()

    For i As Integer = 1 To iLength
        sResult &= ChrW(rdm.Next(32, 126))
    Next

    Return sResult
End Function

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        Try
            Dim msgfrom1 As String = TextBox1.Text.Substring(9, 13)
            msgfrom.Text = msgfrom1
            Dim datemsg As String = TextBox1.Text.Substring(26, 8)
            msgdate.Text = datemsg
            Dim timemsg As String = TextBox1.Text.Substring(35, 8)
            msgtime.Text = timemsg

            Dim strText() As String
            strText = Split(TextBox1.Text, vbCrLf)
            walle.Text = strText(2)

            If walle.Text = "" Then
                Exit Sub
            End If

            If Double.TryParse(walle.Text, walle.Text) Then
            Else
                'MessageBox.Show("The amount entered is not numeric. Please add a numeric amount.")
                Exit Sub
            End If



            If (CDbl(amount.Text)<= CDbl(walle.Text)) Then
             

                If CDbl(walle.Text) < CDbl(amount.Text) Then
                    'MsgBox("x")
                    ' MsgBox(phone)
                    With SerialPort1
                        .WriteLine("AT" & vbCrLf)
                        Threading.Thread.Sleep(1000)
                        .WriteLine("AT+CMGF=1" & vbCrLf) 'Instruct the GSM / GPRS modem to operate in SMS text mode
                        Threading.Thread.Sleep(1000)
                        .WriteLine("AT+CMGS=""" & msgfrom.Text & """" & vbCr) 'sender ko no. rakhne ho tyo txtnumber ma 
                        Threading.Thread.Sleep(1000) 'thapeko
                        .WriteLine("Minerva Does not accept part payments. Please pay in full" & vbCrLf & Chr(26)) 'txtmessage automatic huna parchha haina?
                        'did you get my message?
                    End With
                ElseIf CDbl(walle.Text) > CDbl(amount.Text)
                    _con.Close()
                    _con.Open()
                    _cmd = New mysqlCommand("Insert into payments(paymentfrom,paymentdate,paymenttime,amount) values ('" + msgfrom.Text + "','" + msgdate.Text + "','" + msgtime.Text + "','" + walle.Text + "')", _con)
                    _cmd.ExecuteNonQuery()
                    _con.Close()

                    _con.Close()
             _con.Open()
             _cmd = New mysqlCommand("update quotes set status ='Paid'  where Quote_ID='" + txtQuote.text + "' ", _con)
             _cmd.ExecuteNonQuery()
             _cmd.Dispose()
             _con.Close()
                    Dim cell as String=msgfrom.Text

                     dim username as String = Now.Hour & Now.Millisecond & Now.Minute
                    dim password as String = GetRandomString(6)
                    Dim sql As String =
                            "INSERT into users(usergroup,username,password,phone) values (@usergroup,@username,@password,@phone) "
                    Dim params() As String =
                            {"usergroup", "username", "password", "phone"}
                    Dim values() As String =
                            {"CLIENT", username, password, cellnum.Text}
                    Dim saveupdate As New InsertUpdateData
                    saveupdate.SaveUpdateDelete(sql, params, values)

                    Dim change As Double = cdbl(walle.Text) - CDbl(amount.Text)
                    With SerialPort1
                        .WriteLine("AT" & vbCrLf)
                        Threading.Thread.Sleep(3000)
                        .WriteLine("AT+CMGF=1" & vbCrLf) 'Instruct the GSM / GPRS modem to operate in SMS text mode
                        Threading.Thread.Sleep(3000)
                        .WriteLine("AT+CMGS=""" & msgfrom.Text & """" & vbCr) 'sender ko no. rakhne ho tyo txtnumber ma 
                        Threading.Thread.Sleep(3000) 'thapeko
                        .WriteLine("Payment received. Your change is $ " & change & " and your login credentials are as follows : username- " & username & " and password- "& password  & vbCrLf & Chr(26)) 'txtmessage automatic huna parchha haina?
                        'did you get my message?
                    End With
                    
                ElseIf cdbl(walle.Text) = CDbl(amount.Text)

                     dim username as String = Now.Hour & Now.Millisecond & Now.Minute
                    dim password as String = GetRandomString(6)
                    Dim sql As String =
                            "INSERT into users(usergroup,username,password,phone) values (@usergroup,@username,@password,@phone) "
                    Dim params() As String =
                            {"usergroup", "username", "password", "phone"}
                    Dim values() As String =
                            {"CLIENT", username, password, cellnum.Text}
                    Dim saveupdate As New InsertUpdateData
                    saveupdate.SaveUpdateDelete(sql, params, values)
                    Dim cell as String=msgfrom.Text
                    With SerialPort1
                        .WriteLine("AT" & vbCrLf)
                        Threading.Thread.Sleep(3000)
                        .WriteLine("AT+CMGF=1" & vbCrLf) 'Instruct the GSM / GPRS modem to operate in SMS text mode
                        Threading.Thread.Sleep(3000)
                        .WriteLine("AT+CMGS=""" & msgfrom.Text & """" & vbCr) 'sender ko no. rakhne ho tyo txtnumber ma 
                        Threading.Thread.Sleep(3000) 'thapeko
                        .WriteLine("Payment received of $ " & walle.Text & "and your login credentials are as follows : username- " & username & " and password- "& password  & vbCrLf & Chr(26)) 'txtmessage automatic huna parchha haina?
                        'did you get my message?
                    End With

                   Else
                    With SerialPort1
                        .WriteLine("AT" & vbCrLf)
                        Threading.Thread.Sleep(3000)
                        .WriteLine("AT+CMGF=1" & vbCrLf) 'Instruct the GSM / GPRS modem to operate in SMS text mode
                        Threading.Thread.Sleep(3000)
                        .WriteLine("AT+CMGS=""" & msgfrom.Text & """" & vbCr) 'sender ko no. rakhne ho tyo txtnumber ma 
                        Threading.Thread.Sleep(1000) 'thapeko
                        .WriteLine("Invalid payment. please retry " & vbCrLf & Chr(26)) 'txtmessage automatic huna parchha haina?
                        'did you get my message?
                    End With
                End If


                ' MsgBox("successful")
            Else

                With SerialPort1
                    .WriteLine("AT" & vbCrLf)
                    Threading.Thread.Sleep(1000)
                    .WriteLine("AT+CMGF=1" & vbCrLf) 'Instruct the GSM / GPRS modem to operate in SMS text mode
                    Threading.Thread.Sleep(1000)
                    .WriteLine("AT+CMGS=""" & msgfrom.Text & """" & vbCr) 'sender ko no. rakhne ho tyo txtnumber ma 
                    Threading.Thread.Sleep(1000) 'thapeko
                    .WriteLine("Invalid payment. please retry " & vbCrLf & Chr(26)) 'txtmessage automatic huna parchha haina?
                    'did you get my message?
                End With
            End If
        Catch ex As Exception
            _con.Close()
            ' MsgBox(ex.Message)
        End Try
    End Sub
     Private Sub SerialPort1_DataReceived(sender As Object, e As Ports.SerialDataReceivedEventArgs) Handles SerialPort1.DataReceived
        Me.CheckForIllegalCrossThreadCalls = False
        TextBox1.Text = ""
        'Pause while all data Is read
        System.Threading.Thread.Sleep(300)
        Dim rcvdata As String = CStr(SerialPort1.ReadExisting())
        TextBox1.Text = rcvdata
        '  AppendTextBox(TextBox1, rcvdata)
        rcvdata = ""
    End Sub

    Private Sub NotifyClient_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        frmHomePage.Loadgridquotations
        Dispose()
    End Sub
End Class