<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Salary
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Salary))
        Panel2 = New Panel()
        Button4 = New Button()
        SalaryTb = New RichTextBox()
        LabourDate = New TextBox()
        Label1 = New Label()
        HomeLabel = New Label()
        Button2 = New Button()
        txtSearchId = New TextBox()
        Label15 = New Label()
        EmployeePosLabel = New Label()
        txtEmpName = New Label()
        Button1 = New Button()
        Label3 = New Label()
        Label6 = New Label()
        Label2 = New Label()
        PictureBox1 = New PictureBox()
        PictureBox3 = New PictureBox()
        Label10 = New Label()
        Label4 = New Label()
        PrintDocument1 = New Printing.PrintDocument()
        PrintPreviewDialog1 = New PrintPreviewDialog()
        Panel2.SuspendLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).BeginInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Panel2
        ' 
        Panel2.BackColor = SystemColors.Control
        Panel2.Controls.Add(Button4)
        Panel2.Controls.Add(SalaryTb)
        Panel2.Controls.Add(LabourDate)
        Panel2.Controls.Add(Label1)
        Panel2.Controls.Add(HomeLabel)
        Panel2.Controls.Add(Button2)
        Panel2.Controls.Add(txtSearchId)
        Panel2.Controls.Add(Label15)
        Panel2.Controls.Add(EmployeePosLabel)
        Panel2.Controls.Add(txtEmpName)
        Panel2.Controls.Add(Button1)
        Panel2.Controls.Add(Label3)
        Panel2.Controls.Add(Label6)
        Panel2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Panel2.Location = New Point(0, 121)
        Panel2.Name = "Panel2"
        Panel2.Size = New Size(1207, 598)
        Panel2.TabIndex = 3
        ' 
        ' Button4
        ' 
        Button4.BackgroundImageLayout = ImageLayout.Center
        Button4.Font = New Font("Algerian", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button4.Location = New Point(737, 480)
        Button4.Name = "Button4"
        Button4.Size = New Size(168, 41)
        Button4.TabIndex = 39
        Button4.Text = "print"
        Button4.UseVisualStyleBackColor = True
        ' 
        ' SalaryTb
        ' 
        SalaryTb.Location = New Point(488, 92)
        SalaryTb.Name = "SalaryTb"
        SalaryTb.Size = New Size(665, 364)
        SalaryTb.TabIndex = 38
        SalaryTb.Text = ""
        ' 
        ' LabourDate
        ' 
        LabourDate.BorderStyle = BorderStyle.FixedSingle
        LabourDate.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        LabourDate.Location = New Point(52, 301)
        LabourDate.Name = "LabourDate"
        LabourDate.Size = New Size(195, 43)
        LabourDate.TabIndex = 36
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.BackColor = SystemColors.Control
        Label1.Font = New Font("Algerian", 13.8F)
        Label1.ForeColor = SystemColors.ControlText
        Label1.Location = New Point(28, 256)
        Label1.Name = "Label1"
        Label1.Size = New Size(168, 25)
        Label1.TabIndex = 35
        Label1.Text = "worked days"
        ' 
        ' HomeLabel
        ' 
        HomeLabel.AutoSize = True
        HomeLabel.BackColor = SystemColors.ButtonShadow
        HomeLabel.Font = New Font("Algerian", 16.2F)
        HomeLabel.ForeColor = SystemColors.Highlight
        HomeLabel.Location = New Point(1050, 535)
        HomeLabel.Name = "HomeLabel"
        HomeLabel.Size = New Size(86, 31)
        HomeLabel.TabIndex = 34
        HomeLabel.Text = "HOME"
        ' 
        ' Button2
        ' 
        Button2.BackgroundImageLayout = ImageLayout.Center
        Button2.Font = New Font("Algerian", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button2.Location = New Point(254, 78)
        Button2.Name = "Button2"
        Button2.Size = New Size(168, 41)
        Button2.TabIndex = 33
        Button2.Text = "fetch"
        Button2.UseVisualStyleBackColor = True
        ' 
        ' txtSearchId
        ' 
        txtSearchId.BorderStyle = BorderStyle.FixedSingle
        txtSearchId.Font = New Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSearchId.Location = New Point(40, 78)
        txtSearchId.Name = "txtSearchId"
        txtSearchId.Size = New Size(195, 43)
        txtSearchId.TabIndex = 29
        ' 
        ' Label15
        ' 
        Label15.AutoSize = True
        Label15.BackColor = SystemColors.Control
        Label15.Font = New Font("Algerian", 13.8F)
        Label15.ForeColor = SystemColors.ControlText
        Label15.Location = New Point(40, 38)
        Label15.Name = "Label15"
        Label15.Size = New Size(154, 25)
        Label15.TabIndex = 28
        Label15.Text = "employee id"
        ' 
        ' EmployeePosLabel
        ' 
        EmployeePosLabel.AutoSize = True
        EmployeePosLabel.BackColor = SystemColors.Control
        EmployeePosLabel.Font = New Font("Algerian", 13.8F)
        EmployeePosLabel.ForeColor = Color.Red
        EmployeePosLabel.Location = New Point(263, 202)
        EmployeePosLabel.Name = "EmployeePosLabel"
        EmployeePosLabel.Size = New Size(174, 25)
        EmployeePosLabel.TabIndex = 24
        EmployeePosLabel.Text = "employee pos"
        ' 
        ' txtEmpName
        ' 
        txtEmpName.AutoSize = True
        txtEmpName.BackColor = SystemColors.Control
        txtEmpName.Font = New Font("Algerian", 13.8F)
        txtEmpName.ForeColor = Color.Red
        txtEmpName.Location = New Point(229, 149)
        txtEmpName.Name = "txtEmpName"
        txtEmpName.Size = New Size(195, 25)
        txtEmpName.TabIndex = 23
        txtEmpName.Text = "employee name"
        ' 
        ' Button1
        ' 
        Button1.BackgroundImageLayout = ImageLayout.Center
        Button1.Font = New Font("Algerian", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button1.Location = New Point(97, 374)
        Button1.Name = "Button1"
        Button1.Size = New Size(168, 41)
        Button1.TabIndex = 20
        Button1.Text = "view"
        Button1.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.BackColor = SystemColors.Control
        Label3.Font = New Font("Algerian", 13.8F)
        Label3.ForeColor = SystemColors.ControlText
        Label3.Location = New Point(28, 202)
        Label3.Name = "Label3"
        Label3.Size = New Size(229, 25)
        Label3.TabIndex = 11
        Label3.Text = "employee position"
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.BackColor = SystemColors.Control
        Label6.Font = New Font("Algerian", 13.8F)
        Label6.ForeColor = SystemColors.ControlText
        Label6.Location = New Point(28, 149)
        Label6.Name = "Label6"
        Label6.Size = New Size(195, 25)
        Label6.TabIndex = 6
        Label6.Text = "employee name"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.BackColor = SystemColors.ControlText
        Label2.Font = New Font("Algerian", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label2.ForeColor = SystemColors.ButtonFace
        Label2.Location = New Point(97, 60)
        Label2.Name = "Label2"
        Label2.Size = New Size(306, 34)
        Label2.TabIndex = 7
        Label2.Text = "Employee Salary"
        ' 
        ' PictureBox1
        ' 
        PictureBox1.BackColor = SystemColors.ControlText
        PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), Image)
        PictureBox1.Location = New Point(12, 32)
        PictureBox1.Name = "PictureBox1"
        PictureBox1.Size = New Size(68, 62)
        PictureBox1.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox1.TabIndex = 6
        PictureBox1.TabStop = False
        ' 
        ' PictureBox3
        ' 
        PictureBox3.BackColor = SystemColors.ControlText
        PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), Image)
        PictureBox3.Location = New Point(1024, 738)
        PictureBox3.Name = "PictureBox3"
        PictureBox3.Size = New Size(37, 34)
        PictureBox3.SizeMode = PictureBoxSizeMode.Zoom
        PictureBox3.TabIndex = 30
        PictureBox3.TabStop = False
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.BackColor = SystemColors.ControlText
        Label10.Font = New Font("Algerian", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label10.ForeColor = SystemColors.ButtonFace
        Label10.Location = New Point(1067, 741)
        Label10.Name = "Label10"
        Label10.Size = New Size(140, 34)
        Label10.TabIndex = 29
        Label10.Text = "abc.ltd"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.BackColor = SystemColors.ControlText
        Label4.Font = New Font("Algerian", 18F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label4.ForeColor = SystemColors.ButtonFace
        Label4.Location = New Point(1130, 45)
        Label4.Name = "Label4"
        Label4.Size = New Size(37, 34)
        Label4.TabIndex = 31
        Label4.Text = "X"
        ' 
        ' PrintDocument1
        ' 
        ' 
        ' PrintPreviewDialog1
        ' 
        PrintPreviewDialog1.AutoScrollMargin = New Size(0, 0)
        PrintPreviewDialog1.AutoScrollMinSize = New Size(0, 0)
        PrintPreviewDialog1.ClientSize = New Size(400, 300)
        PrintPreviewDialog1.Enabled = True
        PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), Icon)
        PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        PrintPreviewDialog1.Visible = False
        ' 
        ' Salary
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(0), CByte(64), CByte(64))
        ClientSize = New Size(1207, 773)
        Controls.Add(Label4)
        Controls.Add(PictureBox3)
        Controls.Add(Label10)
        Controls.Add(Label2)
        Controls.Add(PictureBox1)
        Controls.Add(Panel2)
        FormBorderStyle = FormBorderStyle.None
        Name = "Salary"
        StartPosition = FormStartPosition.CenterScreen
        Text = "salary"
        Panel2.ResumeLayout(False)
        Panel2.PerformLayout()
        CType(PictureBox1, ComponentModel.ISupportInitialize).EndInit()
        CType(PictureBox3, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Panel2 As Panel
    Friend WithEvents HomeLabel As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents txtSearchId As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents EmployeePosLabel As Label
    Friend WithEvents txtEmpName As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents PictureBox3 As PictureBox
    Friend WithEvents Label10 As Label
    Friend WithEvents LabourDate As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents SalaryTb As RichTextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents PrintDocument1 As Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As PrintPreviewDialog
End Class
