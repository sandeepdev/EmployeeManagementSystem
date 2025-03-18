<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Splash_screen
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        components = New ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Splash_screen))
        Label1 = New Label()
        Label2 = New Label()
        logo = New PictureBox()
        Timerprogressbar = New Timer(components)
        Panel1 = New Panel()
        Progrsbar = New Panel()
        CType(logo, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Algerian", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.Highlight
        Label1.Location = New Point(114, 44)
        Label1.Name = "Label1"
        Label1.Size = New Size(520, 34)
        Label1.TabIndex = 0
        Label1.Text = "Employee Management System"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Algerian", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.Highlight
        Label2.Location = New Point(312, 364)
        Label2.Name = "Label2"
        Label2.Size = New Size(140, 34)
        Label2.TabIndex = 1
        Label2.Text = "abc.ltd"
        ' 
        ' logo
        ' 
        logo.BackColor = SystemColors.Highlight
        logo.Image = CType(resources.GetObject("logo.Image"), Image)
        logo.Location = New Point(262, 81)
        logo.Name = "logo"
        logo.Size = New Size(223, 240)
        logo.TabIndex = 3
        logo.TabStop = False
        ' 
        ' Timerprogressbar
        ' 
        Timerprogressbar.Enabled = True
        ' 
        ' Panel1
        ' 
        Panel1.Location = New Point(1, 337)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(799, 10)
        Panel1.TabIndex = 4
        ' 
        ' Progrsbar
        ' 
        Progrsbar.BackColor = SystemColors.MenuHighlight
        Progrsbar.Location = New Point(1, 337)
        Progrsbar.Name = "Progrsbar"
        Progrsbar.Size = New Size(52, 10)
        Progrsbar.TabIndex = 5
        ' 
        ' Splash_screen
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Progrsbar)
        Controls.Add(Panel1)
        Controls.Add(logo)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "Splash_screen"
        StartPosition = FormStartPosition.CenterScreen
        Text = "splash_screen"
        CType(logo, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents logo As PictureBox
    Friend WithEvents Timerprogressbar As Timer
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Progrsbar As Panel

End Class
