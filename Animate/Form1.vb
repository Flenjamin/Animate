Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label26.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim labels() As Label = {Label1, Label2, Label3, Label4, Label5, Label6, Label7, Label8, Label9, Label10, Label11, Label12, Label13, Label14, Label15, Label16, Label17, Label18, Label19, Label20, Label23, Label24, Label26, Label27, Label28}

        For Each label In labels
            label.BackColor = Color.Yellow
        Next
        Dim rand2 As New Random()
        Dim index As Integer = rand2.Next(labels.Length)
        labels(index).BackColor = Color.Red
        MessageBox.Show(" " & labels(index).Name & "!")
    End Sub

    Private Sub Label27_Click(sender As Object, e As EventArgs) Handles Label27.Click

    End Sub
End Class
