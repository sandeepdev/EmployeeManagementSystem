<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(login))
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        PictureBox1 = New PictureBox()
        UidTb = New TextBox()
        PassTb = New TextBox()
        Button1 = New Button()
        Button2 = New Button()
        Label4 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Algerian", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.Highlight
        Label1.Location = New Point(129, 50)
        Label1.Name = "Label1"
        Label1.Size = New Size(520, 34)
        Label1.TabIndex = 1
        Label1.Text = "Employee Management System"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Algerian", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.Highlight
        Label2.Location = New Point(196, 238)
        Label2.Name = "Label2"
        Label2.Size = New Size(178, 34)
        Label2.TabIndex = 2
        Label2.Text = "password"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Algerian", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.Highlight
        Label3.Location = New Point(234, 142)
        Label3.Name = "Label3"
        Label3.Size = New Size(130, 34)
        Label3.TabIndex = 3
        Label3.Text = "user id"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.Control
        PictureBox1.BackgroundImageLayout = ImageLayout.Center
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(72, 137)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(118, 109)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' UidTb
        ' 
        UidTb.BorderStyle = BorderStyle.FixedSingle
        UidTb.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        UidTb.Location = New Point(408, 137)
        UidTb.Name = "UidTb"
        UidTb.Size = New Size(241, 43)
        UidTb.TabIndex = 5
        ' 
        ' PassTb
        ' 
        PassTb.BorderStyle = BorderStyle.FixedSingle
        PassTb.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        PassTb.Location = New Point(408, 233)
        PassTb.Name = "PassTb"
        PassTb.PasswordChar = "*"c
        PassTb.Size = New Size(241, 43)
        PassTb.TabIndex = 6
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.ActiveCaption
        Button1.FlatAppearance.BorderSize = 0
        Button1.FlatStyle = FlatStyle.Flat
        Button1.Font = New Font("Algerian", 13.8F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button1.ForeColor = SystemColors.Highlight
        Button1.Location = New Point(445, 304)
        Button1.Name = "Button1"
        Button1.Size = New Size(144, 48)
        Button1.TabIndex = 7
        Button1.Text = "login"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.ActiveCaption
        Button2.FlatAppearance.BorderSize = 0
        Button2.FlatStyle = FlatStyle.Flat
        Button2.Font = New Font("Algerian", 13.8F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        Button2.ForeColor = SystemColors.Highlight
        Button2.Location = New Point(262, 304)
        Button2.Name = "Button2"
        Button2.Size = New Size(144, 48)
        Button2.TabIndex = 8
        Button2.Text = "reset"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Algerian", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.Highlight
        Label4.Location = New Point(742, 18)
        Label4.Name = "Label4"
        Label4.Size = New Size(37, 34)
        Label4.TabIndex = 9
        Label4.Text = "x"
        ' 
        ' login
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label4)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(PassTb)
        Controls.Add(UidTb)
        Controls.Add(PictureBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        FormBorderStyle = FormBorderStyle.None
        Name = "login"
        Text = "login"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents UidTb As TextBox
    Friend WithEvents PassTb As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label4 As Label
End Class
