Imports System.Configuration
Imports MySql.Data.MySqlClient

Public Class frmreports
     Dim _con As New MySqlConnection(ConfigurationManager.ConnectionStrings("myConnection").ConnectionString)
    Dim _cmd As MySqlCommand
    Private Sub TabPane1_SelectedPageIndexChanged(sender As Object, e As EventArgs) _
        Handles TabPane1.SelectedPageIndexChanged
        try
            Select Case TabPane1.SelectedPageIndex
                Case 0
                Dim report As New quotes
                Me.DocumentViewer1.DocumentSource = report
                report.CreateDocument(False)
                    
                Case 1
                    Dim report As New users
                Me.DocumentViewer2.DocumentSource = report
                report.CreateDocument(False)
                Case 2
                     Dim report As New claims
                Me.DocumentViewer3.DocumentSource = report
                report.CreateDocument(False)
                  Case 3
                     Dim report As New payments
                Me.DocumentViewer4.DocumentSource = report
                report.CreateDocument(False)
                End Select
        Catch ex As Exception

        End Try
    End Sub
    Private Sub frmreports_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
