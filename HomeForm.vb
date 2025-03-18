Public Class HomeForm
    Private Sub Panel1_Paint(sender As Object, e As PaintEventArgs) Handles Panel1.Paint

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click

    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles EmployeePictureBox.Click
        Me.Hide()
        Dim Emp = New Employee
        Emp.Show()
    End Sub

    Private Sub EmployeeLabel_Click(sender As Object, e As EventArgs) Handles EmployeeLabel.Click
        Me.Hide()
        Dim Emp = New Employee
        Emp.Show()
    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles DetailsPictureBox.Click
        Me.Hide()
        Dim details = New Details
        details.Show()
    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles DetailsLabel.Click
        Me.Hide()
        Dim details = New Details
        details.Show()
    End Sub

    Private Sub SalaryPictureBox_Click(sender As Object, e As EventArgs) Handles SalaryPictureBox.Click
        Me.Hide()
        Dim salary = New Salary
        salary.Show()
    End Sub

    Private Sub SalaryLabel_Click(sender As Object, e As EventArgs) Handles SalaryLabel.Click
        Me.Hide()
        Dim salary = New Salary
        salary.Show()
    End Sub
End Class