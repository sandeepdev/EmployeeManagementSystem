<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Details
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Details))
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox3 = New PictureBox()
        Label10 = New Label()
        Label6 = New Label()
        Label1 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Button1 = New Button()
        Panel2 = New Panel()
        homeLabel = New Label()
        btnSearch = New Button()
        dtpEmpDOB = New Label()
        cmbEmpPosition = New Label()
        cmbEmpEdu = New Label()
        txtSearchId = New TextBox()
        Label15 = New Label()
        Label14 = New Label()
        txtEmpAddress = New Label()
        txtEmpPhone = New Label()
        cmbEmpGndr = New Label()
        txtEmpName = New Label()
        Label5 = New Label()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        Panel2.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.ControlText
        Label2.Font = New Font("Algerian", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ButtonFace
        Label2.Location = New Point(104, 62)
        Label2.Name = "Label2"
        Label2.Size = New Size(309, 34)
        Label2.TabIndex = 5
        Label2.Text = "Employee Details"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.ControlText
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(19, 34)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(68, 62)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 4
        PictureBox1.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = SystemColors.ControlText
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(1022, 727)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(37, 34)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 28
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
        Label10.TabIndex = 27
        Label10.Text = "abc.ltd"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = SystemColors.Control
        Label6.Font = New Font("Algerian", 13.8F)
        Label6.ForeColor = SystemColors.ControlText
        Label6.Location = New Point(40, 95)
        Label6.Name = "Label6"
        Label6.Size = New Size(195, 25)
        Label6.TabIndex = 6
        Label6.Text = "employee name"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.Control
        Label1.Font = New Font("Algerian", 13.8F)
        Label1.ForeColor = SystemColors.ControlText
        Label1.Location = New Point(582, 95)
        Label1.Name = "Label1"
        Label1.Size = New Size(233, 25)
        Label1.TabIndex = 8
        Label1.Text = "employee address"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.Control
        Label3.Font = New Font("Algerian", 13.8F)
        Label3.ForeColor = SystemColors.ControlText
        Label3.Location = New Point(40, 186)
        Label3.Name = "Label3"
        Label3.Size = New Size(220, 25)
        Label3.TabIndex = 11
        Label3.Text = "employee gender"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.Control
        Label4.Font = New Font("Algerian", 13.8F)
        Label4.ForeColor = SystemColors.ControlText
        Label4.Location = New Point(586, 186)
        Label4.Name = "Label4"
        Label4.Size = New Size(229, 25)
        Label4.TabIndex = 13
        Label4.Text = "employee position"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.BackColor = SystemColors.Control
        Label7.Font = New Font("Algerian", 13.8F)
        Label7.ForeColor = SystemColors.ControlText
        Label7.Location = New Point(40, 274)
        Label7.Name = "Label7"
        Label7.Size = New Size(203, 25)
        Label7.TabIndex = 16
        Label7.Text = "employee phone"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.BackColor = SystemColors.Control
        Label8.Font = New Font("Algerian", 13.8F)
        Label8.ForeColor = SystemColors.ControlText
        Label8.Location = New Point(355, 374)
        Label8.Name = "Label8"
        Label8.Size = New Size(176, 25)
        Label8.TabIndex = 19
        Label8.Text = "employee dob"
        ' 
        ' Button1
        ' 
        Button1.BackgroundImageLayout = ImageLayout.Center
        Button1.Font = New Font("Algerian", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(455, 450)
        Button1.Name = "Button1"
        Button1.Size = New Size(168, 41)
        Button1.TabIndex = 20
        Button1.Text = "print"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.Control
        Panel2.Controls.Add(homeLabel)
        Panel2.Controls.Add(btnSearch)
        Panel2.Controls.Add(dtpEmpDOB)
        Panel2.Controls.Add(cmbEmpPosition)
        Panel2.Controls.Add(cmbEmpEdu)
        Panel2.Controls.Add(txtSearchId)
        Panel2.Controls.Add(Label15)
        Panel2.Controls.Add(Label14)
        Panel2.Controls.Add(txtEmpAddress)
        Panel2.Controls.Add(txtEmpPhone)
        Panel2.Controls.Add(cmbEmpGndr)
        Panel2.Controls.Add(txtEmpName)
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(Label8)
        Panel2.Controls.Add(Label7)
        Panel2.Controls.Add(Label4)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(Label6)
        Panel2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Panel2.Location = New Point(0, 121)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1207, 598)
        Panel2.TabIndex = 2
        ' 
        ' homeLabel
        ' 
        homeLabel.AutoSize = True
        homeLabel.BackColor = SystemColors.ButtonShadow
        homeLabel.Font = New Font("Algerian", 16.2F)
        homeLabel.ForeColor = SystemColors.Highlight
        homeLabel.Location = New Point(1050, 535)
        homeLabel.Name = "homeLabel"
        homeLabel.Size = New Size(86, 31)
        homeLabel.TabIndex = 34
        homeLabel.Text = "HOME"
        ' 
        ' btnSearch
        ' 
        btnSearch.BackgroundImageLayout = ImageLayout.Center
        btnSearch.Font = New Font("Algerian", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSearch.Location = New Point(737, 22)
        btnSearch.Name = "btnSearch"
        btnSearch.Size = New Size(168, 41)
        btnSearch.TabIndex = 33
        btnSearch.Text = "refresh"
        btnSearch.UseVisualStyleBackColor = True
        ' 
        ' dtpEmpDOB
        ' 
        dtpEmpDOB.AutoSize = True
        dtpEmpDOB.BackColor = SystemColors.Control
        dtpEmpDOB.Font = New Font("Algerian", 13.8F)
        dtpEmpDOB.ForeColor = Color.Red
        dtpEmpDOB.Location = New Point(552, 374)
        dtpEmpDOB.Name = "dtpEmpDOB"
        dtpEmpDOB.Size = New Size(176, 25)
        dtpEmpDOB.TabIndex = 32
        dtpEmpDOB.Text = "employee dob"
        ' 
        ' cmbEmpPosition
        ' 
        cmbEmpPosition.AutoSize = True
        cmbEmpPosition.BackColor = SystemColors.Control
        cmbEmpPosition.Font = New Font("Algerian", 13.8F)
        cmbEmpPosition.ForeColor = Color.Red
        cmbEmpPosition.Location = New Point(903, 186)
        cmbEmpPosition.Name = "cmbEmpPosition"
        cmbEmpPosition.Size = New Size(229, 25)
        cmbEmpPosition.TabIndex = 31
        cmbEmpPosition.Text = "employee position"
        ' 
        ' cmbEmpEdu
        ' 
        cmbEmpEdu.AutoSize = True
        cmbEmpEdu.BackColor = SystemColors.Control
        cmbEmpEdu.Font = New Font("Algerian", 13.8F)
        cmbEmpEdu.ForeColor = Color.Red
        cmbEmpEdu.Location = New Point(903, 274)
        cmbEmpEdu.Name = "cmbEmpEdu"
        cmbEmpEdu.Size = New Size(229, 25)
        cmbEmpEdu.TabIndex = 30
        cmbEmpEdu.Text = "employee position"
        ' 
        ' txtSearchId
        ' 
        txtSearchId.BorderStyle = BorderStyle.FixedSingle
        txtSearchId.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSearchId.Location = New Point(393, 22)
        txtSearchId.Name = "txtSearchId"
        txtSearchId.Size = New Size(311, 43)
        txtSearchId.TabIndex = 29
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.BackColor = SystemColors.Control
        Label15.Font = New Font("Algerian", 13.8F)
        Label15.ForeColor = SystemColors.ControlText
        Label15.Location = New Point(220, 34)
        Label15.Name = "Label15"
        Label15.Size = New Size(154, 25)
        Label15.TabIndex = 28
        Label15.Text = "employee id"
        ' 
        ' Label14
        ' 
        Label14.AutoSize = True
        Label14.BackColor = SystemColors.Control
        Label14.Font = New Font("Algerian", 13.8F)
        Label14.ForeColor = SystemColors.ControlText
        Label14.Location = New Point(586, 274)
        Label14.Name = "Label14"
        Label14.Size = New Size(297, 25)
        Label14.TabIndex = 27
        Label14.Text = "employee qualification"
        ' 
        ' txtEmpAddress
        ' 
        txtEmpAddress.AutoSize = True
        txtEmpAddress.BackColor = SystemColors.Control
        txtEmpAddress.Font = New Font("Algerian", 13.8F)
        txtEmpAddress.ForeColor = Color.Red
        txtEmpAddress.Location = New Point(903, 95)
        txtEmpAddress.Name = "txtEmpAddress"
        txtEmpAddress.Size = New Size(233, 25)
        txtEmpAddress.TabIndex = 26
        txtEmpAddress.Text = "employee address"
        ' 
        ' txtEmpPhone
        ' 
        txtEmpPhone.AutoSize = True
        txtEmpPhone.BackColor = SystemColors.Control
        txtEmpPhone.Font = New Font("Algerian", 13.8F)
        txtEmpPhone.ForeColor = Color.Red
        txtEmpPhone.Location = New Point(299, 274)
        txtEmpPhone.Name = "txtEmpPhone"
        txtEmpPhone.Size = New Size(203, 25)
        txtEmpPhone.TabIndex = 25
        txtEmpPhone.Text = "employee phone"
        ' 
        ' cmbEmpGndr
        ' 
        cmbEmpGndr.AutoSize = True
        cmbEmpGndr.BackColor = SystemColors.Control
        cmbEmpGndr.Font = New Font("Algerian", 13.8F)
        cmbEmpGndr.ForeColor = Color.Red
        cmbEmpGndr.Location = New Point(299, 186)
        cmbEmpGndr.Name = "cmbEmpGndr"
        cmbEmpGndr.Size = New Size(220, 25)
        cmbEmpGndr.TabIndex = 24
        cmbEmpGndr.Text = "employee gender"
        ' 
        ' txtEmpName
        ' 
        txtEmpName.AutoSize = True
        txtEmpName.BackColor = SystemColors.Control
        txtEmpName.Font = New Font("Algerian", 13.8F)
        txtEmpName.ForeColor = Color.Red
        txtEmpName.Location = New Point(299, 95)
        txtEmpName.Name = "txtEmpName"
        txtEmpName.Size = New Size(195, 25)
        txtEmpName.TabIndex = 23
        txtEmpName.Text = "employee name"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.BackColor = SystemColors.ControlText
        Label5.Font = New Font("Algerian", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label5.ForeColor = SystemColors.ButtonFace
        Label5.Location = New Point(1126, 34)
        Label5.Name = "Label5"
        Label5.Size = New Size(37, 34)
        Label5.TabIndex = 29
        Label5.Text = "X"
        ' 
        ' Details
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ControlText
        ClientSize = New Size(1207, 773)
        Controls.Add(Label5)
        Controls.Add(PictureBox3)
        Controls.Add(Label10)
        Controls.Add(Label2)
        Controls.Add(PictureBox1)
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.None
        Name = "Details"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Details"
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Panel2 As Panel
    Friend WithEvents cmbEmpGndr As Label
    Friend WithEvents txtEmpName As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents txtEmpAddress As Label
    Friend WithEvents txtEmpPhone As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents dtpEmpDOB As Label
    Friend WithEvents cmbEmpPosition As Label
    Friend WithEvents cmbEmpEdu As Label
    Friend WithEvents txtSearchId As TextBox
    Friend WithEvents btnSearch As Button
    Friend WithEvents homeLabel As Label
    Friend WithEvents Label5 As Label
End Class
