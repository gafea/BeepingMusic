Public Class miniplayer

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Label7.Text = "14"
        choosefromlist.Hide()
        Form1.OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Button2.Enabled = False
        Form1.Show()
        Form1.Opacity = 0
        Form1.Button2.PerformClick()
        Form1.Hide()
        Form6.Show()
        Form1.Opacity = Form6.TrackBar1.Value
        Form6.Hide()
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.Click
        If CheckBox1.Checked = True Then
            Form1.CheckBox1.Checked = True
            Form1.LoopToolStripMenuItem.Checked = True
        Else
            Form1.CheckBox1.Checked = False
            Form1.LoopToolStripMenuItem.Checked = False
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form1.Visible = True
        Hide()
    End Sub

    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.Click
        If CheckBox2.Checked = True Then
            TopMost = True
        Else
            TopMost = False
        End If
    End Sub
End Class