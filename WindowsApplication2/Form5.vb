Public Class Form5
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.ShowDialog()
        Form4.db = OpenFileDialog1.FileName.ToString
        Me.Close()
    End Sub
End Class