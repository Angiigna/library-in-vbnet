Public Class viewdetails

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub viewdetails_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.Isuuedbooks' table. You can move, or remove it, as needed.
        Me.IsuuedbooksTableAdapter.Fill(Me.Database1DataSet.Isuuedbooks)

    End Sub
End Class