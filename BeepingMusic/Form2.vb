Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Button1.Text = "Terminate" Then
            Form1.Close()
            Close()
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Button2.Text = "Ignore" Then
            Form1.Enabled = True
            Form1.Label2.Text = "1"
            Close()
        End If
    End Sub
End Class