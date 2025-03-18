Imports Microsoft.Data.SqlClient
Imports System.Drawing.Printing
Imports System.Runtime.InteropServices

Public Class Salary
    Private WithEvents printDoc As New PrintDocument()
    Dim sqlConnection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sande\Documents\EmployeeVbDb.mdf;Integrated Security=True;Connect Timeout=30")
    Private Sub FetchEmployeeData()
        Try
            ' Ensure input is not empty
            If txtSearchId.Text = "" Then
                MsgBox("Please enter an Employee ID to search.")
                Exit Sub
            End If

            ' Convert ID to integer
            Dim empId As Integer
            If Not Integer.TryParse(txtSearchId.Text, empId) Then
                MsgBox("Invalid ID. Please enter a valid number.")
                Exit Sub
            End If

            sqlConnection.Open() ' Open connection

            ' Query to search for the employee by ID
            Dim query As String = "SELECT * FROM EmployeeTb1 WHERE Id = @EmpId"
            Dim cmd As New SqlCommand(query, sqlConnection)
            cmd.Parameters.AddWithValue("@EmpId", empId)

            Dim reader As SqlDataReader = cmd.ExecuteReader()

            ' Check if employee exists
            If reader.Read() Then
                ' Populate TextBoxes or Labels
                txtEmpName.Text = reader("EmpName").ToString()
                EmployeePosLabel.Text = reader("EmpPos").ToString()

            Else
                MsgBox("No employee found with the given ID.")

            End If

            reader.Close()

        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            sqlConnection.Close() ' Close connection
        End Try

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles EmployeePosLabel.Click

    End Sub

    Private Sub HomeLabel_Click(sender As Object, e As EventArgs) Handles HomeLabel.Click
        Me.Hide()
        Dim main = New HomeForm
        main.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        FetchEmployeeData()

    End Sub

    Private Sub salary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        printDoc = New PrintDocument()
        AddHandler printDoc.PrintPage, AddressOf PrintDocument1_PrintPage
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub
    Dim dailyPay
    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If EmployeePosLabel.Text = "" Then
            MsgBox("select an employee")
        ElseIf LabourDate.Text = "" Or Convert.ToInt32(LabourDate.Text) > 28 Then
            MsgBox("Enter a valid Number Of Days")
        Else
            If EmployeePosLabel.Text = "Manager" Then
                dailyPay = 1200
            ElseIf EmployeePosLabel.Text = "Accountant" Then
                dailyPay = 1000
            ElseIf EmployeePosLabel.Text = "Security" Then
                dailyPay = 500
            ElseIf EmployeePosLabel.Text = "Developer" Then
                dailyPay = 1000
            ElseIf EmployeePosLabel.Text = "Cleaner" Then
                dailyPay = 600
            ElseIf EmployeePosLabel.Text = "HR" Then
                dailyPay = 800



            End If
            Dim Total = dailyPay * Convert.ToInt32(LabourDate.Text)
            SalaryTb.Text = "Employee id :" & txtSearchId.Text & vbCrLf & "Employee Position:" & EmployeePosLabel.Text & vbCrLf & "Days Worked:" & LabourDate.Text & vbCrLf & "Daily Salary:" & Convert.ToString(dailyPay) & vbCrLf & "Total Amount Rs:" & Total

        End If


    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Application.Exit()
    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim startX As Integer = 100
        Dim startY As Integer = 100
        Dim lineSpacing As Integer = 40

        ' Title
        e.Graphics.DrawString("Employee Management System", New Font("Century Gothic", 25, FontStyle.Bold), Brushes.DarkGreen, startX, startY)
        startY += lineSpacing + 20

        ' Payslip Header
        e.Graphics.DrawString("*** PAYSLIP ***", New Font("Arial", 20, FontStyle.Bold), Brushes.Crimson, startX + 150, startY)
        startY += lineSpacing + 20

        ' Employee Details
        Dim lines() As String = SalaryTb.Text.Split(vbCrLf)
        For Each line As String In lines
            e.Graphics.DrawString(line, New Font("Century Gothic", 14), Brushes.Black, startX, startY)
            startY += lineSpacing
        Next

        ' Footer
        e.Graphics.DrawString("========== Thanks For Your Service ==========", New Font("Century Gothic", 15, FontStyle.Italic), Brushes.DarkGreen, startX, startY + 80)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If String.IsNullOrWhiteSpace(SalaryTb.Text) Then
            MsgBox("Nothing to print!")
            Exit Sub
        End If
        PrintPreviewDialog1 = New PrintPreviewDialog()
        PrintPreviewDialog1.Document = printDoc ' Assign print document
        PrintPreviewDialog1.ShowDialog() ' Show preview

    End Sub

    Private Sub PrintPreviewDialog1_Load(sender As Object, e As EventArgs) Handles PrintPreviewDialog1.Load

    End Sub
End Class