Public Class Form6
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
    Friend WithEvents cmdMainmenu As System.Windows.Forms.Button
    Friend WithEvents cmdPlayagain As System.Windows.Forms.Button
    Friend WithEvents lbl1 As System.Windows.Forms.Label
    <System.Diagnostics.DebuggerStepThrough()> Private Sub InitializeComponent()
        Dim resources As System.Resources.ResourceManager = New System.Resources.ResourceManager(GetType(Form6))
        Me.cmdMainmenu = New System.Windows.Forms.Button
        Me.cmdPlayagain = New System.Windows.Forms.Button
        Me.lbl1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'cmdMainmenu
        '
        Me.cmdMainmenu.Location = New System.Drawing.Point(174, 205)
        Me.cmdMainmenu.Name = "cmdMainmenu"
        Me.cmdMainmenu.TabIndex = 5
        Me.cmdMainmenu.Text = "Main Menu"
        '
        'cmdPlayagain
        '
        Me.cmdPlayagain.Location = New System.Drawing.Point(38, 205)
        Me.cmdPlayagain.Name = "cmdPlayagain"
        Me.cmdPlayagain.TabIndex = 4
        Me.cmdPlayagain.Text = "Play Again?"
        '
        'lbl1
        '
        Me.lbl1.BackColor = System.Drawing.SystemColors.Desktop
        Me.lbl1.Image = CType(resources.GetObject("lbl1.Image"), System.Drawing.Image)
        Me.lbl1.Location = New System.Drawing.Point(22, 45)
        Me.lbl1.Name = "lbl1"
        Me.lbl1.Size = New System.Drawing.Size(248, 64)
        Me.lbl1.TabIndex = 3
        '
        'Form6
        '
        Me.AutoScaleBaseSize = New System.Drawing.Size(5, 13)
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.ClientSize = New System.Drawing.Size(292, 273)
        Me.Controls.Add(Me.cmdMainmenu)
        Me.Controls.Add(Me.cmdPlayagain)
        Me.Controls.Add(Me.lbl1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Name = "Form6"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Winner!"
        Me.ResumeLayout(False)

    End Sub

#End Region

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim donkeykong, mario As Image

        If winner = 1 Then
            lbl1.Text = "Mario wins! Play again?"

        ElseIf winner = 2 Then
            lbl1.Text = "Donkey Kong wins! Play again?"
        End If
    End Sub

    Private Sub cmdPlayagain_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPlayagain.Click
        winner = 0
        Dim form5 As New Form5
        Me.Hide()
        form5.ShowDialog()

    End Sub

    Private Sub cmdMainmenu_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdMainmenu.Click
        winner = 0
        Dim form3 As New Form3
        Me.Hide()
        form3.ShowDialog()
    End Sub
End Class
