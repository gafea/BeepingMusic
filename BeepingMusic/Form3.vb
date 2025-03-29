Public Class Form3
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Show()
        Timer1.Stop()
        Dim s As Integer = 132
        Dim y As Integer
        Dim w As Integer
        Dim j As Integer = 38
        Opacity = 0.93
        Do Until s = 300
            y = 0
            Do Until y = 3
                s = s + 1
                Size = New Point(s, j)
                y = y + 1
                If y = 1 Or y = 3 Then
                    Location = New Point(Location.X - 1, Location.Y)
                End If
            Loop
            s = s + 1
            j = j + 1
            Size = New Point(s, j)
            w = w + 1
            If w = 2 Then
                Location = New Point(Location.X, Location.Y - 1)
                w = 0
            End If
        Loop
        y = Size.Height
        Do Until y = 200
            Size = New Point(300, y + 2)
            Location = New Point(Location.X, Location.Y - 1)
            y = y + 2
        Loop
        Label1.Visible = True
        Label2.Visible = True
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.FormClosing
        My.Computer.Audio.Stop()
        Dim s As Integer = 300
        Dim y As Integer
        Dim w As Integer
        Dim j As Integer = 200
        Do Until s = 132
            y = 0
            Do Until y = 3
                s = s - 1
                Size = New Point(s, j)
                y = y + 1
                If y = 1 Or y = 3 Then
                    Location = New Point(Location.X + 1, Location.Y)
                End If
            Loop
            s = s - 1
            j = j - 1
            Size = New Point(s, j)
            w = w - 1
            If w = 2 Then
                Location = New Point(Location.X, Location.Y + 1)
                w = 0
            End If
        Loop
        y = Size.Height
        Do Until y = 30
            Size = New Point(132, y - 2)
            Location = New Point(Location.X, Location.Y + 1)
            y = y - 2
        Loop
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim x As New Random
        Dim y As Integer
        y = x.Next(80)
        If y = 0 Then
            ToolTip1.SetToolTip(Label2, "Pokemon 000 is MissingNo")
        ElseIf y = 1 Then
            ToolTip1.SetToolTip(Label2, "Created by Whoopha")
        ElseIf y = 2 Then
            ToolTip1.SetToolTip(Label2, "Huh, Neat.")
        ElseIf y = 3 Then
            ToolTip1.SetToolTip(Label2, "There's no easter eggs")
        ElseIf y = 4 Then
            ToolTip1.SetToolTip(Label2, "Free, but not (yet) open-source")
        ElseIf y = 5 Then
            ToolTip1.SetToolTip(Label2, "Yolo")
        ElseIf y = 6 Then
            ToolTip1.SetToolTip(Label2, "The sponsor tomorrow")
        ElseIf y = 7 Then
            ToolTip1.SetToolTip(Label2, "I backup my whole HDD on my Google Drive")
        ElseIf y = 8 Then
            ToolTip1.SetToolTip(Label2, "Why the bug is still here ?")
        ElseIf y = 9 Then
            ToolTip1.SetToolTip(Label2, "BeepingMusic")
        ElseIf y = 10 Then
            ToolTip1.SetToolTip(Label2, "OK, I forgot to add this feature...")
        ElseIf y = 11 Then
            ToolTip1.SetToolTip(Label2, "Windows 98 compatible")
        ElseIf y = 12 Then
            ToolTip1.SetToolTip(Label2, "Dial-Up friendly")
        ElseIf y = 13 Then
            ToolTip1.SetToolTip(Label2, "Whoa, Transparency!")
        ElseIf y = 14 Then
            ToolTip1.SetToolTip(Label2, "Thanks, AlphaTestingGroup !")
        ElseIf y = 15 Then
            ToolTip1.SetToolTip(Label2, "WLAN ? Can I eat that ?")
        ElseIf y = 16 Then
            ToolTip1.SetToolTip(Label2, "No iOS 10 for iPad mini 1 :(")
        ElseIf y = 17 Then
            ToolTip1.SetToolTip(Label2, "418 Teapot")
        ElseIf y = 18 Then
            ToolTip1.SetToolTip(Label2, "Intel Celeron 887 is my CPU")
        ElseIf y = 19 Then
            ToolTip1.SetToolTip(Label2, "Music is fun.")
        ElseIf y = 20 Then
            ToolTip1.SetToolTip(Label2, "Fun is infinite")
        ElseIf y = 21 Then
            ToolTip1.SetToolTip(Label2, "Delete system32 to run windows faster")
        ElseIf y = 22 Then
            ToolTip1.SetToolTip(Label2, "Nyan Cat" + vbCrLf + vbCrLf + "Nyan Cat everywhere")
        ElseIf y = 23 Then
            ToolTip1.SetToolTip(Label2, "If NewiPhone.released = true then" + vbCrLf + "Kidney.sell" + vbCrLf + "iPhone.buy" + vbCrLf + "End If")
        ElseIf y = 24 Then
            ToolTip1.SetToolTip(Label2, "Is it that hard to beep smoothly ?")
        ElseIf y = 25 Then
            ToolTip1.SetToolTip(Label2, "Ditto ? Ditto !")
        ElseIf y = 26 Then
            ToolTip1.SetToolTip(Label2, "This msg will disappear in 5 sec...")
        ElseIf y = 27 Then
            ToolTip1.SetToolTip(Label2, "Our princess is in another castle !")
        ElseIf y = 28 Then
            ToolTip1.SetToolTip(Label2, "Can I jast take all of them, Professor Oak?")
        ElseIf y = 29 Then
            ToolTip1.SetToolTip(Label2, "No copyright law in the universe is going to stop me!")
        ElseIf y = 30 Then
            ToolTip1.SetToolTip(Label2, "You're too slow!")
        ElseIf y = 31 Then
            ToolTip1.SetToolTip(Label2, "With the power of friendship, I sure we can win!")
        ElseIf y = 32 Then
            ToolTip1.SetToolTip(Label2, "Poopachu!")
        ElseIf y = 33 Then
            ToolTip1.SetToolTip(Label2, "Is it that hard to tell me a funny joke, siri?")
        ElseIf y = 34 Then
            ToolTip1.SetToolTip(Label2, "The next macbook will have no port!")
        ElseIf y = 35 Then
            ToolTip1.SetToolTip(Label2, "#Placeholder")
        ElseIf y = 36 Then
            ToolTip1.SetToolTip(Label2, "How come there's so many easter eggs?")
        ElseIf y = 37 Then
            ToolTip1.SetToolTip(Label2, "#iMacG5")
        ElseIf y = 38 Then
            ToolTip1.SetToolTip(Label2, "PowerPC is a heater")
        ElseIf y = 39 Then
            ToolTip1.SetToolTip(Label2, "I won't tell you my name is Jason")
        ElseIf y = 40 Then
            ToolTip1.SetToolTip(Label2, "Working Hard...")
        ElseIf y = 41 Then
            ToolTip1.SetToolTip(Label2, "Project start since 31/08/2017")
        ElseIf y = 42 Then
            ToolTip1.SetToolTip(Label2, "Do you know the sun rise in east ?")
        ElseIf y = 43 Then
            ToolTip1.SetToolTip(Label2, "News = North + East + West + South")
        ElseIf y = 44 Then
            ToolTip1.SetToolTip(Label2, "H2O = water")
        ElseIf y = 45 Then
            ToolTip1.SetToolTip(Label2, "Plugging out does work!" + vbCrLf + "-linus")
        ElseIf y = 46 Then
            ToolTip1.SetToolTip(Label2, "In Africa, 60 seconds passes every minute")
        ElseIf y = 47 Then
            ToolTip1.SetToolTip(Label2, "#Hashtag")
        ElseIf y = 48 Then
            ToolTip1.SetToolTip(Label2, "SpeII check was sklpped.")
        ElseIf y = 49 Then
            ToolTip1.SetToolTip(Label2, "!!!1!")
        ElseIf y = 50 Then
            ToolTip1.SetToolTip(Label2, "Don't eat GameBoy")
        ElseIf y = 51 Then
            ToolTip1.SetToolTip(Label2, My.Computer.Info.TotalPhysicalMemory.ToString + "bytes of RAM useable")
        ElseIf y = 52 Then
            ToolTip1.SetToolTip(Label2, "Screen resolution : " + Screen.PrimaryScreen.Bounds.Width.ToString + "x" + Screen.PrimaryScreen.Bounds.Height.ToString)
        ElseIf y = 53 Then
            Dim MyOBJ As Object
            Dim cpu As Object
            MyOBJ = GetObject("WinMgmts:").instancesof("Win32_Processor")
            For Each cpu In MyOBJ
                ToolTip1.SetToolTip(Label2, cpu.Name.ToString)
            Next
        ElseIf y = 54 Then
            ToolTip1.SetToolTip(Label2, DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss"))
        ElseIf y = 55 Then
            ToolTip1.SetToolTip(Label2, "This app's process ID is " + Process.GetCurrentProcess.Id.ToString)
        ElseIf y = 56 Then
            ToolTip1.SetToolTip(Label2, "New BMF file version!")
        ElseIf y = 57 Then
            ToolTip1.SetToolTip(Label2, "VB.net")
        ElseIf y = 58 Then
            ToolTip1.SetToolTip(Label2, "microbit")
        ElseIf y = 59 Then
            ToolTip1.SetToolTip(Label2, "MacBook")
        ElseIf y = 60 Then
            ToolTip1.SetToolTip(Label2, "Windows")
        ElseIf y = 61 Then
            ToolTip1.SetToolTip(Label2, "Make it loop")
        ElseIf y = 62 Then
            ToolTip1.SetToolTip(Label2, "Yes you can!")
        ElseIf y = 63 Then
            ToolTip1.SetToolTip(Label2, "Time to relable")
        ElseIf y = 64 Then
            ToolTip1.SetToolTip(Label2, "http is not secure")
        ElseIf y = 65 Then
            ToolTip1.SetToolTip(Label2, "No money to buy SSL")
        ElseIf y = 66 Then
            ToolTip1.SetToolTip(Label2, "AIO bmf")
        ElseIf y = 67 Then
            ToolTip1.SetToolTip(Label2, "Designing a better format for bmf")
        ElseIf y = 68 Then
            ToolTip1.SetToolTip(Label2, "ClockBreak")
        ElseIf y = 69 Then
            ToolTip1.SetToolTip(Label2, "Shocktake")
        ElseIf y = 70 Then
            ToolTip1.SetToolTip(Label2, "Whoopha")
        ElseIf y = 71 Then
            ToolTip1.SetToolTip(Label2, "HappySmileFace")
        ElseIf y = 72 Then
            ToolTip1.SetToolTip(Label2, "Movieunleashers")
        ElseIf y = 73 Then
            ToolTip1.SetToolTip(Label2, "BUGGY")
        ElseIf y = 74 Then
            ToolTip1.SetToolTip(Label2, "Bugs everywhere")
        ElseIf y = 75 Then
            ToolTip1.SetToolTip(Label2, "Hello World")
        ElseIf y = 76 Then
            ToolTip1.SetToolTip(Label2, "MiniPlayer")
        ElseIf y = 77 Then
            ToolTip1.SetToolTip(Label2, "I'm not iTunes")
        ElseIf y = 78 Then
            ToolTip1.SetToolTip(Label2, "Glass effect")
        ElseIf y = 79 Then
            ToolTip1.SetToolTip(Label2, ":)")
        ElseIf y = 80 Then
            ToolTip1.SetToolTip(Label2, "'3'")
        Else
            ToolTip1.SetToolTip(Label2, "This message shouldn't appear, if it does, it's a bug.")
        End If
    End Sub

    Private Sub Form3_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load
        Hide()
        Location = New Point(Location.X + 84, Location.Y + 81)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click
        Label2.Text = "Thanks for downloading this app!" + vbCrLf + "I hope you like it !" + vbCrLf + vbCrLf + "Whoopha, 2018"
        PictureBox1.Visible = True
        PictureBox1.BringToFront()
        Timer2.Start()
        Timer4.Start()
        Timer3.Stop()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        If Timer2.Enabled = True Then
            Timer2.Stop()
        Else
            Timer2.Start()
        End If
    End Sub

    Private Sub Timer3_Tick(sender As Object, e As EventArgs) Handles Timer3.Tick
        Timer3.Stop()
        Label1_Click(sender, e)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Process.Start("iexplore.exe", "http://whoopha.ddns.net/app/beepingmusic")
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Timer4.Stop()
        Try
            My.Computer.Network.DownloadFile("http://whoopha.ddns.net/app/beepingmusic/windows/bgm.wav", "bgm.wav", "", "", False, 15000, True)
            My.Computer.Audio.Play("bgm.wav", AudioPlayMode.BackgroundLoop)
        Catch ex As Exception
        End Try
    End Sub
End Class