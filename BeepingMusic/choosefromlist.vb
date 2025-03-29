Public Class choosefromlist
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.Click
        Call sleepone()
        CheckBox1.Checked = True
        Label1.Text = "1"
        Label2.Text = CheckBox1.Text
    End Sub
    Private Sub sleepone()
        Timer1.Start()
        Dim stopW As New Stopwatch
        stopW.Start()
        Do While stopW.ElapsedMilliseconds < 100
            Application.DoEvents()
        Loop
        stopW.Stop()
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox3.Checked = False
        CheckBox4.Checked = False
        CheckBox5.Checked = False
        CheckBox6.Checked = False
        CheckBox7.Checked = False
        CheckBox8.Checked = False
        CheckBox9.Checked = False
        CheckBox10.Checked = False
        CheckBox11.Checked = False
        CheckBox12.Checked = False
        CheckBox13.Checked = False
        CheckBox14.Checked = False
        CheckBox15.Checked = False
        CheckBox16.Checked = False
        CheckBox17.Checked = False
        CheckBox18.Checked = False
        CheckBox19.Checked = False
        CheckBox20.Checked = False
    End Sub
    Private Sub CheckBox2_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox2.Click
        Call sleepone()
        CheckBox2.Checked = True
        Label1.Text = "2"
        Label2.Text = CheckBox2.Text
    End Sub

    Private Sub CheckBox3_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox3.Click
        Call sleepone()
        CheckBox3.Checked = True
        Label1.Text = "3"
        Label2.Text = CheckBox3.Text
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Hide()
    End Sub

    Private Sub CheckBox4_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox4.Click
        Call sleepone()
        CheckBox4.Checked = True
        Label1.Text = "4"
        Label2.Text = CheckBox4.Text
    End Sub

    Private Sub CheckBox5_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox5.Click
        Call sleepone()
        CheckBox5.Checked = True
        Label1.Text = "5"
        Label2.Text = CheckBox5.Text
    End Sub

    Private Sub CheckBox6_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox6.Click
        Call sleepone()
        CheckBox6.Checked = True
        Label1.Text = "6"
        Label2.Text = CheckBox6.Text
    End Sub

    Private Sub CheckBox7_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox7.Click
        Call sleepone()
        CheckBox7.Checked = True
        Label1.Text = "7"
        Label2.Text = CheckBox7.Text
    End Sub

    Private Sub CheckBox8_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox8.Click
        Call sleepone()
        CheckBox8.Checked = True
        Label1.Text = "8"
        Label2.Text = CheckBox8.Text
    End Sub

    Private Sub CheckBox9_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox9.Click
        Call sleepone()
        CheckBox9.Checked = True
        Label1.Text = "9"
        Label2.Text = CheckBox9.Text
    End Sub

    Private Sub CheckBox10_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox10.Click
        Call sleepone()
        CheckBox10.Checked = True
        Label1.Text = "10"
        Label2.Text = CheckBox10.Text
    End Sub

    Private Sub CheckBox11_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox11.Click
        Call sleepone()
        CheckBox11.Checked = True
        Label1.Text = "11"
        Label2.Text = CheckBox11.Text
    End Sub

    Private Sub CheckBox12_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox12.Click
        Call sleepone()
        Label1.Text = "12"
        CheckBox12.Checked = True
        Label2.Text = CheckBox12.Text
    End Sub

    Private Sub CheckBox13_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox13.Click
        Call sleepone()
        CheckBox13.Checked = True
        Label1.Text = "13"
        Label2.Text = CheckBox13.Text
    End Sub

    Private Sub CheckBox14_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox14.Click
        Call sleepone()
        CheckBox14.Checked = True
        Label1.Text = "14"
        Label2.Text = CheckBox14.Text
    End Sub

    Private Sub CheckBox15_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox15.Click
        Call sleepone()
        CheckBox15.Checked = True
        Label1.Text = "15"
        Label2.Text = CheckBox15.Text
    End Sub

    Private Sub CheckBox16_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox16.Click
        Call sleepone()
        CheckBox16.Checked = True
        Label1.Text = "16"
        Label2.Text = CheckBox16.Text
    End Sub

    Private Sub CheckBox17_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox17.Click
        Call sleepone()
        CheckBox17.Checked = True
        Label1.Text = "17"
        Label2.Text = CheckBox17.Text
    End Sub

    Private Sub CheckBox18_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox18.Click
        Call sleepone()
        CheckBox18.Checked = True
        Label1.Text = "18"
        Label2.Text = CheckBox18.Text
    End Sub

    Private Sub CheckBox19_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox19.Click
        Call sleepone()
        CheckBox19.Checked = True
        Label1.Text = "19"
        Label2.Text = CheckBox19.Text
    End Sub

    Private Sub CheckBox20_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox20.Click
        Call sleepone()
        CheckBox20.Checked = True
        Label1.Text = "20"
        Label2.Text = CheckBox20.Text
    End Sub

    Private Sub choosefromlist_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label2.Text = CheckBox1.Text
    End Sub
End Class