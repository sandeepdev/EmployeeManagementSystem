<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HomeForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(HomeForm))
        Panel1 = New Panel()
        SalaryLabel = New Label()
        DetailsLabel = New Label()
        EmployeeLabel = New Label()
        DetailsPictureBox = New PictureBox()
        EmployeePictureBox = New PictureBox()
        SalaryPictureBox = New PictureBox()
        Label1 = New Label()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        Label3 = New Label()
        PictureBox2 = New PictureBox()
        Label4 = New Label()
        PictureBox3 = New PictureBox()
        Panel1.SuspendLayout()
        CType(DetailsPictureBox, ComponentModel.ISupportInitialize).BeginInit()
        CType(EmployeePictureBox, ComponentModel.ISupportInitialize).BeginInit()
        CType(SalaryPictureBox, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel1
        ' 
        Panel1.BackColor = SystemColors.ButtonShadow
        Panel1.Controls.Add(SalaryLabel)
        Panel1.Controls.Add(DetailsLabel)
        Panel1.Controls.Add(EmployeeLabel)
        Panel1.Controls.Add(DetailsPictureBox)
        Panel1.Controls.Add(EmployeePictureBox)
        Panel1.Controls.Add(SalaryPictureBox)
        Panel1.Location = New Point(3, 126)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(845, 348)
        Panel1.TabIndex = 0
        ' 
        ' SalaryLabel
        ' 
        SalaryLabel.AutoSize = True
        SalaryLabel.BackColor = SystemColors.ButtonShadow
        SalaryLabel.Font = New Font("Algerian", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        SalaryLabel.ForeColor = SystemColors.Highlight
        SalaryLabel.Location = New Point(596, 220)
        SalaryLabel.Name = "SalaryLabel"
        SalaryLabel.Size = New Size(138, 34)
        SalaryLabel.TabIndex = 7
        SalaryLabel.Text = "salary"
        ' 
        ' DetailsLabel
        ' 
        DetailsLabel.AutoSize = True
        DetailsLabel.BackColor = SystemColors.ButtonShadow
        DetailsLabel.Font = New Font("Algerian", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DetailsLabel.ForeColor = SystemColors.Highlight
        DetailsLabel.Location = New Point(340, 220)
        DetailsLabel.Name = "DetailsLabel"
        DetailsLabel.Size = New Size(141, 34)
        DetailsLabel.TabIndex = 6
        DetailsLabel.Text = "details"
        ' 
        ' EmployeeLabel
        ' 
        EmployeeLabel.AutoSize = True
        EmployeeLabel.BackColor = SystemColors.ButtonShadow
        EmployeeLabel.Font = New Font("Algerian", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        EmployeeLabel.ForeColor = SystemColors.Highlight
        EmployeeLabel.Location = New Point(78, 220)
        EmployeeLabel.Name = "EmployeeLabel"
        EmployeeLabel.Size = New Size(174, 34)
        EmployeeLabel.TabIndex = 5
        EmployeeLabel.Text = "employee"
        ' 
        ' DetailsPictureBox
        ' 
        DetailsPictureBox.BackColor = SystemColors.ControlText
        DetailsPictureBox.Image = CType(resources.GetObject("DetailsPictureBox.Image"), Image)
        DetailsPictureBox.Location = New Point(340, 70)
        DetailsPictureBox.Name = "DetailsPictureBox"
        DetailsPictureBox.Size = New Size(136, 133)
        DetailsPictureBox.SizeMode = PictureBoxSizeMode.Zoom
        DetailsPictureBox.TabIndex = 3
        DetailsPictureBox.TabStop = False
        ' 
        ' EmployeePictureBox
        ' 
        EmployeePictureBox.BackColor = SystemColors.ControlText
        EmployeePictureBox.Image = CType(resources.GetObject("EmployeePictureBox.Image"), Image)
        EmployeePictureBox.Location = New Point(102, 70)
        EmployeePictureBox.Name = "EmployeePictureBox"
        EmployeePictureBox.Size = New Size(139, 133)
        EmployeePictureBox.SizeMode = PictureBoxSizeMode.Zoom
        EmployeePictureBox.TabIndex = 2
        EmployeePictureBox.TabStop = False
        ' 
        ' SalaryPictureBox
        ' 
        SalaryPictureBox.BackColor = SystemColors.ControlText
        SalaryPictureBox.Image = CType(resources.GetObject("SalaryPictureBox.Image"), Image)
        SalaryPictureBox.Location = New Point(596, 70)
        SalaryPictureBox.Name = "SalaryPictureBox"
        SalaryPictureBox.Size = New Size(144, 133)
        SalaryPictureBox.SizeMode = PictureBoxSizeMode.Zoom
        SalaryPictureBox.TabIndex = 1
        SalaryPictureBox.TabStop = False
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ControlText
        Label1.Font = New Font("Algerian", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.ForeColor = SystemColors.ButtonShadow
        Label1.Location = New Point(129, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(520, 34)
        Label1.TabIndex = 1
        Label1.Text = "Employee Management System"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.ControlText
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(31, 67)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(68, 62)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 0
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.ControlText
        Label2.Font = New Font("Algerian", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ButtonFace
        Label2.Location = New Point(105, 95)
        Label2.Name = "Label2"
        Label2.Size = New Size(98, 34)
        Label2.TabIndex = 2
        Label2.Text = "home"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.ControlText
        Label3.Font = New Font("Algerian", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label3.ForeColor = SystemColors.ButtonFace
        Label3.Location = New Point(708, 95)
        Label3.Name = "Label3"
        Label3.Size = New Size(130, 34)
        Label3.TabIndex = 2
        Label3.Text = "logout"
        ' 
        ' PictureBox2
        ' 
        PictureBox2.BackColor = SystemColors.ControlText
        PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), Image)
        PictureBox2.Location = New Point(665, 95)
        PictureBox2.Name = "PictureBox2"
        PictureBox2.Size = New Size(37, 34)
        PictureBox2.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox2.TabIndex = 1
        PictureBox2.TabStop = False
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.ControlText
        Label4.Font = New Font("Algerian", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ButtonFace
        Label4.Location = New Point(708, 496)
        Label4.Name = "Label4"
        Label4.Size = New Size(140, 34)
        Label4.TabIndex = 3
        Label4.Text = "abc.ltd"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = SystemColors.ControlText
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(665, 496)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(37, 34)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 4
        PictureBox3.TabStop = False
        ' 
        ' HomeForm
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlText
        ClientSize = New Size(848, 530)
        Controls.Add(PictureBox3)
        Controls.Add(Label4)
        Controls.Add(PictureBox2)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(PictureBox1)
        Controls.Add(Label1)
        Controls.Add(Panel1)
        FormBorderStyle = FormBorderStyle.None
        Name = "HomeForm"
        StartPosition = FormStartPosition.CenterScreen
        Text = "MainForm"
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        CType(DetailsPictureBox, ComponentModel.ISupportInitialize).EndInit()
        CType(EmployeePictureBox, ComponentModel.ISupportInitialize).EndInit()
        CType(SalaryPictureBox, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox2, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents EmployeePictureBox As PictureBox
    Friend WithEvents SalaryPictureBox As PictureBox
    Friend WithEvents SalaryLabel As Label
    Friend WithEvents DetailsLabel As Label
    Friend WithEvents EmployeeLabel As Label
    Friend WithEvents DetailsPictureBox As PictureBox
End Class
