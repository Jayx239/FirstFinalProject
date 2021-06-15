Public Class Form3
    Inherits System.Windows.Forms.Form

#Region " Windows Form Designer generated code "

    Public Sub New()
        MyBase.New()

        'This call is required by the Windows Form Designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call

    End Sub

    'Form overrides dispose to clean up the component list.
    Protected Overloads Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing Then
            If Not (components Is Nothing) Then
                components.Dispose()
            End If
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    Friend WithEvents cmd2Player As System.Windows.Forms.Button
    Friend WithEvents cmdControls As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Friend WithEvents cmd1Player As System.Windows.Forms.Button
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form3))
        Me.cmd2Player = New System.Windows.Forms.Button
        Me.cmdControls = New System.Windows.Forms.Button
        Me.cmdExit = New System.Windows.Forms.Button
        Me.cmd1Player = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'cmd2Player
        '
        Me.cmd2Player.Location = New System.Drawing.Point(568, 176)
        Me.cmd2Player.Name = "cmd2Player"
        Me.cmd2Player.Size = New System.Drawing.Size(80, 23)
        Me.cmd2Player.TabIndex = 0
        Me.cmd2Player.Text = "Multiplayer"
        '
        'cmdControls
        '
        Me.cmdControls.Location = New System.Drawing.Point(568, 208)
        Me.cmdControls.Name = "cmdControls"
        Me.cmdControls.Size = New System.Drawing.Size(80, 23)
        Me.cmdControls.TabIndex = 1
        Me.cmdControls.Text = "Controls"
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(568, 240)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(80, 23)
        Me.cmdExit.TabIndex = 2
        Me.cmdExit.Text = "Exit"
        '
        'cmd1Player
        '
        Me.cmd1Player.Location = New System.Drawing.Point(568, 144)
        Me.cmd1Player.Name = "cmd1Player"
        Me.cmd1Player.Size = New System.Drawing.Size(80, 23)
        Me.cmd1Player.TabIndex = 3
        Me.cmd1Player.Text = "Single Player"
        '
        'Form3
        '
        Me.AcceptButton = Me.cmd1Player
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(734, 516)
        Me.Controls.Add(Me.cmd1Player)
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.cmdControls)
        Me.Controls.Add(Me.cmd2Player)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form3"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Main Menu"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd2Player.Click
        Dim form1 As New Form1
        Me.Hide()
        form1.ShowDialog()

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click
        Me.Close()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdControls.Click
        MessageBox.Show("Controls" & vbNewLine & vbNewLine & "Player 1" & vbNewLine & "w = Jump Up" & vbNewLine & "s = Jump Down" & vbNewLine & "d = Right" & vbNewLine & "a = Left" & vbNewLine & "e = Jump Right" & vbNewLine & "q = Jump Left" & vbNewLine & "c = Shoot Fireball Right" & vbNewLine & "z = Shoot Fireball Left" & vbNewLine & vbNewLine & "Player 2 (numpad)" & vbNewLine & "8 = Jump Up" & vbNewLine & "5 = Jump Down" & vbNewLine & "6 = Right" & vbNewLine & "4 = Left" & vbNewLine & "9 = Jump Right" & vbNewLine & "7 = Jump Left" & vbNewLine & "3 = Shoot Fireball Right" & vbNewLine & "1 = Shoot Fireball Left", "Controls", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly)
    End Sub

    Private Sub cmd1Player_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmd1Player.Click
        Dim form5 As New Form5
        Me.Hide()
        form5.ShowDialog()

    End Sub
End Class
