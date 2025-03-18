<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Employee
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Employee))
        Panel2 = New Panel()
        EmployeeDGV = New DataGridView()
        HomeLabel = New Label()
        Button4 = New Button()
        Button3 = New Button()
        Button1 = New Button()
        Label8 = New Label()
        empDOB = New DateTimePicker()
        empPhoneTb = New TextBox()
        Label7 = New Label()
        Label5 = New Label()
        empQuliComboBox = New ComboBox()
        Label4 = New Label()
        empPositionComboBox = New ComboBox()
        Label3 = New Label()
        empGndrComboBox = New ComboBox()
        empAddrsTb = New TextBox()
        Label1 = New Label()
        EmpNameTab = New TextBox()
        Label6 = New Label()
        PictureBox1 = New PictureBox()
        Label2 = New Label()
        PictureBox3 = New PictureBox()
        Label10 = New Label()
        CloseButton = New Label()
        Panel2.SuspendLayout()
        CType(EmployeeDGV, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.ButtonShadow
        Panel2.Controls.Add(EmployeeDGV)
        Panel2.Controls.Add(HomeLabel)
        Panel2.Controls.Add(Button4)
        Panel2.Controls.Add(Button3)
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(empDOB)
        Panel2.Controls.Add(empPhoneTb)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(Label5)
        Panel2.Controls.Add(empQuliComboBox)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(empPositionComboBox)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(empGndrComboBox)
        Panel2.Controls.Add(empAddrsTb)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(EmpNameTab)
        Panel2.Controls.Add(Label6)
        Panel2.Location = New Point(0, 121)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1341, 598)
        Panel2.TabIndex = 1
        ' 
        ' EmployeeDGV
        ' 
        EmployeeDGV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        EmployeeDGV.Location = New Point(418, 3)
        EmployeeDGV.Name = "EmployeeDGV"
        EmployeeDGV.RowHeadersWidth = 51
        EmployeeDGV.Size = New Size(910, 529)
        EmployeeDGV.TabIndex = 25
        ' 
        ' HomeLabel
        ' 
        HomeLabel.AutoSize = True
        HomeLabel.BackColor = SystemColors.ButtonShadow
        HomeLabel.Font = New Font("Algerian", 16.2F)
        HomeLabel.ForeColor = SystemColors.Highlight
        HomeLabel.Location = New Point(1048, 550)
        HomeLabel.Name = "HomeLabel"
        HomeLabel.Size = New Size(86, 31)
        HomeLabel.TabIndex = 24
        HomeLabel.Text = "HOME"
        ' 
        ' Button4
        ' 
        Button4.BackgroundImageLayout = ImageLayout.Center
        Button4.Font = New Font("Algerian", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.Location = New Point(213, 469)
        Button4.Name = "Button4"
        Button4.Size = New Size(168, 41)
        Button4.TabIndex = 23
        Button4.Text = "EDIT"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' Button3
        ' 
        Button3.BackgroundImageLayout = ImageLayout.Center
        Button3.Font = New Font("Algerian", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button3.Location = New Point(127, 526)
        Button3.Name = "Button3"
        Button3.Size = New Size(168, 41)
        Button3.TabIndex = 22
        Button3.Text = "DELETE"
        Button3.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.BackgroundImageLayout = ImageLayout.Center
        Button1.Font = New Font("Algerian", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(26, 469)
        Button1.Name = "Button1"
        Button1.Size = New Size(168, 41)
        Button1.TabIndex = 20
        Button1.Text = "ADD"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = SystemColors.ButtonShadow
        Label8.Font = New Font("Algerian", 10.2F)
        Label8.ForeColor = SystemColors.Highlight
        Label8.Location = New Point(118, 370)
        Label8.Name = "Label8"
        Label8.Size = New Size(131, 19)
        Label8.TabIndex = 19
        Label8.Text = "employee dob"
        ' 
        ' empDOB
        ' 
        empDOB.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        empDOB.Location = New Point(76, 409)
        empDOB.MaxDate = New Date(2100, 12, 31, 0, 0, 0, 0)
        empDOB.MinDate = New Date(1970, 1, 1, 0, 0, 0, 0)
        empDOB.Name = "empDOB"
        empDOB.Size = New Size(250, 34)
        empDOB.TabIndex = 18
        ' 
        ' empPhoneTb
        ' 
        empPhoneTb.BorderStyle = BorderStyle.FixedSingle
        empPhoneTb.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        empPhoneTb.Location = New Point(20, 299)
        empPhoneTb.Name = "empPhoneTb"
        empPhoneTb.Size = New Size(148, 43)
        empPhoneTb.TabIndex = 17
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = SystemColors.ButtonShadow
        Label7.Font = New Font("Algerian", 10.2F)
        Label7.ForeColor = SystemColors.Highlight
        Label7.Location = New Point(16, 253)
        Label7.Name = "Label7"
        Label7.Size = New Size(152, 19)
        Label7.TabIndex = 16
        Label7.Text = "employee phone"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = SystemColors.ButtonShadow
        Label5.Font = New Font("Algerian", 10.2F)
        Label5.ForeColor = SystemColors.Highlight
        Label5.Location = New Point(192, 253)
        Label5.Name = "Label5"
        Label5.Size = New Size(220, 19)
        Label5.TabIndex = 15
        Label5.Text = "employee qualification"
        ' 
        ' empQuliComboBox
        ' 
        empQuliComboBox.FlatStyle = FlatStyle.Flat
        empQuliComboBox.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        empQuliComboBox.FormattingEnabled = True
        empQuliComboBox.Items.AddRange(New Object() {"UG", "PG", "SSlC", "Plus two", "Diploma", "Degree"})
        empQuliComboBox.Location = New Point(192, 306)
        empQuliComboBox.Name = "empQuliComboBox"
        empQuliComboBox.Size = New Size(143, 36)
        empQuliComboBox.TabIndex = 14
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.ButtonShadow
        Label4.Font = New Font("Algerian", 10.2F)
        Label4.ForeColor = SystemColors.Highlight
        Label4.Location = New Point(192, 150)
        Label4.Name = "Label4"
        Label4.Size = New Size(170, 19)
        Label4.TabIndex = 13
        Label4.Text = "employee position"
        ' 
        ' empPositionComboBox
        ' 
        empPositionComboBox.FlatStyle = FlatStyle.Flat
        empPositionComboBox.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        empPositionComboBox.FormattingEnabled = True
        empPositionComboBox.Items.AddRange(New Object() {"", "Manager", "Accountant", "Security", "Cleaner", "Developer", "HR"})
        empPositionComboBox.Location = New Point(192, 193)
        empPositionComboBox.Name = "empPositionComboBox"
        empPositionComboBox.Size = New Size(143, 36)
        empPositionComboBox.TabIndex = 12
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.ButtonShadow
        Label3.Font = New Font("Algerian", 10.2F)
        Label3.ForeColor = SystemColors.Highlight
        Label3.Location = New Point(12, 150)
        Label3.Name = "Label3"
        Label3.Size = New Size(164, 19)
        Label3.TabIndex = 11
        Label3.Text = "employee gender"
        ' 
        ' empGndrComboBox
        ' 
        empGndrComboBox.FlatStyle = FlatStyle.Flat
        empGndrComboBox.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        empGndrComboBox.FormattingEnabled = True
        empGndrComboBox.Items.AddRange(New Object() {"Male", "Female"})
        empGndrComboBox.Location = New Point(19, 193)
        empGndrComboBox.Name = "empGndrComboBox"
        empGndrComboBox.Size = New Size(150, 36)
        empGndrComboBox.TabIndex = 10
        ' 
        ' empAddrsTb
        ' 
        empAddrsTb.BorderStyle = BorderStyle.FixedSingle
        empAddrsTb.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        empAddrsTb.Location = New Point(192, 83)
        empAddrsTb.Name = "empAddrsTb"
        empAddrsTb.Size = New Size(158, 43)
        empAddrsTb.TabIndex = 9
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.ButtonShadow
        Label1.Font = New Font("Algerian", 10.2F)
        Label1.ForeColor = SystemColors.Highlight
        Label1.Location = New Point(192, 37)
        Label1.Name = "Label1"
        Label1.Size = New Size(172, 19)
        Label1.TabIndex = 8
        Label1.Text = "employee address"
        ' 
        ' EmpNameTab
        ' 
        EmpNameTab.BorderStyle = BorderStyle.FixedSingle
        EmpNameTab.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        EmpNameTab.Location = New Point(12, 83)
        EmpNameTab.Name = "EmpNameTab"
        EmpNameTab.Size = New Size(145, 43)
        EmpNameTab.TabIndex = 7
        EmpNameTab.Tag = ""
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = SystemColors.ButtonShadow
        Label6.Font = New Font("Algerian", 10.2F)
        Label6.ForeColor = SystemColors.Highlight
        Label6.Location = New Point(12, 37)
        Label6.Name = "Label6"
        Label6.Size = New Size(145, 19)
        Label6.TabIndex = 6
        Label6.Text = "employee name"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.ControlText
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(19, 34)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(68, 62)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 2
        PictureBox1.TabStop = False
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.ControlText
        Label2.Font = New Font("Algerian", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ButtonFace
        Label2.Location = New Point(104, 62)
        Label2.Name = "Label2"
        Label2.Size = New Size(314, 34)
        Label2.TabIndex = 3
        Label2.Text = "Manage Employee"
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = SystemColors.ControlText
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(1022, 727)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(37, 34)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 26
        PictureBox3.TabStop = False
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = SystemColors.ControlText
        Label10.Font = New Font("Algerian", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = SystemColors.ButtonFace
        Label10.Location = New Point(1065, 730)
        Label10.Name = "Label10"
        Label10.Size = New Size(140, 34)
        Label10.TabIndex = 25
        Label10.Text = "abc.ltd"
        ' 
        ' CloseButton
        ' 
        CloseButton.AutoSize = True
        CloseButton.BackColor = SystemColors.ControlText
        CloseButton.Font = New Font("Algerian", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        CloseButton.ForeColor = SystemColors.ButtonFace
        CloseButton.Location = New Point(1255, 34)
        CloseButton.Name = "CloseButton"
        CloseButton.Size = New Size(37, 34)
        CloseButton.TabIndex = 27
        CloseButton.Text = "X"
        ' 
        ' Employee
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlText
        ClientSize = New Size(1340, 773)
        Controls.Add(CloseButton)
        Controls.Add(PictureBox3)
        Controls.Add(Label2)
        Controls.Add(Label10)
        Controls.Add(PictureBox1)
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.None
        Name = "Employee"
        Text = "Employee"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(EmployeeDGV, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents empAddrsTb As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents EmpNameTab As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents empGndrComboBox As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents empDOB As DateTimePicker
    Friend WithEvents empPhoneTb As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents empQuliComboBox As ComboBox
    Friend WithEvents Label4 As Label
    Friend WithEvents empPositionComboBox As ComboBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents HomeLabel As Label
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents EmployeeDGV As DataGridView
    Friend WithEvents CloseButton As Label
End Class
