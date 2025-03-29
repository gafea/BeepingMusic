<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.ExtendAero1 = New ExtendAero.ExtendAero()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.OpenToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.CloseToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PlayToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoopToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TimedPlayToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisableBadNotesDetectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisableHighPitchNotesDetectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DisableLongLenghNotesDetectionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UseMiniPlayerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExtraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DownloadBMFFilesFromJasonkwokddnsnetToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EditTransparencyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DownloadOldVersionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AboutThisAppToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WebsiteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.DefaultExt = "bmf"
        Me.OpenFileDialog1.Filter = ".bmf files|*.bmf"
        '
        'Button1
        '
        Me.Button1.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button1.Font = New System.Drawing.Font("Century Gothic", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(406, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 28)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Open File"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.Color.WhiteSmoke
        Me.TextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TextBox1.Font = New System.Drawing.Font("Consolas", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(3, 16)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(403, 23)
        Me.TextBox1.TabIndex = 2
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TextBox1)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox1.Location = New System.Drawing.Point(0, 26)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(484, 47)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'ToolTip1
        '
        Me.ToolTip1.ShowAlways = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Dock = System.Windows.Forms.DockStyle.Top
        Me.ProgressBar1.Location = New System.Drawing.Point(0, 126)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(484, 16)
        Me.ProgressBar1.Style = System.Windows.Forms.ProgressBarStyle.Marquee
        Me.ProgressBar1.TabIndex = 5
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.Black
        Me.RichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.RichTextBox1.Font = New System.Drawing.Font("Consolas", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RichTextBox1.ForeColor = System.Drawing.Color.Lime
        Me.RichTextBox1.Location = New System.Drawing.Point(0, 142)
        Me.RichTextBox1.Margin = New System.Windows.Forms.Padding(3, 10, 3, 10)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.ReadOnly = True
        Me.RichTextBox1.Size = New System.Drawing.Size(484, 220)
        Me.RichTextBox1.TabIndex = 6
        Me.RichTextBox1.Text = "Waiting for bmf file..."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(305, 201)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Visible = False
        '
        'Timer1
        '
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(178, 178)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 8
        Me.Label3.Visible = False
        '
        'Timer2
        '
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(128, 231)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(0, 13)
        Me.Label8.TabIndex = 11
        Me.Label8.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(3, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(166, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Waiting for bmf file..."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(202, 16)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(0, 13)
        Me.Label6.TabIndex = 2
        Me.Label6.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(269, 27)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(0, 13)
        Me.Label7.TabIndex = 3
        Me.Label7.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button6)
        Me.GroupBox2.Controls.Add(Me.CheckBox1)
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Button2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Dock = System.Windows.Forms.DockStyle.Top
        Me.GroupBox2.Enabled = False
        Me.GroupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.GroupBox2.Location = New System.Drawing.Point(0, 73)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(484, 53)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        '
        'Button6
        '
        Me.Button6.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button6.Enabled = False
        Me.Button6.Location = New System.Drawing.Point(272, 16)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(92, 34)
        Me.Button6.TabIndex = 6
        Me.Button6.Text = "Choose music..."
        Me.Button6.UseVisualStyleBackColor = True
        Me.Button6.Visible = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.CheckAlign = System.Drawing.ContentAlignment.TopCenter
        Me.CheckBox1.Dock = System.Windows.Forms.DockStyle.Right
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(136, Byte))
        Me.CheckBox1.Location = New System.Drawing.Point(364, 16)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(35, 34)
        Me.CheckBox1.TabIndex = 4
        Me.CheckBox1.Text = "Loop"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.BackgroundImage = Global.BeepingMusic.My.Resources.Resources.Untitled_1
        Me.Button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button5.Enabled = False
        Me.Button5.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button5.Font = New System.Drawing.Font("Microsoft YaHei UI", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button5.Location = New System.Drawing.Point(399, 16)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(43, 34)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "ll"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button5.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.Button2.BackgroundImage = Global.BeepingMusic.My.Resources.Resources.Untitled_1
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Dock = System.Windows.Forms.DockStyle.Right
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(442, 16)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(39, 34)
        Me.Button2.TabIndex = 1
        Me.Button2.Text = "▶"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        Me.Button2.UseVisualStyleBackColor = False
        '
        'ExtendAero1
        '
        Me.ExtendAero1.BackColor = System.Drawing.Color.Black
        Me.ExtendAero1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ExtendAero1.Location = New System.Drawing.Point(0, 0)
        Me.ExtendAero1.Name = "ExtendAero1"
        Me.ExtendAero1.Size = New System.Drawing.Size(484, 362)
        Me.ExtendAero1.TabIndex = 12
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(254, 208)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(0, 13)
        Me.Label9.TabIndex = 13
        Me.Label9.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.AliceBlue
        Me.GroupBox3.BackgroundImage = Global.BeepingMusic.My.Resources.Resources.Untitled_2
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.GroupBox3.Location = New System.Drawing.Point(0, 317)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(484, 45)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Visible = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Dock = System.Windows.Forms.DockStyle.Left
        Me.Label4.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(3, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(118, 21)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "BeepingMusic"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Dock = System.Windows.Forms.DockStyle.Right
        Me.Label5.Font = New System.Drawing.Font("Century Gothic", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(350, 16)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(131, 21)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Whoopha, 2018"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackgroundImage = Global.BeepingMusic.My.Resources.Resources.Untitled_4
        Me.MenuStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.PlayToolStripMenuItem, Me.ExtraToolStripMenuItem, Me.AboutToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.MenuStrip1.Size = New System.Drawing.Size(484, 26)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OpenToolStripMenuItem, Me.ToolStripSeparator1, Me.CloseToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(38, 22)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'OpenToolStripMenuItem
        '
        Me.OpenToolStripMenuItem.Name = "OpenToolStripMenuItem"
        Me.OpenToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.O), System.Windows.Forms.Keys)
        Me.OpenToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.OpenToolStripMenuItem.Text = "Open"
        Me.OpenToolStripMenuItem.ToolTipText = "Open a BMF file"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(147, 6)
        '
        'CloseToolStripMenuItem
        '
        Me.CloseToolStripMenuItem.Name = "CloseToolStripMenuItem"
        Me.CloseToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Alt Or System.Windows.Forms.Keys.F4), System.Windows.Forms.Keys)
        Me.CloseToolStripMenuItem.Size = New System.Drawing.Size(150, 22)
        Me.CloseToolStripMenuItem.Text = "Close"
        Me.CloseToolStripMenuItem.ToolTipText = "Close this app"
        '
        'PlayToolStripMenuItem
        '
        Me.PlayToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PlayToolStripMenuItem1, Me.LoopToolStripMenuItem, Me.TimedPlayToolStripMenuItem, Me.DisableBadNotesDetectionToolStripMenuItem, Me.ToolStripSeparator2, Me.SettingsToolStripMenuItem, Me.UseMiniPlayerToolStripMenuItem})
        Me.PlayToolStripMenuItem.Name = "PlayToolStripMenuItem"
        Me.PlayToolStripMenuItem.Size = New System.Drawing.Size(39, 22)
        Me.PlayToolStripMenuItem.Text = "Play"
        '
        'PlayToolStripMenuItem1
        '
        Me.PlayToolStripMenuItem1.Enabled = False
        Me.PlayToolStripMenuItem1.Name = "PlayToolStripMenuItem1"
        Me.PlayToolStripMenuItem1.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.P), System.Windows.Forms.Keys)
        Me.PlayToolStripMenuItem1.Size = New System.Drawing.Size(214, 22)
        Me.PlayToolStripMenuItem1.Text = "Play"
        Me.PlayToolStripMenuItem1.ToolTipText = "Play the seleted BMF file"
        '
        'LoopToolStripMenuItem
        '
        Me.LoopToolStripMenuItem.CheckOnClick = True
        Me.LoopToolStripMenuItem.Enabled = False
        Me.LoopToolStripMenuItem.Name = "LoopToolStripMenuItem"
        Me.LoopToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.L), System.Windows.Forms.Keys)
        Me.LoopToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.LoopToolStripMenuItem.Text = "Loop"
        '
        'TimedPlayToolStripMenuItem
        '
        Me.TimedPlayToolStripMenuItem.CheckOnClick = True
        Me.TimedPlayToolStripMenuItem.Enabled = False
        Me.TimedPlayToolStripMenuItem.Name = "TimedPlayToolStripMenuItem"
        Me.TimedPlayToolStripMenuItem.ShortcutKeys = CType((System.Windows.Forms.Keys.Control Or System.Windows.Forms.Keys.T), System.Windows.Forms.Keys)
        Me.TimedPlayToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.TimedPlayToolStripMenuItem.Text = "Timed Play"
        Me.TimedPlayToolStripMenuItem.ToolTipText = "Play the selected BMF file at a seleted time"
        '
        'DisableBadNotesDetectionToolStripMenuItem
        '
        Me.DisableBadNotesDetectionToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DisableHighPitchNotesDetectionToolStripMenuItem, Me.DisableLongLenghNotesDetectionToolStripMenuItem})
        Me.DisableBadNotesDetectionToolStripMenuItem.Name = "DisableBadNotesDetectionToolStripMenuItem"
        Me.DisableBadNotesDetectionToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.DisableBadNotesDetectionToolStripMenuItem.Text = "Disable bad notes detection"
        '
        'DisableHighPitchNotesDetectionToolStripMenuItem
        '
        Me.DisableHighPitchNotesDetectionToolStripMenuItem.Name = "DisableHighPitchNotesDetectionToolStripMenuItem"
        Me.DisableHighPitchNotesDetectionToolStripMenuItem.Size = New System.Drawing.Size(251, 22)
        Me.DisableHighPitchNotesDetectionToolStripMenuItem.Text = "Disable high pitch notes detection"
        Me.DisableHighPitchNotesDetectionToolStripMenuItem.ToolTipText = "Even if the note's fequence is higher then 2500, don't block it." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Warning : Disab" &
    "ling this may damage your hearing."
        '
        'DisableLongLenghNotesDetectionToolStripMenuItem
        '
        Me.DisableLongLenghNotesDetectionToolStripMenuItem.Name = "DisableLongLenghNotesDetectionToolStripMenuItem"
        Me.DisableLongLenghNotesDetectionToolStripMenuItem.Size = New System.Drawing.Size(251, 22)
        Me.DisableLongLenghNotesDetectionToolStripMenuItem.Text = "Disable long length notes detection"
        Me.DisableLongLenghNotesDetectionToolStripMenuItem.ToolTipText = "Even if the note's length is longer then 15 seconds, don't block it." & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Warning : D" &
    "isabling this may damage your hearing."
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(211, 6)
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Enabled = False
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'UseMiniPlayerToolStripMenuItem
        '
        Me.UseMiniPlayerToolStripMenuItem.Name = "UseMiniPlayerToolStripMenuItem"
        Me.UseMiniPlayerToolStripMenuItem.Size = New System.Drawing.Size(214, 22)
        Me.UseMiniPlayerToolStripMenuItem.Text = "Use MiniPlayer"
        '
        'ExtraToolStripMenuItem
        '
        Me.ExtraToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DownloadBMFFilesFromJasonkwokddnsnetToolStripMenuItem, Me.EditTransparencyToolStripMenuItem, Me.DownloadOldVersionToolStripMenuItem})
        Me.ExtraToolStripMenuItem.Name = "ExtraToolStripMenuItem"
        Me.ExtraToolStripMenuItem.Size = New System.Drawing.Size(46, 22)
        Me.ExtraToolStripMenuItem.Text = "Extra"
        '
        'DownloadBMFFilesFromJasonkwokddnsnetToolStripMenuItem
        '
        Me.DownloadBMFFilesFromJasonkwokddnsnetToolStripMenuItem.Name = "DownloadBMFFilesFromJasonkwokddnsnetToolStripMenuItem"
        Me.DownloadBMFFilesFromJasonkwokddnsnetToolStripMenuItem.Size = New System.Drawing.Size(297, 22)
        Me.DownloadBMFFilesFromJasonkwokddnsnetToolStripMenuItem.Text = "Download BMF files from whoopha.ddns.net"
        '
        'EditTransparencyToolStripMenuItem
        '
        Me.EditTransparencyToolStripMenuItem.Name = "EditTransparencyToolStripMenuItem"
        Me.EditTransparencyToolStripMenuItem.Size = New System.Drawing.Size(297, 22)
        Me.EditTransparencyToolStripMenuItem.Text = "Adjust Transparency Level"
        '
        'DownloadOldVersionToolStripMenuItem
        '
        Me.DownloadOldVersionToolStripMenuItem.Name = "DownloadOldVersionToolStripMenuItem"
        Me.DownloadOldVersionToolStripMenuItem.Size = New System.Drawing.Size(297, 22)
        Me.DownloadOldVersionToolStripMenuItem.Text = "Download Old Version"
        Me.DownloadOldVersionToolStripMenuItem.ToolTipText = "Download the old version of BeepingMusic (Beta version only)"
        '
        'AboutToolStripMenuItem
        '
        Me.AboutToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AboutThisAppToolStripMenuItem, Me.WebsiteToolStripMenuItem})
        Me.AboutToolStripMenuItem.Name = "AboutToolStripMenuItem"
        Me.AboutToolStripMenuItem.Size = New System.Drawing.Size(51, 22)
        Me.AboutToolStripMenuItem.Text = "About"
        '
        'AboutThisAppToolStripMenuItem
        '
        Me.AboutThisAppToolStripMenuItem.Name = "AboutThisAppToolStripMenuItem"
        Me.AboutThisAppToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.AboutThisAppToolStripMenuItem.Text = "About this App"
        '
        'WebsiteToolStripMenuItem
        '
        Me.WebsiteToolStripMenuItem.Name = "WebsiteToolStripMenuItem"
        Me.WebsiteToolStripMenuItem.Size = New System.Drawing.Size(152, 22)
        Me.WebsiteToolStripMenuItem.Text = "Website"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(484, 362)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ExtendAero1)
        Me.Controls.Add(Me.Label9)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.MinimumSize = New System.Drawing.Size(500, 400)
        Me.Name = "Form1"
        Me.Opacity = 0.93R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "BeepingMusic"
        Me.TransparencyKey = System.Drawing.Color.DimGray
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CloseToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AboutThisAppToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WebsiteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Label3 As Label
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label5 As Label
    Friend WithEvents ExtraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DownloadBMFFilesFromJasonkwokddnsnetToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Timer2 As Timer
    Friend WithEvents PlayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents TimedPlayToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisableBadNotesDetectionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisableHighPitchNotesDetectionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DisableLongLenghNotesDetectionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PlayToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents EditTransparencyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label8 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExtendAero1 As ExtendAero.ExtendAero
    Friend WithEvents LoopToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Button5 As Button
    Friend WithEvents DownloadOldVersionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Label9 As Label
    Friend WithEvents Button6 As Button
    Friend WithEvents UseMiniPlayerToolStripMenuItem As ToolStripMenuItem
End Class
