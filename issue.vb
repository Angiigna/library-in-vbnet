Imports System.Data
Imports System.Data.SqlClient
Public Class issue
    Dim con As SqlConnection
    Dim con1 As SqlConnection
    Dim con2 As SqlConnection
    Dim con3 As SqlConnection
    Dim cmd As SqlCommand
    Dim cmd1 As SqlCommand
    Dim cmd2 As SqlCommand
    Dim cmd3 As SqlCommand
    Dim rdr As SqlDataReader
    Dim rdr1 As SqlDataReader
    Dim rdr2 As SqlDataReader
    Dim rdr3 As SqlDataReader
    Public Shared sid As Integer
    Public Shared user As String
    Dim temp As String
    Dim enters As String
    Dim enterdue As String
    Public Shared s As Date
    Public Shared duedate As Date
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            con = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Sivangi\OneDrive\Documents\Visual Studio 2012\Projects\librarymanagement\librarymanagement\Database1.mdf;Integrated Security=True")
            con.Open()
            s = Date.Now
            Label2.Text = s
            enters = s.ToString
            duedate = s.AddDays(7)
            enterdue = duedate.ToString
            user = "select noofbooks from Studentdata where libraryid = '" & sid & "'"
            cmd = New SqlCommand(user, con)
            temp = cmd.ExecuteScalar()
            con.Close()
            If temp = "5" Then
                MsgBox("Exceeded limit")
            Else
                con1 = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Sivangi\OneDrive\Documents\Visual Studio 2012\Projects\librarymanagement\librarymanagement\Database1.mdf;Integrated Security=True")
                con1.Open()
                cmd1 = New SqlCommand("insert into Isuuedbooks(bookid, libraryid, date,duedate) values('" & TextBox1.Text & "', '" & sid & "', '" & enters & "', '" & enterdue & "') ")
                cmd1.Connection = con1
                rdr1 = cmd1.ExecuteReader()
                MsgBox("Your data has been saved successfully")
                con1.Close()
                con2 = New SqlConnection("Data Source=(LocalDB)\v11.0;AttachDbFilename=C:\Users\Sivangi\OneDrive\Documents\Visual Studio 2012\Projects\librarymanagement\librarymanagement\Database1.mdf;Integrated Security=True")
                con2.Open()
                cmd2 = New SqlCommand("update Studentdata set noofbooks += 1 where libraryid = '" & sid & "'")
                cmd2.Connection = con2
                rdr2 = cmd2.ExecuteReader()
                con2.Close()
                
                
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub issue_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet3.Booklist' table. You can move, or remove it, as needed.
        Me.BooklistTableAdapter1.Fill(Me.Database1DataSet3.Booklist)

    End Sub
End Class