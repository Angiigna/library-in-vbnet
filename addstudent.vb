Imports System.Data
Imports System.Data.SqlClient
Public Class addstudent
    Public Shared bookcount As Integer = 0
    Dim studentcount As Integer
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim rdr As SqlDataReader
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        
        
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        studentcount = Int((20 * Rnd()) + 1)
        Try
            con = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Sivangi\OneDrive\Documents\Visual Studio 2012\Projects\librarymanagement\librarymanagement\Database1.mdf;Integrated Security=True")
            con.Open()
            cmd = New SqlCommand("insert into Studentdata(libraryid, studentname, registernumber,contactnumber,noofbooks) values('" & studentcount & " ', '" & TextBox1.Text & "', '" & TextBox2.Text & "', '" & TextBox3.Text & "', '" & bookcount & "') ")
            cmd.Connection = con
            rdr = cmd.ExecuteReader()
            MsgBox("Your data has been saved successfully" & studentcount)
            con.Close()
            studentcount += 1
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        adminhome.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TextBox1.Text = " "
        TextBox2.Text = " "
        TextBox3.Text = " "
    End Sub
End Class