Imports System.Data
Imports System.Data.SqlClient
Public Class addbook
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim rdr As SqlDataReader
    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            con = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Sivangi\OneDrive\Documents\Visual Studio 2012\Projects\librarymanagement\librarymanagement\Database1.mdf;Integrated Security=True")
            con.Open()
            cmd = New SqlCommand("insert into Booklist(bookid, bookname, authorname) values('" & TextBox1.Text & "', '" & TextBox2.Text & "', '" & TextBox3.Text & "') ")
            cmd.Connection = con
            rdr = cmd.ExecuteReader()
            MsgBox("Your data has been saved successfully")
            con.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
        adminhome.Show()
    End Sub
End Class