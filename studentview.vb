Imports System.Data.SqlClient
Public Class studentview
    Dim con As SqlConnection
    Dim cmd As SqlCommand
    Dim rdr As SqlDataReader
    Dim issueddate As String
    Dim duedate As Date

    Dim d As String

    Private Sub studentview_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet2.Isuuedbooks' table. You can move, or remove it, as needed.
        Me.IsuuedbooksTableAdapter.Fill(Me.Database1DataSet2.Isuuedbooks)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TextBox2.Text = issue.duedate
    End Sub
End Class