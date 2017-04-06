Imports System.Configuration
Imports MySql.Data.MySqlClient

Public Class frmHomePage
     Dim _con As New MySqlConnection(ConfigurationManager.ConnectionStrings("myConnection").ConnectionString)
    Dim _cmd As MySqlCommand
    Dim menuchosen as String
     Dim logintime As String
     Dim logindate As String
     Public username As String
    Public realcoID as String

    Public cellnum as String
    Public namesurname as String
    Public insurancetype as String
    Public quoteid as String

    Public policepath as String
    Public claimid as String
    
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
       
        Try
            _con.Open()
            Dim logoutdate As String = "LOGGED IN"
            Dim logout As String = "LOGGED IN"
            logintime= Now.ToLongTimeString
           logindate = Now.Date.ToString("dd/MM/yyyy")
            timeIn.Text = logintime
            dateIn.Text = logindate
            _cmd =
                New MySqlCommand(
                    "INSERT into LogTransactions(loginDate,loginTime,logoutDate,logoutTime,username) values ('" +
                    logindate + "','" + logintime + "','" + logoutdate + "','" + logout + "','" + lblUsername.Text +
                    "') ", _con)
            _cmd.ExecuteReader(CommandBehavior.CloseConnection)
            _cmd.Dispose()
            _con.Close()
        Catch ex As Exception
            _cmd.Dispose()
            _con.Close()
            'MsgBox(ex.Message)
        End Try

        Timer2.Start()
        Loadgrid()
        Loadgridquotations()
        Timer1.Start()
        Loadgridpayments()
        Loadgridpendingclaims()
        Loadgridclaims()
    End Sub
     Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        if txtusergroup.Text="ADMIN"
            NavigationPage3.PageVisible=False
            NavigationPage4.PageVisible=True
            NavigationPage2.PageVisible=True

        End If

         if txtusergroup.Text="AGENT"
            NavigationPage3.PageVisible=False
            NavigationPage4.PageVisible=True
            NavigationPage2.PageVisible=False
        End If

        if txtusergroup.Text="CLIENT"
            NavigationPage3.PageVisible=True
            NavigationPage4.PageVisible=False
            NavigationPage2.PageVisible=False
        End If 
    End Sub

    
     Private Sub FrmMain_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        _cmd.Dispose()
        _con.Close()
        Try
            _con.Open()
           Dim logout As String = Now.ToLongTimeString
            Dim logoutdate As String = Now.Date.ToString("dd/MM/yyyy")
           _cmd =
                New mySQLCommand(
                    "UPDATE LogTransactions set logoutDate='" + logoutdate + "',logoutTime='" + logout + "' where username='" + username +
                    "' and loginDate='" + logindate + "' and loginTime='"+ logintime +"'", _con)
            _cmd.ExecuteNonQuery()
            _cmd.Dispose()
            _con.Close()

            Dispose()
        Catch ex As Exception
            _cmd.Dispose()
            _con.Close()
            MsgBox(ex.Message)
        End Try
       'FrmLogin.Show()
         
    End Sub

    Private Sub TileItem2_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs)

    End Sub

    Private Sub SimpleButton7_Click(sender As Object, e As EventArgs) Handles SimpleButton7.Click
         If txtUsername.Text = "" Or txtPassword.Text = "" Or TextBox1.Text = "" Then
            MsgBox("missing parameters")
            Exit Sub
        End If

        if txtUsername.Enabled=True
             Try
           _con.Open()
            _cmd = New mysqlCommand("INSERT into users(usergroup,UserName,Password,Email,Surname,Forename,Phone) values ('" & txtgroup.Text & "','" & txtUsername.Text & "', '" & txtPassword.Text & "','" + Email_addressTextBox.Text.ToLower + "', '" & txtsurname.Text.ToString.Replace("'", "''") & "', '" & txtforename.Text.ToString.Replace("'", "''") & "', '" & txtphonenumber.Text & "')", _con)
            _cmd.ExecuteReader(CommandBehavior.CloseConnection)
            _cmd.Dispose()
            _con.Close()
            MsgBox("User Details Saved")
            loadgrid()
            TabPane2.SelectedPageIndex = 1
        Catch ex As Exception
            _cmd.Dispose()
            _con.Close()
            MessageBox.Show(ex.Message, "Error")
        End Try
            Else 
           Try
            _con.Open()
            _cmd = New mysqlcommand("update users set usergroup='" + txtgroup.Text + "', Email='" + Email_addressTextBox.Text + "',Surname='" + txtsurname.Text + "',Forename='" + txtforename.Text + "',Phone='" + txtphonenumber.Text + "',password='" + txtPassword.Text + "' where UserName='" + txtUsername.Text + "' ", _con)
            _cmd.ExecuteReader(CommandBehavior.CloseConnection)
            _cmd.Dispose()
            _con.Close()
            MessageBox.Show("Record Updated")
                txtUsername.Enabled=True
                 SimpleButton6.Enabled = False
           loadgrid()
                 TabPane2.SelectedPageIndex = 1
        Catch ex As Exception
             _cmd.Dispose()
            _con.Close()
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        End If
       

    End Sub
    Private Sub DataGridView1_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellDoubleClick
        Try
            Dim dr As DataGridViewRow = DataGridView1.SelectedRows(0)
            txtgroup.Text = dr.Cells(1).Value.ToString
            txtUsername.Text = dr.Cells(2).Value.ToString
            txtPassword.Text = dr.Cells(3).Value.ToString
            TextBox1.Text = dr.Cells(3).Value.ToString
            Email_addressTextBox.Text = dr.Cells(4).Value.ToString
            txtforename.Text = dr.Cells(6).Value.ToString
            txtsurname.Text = dr.Cells(5).Value.ToString
            txtphonenumber.Text = dr.Cells(7).Value.ToString
            txtUsername.Enabled = False
            SimpleButton7.Enabled = True
            TabPane2.SelectedPageIndex = 0
        Catch ex As Exception

        End Try
    End Sub
    Private Sub Loadgrid()
        _con.Close()
        Try
            _con.Open()
            _cmd = New mysqlCommand("select * from users ", _con)
            Dim myda2 As mysqlDataAdapter = New mysqlDataAdapter(_cmd)
            Dim mydataset2 As DataSet = New DataSet
            myda2.Fill(mydataset2, "users")
            DataGridView1.DataSource = mydataset2.Tables("users").DefaultView
             DataGridView1.FirstDisplayedScrollingRowIndex=DataGridView1.RowCount-1
            DataGridView1.Rows(DataGridView1.RowCount-1).Selected=True
            DataGridView1.CurrentCell=DataGridView1.Rows(DataGridView1.RowCount-1).Cells(0)
            _con.Close()
        Catch ex As Exception
            _con.Close()
           ' MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Loadgridquotations()
        _con.Close()
        Try
            _con.Open()
            _cmd = New mysqlCommand("select * from quote_view ", _con)
            Dim myda2 As mysqlDataAdapter = New mysqlDataAdapter(_cmd)
            Dim mydataset2 As DataSet = New DataSet
            myda2.Fill(mydataset2, "quote_view")
            DataGridView2.DataSource = mydataset2.Tables("quote_view").DefaultView
             DataGridView2.FirstDisplayedScrollingRowIndex=DataGridView2.RowCount-1
            DataGridView2.Rows(DataGridView2.RowCount-1).Selected=True
            DataGridView2.CurrentCell=DataGridView2.Rows(DataGridView2.RowCount-1).Cells(0)
            _con.Close()
        Catch ex As Exception
            _con.Close()
           ' MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Loadgridpayments()
        _con.Close()
        Try
            _con.Open()
            _cmd = New mysqlCommand("select * from payment_view where username='"& lblUsername.Text &"' ", _con)
            Dim myda2 As mysqlDataAdapter = New mysqlDataAdapter(_cmd)
            Dim mydataset2 As DataSet = New DataSet
            myda2.Fill(mydataset2, "payment_view")
            dgvpaymenthistory.DataSource = mydataset2.Tables("payment_view").DefaultView
             dgvpaymenthistory.FirstDisplayedScrollingRowIndex=dgvpaymenthistory.RowCount-1
            dgvpaymenthistory.Rows(dgvpaymenthistory.RowCount-1).Selected=True
            dgvpaymenthistory.CurrentCell=dgvpaymenthistory.Rows(dgvpaymenthistory.RowCount-1).Cells(0)
            _con.Close()
        Catch ex As Exception
            _con.Close()
           ' MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Loadgridclaims()
        _con.Close()
        Try
            _con.Open()
            _cmd = New mysqlCommand("select * from claims_view where username='"& lblUsername.Text &"' ", _con)
            Dim myda2 As mysqlDataAdapter = New mysqlDataAdapter(_cmd)
            Dim mydataset2 As DataSet = New DataSet
            myda2.Fill(mydataset2, "claims_view")
            dgvclaims.DataSource = mydataset2.Tables("claims_view").DefaultView
             dgvclaims.FirstDisplayedScrollingRowIndex=dgvclaims.RowCount-1
            dgvclaims.Rows(dgvclaims.RowCount-1).Selected=True
            dgvclaims.CurrentCell=dgvclaims.Rows(dgvclaims.RowCount-1).Cells(0)
            _con.Close()
        Catch ex As Exception
            _con.Close()
           ' MsgBox(ex.Message)
        End Try
    End Sub

    Public Sub Loadgridpendingclaims()
        _con.Close()
        Try
            _con.Open()
            _cmd = New mysqlCommand("select * from claims_view where status='Pending' ", _con)
            Dim myda2 As mysqlDataAdapter = New mysqlDataAdapter(_cmd)
            Dim mydataset2 As DataSet = New DataSet
            myda2.Fill(mydataset2, "claims_view")
            pendingclaims.DataSource = mydataset2.Tables("claims_view").DefaultView
             pendingclaims.FirstDisplayedScrollingRowIndex=pendingclaims.RowCount-1
            pendingclaims.Rows(pendingclaims.RowCount-1).Selected=True
            pendingclaims.CurrentCell=pendingclaims.Rows(pendingclaims.RowCount-1).Cells(0)
            _con.Close()
        Catch ex As Exception
            _con.Close()
           ' MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub DataGridView2_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView2.CellDoubleClick
        Try
            Dim dr As DataGridViewRow = DataGridView2.SelectedRows(0)
            cellnum = dr.Cells(4).Value.ToString
            namesurname = dr.Cells(1).Value.ToString
            insurancetype = "PRIVATE MOTOR CAR INSURANCE"       
            quoteid= dr.Cells(0).Value.ToString

            NotifyClient.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
         Try
            Dim myForm As New FrmChangePassword() 'go to the menu after logging in
            'Me.Hide() ' temporarily hide the log in form
            myForm.txtUsername.Text = lblUsername.Text
            myForm.ShowDialog()
            'Me.Show()  ' when user closes the menu, show the form again
            'FrmTransactions2.ShowDialog()
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TileBarItem1_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileBarItem1.ItemClick
        frmQuote.ShowDialog()
    End Sub

    Private Sub TileBarItem4_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileBarItem4.ItemClick
        frmClaim.ShowDialog()
    End Sub

    Private Sub pendingclaims_CellDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles pendingclaims.CellDoubleClick
         Try
            Dim dr As DataGridViewRow = pendingclaims.SelectedRows(0)
            cellnum = dr.Cells(8).Value.ToString
            policepath = dr.Cells(5).Value.ToString
         claimid= dr.Cells(0).Value.ToString

            frmclaimpay.ShowDialog()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub TileItem2_ItemClick_1(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem2.ItemClick
     If (Not System.IO.Directory.Exists("C:\SystemBackups")) Then
            System.IO.Directory.CreateDirectory("C:\SystemBackups")
        End If
        _cmd.Connection = _con
        _con.Open
        Dim mb As MySqlBackup = New MySqlBackup(_cmd)
        Dim filename as String="C:\SystemBackups\backup" & Now.ToShortDateString() &".sql"
        mb.ExportToFile(filename)
        _con.Close
        MsgBox("Backup Successful check C:\SystemBackups for backedup file")
    End Sub

    Private Sub TileItem6_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem6.ItemClick
        If (Not System.IO.Directory.Exists("C:\SystemBackups")) Then
            System.IO.Directory.CreateDirectory("C:\SystemBackups")
        End If
        _cmd.Connection = _con
        _con.Open
        Dim mb As MySqlBackup = New MySqlBackup(_cmd)
        Dim ofd As New OpenFileDialog
        dim filename as String
        If ofd.ShowDialog = DialogResult.OK AndAlso ofd.FileName <> "" Then
            filename= ofd.FileName
            End If
        mb.ImportFromFile(filename)
        _con.Close
        MsgBox("Restore Successful")
    End Sub

    Private Sub TileItem5_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem5.ItemClick
        frmreports.ShowDialog()
    End Sub

    Private Sub TileItem1_ItemClick(sender As Object, e As DevExpress.XtraEditors.TileItemEventArgs) Handles TileItem1.ItemClick
         If MsgBox("Are you sure you want to refresh by clearing all system data", vbInformation + MsgBoxStyle.YesNo, "Caution") = MsgBoxResult.No Then
               MsgBox("Cancelled")
            Else 
                try

                    _con.Close()
                    _con.Open()
                    Dim admin As String = "DELETE from users where username <> 'Admin'"
                    Dim quotes As String = "TRUNCATE TABLE  quotes"
                    Dim payments As String = "TRUNCATE TABLE  payments"
                    Dim logtransactions As String = "TRUNCATE TABLE  logtransactions"
                    Dim claims As String = "TRUNCATE TABLE  claims"
                    Dim queryString As String = String.Concat(admin, ";", quotes, ";", payments, ";", logtransactions, ";", claims)
                    _cmd =
                        new MySqlCommand(queryString, _con)
                    _cmd.ExecuteNonQuery()
                    _cmd.Dispose()
                    _con.Close()
                MsgBox("Minerva system has been successfully refreshed", vbInformation, "Success")
               Catch ex As Exception
                 _cmd.Dispose()
                    _con.Close()
                MsgBox(ex.Message)
                End Try
            Exit Sub
        End If
        Loadgrid()
        Loadgridquotations()
        Loadgridpayments()
        Loadgridpendingclaims()
        Loadgridclaims()
        
    End Sub
   
End Class
