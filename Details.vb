Imports Microsoft.Data.SqlClient
Public Class Details
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
                txtEmpAddress.Text = reader("empAdd").ToString()
                cmbEmpPosition.Text = reader("EmpPos").ToString()
                dtpEmpDOB.Text = Convert.ToDateTime(reader("empDOB"))
                txtEmpPhone.Text = reader("empPhone").ToString()
                cmbEmpEdu.Text = reader("EmpEdu").ToString()
                cmbEmpGndr.Text = reader("Empgndr").ToString()
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
    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles homeLabel.Click
        Me.Hide()
        Dim main = New HomeForm
        main.Show()
    End Sub

    Private Sub Details_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label12_Click(sender As Object, e As EventArgs) Handles txtEmpName.Click

    End Sub

    Private Sub Panel2_Paint(sender As Object, e As PaintEventArgs) Handles Panel2.Paint

    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        FetchEmployeeData()

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click
        Application.Exit()

    End Sub
End Class