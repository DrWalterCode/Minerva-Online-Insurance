Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'comment
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Try
            MsgBox("Address cannot be changed for this cloud application",vbInformation,"Notification")
        Catch ex As Exception

        End Try
    End Sub
End Class
