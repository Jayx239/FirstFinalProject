Public Class Form5
    Inherits System.Windows.Forms.Form
    Dim i, x, y, z, x1, y1, key1, key2, key3, key4, key5, key6, key7, key8, key9, key10, key11, key12, key13, key14, key15, key16, random As Integer
    Dim right1, left1, right2, left2 As Image
    Dim randomnum As New Random
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
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents mnuPause As System.Windows.Forms.MenuItem
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents lbl4 As System.Windows.Forms.Label
    Friend WithEvents imgFireball1 As System.Windows.Forms.PictureBox
    Friend WithEvents MainMenu1 As System.Windows.Forms.MainMenu
    Friend WithEvents mnuRestart As System.Windows.Forms.MenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.MenuItem
    Friend WithEvents img1 As System.Windows.Forms.PictureBox
    Friend WithEvents img2 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl3 As System.Windows.Forms.Label
    Friend WithEvents imgBase As System.Windows.Forms.PictureBox
    Friend WithEvents lbl2 As System.Windows.Forms.Label
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents imgBlock3 As System.Windows.Forms.PictureBox
    Friend WithEvents imgBlock2 As System.Windows.Forms.PictureBox
    Friend WithEvents imgBlock As System.Windows.Forms.PictureBox
    Friend WithEvents imgFireball As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents MainMenu2 As System.Windows.Forms.MainMenu
    Friend WithEvents mnuP As System.Windows.Forms.MenuItem
    Friend WithEvents mnuR As System.Windows.Forms.MenuItem
    Friend WithEvents mnuE As System.Windows.Forms.MenuItem
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form5))
        Me.Label2 = New System.Windows.Forms.Label
        Me.mnuPause = New System.Windows.Forms.MenuItem
        Me.Label1 = New System.Windows.Forms.Label
        Me.lbl4 = New System.Windows.Forms.Label
        Me.imgFireball1 = New System.Windows.Forms.PictureBox
        Me.MainMenu1 = New System.Windows.Forms.MainMenu
        Me.mnuRestart = New System.Windows.Forms.MenuItem
        Me.mnuExit = New System.Windows.Forms.MenuItem
        Me.img1 = New System.Windows.Forms.PictureBox
        Me.img2 = New System.Windows.Forms.PictureBox
        Me.lbl3 = New System.Windows.Forms.Label
        Me.imgBase = New System.Windows.Forms.PictureBox
        Me.lbl2 = New System.Windows.Forms.Label
        Me.lbl1 = New System.Windows.Forms.Label
        Me.imgBlock3 = New System.Windows.Forms.PictureBox
        Me.imgBlock2 = New System.Windows.Forms.PictureBox
        Me.imgBlock = New System.Windows.Forms.PictureBox
        Me.imgFireball = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.MainMenu2 = New System.Windows.Forms.MainMenu
        Me.mnuP = New System.Windows.Forms.MenuItem
        Me.mnuR = New System.Windows.Forms.MenuItem
        Me.mnuE = New System.Windows.Forms.MenuItem
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.Location = New System.Drawing.Point(40, 8)
        Me.Label2.Name = "Label2"
        Me.Label2.TabIndex = 29
        Me.Label2.Text = "Mario Lives"
        '
        'mnuPause
        '
        Me.mnuPause.Index = 0
        Me.mnuPause.Text = "Pause"
        '
        'Label1
        '
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.Location = New System.Drawing.Point(728, 8)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(104, 23)
        Me.Label1.TabIndex = 28
        Me.Label1.Text = "Donkey Kong Lives"
        '
        'lbl4
        '
        Me.lbl4.Image = CType(resources.GetObject("lbl4.Image"), System.Drawing.Image)
        Me.lbl4.Location = New System.Drawing.Point(48, 32)
        Me.lbl4.Name = "lbl4"
        Me.lbl4.TabIndex = 27
        Me.lbl4.Text = "10"
        '
        'imgFireball1
        '
        Me.imgFireball1.Image = CType(resources.GetObject("imgFireball1.Image"), System.Drawing.Image)
        Me.imgFireball1.Location = New System.Drawing.Point(0, 16)
        Me.imgFireball1.Name = "imgFireball1"
        Me.imgFireball1.Size = New System.Drawing.Size(33, 32)
        Me.imgFireball1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgFireball1.TabIndex = 26
        Me.imgFireball1.TabStop = False
        Me.imgFireball1.Visible = False
        '
        'MainMenu1
        '
        Me.MainMenu1.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuPause, Me.mnuRestart, Me.mnuExit})
        '
        'mnuRestart
        '
        Me.mnuRestart.Index = 1
        Me.mnuRestart.Text = "Restart"
        '
        'mnuExit
        '
        Me.mnuExit.Index = 2
        Me.mnuExit.Text = "Exit"
        '
        'img1
        '
        Me.img1.Image = CType(resources.GetObject("img1.Image"), System.Drawing.Image)
        Me.img1.Location = New System.Drawing.Point(176, 184)
        Me.img1.Name = "img1"
        Me.img1.Size = New System.Drawing.Size(48, 50)
        Me.img1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img1.TabIndex = 16
        Me.img1.TabStop = False
        '
        'img2
        '
        Me.img2.Image = CType(resources.GetObject("img2.Image"), System.Drawing.Image)
        Me.img2.Location = New System.Drawing.Point(528, 184)
        Me.img2.Name = "img2"
        Me.img2.Size = New System.Drawing.Size(48, 50)
        Me.img2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img2.TabIndex = 18
        Me.img2.TabStop = False
        '
        'lbl3
        '
        Me.lbl3.BackColor = System.Drawing.SystemColors.Desktop
        Me.lbl3.Image = CType(resources.GetObject("lbl3.Image"), System.Drawing.Image)
        Me.lbl3.Location = New System.Drawing.Point(592, 8)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(8, 8)
        Me.lbl3.TabIndex = 25
        Me.lbl3.Visible = False
        '
        'imgBase
        '
        Me.imgBase.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.imgBase.Image = CType(resources.GetObject("imgBase.Image"), System.Drawing.Image)
        Me.imgBase.Location = New System.Drawing.Point(24, 234)
        Me.imgBase.Name = "imgBase"
        Me.imgBase.Size = New System.Drawing.Size(784, 38)
        Me.imgBase.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgBase.TabIndex = 24
        Me.imgBase.TabStop = False
        '
        'lbl2
        '
        Me.lbl2.Image = CType(resources.GetObject("lbl2.Image"), System.Drawing.Image)
        Me.lbl2.Location = New System.Drawing.Point(736, 32)
        Me.lbl2.Name = "lbl2"
        Me.lbl2.TabIndex = 23
        Me.lbl2.Text = "10"
        '
        'lbl1
        '
        Me.lbl1.BackColor = System.Drawing.SystemColors.Desktop
        Me.lbl1.Image = CType(resources.GetObject("lbl1.Image"), System.Drawing.Image)
        Me.lbl1.Location = New System.Drawing.Point(592, 16)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(8, 8)
        Me.lbl1.TabIndex = 22
        Me.lbl1.Visible = False
        '
        'imgBlock3
        '
        Me.imgBlock3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.imgBlock3.Image = CType(resources.GetObject("imgBlock3.Image"), System.Drawing.Image)
        Me.imgBlock3.Location = New System.Drawing.Point(520, 104)
        Me.imgBlock3.Name = "imgBlock3"
        Me.imgBlock3.Size = New System.Drawing.Size(227, 32)
        Me.imgBlock3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgBlock3.TabIndex = 21
        Me.imgBlock3.TabStop = False
        '
        'imgBlock2
        '
        Me.imgBlock2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.imgBlock2.Image = CType(resources.GetObject("imgBlock2.Image"), System.Drawing.Image)
        Me.imgBlock2.Location = New System.Drawing.Point(64, 96)
        Me.imgBlock2.Name = "imgBlock2"
        Me.imgBlock2.Size = New System.Drawing.Size(227, 32)
        Me.imgBlock2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgBlock2.TabIndex = 20
        Me.imgBlock2.TabStop = False
        '
        'imgBlock
        '
        Me.imgBlock.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.imgBlock.Image = CType(resources.GetObject("imgBlock.Image"), System.Drawing.Image)
        Me.imgBlock.Location = New System.Drawing.Point(288, 184)
        Me.imgBlock.Name = "imgBlock"
        Me.imgBlock.Size = New System.Drawing.Size(227, 32)
        Me.imgBlock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgBlock.TabIndex = 19
        Me.imgBlock.TabStop = False
        '
        'imgFireball
        '
        Me.imgFireball.Image = CType(resources.GetObject("imgFireball.Image"), System.Drawing.Image)
        Me.imgFireball.Location = New System.Drawing.Point(0, 0)
        Me.imgFireball.Name = "imgFireball"
        Me.imgFireball.Size = New System.Drawing.Size(33, 32)
        Me.imgFireball.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgFireball.TabIndex = 17
        Me.imgFireball.TabStop = False
        Me.imgFireball.Visible = False
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-8, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(856, 311)
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        '
        'MainMenu2
        '
        Me.MainMenu2.MenuItems.AddRange(New System.Windows.Forms.MenuItem() {Me.mnuP, Me.mnuR, Me.mnuE})
        '
        'mnuP
        '
        Me.mnuP.Index = 0
        Me.mnuP.Text = "Pause"
        '
        'mnuR
        '
        Me.mnuR.Index = 1
        Me.mnuR.Text = "Restart"
        '
        'mnuE
        '
        Me.mnuE.Index = 2
        Me.mnuE.Text = "Exit"
        '
        'Form5
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(840, 273)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.lbl4)
        Me.Controls.Add(Me.imgFireball1)
        Me.Controls.Add(Me.img1)
        Me.Controls.Add(Me.img2)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.imgBase)
        Me.Controls.Add(Me.lbl2)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.imgBlock3)
        Me.Controls.Add(Me.imgBlock2)
        Me.Controls.Add(Me.imgBlock)
        Me.Controls.Add(Me.imgFireball)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Menu = Me.MainMenu2
        Me.Name = "Form5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mario Versus Donkey Kong"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub jumpright1()
        For i = 0 To 10
            Me.Refresh()
            img1.Left += 3
            img1.Top -= 6
        Next
        For i = 0 To 10
            Me.Refresh()
            img1.Left += 3
            img1.Top += 6
        Next
    End Sub

    Private Sub jumpleft1()
        For i = 0 To 10
            Me.Refresh()
            img1.Left -= 3
            img1.Top -= 6
        Next
        For i = 0 To 10
            Me.Refresh()
            img1.Left -= 3
            img1.Top += 6
        Next
    End Sub
    Private Sub walkright1()
        For i = 0 To 3
            Me.Refresh()
            img1.Left += 5
        Next
    End Sub

    Private Sub walkleft1()
        For i = 0 To 3
            Me.Refresh()
            img1.Left -= 5
        Next
    End Sub

    Private Sub jumpup1()
        For i = 0 To 10
            Me.Refresh()
            img1.Top -= 6
        Next
        For i = 0 To 10
            Me.Refresh()
            img1.Top += 6
        Next
    End Sub

    Private Sub Hitdetection1()
        If img2.Top - imgFireball.Top <= 0 AndAlso img2.Top - imgFireball.Top >= -15 AndAlso imgFireball.Left - img2.Left <= 15 AndAlso imgFireball.Left - img2.Left >= -15 Then
            imgFireball.Visible = False
            lbl1.Visible = False
            lbl1.Text += "T"
            lbl2.Text = 10 - lbl1.Text.Length
            imgFireball.Left = 0
            imgFireball.Top = 0
        End If
    End Sub
    Private Sub Hitdetection2()
        If img1.Top - imgFireball1.Top <= 0 AndAlso img1.Top - imgFireball1.Top >= -15 AndAlso imgFireball1.Left - img1.Left <= 15 AndAlso imgFireball1.Left - img1.Left >= -15 Then
            imgFireball1.Visible = False
            lbl3.Visible = False
            lbl3.Text += "T"
            lbl4.Text = 10 - lbl3.Text.Length
            imgFireball1.Left = 0
            imgFireball1.Top = 0
        End If
    End Sub

    Private Sub Form1_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        random = randomnum.Next(0, 3)
        x = img1.Left
        y = img1.Top

        right1 = Image.FromFile("e:\Final Project\Images\mariofaceright.jpg")
        left1 = Image.FromFile("e:\Final Project\Images\mariofaceleft.jpg")
        imgFireball.Image = Image.FromFile("e:\Final Project\Images\fireball.jpg")
        right2 = Image.FromFile("e:\Final Project\Images\donkeykongright.jpg")
        left2 = Image.FromFile("e:\Final Project\Images\donkeykongleft.jpg")
        If e.KeyCode = Keys.E Then    'Jump Right
            key1 = 1

        End If
        If e.KeyCode = Keys.Q Then          'Jump Left
            key2 = 1
        End If

        If e.KeyCode = Keys.W Then         'Jump Straight up
            key3 = 1
        End If

        If e.KeyCode = Keys.D Then         'Move Right
            key4 = 1
        End If

        If e.KeyCode = Keys.A Then         'Move left
            key5 = 1
        End If

        If e.KeyCode = Keys.C Then         'Shoot Fireball right
            key6 = 1

        End If
        If e.KeyCode = Keys.Z Then         'Shoot Fireball left
            key7 = 1
        End If

        If e.KeyCode = Keys.S Then          'Jump Down
            key8 = 1
        End If

        If key1 = 1 Then
            img1.Image = right1
            Call jumpright1()

        End If

        If key2 = 1 Then
            img1.Image = left1
            Call jumpleft1()
        End If

        If key3 = 1 Then
            Call jumpup1()
        End If

        If key4 = 1 Then
            img1.Image = right1
            Call walkright1()
        End If

        If key5 = 1 Then
            img1.Image = left1
            Call walkleft1()
        End If

        If key6 = 1 Then
            img1.Image = right1
            imgFireball.Left = x
            imgFireball.Top = y
            imgFireball.Visible = True
            For i = 0 To 3
                For z = 0 To 3
                    Me.Refresh()
                    imgFireball.Left += 10
                    imgFireball.Top += 5
                    Call Hitdetection1()
                Next

                For z = 0 To 3
                    Me.Refresh()
                    imgFireball.Left += 10
                    imgFireball.Top -= 5
                    Call Hitdetection1()
                Next
            Next
            imgFireball.Visible = False
        End If

        If key7 = 1 Then
            img1.Image = left1
            imgFireball.Left = x
            imgFireball.Top = y
            imgFireball.Visible = True
            For i = 0 To 3
                For z = 0 To 3
                    Me.Refresh()
                    imgFireball.Left -= 10
                    imgFireball.Top += 5
                    Call Hitdetection1()
                Next

                For z = 0 To 3
                    Me.Refresh()
                    imgFireball.Left -= 10
                    imgFireball.Top -= 5
                    Call Hitdetection1()
                Next
            Next
            imgFireball.Visible = False
        End If

        'XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXx Player 1
        If img1.Left > imgBlock.Left - 48 AndAlso img1.Left < imgBlock.Left + 227 AndAlso key3 = 1 AndAlso img1.Top = imgBlock.Top Then          'Block Jump up
            img1.Top = imgBlock.Top - 50
        ElseIf img1.Left > (imgBlock2.Left - 48) AndAlso img1.Left < (imgBlock2.Left + 227) AndAlso key3 = 1 AndAlso img1.Top = imgBlock.Top - 50 Then                       'Jump onto block2
            img1.Top = imgBlock2.Top - 50
        ElseIf img1.Left > (imgBlock3.Left - 48) AndAlso img1.Left < (imgBlock3.Left + 227) AndAlso key3 = 1 AndAlso img1.Top = imgBlock.Top - 50 Then                  ' Jump onto block3
            img1.Top = imgBlock3.Top - 50


        ElseIf img1.Left > imgBlock.Left - 48 AndAlso img1.Left < imgBlock.Left + 227 AndAlso key1 = 1 AndAlso img1.Top = imgBlock.Top Then           'Block Jump Right
            img1.Top = imgBlock.Top - 50
        ElseIf img1.Left > (imgBlock3.Left - 48) AndAlso img1.Left < (imgBlock3.Left + 227) AndAlso key1 = 1 AndAlso img1.Top = imgBlock.Top - 50 Then                       'Jump sideways onto block3
            img1.Top = imgBlock3.Top - 50

        ElseIf img1.Left > imgBlock.Left - 48 AndAlso img1.Left < imgBlock.Left + 227 AndAlso key2 = 1 AndAlso img1.Top = imgBlock.Top Then            'Block Jump Left
            img1.Top = imgBlock.Top - 50
        ElseIf img1.Left > (imgBlock2.Left - 48) AndAlso img1.Left < (imgBlock2.Left + 227) AndAlso key2 = 1 AndAlso img1.Top = imgBlock.Top - 50 Then                       'Jump sideways onto block2
            img1.Top = imgBlock2.Top - 50

        ElseIf img1.Left > imgBlock.Left - 48 AndAlso img1.Left < imgBlock.Left + 227 AndAlso key8 = 1 AndAlso img1.Top = imgBlock.Top - 50 Then          'Block Jump down
            img1.Top = imgBlock.Top
        ElseIf img1.Left > imgBlock2.Left - 48 AndAlso img1.Left < imgBlock2.Left + 227 AndAlso key8 = 1 AndAlso img1.Top = imgBlock2.Top - 50 Then      'Block2 jump down
            img1.Top = imgBlock.Top
        ElseIf img1.Left > imgBlock3.Left - 48 AndAlso img1.Left < imgBlock3.Left + 227 AndAlso key8 = 1 AndAlso img1.Top = imgBlock3.Top - 50 Then      'block3 jump down
            img1.Top = imgBlock.Top

        ElseIf img1.Left < imgBlock.Left - 48 AndAlso img1.Top = imgBlock.Top - 50 OrElse img1.Left > (imgBlock.Left + 227) AndAlso img1.Top = imgBlock.Top - 50 Then           'Falling off the edge
            img1.Top = imgBlock.Top
        ElseIf img1.Left > imgBlock2.Left + 227 AndAlso img1.Top = imgBlock2.Top - 50 Then       'falling off edge block2 right                                                                                 'Falling off edge block2 right
            img1.Top = imgBlock.Top - 50
        ElseIf img1.Left < imgBlock2.Left - 48 AndAlso img1.Top = imgBlock2.Top - 50 Then       'Falling off edge block2 left
            img1.Top = imgBlock.Top
        ElseIf img1.Left > imgBlock3.Left + 227 AndAlso img1.Top = imgBlock3.Top - 50 Then      'falling off edge block3 right
            img1.Top = imgBlock.Top
        ElseIf img1.Left < imgBlock3.Left - 48 AndAlso img1.Top = imgBlock3.Top - 50 Then       'Falling off edge block3 left
            img1.Top = imgBlock.Top - 50

        ElseIf img1.Left < imgBase.Left - 50 AndAlso img1.Top = imgBase.Top - 50 Then               'Falling off edge of base left
            For i = 0 To 75
                Me.Refresh()
                img1.Top += 2
                img1.Left -= 1
            Next

            Select Case (random)
                Case 0                                                                              'Start middle left
                    img1.Top = imgBlock.Top - 50
                    img1.Left = imgBlock.Left
                Case 1                                                                              'Start left top left
                    img1.Top = imgBlock2.Top - 50
                    img1.Left = imgBlock2.Left
                Case 2                                                                              'Start right top Block
                    img1.Top = imgBlock3.Top - 50
                    img1.Left = imgBlock3.Left
                Case 3                                                                              'Start base left
                    img1.Top = imgBase.Top - 50
                    img1.Left = imgBase.Left
            End Select
            lbl3.Text += "T"
            lbl4.Text = 10 - lbl3.Text.Length
        ElseIf img1.Left > imgBase.Left + 784 AndAlso img1.Top = imgBase.Top - 50 Then              'Fall off edge base right
            For i = 0 To 75
                Me.Refresh()
                img1.Top += 2
                img1.Left += 1
            Next

            Select Case (random)
                Case 0                                                                              'Start middle left
                    img1.Top = imgBlock.Top - 50
                    img1.Left = imgBlock.Left
                Case 1                                                                              'Start left top left
                    img1.Top = imgBlock2.Top - 50
                    img1.Left = imgBlock2.Left
                Case 2                                                                              'Start right top Block
                    img1.Top = imgBlock3.Top - 50
                    img1.Left = imgBlock3.Left
                Case 3                                                                              'Start base left
                    img1.Top = imgBase.Top - 50
                    img1.Left = imgBase.Left
            End Select
            lbl3.Text += "T"
            lbl4.Text = 10 - lbl3.Text.Length
        End If
        'XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXx
        If lbl1.Text.Length = 10 Then                   'Move to form 2
            winner = 1
        End If
        If winner = 1 Then
            Timer1.Enabled = False
            Dim form6 As New Form6
            Me.Hide()
            form6.ShowDialog()
        End If

    End Sub

    Private Sub Form1_KeyUp(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyUp
        If e.KeyCode = Keys.E Then    'Jump Right
            key1 = 0
        End If

        If e.KeyCode = Keys.Q Then          'Jump Left
            key2 = 0
        End If

        If e.KeyCode = Keys.W Then         'Jump Straight up
            key3 = 0
        End If

        If e.KeyCode = Keys.D Then         'Move Right
            key4 = 0
        End If

        If e.KeyCode = Keys.A Then         'Move left
            key5 = 0
        End If

        If e.KeyCode = Keys.C Then         'Shoot Fireball right
            key6 = 0
        End If

        If e.KeyCode = Keys.Z Then         'Shoot Fireball left
            key7 = 0
        End If

        If e.KeyCode = Keys.S Then          'Jump Down
            key8 = 0
        End If

    End Sub

    Private Sub jumpright2()
        For i = 0 To 10
            Me.Refresh()
            img2.Left += 3
            img2.Top -= 6
        Next
        For i = 0 To 10
            Me.Refresh()
            img2.Left += 3
            img2.Top += 6
        Next
    End Sub

    Private Sub jumpleft2()
        For i = 0 To 10
            Me.Refresh()
            img2.Left -= 3
            img2.Top -= 6
        Next
        For i = 0 To 10
            Me.Refresh()
            img2.Left -= 3
            img2.Top += 6
        Next
    End Sub
    Private Sub walkright2()
        For i = 0 To 3
            Me.Refresh()
            img2.Left += 5
        Next
    End Sub

    Private Sub walkleft2()
        For i = 0 To 3
            Me.Refresh()
            img2.Left -= 5
        Next
    End Sub

    Private Sub jumpup2()
        For i = 0 To 10
            Me.Refresh()
            img2.Top -= 6
        Next
        For i = 0 To 10
            Me.Refresh()
            img2.Top += 6
        Next
    End Sub

    Private Sub MenuItem3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuExit.Click
        Me.Close()
    End Sub

    Private Sub mnuRestart_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuRestart.Click
        lbl1.Text = ""
        lbl2.Text = "10"
        lbl3.Text = ""
        lbl4.Text = "10"
    End Sub

    Private Sub mnuPause_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuPause.Click
        MessageBox.Show("Paused", "Paused", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly)

    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
       
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        random = randomnum.Next(0, 3)
        right2 = Image.FromFile("e:\Final Project\Images\donkeykongright.jpg")
        left2 = Image.FromFile("e:\Final Project\Images\donkeykongleft.jpg")
        x1 = img2.Left
        y1 = img2.Top
        If img1.Left > img2.Left AndAlso img1.Top < img2.Top Then          'Computer Jump Right
            key9 = 1
            key10 = 0
            key11 = 0
            img2.Image = right2
            Call jumpright2()


        ElseIf img1.Left < img2.Left AndAlso img1.Top < img2.Top Then      'Computer Jump Left
            key9 = 0
            key10 = 1
            key11 = 0
            img2.Image = left2
            Call jumpleft2()

        ElseIf img1.Left = img2.Left AndAlso img1.Top < img2.Top Then       'Computer Jump Up
            key9 = 0
            key10 = 0
            key11 = 1
            Call jumpup2()


        ElseIf img1.Left - img2.Left > 320 AndAlso img1.Top = img2.Top OrElse img2.Top < img1.Top AndAlso img2.Left < img1.Left Then       'Computer Walk right
            key9 = 0
            key10 = 0
            key11 = 0
            img2.Image = right2
            Call walkright2()



        ElseIf img2.Left - img1.Left > 320 AndAlso img1.Top = img2.Top OrElse img2.Top < img1.Top AndAlso img2.Left > img1.Left Then         'Computer walk left
            key9 = 0
            key10 = 0
            key11 = 0
            img2.Image = left2
            Call walkleft2()

        ElseIf img2.Top < img1.Top AndAlso img2.Left >= img1.Left - 150 OrElse img2.Top < img1.Top AndAlso img2.Left <= img1.Left + 150 Then       'Computer jump down
            key9 = 0
            key10 = 0
            key11 = 0
            img2.Top = imgBase.Top

        End If
        If img2.Left < img1.Left AndAlso img2.Left > img1.Left - 320 AndAlso img1.Top = img2.Top Then       'Computer Shoot Fireball right
            key9 = 0
            key10 = 0
            key11 = 0
            img2.Image = right2
            imgFireball1.Left = x1
            imgFireball1.Top = y1
            imgFireball1.Visible = True
            For i = 0 To 3
                For z = 0 To 3
                    Me.Refresh()
                    imgFireball1.Left += 10
                    imgFireball1.Top += 5
                    Call Hitdetection2()
                Next

                For z = 0 To 3
                    Me.Refresh()
                    imgFireball1.Left += 10
                    imgFireball1.Top -= 5
                    Call Hitdetection2()
                Next
            Next
            imgFireball1.Visible = False
        End If

        If img2.Left > img1.Left AndAlso img2.Left < img1.Left + 320 AndAlso img1.Top = img2.Top Then           'Computer Shoot Fireball left
            key9 = 0
            key10 = 0
            key11 = 0
            img2.Image = left2
            imgFireball1.Left = x1
            imgFireball1.Top = y1
            imgFireball1.Visible = True
            For i = 0 To 3
                For z = 0 To 3
                    Me.Refresh()
                    imgFireball1.Left -= 10
                    imgFireball1.Top += 5
                    Call Hitdetection2()
                Next

                For z = 0 To 3
                    Me.Refresh()
                    imgFireball1.Left -= 10
                    imgFireball1.Top -= 5
                    Call Hitdetection2()
                Next
            Next
            imgFireball1.Visible = False
        End If
        'XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXx Player 2

        If img2.Left > imgBlock.Left - 48 AndAlso img2.Left < imgBlock.Left + 227 AndAlso key11 = 1 AndAlso img2.Top = imgBlock.Top Then          'Block Jump up
            img2.Top = imgBlock.Top - 50
        ElseIf img2.Left > (imgBlock2.Left - 48) AndAlso img2.Left < (imgBlock2.Left + 227) AndAlso key11 = 1 AndAlso img2.Top = imgBlock.Top - 50 Then                       'Jump onto block2
            img2.Top = imgBlock2.Top - 50
        ElseIf img2.Left > (imgBlock3.Left - 48) AndAlso img2.Left < (imgBlock3.Left + 227) AndAlso key11 = 1 AndAlso img2.Top = imgBlock.Top - 50 Then                  ' Jump onto block3
            img2.Top = imgBlock3.Top - 50


        ElseIf img2.Left > imgBlock.Left - 48 AndAlso img2.Left < imgBlock.Left + 227 AndAlso key9 = 1 AndAlso img2.Top = imgBlock.Top Then           'Block Jump Right
            img2.Top = imgBlock.Top - 50
        ElseIf img2.Left > (imgBlock3.Left - 48) AndAlso img2.Left < (imgBlock3.Left + 227) AndAlso key9 = 1 AndAlso img2.Top = imgBlock.Top - 50 Then                       'Jump sideways onto block3
            img2.Top = imgBlock3.Top - 50

        ElseIf img2.Left > imgBlock.Left - 48 AndAlso img2.Left < imgBlock.Left + 227 AndAlso key10 = 1 AndAlso img2.Top = imgBlock.Top Then            'Block Jump Left
            img2.Top = imgBlock.Top - 50
        ElseIf img2.Left > (imgBlock2.Left - 48) AndAlso img2.Left < (imgBlock2.Left + 227) AndAlso key10 = 1 AndAlso img2.Top = imgBlock.Top - 50 Then                       'Jump sideways onto block2
            img2.Top = imgBlock2.Top - 50

        ElseIf img2.Left > imgBlock.Left - 48 AndAlso img2.Left < imgBlock.Left + 227 AndAlso key16 = 1 AndAlso img2.Top = imgBlock.Top - 50 Then          'Block Jump down
            img2.Top = imgBlock.Top
        ElseIf img2.Left > imgBlock2.Left - 48 AndAlso img2.Left < imgBlock2.Left + 227 AndAlso key16 = 1 AndAlso img2.Top = imgBlock2.Top - 50 Then      'Block2 jump down
            img2.Top = imgBlock.Top
        ElseIf img2.Left > imgBlock3.Left - 48 AndAlso img2.Left < imgBlock3.Left + 227 AndAlso key16 = 1 AndAlso img2.Top = imgBlock3.Top - 50 Then      'block3 jump down
            img2.Top = imgBlock.Top

        ElseIf img2.Left < imgBlock.Left - 48 AndAlso img2.Top = imgBlock.Top - 50 OrElse img2.Left > (imgBlock.Left + 227) AndAlso img2.Top = imgBlock.Top - 50 Then           'Falling off the edge
            img2.Top = imgBlock.Top
        ElseIf img2.Left > imgBlock2.Left + 227 AndAlso img2.Top = imgBlock2.Top - 50 Then       'falling off edge block2 right                                                                                 'Falling off edge block2 right
            img2.Top = imgBlock.Top - 50
        ElseIf img2.Left < imgBlock2.Left - 48 AndAlso img2.Top = imgBlock2.Top - 50 Then       'Falling off edge block2 left
            img2.Top = imgBlock.Top
        ElseIf img2.Left > imgBlock3.Left + 227 AndAlso img2.Top = imgBlock3.Top - 50 Then      'falling off edge block3 right
            img2.Top = imgBlock.Top
        ElseIf img2.Left < imgBlock3.Left - 48 AndAlso img2.Top = imgBlock3.Top - 50 Then       'Falling off edge block3 left
            img2.Top = imgBlock.Top - 50

        ElseIf img2.Left < imgBase.Left - 50 AndAlso img2.Top = imgBase.Top - 50 Then               'Falling off edge of base left
            For i = 0 To 75
                Me.Refresh()
                img2.Top += 2
                img2.Left -= 1
            Next

            Select Case (random)
                Case 0                                                                              'Start middle left
                    img2.Top = imgBlock.Top - 50
                    img2.Left = imgBlock.Left
                Case 1                                                                              'Start left top left
                    img2.Top = imgBlock2.Top - 50
                    img2.Left = imgBlock2.Left
                Case 2                                                                              'Start right top Block
                    img2.Top = imgBlock3.Top - 50
                    img2.Left = imgBlock3.Left
                Case 3                                                                              'Start base left
                    img2.Top = imgBase.Top - 50
                    img2.Left = imgBase.Left
            End Select
            lbl1.Text += "T"
            lbl2.Text = 10 - lbl1.Text.Length

        ElseIf img2.Left > imgBase.Left + 784 AndAlso img2.Top = imgBase.Top - 50 Then              'Fall off edge base right
            For i = 0 To 75
                Me.Refresh()
                img2.Top += 2
                img2.Left += 1
            Next

            Select Case (random)
                Case 0                                                                              'Start middle left
                    img2.Top = imgBlock.Top - 50
                    img2.Left = imgBlock.Left
                Case 1                                                                              'Start left top left
                    img2.Top = imgBlock2.Top - 50
                    img2.Left = imgBlock2.Left
                Case 2                                                                              'Start right top Block
                    img2.Top = imgBlock3.Top - 50
                    img2.Left = imgBlock3.Left
                Case 3                                                                              'Start base left
                    img2.Top = imgBase.Top - 50
                    img2.Left = imgBase.Left
            End Select
            lbl1.Text += "T"
            lbl2.Text = 10 - lbl1.Text.Length
        End If

        'XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXx
        'Player1

        'XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXx
        If lbl3.Text.Length = 10 Then            'Move to form 2
            winner = 2
        End If
        If winner = 2 Then
            Timer1.Enabled = False
            Dim form6 As New Form6
            Me.Hide()
            form6.ShowDialog()
        End If

    End Sub

    Private Sub mnuP_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuP.Click
        MessageBox.Show("Paused", "Paused", MessageBoxButtons.OK, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly)
    End Sub

    Private Sub mnuR_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuR.Click
        lbl1.Text = ""
        lbl2.Text = "10"
        lbl3.Text = ""
        lbl4.Text = "10"
    End Sub

    Private Sub mnuE_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles mnuE.Click
        Dim form3 As New Form3
        Me.Hide()
        form3.ShowDialog()
    End Sub
End Class
