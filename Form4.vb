Public Class Form4
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
    Friend WithEvents img1 As System.Windows.Forms.PictureBox
    Friend WithEvents img2 As System.Windows.Forms.PictureBox
    Friend WithEvents imgFireball1 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl3 As System.Windows.Forms.Label
    Friend WithEvents imgBase As System.Windows.Forms.PictureBox
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    Friend WithEvents imgBlock3 As System.Windows.Forms.PictureBox
    Friend WithEvents imgBlock2 As System.Windows.Forms.PictureBox
    Friend WithEvents imgBlock As System.Windows.Forms.PictureBox
    Friend WithEvents imgFireball As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents img3 As System.Windows.Forms.PictureBox
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form4))
        Me.img1 = New System.Windows.Forms.PictureBox
        Me.img2 = New System.Windows.Forms.PictureBox
        Me.imgFireball1 = New System.Windows.Forms.PictureBox
        Me.lbl3 = New System.Windows.Forms.Label
        Me.imgBase = New System.Windows.Forms.PictureBox
        Me.lbl1 = New System.Windows.Forms.Label
        Me.imgBlock3 = New System.Windows.Forms.PictureBox
        Me.imgBlock2 = New System.Windows.Forms.PictureBox
        Me.imgBlock = New System.Windows.Forms.PictureBox
        Me.imgFireball = New System.Windows.Forms.PictureBox
        Me.PictureBox1 = New System.Windows.Forms.PictureBox
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.img3 = New System.Windows.Forms.PictureBox
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'img1
        '
        Me.img1.Image = CType(resources.GetObject("img1.Image"), System.Drawing.Image)
        Me.img1.Location = New System.Drawing.Point(88, 192)
        Me.img1.Name = "img1"
        Me.img1.Size = New System.Drawing.Size(48, 50)
        Me.img1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img1.TabIndex = 16
        Me.img1.TabStop = False
        '
        'img2
        '
        Me.img2.Image = CType(resources.GetObject("img2.Image"), System.Drawing.Image)
        Me.img2.Location = New System.Drawing.Point(704, 192)
        Me.img2.Name = "img2"
        Me.img2.Size = New System.Drawing.Size(48, 50)
        Me.img2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.img2.TabIndex = 18
        Me.img2.TabStop = False
        '
        'imgFireball1
        '
        Me.imgFireball1.Image = CType(resources.GetObject("imgFireball1.Image"), System.Drawing.Image)
        Me.imgFireball1.Location = New System.Drawing.Point(0, 0)
        Me.imgFireball1.Name = "imgFireball1"
        Me.imgFireball1.Size = New System.Drawing.Size(33, 32)
        Me.imgFireball1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgFireball1.TabIndex = 26
        Me.imgFireball1.TabStop = False
        Me.imgFireball1.Visible = False
        '
        'lbl3
        '
        Me.lbl3.BackColor = System.Drawing.SystemColors.Desktop
        Me.lbl3.Image = CType(resources.GetObject("lbl3.Image"), System.Drawing.Image)
        Me.lbl3.Location = New System.Drawing.Point(592, -11)
        Me.lbl3.Name = "lbl3"
        Me.lbl3.Size = New System.Drawing.Size(8, 11)
        Me.lbl3.TabIndex = 25
        Me.lbl3.Visible = False
        '
        'imgBase
        '
        Me.imgBase.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.imgBase.Image = CType(resources.GetObject("imgBase.Image"), System.Drawing.Image)
        Me.imgBase.Location = New System.Drawing.Point(16, 240)
        Me.imgBase.Name = "imgBase"
        Me.imgBase.Size = New System.Drawing.Size(784, 38)
        Me.imgBase.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgBase.TabIndex = 24
        Me.imgBase.TabStop = False
        '
        'lbl1
        '
        Me.lbl1.BackColor = System.Drawing.SystemColors.Desktop
        Me.lbl1.Image = CType(resources.GetObject("lbl1.Image"), System.Drawing.Image)
        Me.lbl1.Location = New System.Drawing.Point(592, -3)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(8, 8)
        Me.lbl1.TabIndex = 22
        Me.lbl1.Visible = False
        '
        'imgBlock3
        '
        Me.imgBlock3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.imgBlock3.Image = CType(resources.GetObject("imgBlock3.Image"), System.Drawing.Image)
        Me.imgBlock3.Location = New System.Drawing.Point(512, 112)
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
        Me.imgBlock2.Location = New System.Drawing.Point(56, 104)
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
        Me.imgBlock.Location = New System.Drawing.Point(280, 192)
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
        Me.PictureBox1.Location = New System.Drawing.Point(-8, -19)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(856, 311)
        Me.PictureBox1.TabIndex = 30
        Me.PictureBox1.TabStop = False
        '
        'Timer1
        '
        '
        'Timer2
        '
        Me.Timer2.Interval = 500
        '
        'img3
        '
        Me.img3.Image = CType(resources.GetObject("img3.Image"), System.Drawing.Image)
        Me.img3.Location = New System.Drawing.Point(288, 48)
        Me.img3.Name = "img3"
        Me.img3.Size = New System.Drawing.Size(208, 104)
        Me.img3.TabIndex = 31
        Me.img3.TabStop = False
        Me.img3.Visible = False
        '
        'Timer3
        '
        Me.Timer3.Interval = 2000
        '
        'Form4
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.ClientSize = New System.Drawing.Size(840, 273)
        Me.Controls.Add(Me.img3)
        Me.Controls.Add(Me.imgFireball1)
        Me.Controls.Add(Me.img2)
        Me.Controls.Add(Me.lbl3)
        Me.Controls.Add(Me.imgBase)
        Me.Controls.Add(Me.lbl1)
        Me.Controls.Add(Me.imgBlock3)
        Me.Controls.Add(Me.imgBlock2)
        Me.Controls.Add(Me.imgBlock)
        Me.Controls.Add(Me.imgFireball)
        Me.Controls.Add(Me.img1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form4"
        Me.Text = "Intro"
        Me.ResumeLayout(False)

    End Sub

#End Region

    
    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Enabled = True
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Dim i, j, x, y, x1, y1 As Integer
        x = img1.Left + 120
        y = img1.Top
        x1 = img2.Left - 120
        y1 = img2.Top

        For j = 0 To 1
            For i = 0 To 10
                Me.Refresh()
                img1.Left += 3
                img2.Left -= 3
                img1.Top -= 6
                img2.Top -= 6
            Next
            For i = 0 To 10
                Me.Refresh()
                img1.Left += 3
                img2.Left -= 3
                img1.Top += 6
                img2.Top += 6
            Next
        Next
        Timer1.Enabled = False
        Timer2.Enabled = True
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        img3.Visible = True
        Timer2.Enabled = False
        Timer3.Enabled = True

    End Sub

    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        Timer3.Enabled = False
        Dim form3 As New Form3
        Me.Hide()
        form3.ShowDialog()


    End Sub
End Class
