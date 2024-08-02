Imports System.Data
Imports System.Data.SqlClient
Public Class studenthome
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim rdr As SqlDataReader



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        con = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Sivangi\OneDrive\Documents\Visual Studio 2012\Projects\librarymanagement\librarymanagement\Database1.mdf;Integrated Security=True")
        con.Open()
        cmd = New SqlCommand("select * from Studentdata where libraryid = '" & TextBox1.Text & " ' ")
        cmd.Connection = con
        rdr = cmd.ExecuteReader()
        If (rdr.Read()) Then
            issue.sid = TextBox1.Text
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        issue.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        drop.Show()
        Me.Hide()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        studentview.Show()
        Me.Hide()
    End Sub
End Class