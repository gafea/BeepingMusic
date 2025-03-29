Imports System.IO
Imports System.Runtime.InteropServices
Public Class Form1
    Dim thread As System.Threading.Thread
    Dim thread2 As System.Threading.Thread
    Private Const APPCOMMAND_VOLUME_MUTE As Integer = &H80000
    Private Const APPCOMMAND_VOLUME_UP As Integer = &HA0000
    Private Const APPCOMMAND_VOLUME_DOWN As Integer = &H90000
    Private Const WM_APPCOMMAND As Integer = &H319

    <DllImport("user32.dll")>
    Public Shared Function SendMessageW(ByVal hWnd As IntPtr, ByVal Msg As Integer, ByVal wParam As IntPtr, ByVal lParam As IntPtr) As IntPtr
    End Function

    Dim HScroll3 As Integer = 0
    Dim Count As Integer = 0
    Private Sub WebsiteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WebsiteToolStripMenuItem.Click
        Process.Start("iexplore.exe", "http://jasonkwok.ddns.net/app/beepingmusic")
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label7.Text = "14"
        choosefromlist.Hide()
        OpenFileDialog1.ShowDialog()
        RichTextBox1.Text = ""
        RichTextBox1.Visible = True
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk
        Me.Text = "BeepingMusic"
        miniplayer.Label1.Text = OpenFileDialog1.SafeFileName
        Button6.Visible = False
        TextBox1.Text = OpenFileDialog1.FileName
        RichTextBox1.Text = "Opened bmf file : " + OpenFileDialog1.FileName + vbCrLf + RichTextBox1.Text
        GroupBox2.Enabled = True
        Label1.Text = "Please Wait..."
        Dim fileReader As StreamReader
        fileReader = My.Computer.FileSystem.OpenTextFileReader(OpenFileDialog1.FileName)
        Label3.Text = fileReader.ReadLine()
        RichTextBox1.Text = "Verifing file..." + vbCrLf + RichTextBox1.Text
        Timer1.Start()
        fileReader.Close()
        TextBox1.BackColor = Color.WhiteSmoke
        ProgressBar1.Value = 0
        ToolTip1.SetToolTip(Me.TextBox1, "BMF file location path")
        GroupBox3.Visible = True
    End Sub
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CheckForIllegalCrossThreadCalls = False
        Dim toolTip1 As New ToolTip()
        toolTip1.SetToolTip(Me.Button1, "Open the bmf file to play")
        toolTip1.SetToolTip(Me.Button2, "Play the seleted BMF file")
        toolTip1.SetToolTip(Me.RichTextBox1, "Log")
        toolTip1.SetToolTip(Me.TextBox1, "BMF file location path")
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim o As Integer = 0
        Dim y As Integer = 0
        Dim t As String = Label3.Text
        If t = "1218" Then
            y = 1
            RichTextBox1.Text = "Sucess!" + vbCrLf + RichTextBox1.Text
        ElseIf Label2.Text = "1" Then
            y = 1
            RichTextBox1.Text = "User ignored the problem." + vbCrLf + RichTextBox1.Text
        Else
            If Form2.Button2.Text = "Ignore" Then
            Else
                RichTextBox1.Text = "Failed." + vbCrLf + RichTextBox1.Text
                Form2.Show()
                Me.Enabled = False
                Form2.Button2.Text = "Ignore"
                Form2.Button2.Visible = True
                Form2.Label1.Text = "Failed to verify the file"
                Form2.Label2.Text = "Maybe the file is corrupted , or this app is too old." + vbCrLf + "Try install a newer version of this app." + vbCrLf + "Or press the Ignore button to continue reading the file."
            End If
        End If
        If y = 1 Then
            Timer1.Stop()
            ProgressBar1.Style = ProgressBarStyle.Blocks
            Dim fileReader As StreamReader
            fileReader = My.Computer.FileSystem.OpenTextFileReader(OpenFileDialog1.FileName)
            t = fileReader.ReadLine()
            Label3.Text = fileReader.ReadLine()
            RichTextBox1.Text = "Checking file version..." + vbCrLf + RichTextBox1.Text
            If Label3.Text = "8c" Or Label3.Text = "ED" Or Label3.Text = "aa" Then
                miniplayer.Button2.Enabled = True
                LoopToolStripMenuItem.Enabled = True
                LoopToolStripMenuItem.Checked = False
                PlayToolStripMenuItem1.Enabled = True
                TimedPlayToolStripMenuItem.Enabled = True
                TimedPlayToolStripMenuItem.Checked = False
                RichTextBox1.Text = "OK" + vbCrLf + RichTextBox1.Text
                Label1.Text = "Press the Play button !"
                Me.Text = "BeepingMusic - " + OpenFileDialog1.SafeFileName
                If Label3.Text = "8c" Then
                    y = File.ReadAllLines(OpenFileDialog1.FileName).Length / 2 - 1
                    ProgressBar1.Maximum = y
                    miniplayer.ProgressBar1.Maximum = y
                    RichTextBox1.Text = "Notes to play : " + y.ToString + vbCrLf + RichTextBox1.Text
                    Label4.Text = "BeepingMusic by Whoopha"
                    Dim r As Integer = 0
                    Do Until y = 0
                        t = fileReader.ReadLine()
                        If t = 38 Then
                            t = fileReader.ReadLine()
                            t = fileReader.ReadLine()
                            t = fileReader.ReadLine()
                            y = y - 1
                        Else
                            r = fileReader.ReadLine() + r
                        End If
                        y = y - 1
                    Loop
                    Dim SecondsDifference As Integer = r
                    Dim hms = TimeSpan.FromMilliseconds(SecondsDifference)
                    Dim h = hms.Hours.ToString
                    Dim m = hms.Minutes.ToString
                    Dim s = hms.Seconds.ToString
                    s = s + " sec"
                    If m = "0" Then
                        m = ""
                    Else
                        m = m + " min, "
                    End If
                    If h = "0" Then
                        h = ""
                    Else
                        h = h + " hr, "
                        If m = "" Then
                            m = "0 min, "
                        End If
                    End If
                    Label5.Text = "Music Length : " + h + m + s
                    miniplayer.Label2.Text = "BeepingMusic"
                    miniplayer.Label3.Text = ""
                Else
                    miniplayer.Label2.Text = "Unknown Creater"
                    miniplayer.Label3.Text = "BeepingMusic"
                    Label5.Text = "Playing " + OpenFileDialog1.SafeFileName
                    Label4.Text = "Whoopha, 2018"
                    y = 0
                    t = ""
                    Dim q As Integer = 0
                    miniplayer.CheckBox1.Enabled = True
                    miniplayer.CheckBox1.Checked = False
                    Do Until t = "notes" Or y = 7 Or q = 100
                        q = q + 1
                        t = fileReader.ReadLine
                        If t = "islist" Then
                            MsgBox("Playlisting is no longer supported, contect creater.", 16, "Error")
                        ElseIf t = "forcelist" Then
                            choosefromlist.Timer1.Start()
                            choosefromlist.CheckBox2.Visible = False
                            choosefromlist.CheckBox3.Visible = False
                            choosefromlist.CheckBox4.Visible = False
                            choosefromlist.CheckBox5.Visible = False
                            choosefromlist.CheckBox6.Visible = False
                            choosefromlist.CheckBox7.Visible = False
                            choosefromlist.CheckBox8.Visible = False
                            choosefromlist.CheckBox9.Visible = False
                            choosefromlist.CheckBox10.Visible = False
                            choosefromlist.CheckBox11.Visible = False
                            choosefromlist.CheckBox12.Visible = False
                            choosefromlist.CheckBox13.Visible = False
                            choosefromlist.CheckBox14.Visible = False
                            choosefromlist.CheckBox15.Visible = False
                            choosefromlist.CheckBox16.Visible = False
                            choosefromlist.CheckBox17.Visible = False
                            choosefromlist.CheckBox18.Visible = False
                            choosefromlist.CheckBox19.Visible = False
                            choosefromlist.CheckBox20.Visible = False
                            Button6.Visible = True
                            Button6.Enabled = True
                            Dim nn As String
                            Do Until t = "endlist"
                                t = fileReader.ReadLine
                                If t = "m1" Then
                                    nn = fileReader.ReadLine
                                    choosefromlist.CheckBox1.Text = nn
                                ElseIf t = "m2" Then
                                    choosefromlist.CheckBox2.Visible = True
                                    nn = fileReader.ReadLine
                                    choosefromlist.CheckBox2.Text = nn
                                ElseIf t = "m3" Then
                                    choosefromlist.CheckBox3.Visible = True
                                    nn = fileReader.ReadLine
                                    choosefromlist.CheckBox3.Text = nn
                                ElseIf t = "m4" Then
                                    choosefromlist.CheckBox4.Visible = True
                                    nn = fileReader.ReadLine
                                    choosefromlist.CheckBox4.Text = nn
                                ElseIf t = "m5" Then
                                    choosefromlist.CheckBox5.Visible = True
                                    nn = fileReader.ReadLine
                                    choosefromlist.CheckBox5.Text = nn
                                ElseIf t = "m6" Then
                                    choosefromlist.CheckBox6.Visible = True
                                    nn = fileReader.ReadLine
                                    choosefromlist.CheckBox6.Text = nn
                                ElseIf t = "m7" Then
                                    choosefromlist.CheckBox7.Visible = True
                                    nn = fileReader.ReadLine
                                    choosefromlist.CheckBox7.Text = nn
                                ElseIf t = "m8" Then
                                    choosefromlist.CheckBox8.Visible = True
                                    nn = fileReader.ReadLine
                                    choosefromlist.CheckBox8.Text = nn
                                ElseIf t = "m9" Then
                                    choosefromlist.CheckBox9.Visible = True
                                    nn = fileReader.ReadLine
                                    choosefromlist.CheckBox9.Text = nn
                                ElseIf t = "m10" Then
                                    choosefromlist.CheckBox10.Visible = True
                                    nn = fileReader.ReadLine
                                    choosefromlist.CheckBox10.Text = nn
                                ElseIf t = "m11" Then
                                    choosefromlist.CheckBox11.Visible = True
                                    nn = fileReader.ReadLine
                                    choosefromlist.CheckBox11.Text = nn
                                ElseIf t = "m12" Then
                                    choosefromlist.CheckBox12.Visible = True
                                    nn = fileReader.ReadLine
                                    choosefromlist.CheckBox12.Text = nn
                                ElseIf t = "m13" Then
                                    choosefromlist.CheckBox13.Visible = True
                                    nn = fileReader.ReadLine
                                    choosefromlist.CheckBox13.Text = nn
                                ElseIf t = "m14" Then
                                    choosefromlist.CheckBox14.Visible = True
                                    nn = fileReader.ReadLine
                                    choosefromlist.CheckBox14.Text = nn
                                ElseIf t = "m15" Then
                                    choosefromlist.CheckBox15.Visible = True
                                    nn = fileReader.ReadLine
                                    choosefromlist.CheckBox15.Text = nn
                                ElseIf t = "m16" Then
                                    choosefromlist.CheckBox16.Visible = True
                                    nn = fileReader.ReadLine
                                    choosefromlist.CheckBox16.Text = nn
                                ElseIf t = "m17" Then
                                    choosefromlist.CheckBox17.Visible = True
                                    nn = fileReader.ReadLine
                                    choosefromlist.CheckBox17.Text = nn
                                ElseIf t = "m18" Then
                                    choosefromlist.CheckBox18.Visible = True
                                    nn = fileReader.ReadLine
                                    choosefromlist.CheckBox18.Text = nn
                                ElseIf t = "m19" Then
                                    choosefromlist.CheckBox19.Visible = True
                                    nn = fileReader.ReadLine
                                    choosefromlist.CheckBox19.Text = nn
                                ElseIf t = "m20" Then
                                    choosefromlist.CheckBox20.Visible = True
                                    nn = fileReader.ReadLine
                                    choosefromlist.CheckBox20.Text = nn
                                End If
                            Loop
                            choosefromlist.Show()
                            choosefromlist.CheckBox1.Checked = True
                        End If
                        If t = "creater" Then
                            t = fileReader.ReadLine
                            Label5.Text = OpenFileDialog1.SafeFileName + " by " + t
                            miniplayer.Label2.Text = "Created by " + t
                            y = y + 1
                        End If
                        If t = "nolog" Then
                            RichTextBox1.Text = "The note's frequence will not be shown."

                            y = y + 1
                        End If
                        If t = "textshow" Then
                            t = fileReader.ReadLine
                            Label4.Text = t
                            miniplayer.Label3.Text = "-" + t
                            y = y + 1
                        End If
                        If t = "autoplay" Then
                            o = o + 1
                            y = y + 1
                            RichTextBox1.Text = "Autoplay by file" + vbCrLf + RichTextBox1.Text
                        End If
                        If t = "noloop" Then
                            y = y + 1
                            o = o + 2
                            miniplayer.CheckBox1.Enabled = False
                            RichTextBox1.Text = "Loop disabled by file" + vbCrLf + RichTextBox1.Text
                        End If
                        If t = "loopcheck" Then
                            y = y + 1
                            o = o + 4
                            miniplayer.CheckBox1.Checked = True
                            RichTextBox1.Text = "Looping requried by file" + vbCrLf + RichTextBox1.Text
                        End If
                        If t = "tempo" Then
                            y = y + 1
                            Label9.Text = fileReader.ReadLine
                            RichTextBox1.Text = "Tempo : " + Label9.Text + vbCrLf + RichTextBox1.Text
                        End If
                    Loop
                    q = 0
                    t = ""
                    fileReader.Close()
                    Dim fileReader1 As StreamReader
                    fileReader1 = My.Computer.FileSystem.OpenTextFileReader(OpenFileDialog1.FileName)
                    Do Until t = "notes" Or q = 100
                        t = fileReader1.ReadLine
                        q = q + 1
                    Loop
                    If t = "notes" Then
                        q = 0
                        Do Until t = "end" Or t = ""
                            t = fileReader1.ReadLine
                            q = q + 1
                        Loop
                        q = q - 1
                        q = q / 2
                        ProgressBar1.Maximum = q
                        miniplayer.ProgressBar1.Maximum = q
                    End If
                    fileReader1.Close()
                End If
                If RichTextBox1.Text = "The note's frequence will not be shown." Then
                Else
                    RichTextBox1.Text = "Ready." + vbCrLf + RichTextBox1.Text
                End If
                CheckBox1.Enabled = True
                LoopToolStripMenuItem.Enabled = True
                CheckBox1.Checked = False
                If o = 1 Then
                    Button2_Click(sender, e)
                ElseIf o = 2 Then
                    CheckBox1.Enabled = False
                    LoopToolStripMenuItem.Enabled = False
                ElseIf o = 3 Then
                    Button2_Click(sender, e)
                    CheckBox1.Enabled = False
                    LoopToolStripMenuItem.Enabled = False
                ElseIf o = 4 Then
                    CheckBox1.Checked = True
                    LoopToolStripMenuItem.Checked = True
                ElseIf o = 5 Then
                    CheckBox1.Checked = True
                    LoopToolStripMenuItem.Checked = True
                    Button2_Click(sender, e)
                ElseIf o = 6 Then
                    CheckBox1.Checked = True
                    LoopToolStripMenuItem.Checked = True
                    CheckBox1.Enabled = False
                    LoopToolStripMenuItem.Enabled = False
                ElseIf o = 7 Then
                    CheckBox1.Checked = True
                    LoopToolStripMenuItem.Checked = True
                    Button2_Click(sender, e)
                    CheckBox1.Enabled = False
                    LoopToolStripMenuItem.Enabled = False
                End If
            Else
                RichTextBox1.Text = "File not compatable." + vbCrLf + RichTextBox1.Text
                If Label3.Text = "" Then
                    MsgBox("The file is not compatable with this version, and the file didn't give the compatable version number.", 16, "Error")
                Else
                    MsgBox("The file is not compatable with this version, You should use the `" + Label3.Text + "' version of this app.", 16, "Error")
                End If
                Label1.Text = "Waiting for bmf file..."
                GroupBox2.Enabled = False
                ProgressBar1.Style = ProgressBar1.Style.Marquee
                GroupBox3.Visible = False
                TextBox1.Text = ""
                TimedPlayToolStripMenuItem.Enabled = False
                TimedPlayToolStripMenuItem.Checked = False
                LoopToolStripMenuItem.Enabled = False
                miniplayer.Label1.Text = "No file..."
            End If
            fileReader.Close()
        End If
    End Sub

    Private Sub refresh()
        Do Until ProgressBar1.Value = ProgressBar1.Maximum
            Application.DoEvents()
        Loop
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        thread = New System.Threading.Thread(AddressOf refresh)
        thread.Start()
        choosefromlist.Hide()
        Button6.Enabled = False
        Button5.Enabled = True
        TimedPlayToolStripMenuItem.Enabled = False
        PlayToolStripMenuItem1.Enabled = False
        Button2.Enabled = False
        If RichTextBox1.Text = "The note's frequence will not be shown." Then
            RichTextBox1.Visible = False
        End If
        Button1.Enabled = False
        If Label3.Text = "8c" Then
            Label1.Text = "Playing..."
            ProgressBar1.Value = 0
            miniplayer.ProgressBar1.Value = 0
            RichTextBox1.Text = "Playing" + vbCrLf + RichTextBox1.Text
            Dim fileReader As StreamReader
            Dim t As Integer = 0
            fileReader = My.Computer.FileSystem.OpenTextFileReader(OpenFileDialog1.FileName)
            fileReader.ReadLine()
            fileReader.ReadLine()
            Dim y As Integer = ProgressBar1.Value * 2
            Do Until y = 0
                fileReader.ReadLine()
            Loop
            Do Until ProgressBar1.Value = ProgressBar1.Maximum
                Application.DoEvents()
                ProgressBar1.Value = ProgressBar1.Value + 1
                miniplayer.ProgressBar1.Value = miniplayer.ProgressBar1.Value + 1
                t = fileReader.ReadLine()
                y = fileReader.ReadLine()
                RichTextBox1.Text = $"Feq : {t.ToString} , Dur : {y.ToString}ms{vbCrLf}{RichTextBox1.Text}"
                If y > 60000 Then
                    ToolTip1.SetToolTip(Me.TextBox1, "This file include some super long notes")
                    TextBox1.BackColor = Color.Gold
                    RichTextBox1.Text = "Lengh way too long @ " + y.ToString + "ms" + vbCrLf + RichTextBox1.Text
                    If DisableLongLenghNotesDetectionToolStripMenuItem.Checked = True Then
                        RichTextBox1.Text = "User ignored the problem." + vbCrLf + RichTextBox1.Text
                        Console.Beep(t, y)
                    Else
                        RichTextBox1.Text = "Note blocked." + vbCrLf + RichTextBox1.Text
                    End If
                ElseIf t = 38 Then
                    ProgressBar1.Value = ProgressBar1.Value + 1
                    miniplayer.ProgressBar1.Value = miniplayer.ProgressBar1.Value + 1
                    Label6.Text = y.ToString
                    y = fileReader.ReadLine
                    Label7.Text = fileReader.ReadLine()
                    If Label6.Text = "1" Then
                        t = 1
                    ElseIf Label6.Text = "2" Then
                        t = 0
                    Else
                    End If
                    If y = 38 Then
                        SendMessageW(Me.Handle, WM_APPCOMMAND, Me.Handle, New IntPtr(APPCOMMAND_VOLUME_MUTE))
                        RichTextBox1.Text = "Volume muted/unmuted" + vbCrLf + RichTextBox1.Text
                    Else
                        If t = 1 Then
                            RichTextBox1.Text = "Volume adjusted up by " + Label7.Text + vbCrLf + RichTextBox1.Text
                            Label7.Text = Label7.Text / 2
                            Do Until Label7.Text = "0"
                                Label7.Text = Label7.Text - 1
                                SendMessageW(Me.Handle, WM_APPCOMMAND, Me.Handle, New IntPtr(APPCOMMAND_VOLUME_UP))
                            Loop
                        Else
                            RichTextBox1.Text = "Volume adjusted down by " + Label7.Text + vbCrLf + RichTextBox1.Text
                            Label7.Text = Label7.Text / 2
                            Do Until Label7.Text = "0"
                                Label7.Text = Label7.Text - 1
                                SendMessageW(Me.Handle, WM_APPCOMMAND, Me.Handle, New IntPtr(APPCOMMAND_VOLUME_DOWN))
                            Loop
                        End If
                    End If
                ElseIf y > 15000 Then
                    ToolTip1.SetToolTip(Me.TextBox1, "This file include some long notes")
                    TextBox1.BackColor = Color.Red
                    RichTextBox1.Text = "Lengh too long @ " + y.ToString + "ms" + vbCrLf + RichTextBox1.Text
                    If DisableLongLenghNotesDetectionToolStripMenuItem.Checked = True Then
                        RichTextBox1.Text = "User ignored the problem." + vbCrLf + RichTextBox1.Text
                        Console.Beep(t, y)
                    Else
                        If MsgBox("The following note's lengh is " + y.ToString + " miliseconds, which is pretty long." + vbCrLf + "Do you want to continue ?", vbQuestion + vbYesNo, "Lengh too long") = MsgBoxResult.Yes Then
                            RichTextBox1.Text = "User replied : Yes" + vbCrLf + RichTextBox1.Text
                            Console.Beep(t, y)
                        Else
                            RichTextBox1.Text = "User replied : No" + vbCrLf + RichTextBox1.Text
                            RichTextBox1.Text = "Note skipped." + vbCrLf + RichTextBox1.Text
                        End If
                    End If
                ElseIf t < 37 Or t > 32767 Then
                    ToolTip1.SetToolTip(Me.TextBox1, "This file include some unplayable notes")
                    RichTextBox1.Text = "Frequency not supported : " + t.ToString + vbCrLf + RichTextBox1.Text
                    TextBox1.BackColor = Color.Gold
                ElseIf t > 2093 Then
                    ToolTip1.SetToolTip(Me.TextBox1, "This file include some unplayable notes")
                    TextBox1.BackColor = Color.Red
                    RichTextBox1.Text = "Frequency too high @ " + t.ToString + vbCrLf + RichTextBox1.Text
                    If DisableHighPitchNotesDetectionToolStripMenuItem.Checked = True Then
                        RichTextBox1.Text = "User ignored the problem." + vbCrLf + RichTextBox1.Text
                        Console.Beep(t, y)
                    Else
                        If MsgBox("The following note's frequency is " + t.ToString + " , which is pretty high." + vbCrLf + "Do you want to continue ?", vbQuestion + vbYesNo, "Frequency too high") = MsgBoxResult.Yes Then
                            RichTextBox1.Text = "User replied : Yes" + vbCrLf + RichTextBox1.Text
                            Console.Beep(t, y)
                        Else
                            RichTextBox1.Text = "User replied : No" + vbCrLf + RichTextBox1.Text
                            RichTextBox1.Text = "Note skipped." + vbCrLf + RichTextBox1.Text
                        End If
                    End If
                Else
                    Console.Beep(t, y)
                End If
                Application.DoEvents()
            Loop
            If CheckBox1.Checked = True Then
                RichTextBox1.Text = "Looped" + vbCrLf + RichTextBox1.Text
                Application.DoEvents()
                Button2_Click(sender, e)
            End If
        ElseIf Label3.Text = "ED" Or Label3.Text = "aa" Then
            Application.DoEvents()
            Label1.Text = "Playing..."
            ProgressBar1.Value = 0
            miniplayer.ProgressBar1.Value = 0
            RichTextBox1.Text = "Playing" + vbCrLf + RichTextBox1.Text
            Dim fileReader As StreamReader
            Dim t As Integer = 0
            fileReader = My.Computer.FileSystem.OpenTextFileReader(OpenFileDialog1.FileName)
            Dim p As String = ""
            Dim r As Integer = 0
            If Button6.Visible = True Then
                Text = "BeepingMusic - " + OpenFileDialog1.SafeFileName + " - " + choosefromlist.Label2.Text
                Dim yy As String = "m" + choosefromlist.Label1.Text
                Label3.Text = yy
                Do Until p = yy Or r = 1
                    If t = 100000 Then
                        r = 1
                    End If
                    p = fileReader.ReadLine
                    t = t + 1
                Loop
                p = fileReader.ReadLine
                p = fileReader.ReadLine
            Else
                Do Until p = "notes" Or r = 1
                    If t = 100 Then
                        r = 1
                    End If
                    p = fileReader.ReadLine
                    t = t + 1
                Loop
            End If
            If r = 1 Then
                RichTextBox1.Text = "Error : Timeout while finding Notes sign." + vbCrLf + RichTextBox1.Text
                Label1.Text = "Waiting for BMF files..."
            Else
                Dim x As Integer = 0
                Dim z As Integer = 0
                Dim ver As Boolean
                Do Until p = "end" Or p = ""
                    p = fileReader.ReadLine
                    ver = IsNumeric(p)
                    If ver = False Then
                        If p = "D2" Then
                            x = 37
                        ElseIf p = "D#2" Then
                            x = 39
                        ElseIf p = "E2" Then
                            x = 41
                        ElseIf p = "F2" Then
                            x = 44
                        ElseIf p = "F#2" Then
                            x = 46
                        ElseIf p = "G2" Then
                            x = 49
                        ElseIf p = "G#2" Then
                            x = 52
                        ElseIf p = "A2" Then
                            x = 55
                        ElseIf p = "A#2" Then
                            x = 58
                        ElseIf p = "B2" Then
                            x = 62
                        ElseIf p = "C3" Then
                            x = 65
                        ElseIf p = "C#3" Then
                            x = 69
                        ElseIf p = "D3" Then
                            x = 73
                        ElseIf p = "D#3" Then
                            x = 78
                        ElseIf p = "E3" Then
                            x = 82
                        ElseIf p = "F3" Then
                            x = 87
                        ElseIf p = "F#3" Then
                            x = 92
                        ElseIf p = "G3" Then
                            x = 98
                        ElseIf p = "G#3" Then
                            x = 104
                        ElseIf p = "A3" Then
                            x = 110
                        ElseIf p = "A#3" Then
                            x = 116
                        ElseIf p = "B3" Then
                            x = 123
                        ElseIf p = "C4" Then
                            x = 131
                        ElseIf p = "C#4" Then
                            x = 139
                        ElseIf p = "D4" Then
                            x = 147
                        ElseIf p = "D#4" Then
                            x = 155
                        ElseIf p = "E4" Then
                            x = 165
                        ElseIf p = "F4" Then
                            x = 175
                        ElseIf p = "F#4" Then
                            x = 185
                        ElseIf p = "G4" Then
                            x = 196
                        ElseIf p = "G#4" Then
                            x = 208
                        ElseIf p = "A4" Then
                            x = 220
                        ElseIf p = "A#4" Then
                            x = 233
                        ElseIf p = "B4" Then
                            x = 245
                        ElseIf p = "C5" Then
                            x = 262
                        ElseIf p = "C#5" Then
                            x = 277
                        ElseIf p = "D5" Then
                            x = 294
                        ElseIf p = "D#5" Then
                            x = 311
                        ElseIf p = "E5" Then
                            x = 330
                        ElseIf p = "F5" Then
                            x = 349
                        ElseIf p = "F#5" Then
                            x = 370
                        ElseIf p = "G5" Then
                            x = 392
                        ElseIf p = "G#5" Then
                            x = 415
                        ElseIf p = "A5" Then
                            x = 440
                        ElseIf p = "A#5" Then
                            x = 466
                        ElseIf p = "B5" Then
                            x = 494
                        ElseIf p = "C6" Then
                            x = 523
                        ElseIf p = "C#6" Then
                            x = 554
                        ElseIf p = "D6" Then
                            x = 587
                        ElseIf p = "D#6" Then
                            x = 622
                        ElseIf p = "E6" Then
                            x = 659
                        ElseIf p = "F6" Then
                            x = 698
                        ElseIf p = "F#6" Then
                            x = 740
                        ElseIf p = "G6" Then
                            x = 784
                        ElseIf p = "G#6" Then
                            x = 831
                        ElseIf p = "A6" Then
                            x = 880
                        ElseIf p = "A#6" Then
                            x = 932
                        ElseIf p = "B6" Then
                            x = 988
                        ElseIf p = "C7" Then
                            x = 1046
                        ElseIf p = "C#7" Then
                            x = 1109
                        ElseIf p = "D7" Then
                            x = 1175
                        ElseIf p = "D#7" Then
                            x = 1244
                        ElseIf p = "E7" Then
                            x = 1328
                        ElseIf p = "F7" Then
                            x = 1397
                        ElseIf p = "F#7" Then
                            x = 1480
                        ElseIf p = "G7" Then
                            x = 1568
                        ElseIf p = "G#7" Then
                            x = 1661
                        ElseIf p = "A7" Then
                            x = 1760
                        ElseIf p = "A#7" Then
                            x = 1865
                        ElseIf p = "B7" Then
                            x = 1975
                        ElseIf p = "C8" Then
                            x = 2093
                        ElseIf p = "C#8" Then
                            x = 2217
                        ElseIf p = "D8" Then
                            x = 2349
                        ElseIf p = "D#8" Then
                            x = 2489
                        ElseIf p = "vol" Then
                            p = fileReader.ReadLine
                            If p = "mutebtpress" Then
                                SendMessageW(Me.Handle, WM_APPCOMMAND, Me.Handle, New IntPtr(APPCOMMAND_VOLUME_MUTE))
                                RichTextBox1.Text = "Volume muted/unmuted" + vbCrLf + RichTextBox1.Text
                            ElseIf p = "changevol" Then
                                ProgressBar1.Value = ProgressBar1.Value + 1
                                miniplayer.ProgressBar1.Value = miniplayer.ProgressBar1.Value + 1
                                p = fileReader.ReadLine
                                If p = "up" Then
                                    Label7.Text = fileReader.ReadLine
                                    RichTextBox1.Text = "Volume adjusted up by " + Label7.Text + vbCrLf + RichTextBox1.Text
                                    Label7.Text = Label7.Text / 2
                                    Do Until Label7.Text = "0"
                                        Label7.Text = Label7.Text - 1
                                        SendMessageW(Me.Handle, WM_APPCOMMAND, Me.Handle, New IntPtr(APPCOMMAND_VOLUME_UP))
                                    Loop
                                ElseIf p = "down" Then
                                    Label7.Text = fileReader.ReadLine
                                    RichTextBox1.Text = "Volume adjusted down by " + Label7.Text + vbCrLf + RichTextBox1.Text
                                    Label7.Text = Label7.Text / 2
                                    Do Until Label7.Text = "0"
                                        Label7.Text = Label7.Text - 1
                                        SendMessageW(Me.Handle, WM_APPCOMMAND, Me.Handle, New IntPtr(APPCOMMAND_VOLUME_DOWN))
                                    Loop
                                End If
                            End If
                            x = 40001
                        Else
                            x = 40000
                        End If
                    Else
                        Try
                            x = p
                        Catch ex As Exception
                        End Try
                    End If
                    If Label9.Text = "" Then
                        p = fileReader.ReadLine
                        If p = "end" Then
                            x = 40000
                        Else
                            z = p
                        End If
                    Else
                        Dim u As Double = Label9.Text
                        p = fileReader.ReadLine
                        If p = "end" Then
                            x = 40000
                        Else
                            z = 60000 / u * p
                        End If
                    End If
                    If x = 40000 Then
                        If p = "end" Or p = "" Then
                            ProgressBar1.Value = ProgressBar1.Maximum
                            miniplayer.ProgressBar1.Value = miniplayer.ProgressBar1.Maximum
                            If CheckBox1.Checked = True Then
                                RichTextBox1.Text = "Looped" + vbCrLf + RichTextBox1.Text
                                Application.DoEvents()
                                Button2_Click(sender, e)
                            End If
                            Application.DoEvents()
                        Else
                            RichTextBox1.Text = "Unknown note : " + p + vbCrLf + RichTextBox1.Text
                        End If
                    ElseIf x = 40001 Then
                        Application.DoEvents()
                    ElseIf ver = False Then
                        RichTextBox1.Text = $"Note : {x} , Dur : {z.ToString}ms{vbCrLf}{RichTextBox1.Text}"
                    Else
                        RichTextBox1.Text = $"Feq : {x.ToString} , Dur : {z.ToString}ms{vbCrLf}{RichTextBox1.Text}"
                    End If
                    If z > 60000 Then
                        ToolTip1.SetToolTip(Me.TextBox1, "This file include some super long notes")
                        TextBox1.BackColor = Color.Gold
                        RichTextBox1.Text = "Lengh way too long @ " + z.ToString + "ms" + vbCrLf + RichTextBox1.Text
                        If DisableLongLenghNotesDetectionToolStripMenuItem.Checked = True Then
                            RichTextBox1.Text = "User ignored the problem." + vbCrLf + RichTextBox1.Text
                            Console.Beep(x, z)
                        Else
                            RichTextBox1.Text = "Note blocked." + vbCrLf + RichTextBox1.Text
                        End If
                    ElseIf z > 15000 Then
                        ToolTip1.SetToolTip(Me.TextBox1, "This file include some long notes")
                        TextBox1.BackColor = Color.Red
                        RichTextBox1.Text = "Lengh too long @ " + z.ToString + "ms" + vbCrLf + RichTextBox1.Text
                        If DisableLongLenghNotesDetectionToolStripMenuItem.Checked = True Then
                            RichTextBox1.Text = "User ignored the problem." + vbCrLf + RichTextBox1.Text
                            Console.Beep(x, z)
                        Else
                            If MsgBox("The following note's lengh is " + z.ToString + " miliseconds, which is pretty long." + vbCrLf + "Do you want to continue ?", vbQuestion + vbYesNo, "Lengh too long") = MsgBoxResult.Yes Then
                                RichTextBox1.Text = "User replied : Yes" + vbCrLf + RichTextBox1.Text
                                Console.Beep(x, z)
                            Else
                                RichTextBox1.Text = "User replied : No" + vbCrLf + RichTextBox1.Text
                                RichTextBox1.Text = "Note skipped." + vbCrLf + RichTextBox1.Text
                            End If
                        End If
                    ElseIf x = 40000 Or x = 40001 Then
                    ElseIf x < 37 Or x > 32767 Then
                        ToolTip1.SetToolTip(Me.TextBox1, "This file include some unplayable notes")
                        RichTextBox1.Text = "Frequency not supported : " + x.ToString + vbCrLf + RichTextBox1.Text
                        TextBox1.BackColor = Color.Gold
                    ElseIf x > 2093 Then
                        ToolTip1.SetToolTip(Me.TextBox1, "This file include some unplayable notes")
                        TextBox1.BackColor = Color.Red
                        RichTextBox1.Text = "Frequency too high @ " + x.ToString + vbCrLf + RichTextBox1.Text
                        If DisableHighPitchNotesDetectionToolStripMenuItem.Checked = True Then
                            RichTextBox1.Text = "User ignored the problem." + vbCrLf + RichTextBox1.Text
                            Console.Beep(x, z)
                        Else
                            If MsgBox("The following note's frequency is " + x.ToString + " , which is pretty high." + vbCrLf + "Do you want to continue ?", vbQuestion + vbYesNo, "Frequency too high") = MsgBoxResult.Yes Then
                                RichTextBox1.Text = "User replied : Yes" + vbCrLf + RichTextBox1.Text
                                Console.Beep(x, z)
                            Else
                                RichTextBox1.Text = "User replied : No" + vbCrLf + RichTextBox1.Text
                                RichTextBox1.Text = "Note skipped." + vbCrLf + RichTextBox1.Text
                            End If
                        End If
                    Else
                        Console.Beep(x, z)
                    End If
                    Try
                        ProgressBar1.Value = ProgressBar1.Value + 1
                        miniplayer.ProgressBar1.Value = miniplayer.ProgressBar1.Value + 1
                    Catch ex As Exception
                    End Try
                    Application.DoEvents()
                Loop
                fileReader.Close()
            End If
        Else
            Form2.Show()
        End If
        Application.DoEvents()
        If Label7.Text = "123" Then
        Else
            RichTextBox1.Text = "Done" + vbCrLf + RichTextBox1.Text
            Label7.Text = "123"
        End If
        Label1.Text = "Press the Play button !"
        Button2.Enabled = True
        Button1.Enabled = True
        TimedPlayToolStripMenuItem.Enabled = True
        PlayToolStripMenuItem1.Enabled = True
        Button5.Enabled = False
        Application.DoEvents()
        Button6.Enabled = True
        miniplayer.Button2.Enabled = True
    End Sub

    Private Sub AboutThisAppToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutThisAppToolStripMenuItem.Click
        Try
            Form3.Opacity = 0
            Form3.Show()
        Catch ex As Exception
            Form5.Show()
        End Try
    End Sub

    Private Sub OpenToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles OpenToolStripMenuItem.Click
        OpenFileDialog1.ShowDialog()
    End Sub

    Private Sub DownloadBMFFilesFromJasonkwokddnsnetToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DownloadBMFFilesFromJasonkwokddnsnetToolStripMenuItem.Click
        Process.Start("iexplore.exe", "http://whoopha.ddns.net/app/beepingmusic/bmf")
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Dim x As Integer = Form4.DateTimePicker1.Value.Second
        Dim y As String
        If x < 10 Then
            y = "0" + x.ToString
        Else
            y = x.ToString
        End If
        If Form4.DateTimePicker1.Value.Hour = Date.Now.Hour And Form4.DateTimePicker1.Value.Minute = Date.Now.Minute And Form4.DateTimePicker1.Value.Second < Date.Now.Second + 10 Then
            If Label1.Text = "AutoPlay in 10 seconds..." Then
            Else
                RichTextBox1.Text = "AutoPlay in 10 seconds..." + vbCrLf + RichTextBox1.Text
                Label1.Text = "AutoPlay in 10 seconds..."
            End If
        End If
        TimedPlayToolStripMenuItem.Text = "Timed Play (" + Form4.DateTimePicker1.Value.ToShortTimeString + ":" + y + ")"
        If Form4.DateTimePicker1.Value.Hour = Date.Now.Hour And Form4.DateTimePicker1.Value.Minute = Date.Now.Minute And Form4.DateTimePicker1.Value.Second = Date.Now.Second Then
            Label1.Text = "Playing..."
            Timer2.Stop()
            RichTextBox1.Text = "AutoPlay by Timed Play" + vbCrLf + RichTextBox1.Text
            Button2_Click(sender, e)
            TimedPlayToolStripMenuItem.Checked = False
            TimedPlayToolStripMenuItem.Text = "Timed Play"
        End If
    End Sub

    Private Sub DisableHighPitchNotesDetectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisableHighPitchNotesDetectionToolStripMenuItem.Click
        If DisableHighPitchNotesDetectionToolStripMenuItem.Checked = True Then
            DisableHighPitchNotesDetectionToolStripMenuItem.Checked = False
        Else
            If MsgBox("Are you sure you want to disable this ?" + vbCrLf + "Warning : Disabling this may damage your hearing.", vbYesNo + vbExclamation, "Disable High Pitch Notes Detection") = vbYes Then
                DisableHighPitchNotesDetectionToolStripMenuItem.Checked = True
            End If
        End If
    End Sub

    Private Sub DisableLongLenghNotesDetectionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DisableLongLenghNotesDetectionToolStripMenuItem.Click
        If DisableLongLenghNotesDetectionToolStripMenuItem.Checked = True Then
            DisableLongLenghNotesDetectionToolStripMenuItem.Checked = False
        Else
            If MsgBox("Are you sure you want to disable this ?" + vbCrLf + "Warning : Disabling this may damage your hearing.", vbYesNo + vbExclamation, "Disable Long Length Notes Detection") = vbYes Then
                DisableLongLenghNotesDetectionToolStripMenuItem.Checked = True
            End If
        End If
    End Sub

    Private Sub TimedPlayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TimedPlayToolStripMenuItem.Click
        If TimedPlayToolStripMenuItem.Checked = True Then
            Try
                Form4.Close()
                Timer2.Stop()
                Form4.Show()
            Catch exx As Exception
                MsgBox(exx.Message, vbCritical + vbOKOnly, "Error")
            End Try
        Else
            Timer2.Stop()
        End If
    End Sub

    Private Sub PlayToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles PlayToolStripMenuItem1.Click
        Button2_Click(sender, e)
    End Sub

    Private Sub EditTransparencyToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditTransparencyToolStripMenuItem.Click
        Label8.Text = Opacity * 100
        Form6.Show()
    End Sub

    Private Sub SettingsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingsToolStripMenuItem.Click
        Setting.Show()
    End Sub

    Private Sub LoopToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoopToolStripMenuItem.Click
        If LoopToolStripMenuItem.Checked = False Then
            CheckBox1.Checked = False
        Else
            CheckBox1.Checked = True
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.Click
        If CheckBox1.Checked = False Then
            LoopToolStripMenuItem.Checked = False
        Else
            LoopToolStripMenuItem.Checked = True
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Button5.Enabled = False
        Label1.Text = "Paused"
        MsgBox("Press OK to unpause.", vbInformation, "Paused")
        Label1.Text = "Playing..."
        Button5.Enabled = True
    End Sub

    Private Sub DownloadOldVersionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DownloadOldVersionToolStripMenuItem.Click
        downoldapp.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        choosefromlist.Show()
    End Sub

    Private Sub UseMiniPlayerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles UseMiniPlayerToolStripMenuItem.Click
        miniplayer.Show()
        Visible = False
        MsgBox("MiniPlayer is super buggy right now, bugs will be fixed in future update.", 64, "Warning")

    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub
End Class
