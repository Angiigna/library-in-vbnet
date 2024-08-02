Public Class mainhome

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        adminhome.show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        studenthome.Show()
        Me.Hide()
    End Sub
End Class
