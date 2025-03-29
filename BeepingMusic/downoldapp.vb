Public Class downoldapp
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SaveFileDialog1.ShowDialog()
        Dim x As String = SaveFileDialog1.FileName
        Dim y As String = "http://whoopha.ddns.net/app/beepingmusic/windows/app/BeepingMusic_0."
        y = y + NumericUpDown1.Value.ToString + "." + NumericUpDown2.Value.ToString + "." + NumericUpDown3.Value.ToString + ".zip"
        Try
            My.Computer.Network.DownloadFile(y, x)
            Label2.Text = "Downloaded."
        Catch ex As Exception
            Label2.Text = ex.ToString
        End Try
    End Sub
End Class