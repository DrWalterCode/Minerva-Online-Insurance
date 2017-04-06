Imports System.Configuration
Imports System.IO
Imports MySql.Data.MySqlClient
Imports System.Net.Mail
Public Class frmQuote

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        openport()
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Try
            MsgBox("Address cannot be changed for this cloud application",vbInformation,"Notification")
        Catch ex As Exception

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

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If v1.Text = "" or v1.Text = "" or v4.Text = "" or v11.Text = "" or v14.Text = "" or v16.Text = "" or v17.Text = "" or v5.Text = ""
            MsgBox("Make sure all fields are filled in", , "Missing Parameters")
            Exit Sub
        End If

        Try
  
           Dim sql As String =
                    "INSERT into quotes(Details,ID_Number,Landline,Cell,Fax,Fromdate,Todate,Physical_Address,Postal_Address,Email,Make,Model,Capacity,Year_Manufactured,Price,Dated,Estimated) values (@Details,@ID_Number,@Landline,@Cell,@Fax,@Fromdate,@Todate,@Physical_Address,@Postal_Address,@Email,@Make,@Model,@Capacity,@Year_Manufactured,@Price,@Dated,@Estimated) "
            Dim params() As String =
                    {"Details","ID_Number","Landline","Cell","Fax","Fromdate","Todate","Physical_Address","Postal_Address","Email","Make","Model","Capacity","Year_Manufactured","Price","Dated","Estimated"}
            Dim values() As String =
                    {v1.Text, v2.Text, v3.Text, v4.Text,v5.Text,v6.Text,v7.Text,v8.Text,v9.Text,v10.Text,v11.Text,v12.Text,v13.Text,v14.Text,v15.Text,v16.Text,v17.Text}
            Dim saveupdate As New InsertUpdateData
            saveupdate.SaveUpdateDelete(sql, params, values)
            MsgBox("Quote Sent Successfully")

            Try
                With SerialPort1
                    .WriteLine("AT" & vbCrLf)
                    Threading.Thread.Sleep(1000)
                    .WriteLine("AT+CMGF=1" & vbCrLf) 'Instruct the GSM / GPRS modem to operate in SMS text mode
                    Threading.Thread.Sleep(1000)
                    .WriteLine("AT+CMGS=""" & v4.text & """" & vbCr) 'sender ko no. rakhne ho tyo txtnumber ma 
                    Threading.Thread.Sleep(1000) 'thapeko
                    .WriteLine("Your Vehicle insurance quote has been received. You will be notified once a quote has been generated" & vbCrLf & Chr(26)) 'txtmessage automatic huna parchha haina?
                    'did you get my message?
                End With
            Catch ex As Exception
                MsgBox(ex.Message)
            End try
           Cleartxt
           Catch ex As Exception
           MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub Cleartxt
        v1.Text = ""
        v2.Text = ""
        v3.Text = ""
         v4.Text = ""
        v5.Text = ""
        v6.Text = ""
         v7.Text = ""
        v8.Text = ""
        v9.Text = ""
         v10.Text = ""
        v11.SelectedIndex=-1
        v13.Text = ""
         v12.Text = ""
        v14.Text = ""
        v15.Text = ""
         v16.Text = ""
        v17.Text = ""
        End Sub

    Private Sub frmQuote_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Dispose()
    End Sub
End Class
