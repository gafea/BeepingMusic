Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Timer2.Start()
        Form4_close(sender, e)
        Me.Hide()
        Timer1.Start()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.TimedPlayToolStripMenuItem.Checked = False
        Me.Close()
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Form1.Button1.Enabled = False
        Form1.Button2.Enabled = False
        Form1.MenuStrip1.Enabled = False
        Me.Size = New Point(50, 25)
        Me.Location = New Point(Location.X + 100, Location.Y + 50)
        Me.Text = " "
        Label1.Visible = False
        DateTimePicker1.Visible = False
        Button1.Visible = False
        Button2.Visible = False
    End Sub
    Private Sub Form4_close(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        Me.Text = " "
        Label1.Visible = False
        DateTimePicker1.Visible = False
        Button1.Visible = False
        Button2.Visible = False
        Dim x As Integer = 250
        Dim y As Integer = 125
        Dim a As Integer = 0
        Dim b As Integer = 0
        Do Until x = 50
            x = x - 2
            y = y - 1
            If a = 0 Then
                a = 1
            Else
                a = 0
                Me.Location = New Point(Location.X + 2, Location.Y + 1)
            End If
            Me.Size = New Point(x, y)
        Loop
        Form1.MenuStrip1.Enabled = True
        If Form1.ProgressBar1.Visible < 0 Then
            Form1.Button1.Enabled = True
            Form1.Button2.Enabled = True
        End If
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        Dim x As Integer = 50
        Dim y As Integer = 25
        Dim a As Integer = 0
        Dim b As Integer = 0
        Do Until x = 250
            x = x + 2
            y = y + 1
            If a = 0 Then
                a = 1
            Else
                a = 0
                Me.Location = New Point(Location.X - 2, Location.Y - 1)
            End If
            Me.Size = New Point(x, y)
        Loop
        Me.Text = "Timed Play"
        Label1.Visible = True
        DateTimePicker1.Visible = True
        Button1.Visible = True
        Button2.Visible = True
    End Sub
End Class