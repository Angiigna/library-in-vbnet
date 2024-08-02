Imports System.Data
Imports System.Data.SqlClient
Public Class drop
    Dim con As SqlConnection
    Dim con1 As SqlConnection
    Dim cmd As SqlCommand
    Dim cmd1 As SqlCommand
    Dim rdr As SqlDataReader
    Dim rdr1 As SqlDataReader
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            con = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Sivangi\OneDrive\Documents\Visual Studio 2012\Projects\librarymanagement\librarymanagement\Database1.mdf;Integrated Security=True")
            con.Open()
            cmd = New SqlCommand("delete from Isuuedbooks where bookid = '" & TextBox1.Text & "' ")
            cmd.Connection = con
            rdr = cmd.ExecuteReader()
            MsgBox("Book has been returned")
            con.Close()
            con1 = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Sivangi\OneDrive\Documents\Visual Studio 2012\Projects\librarymanagement\librarymanagement\Database1.mdf;Integrated Security=True")
            con1.Open()
            cmd1 = New SqlCommand("update Studentdata set noofbooks -= 1 where libraryid = '" & issue.sid & "'")
            cmd1.Connection = con1
            rdr1 = cmd1.ExecuteReader()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub
End Class