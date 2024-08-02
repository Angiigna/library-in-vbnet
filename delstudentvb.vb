Imports System.Data
Imports System.Data.SqlClient
Public Class delstudentvb
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim rdr As SqlDataReader
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            con = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Sivangi\OneDrive\Documents\Visual Studio 2012\Projects\librarymanagement\librarymanagement\Database1.mdf;Integrated Security=True")
            con.Open()
            cmd = New SqlCommand("delete from Studentdata where libraryid = '" & TextBox1.Text & "' ")
            cmd.Connection = con
            rdr = cmd.ExecuteReader()
            MsgBox("Student has been removed")
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