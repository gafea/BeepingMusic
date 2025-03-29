Public Class Form6
    Private Sub TrackBar1_Scroll(sender As Object, e As EventArgs) Handles TrackBar1.ValueChanged
        Form1.Opacity = TrackBar1.Value / 100
        Form3.Opacity = TrackBar1.Value / 100
        Form4.Opacity = TrackBar1.Value / 100
        Opacity = TrackBar1.Value / 100
        Label1.Text = TrackBar1.Value.ToString + "%"
        Form3.Close()
        Form4.Close()
        If TrackBar1.Value < 20 And Label2.Text = "0" And Form1.Label8.Text > 19 Then
            If MsgBox("Are you sure you want to adjust the transparency level to under 20% ?", vbYesNo + vbExclamation, "Warning") = vbYes Then
                Label2.Text = "1"
            Else
                TrackBar1.Value = 20
            End If
        ElseIf TrackBar1.Value < 40 Then
            Label1.ForeColor = Color.Red
        ElseIf TrackBar1.Value < 55 Then
            Label1.ForeColor = Color.Orange
        ElseIf TrackBar1.Value < 70 Then
            Label1.ForeColor = Color.Gold
        Else
            Label1.ForeColor = Color.Black
        End If
    End Sub

    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TrackBar1.Value = Form1.Label8.Text
        Label2.Text = "0"
        ToolTip1.SetToolTip(TrackBar1, "Scroll the bar to adjust the transparency level")
    End Sub
End Class