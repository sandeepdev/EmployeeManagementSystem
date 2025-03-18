Imports Microsoft.Data.SqlClient

Public Class Employee
    ' Database Connection
    Dim sqlConnection As New SqlConnection("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\sande\Documents\EmployeeVbDb.mdf;Integrated Security=True;Connect Timeout=30")
    Dim key As Integer = 0 ' Used for tracking selected employee

    ' Clears input fields
    Private Sub Clear()
        EmpNameTab.Clear()
        empAddrsTb.Clear()
        empPositionComboBox.Text = ""
        empDOB.Text = ""
        empPhoneTb.Clear()
        empQuliComboBox.Text = ""
        empGndrComboBox.Text = ""
        key = 0
    End Sub

    ' Deletes an employee
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        If key = 0 Then
            MsgBox("Select an Employee To Delete")
        Else
            Try
                sqlConnection.Open()
                Dim query As String = "DELETE FROM EmployeeTb1 WHERE Id = @Id"
                Dim cmd As New SqlCommand(query, sqlConnection)
                cmd.Parameters.AddWithValue("@Id", key)
                cmd.ExecuteNonQuery()
                MsgBox("Employee Deleted Successfully")

                Clear()
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
            Finally
                sqlConnection.Close()
            End Try
            Populate()
        End If
    End Sub

    ' Populates the DataGridView with Employee records
    Private Sub Populate()
        Try
            sqlConnection.Open()
            Dim query As String = "SELECT * FROM EmployeeTb1"
            Dim adapter As New SqlDataAdapter(query, sqlConnection)
            Dim dt As New DataTable()
            adapter.Fill(dt)
            EmployeeDGV.DataSource = dt
        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            sqlConnection.Close()
        End Try
    End Sub

    ' Adds a new employee
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            sqlConnection.Open()
            Dim query As String = "INSERT INTO EmployeeTb1 (EmpName, empAdd, EmpPos, EmpDOB, empPhone, EmpEdu, Empgndr) 
                                   VALUES (@EmpName, @EmpAddress, @EmpPosition, @EmpDOB, @EmpPhone, @EmpEdu, @EmpGndr)"
            Dim cmd As New SqlCommand(query, sqlConnection)

            ' Add Parameters
            cmd.Parameters.AddWithValue("@EmpName", EmpNameTab.Text)
            cmd.Parameters.AddWithValue("@EmpAddress", empAddrsTb.Text)
            cmd.Parameters.AddWithValue("@EmpPosition", empPositionComboBox.SelectedItem?.ToString())
            cmd.Parameters.AddWithValue("@EmpDOB", empDOB.Value.ToString("yyyy-MM-dd"))
            cmd.Parameters.AddWithValue("@EmpPhone", empPhoneTb.Text)
            cmd.Parameters.AddWithValue("@EmpEdu", empQuliComboBox.SelectedItem?.ToString())
            cmd.Parameters.AddWithValue("@EmpGndr", empGndrComboBox.SelectedItem?.ToString())

            cmd.ExecuteNonQuery()
            MsgBox("Employee Added Successfully")


        Catch ex As Exception
            MsgBox("Error: " & ex.Message)
        Finally
            sqlConnection.Close()
        End Try
        Populate()
        Clear()
    End Sub

    ' Handles DataGridView row selection
    Private Sub EmployeeDGV_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles EmployeeDGV.CellMouseClick
        ' Check if the clicked row index is valid and not the empty new row
        If e.RowIndex >= 0 AndAlso e.RowIndex < EmployeeDGV.Rows.Count - 1 Then
            Dim row As DataGridViewRow = EmployeeDGV.Rows(e.RowIndex)

            ' Ensure the row has valid data before accessing
            If row.Cells(0).Value IsNot Nothing Then
                key = Convert.ToInt32(row.Cells(0).Value.ToString())
                EmpNameTab.Text = If(row.Cells(1).Value IsNot Nothing, row.Cells(1).Value.ToString(), "")
                empAddrsTb.Text = If(row.Cells(2).Value IsNot Nothing, row.Cells(2).Value.ToString(), "")
                empPositionComboBox.SelectedItem = If(row.Cells(3).Value IsNot Nothing, row.Cells(3).Value.ToString(), Nothing)
                empDOB.Value = If(row.Cells(4).Value IsNot Nothing, Convert.ToDateTime(row.Cells(4).Value), DateTime.Now)
                empPhoneTb.Text = If(row.Cells(5).Value IsNot Nothing, row.Cells(5).Value.ToString(), "")
                empQuliComboBox.SelectedItem = If(row.Cells(6).Value IsNot Nothing, row.Cells(6).Value.ToString(), Nothing)
                empGndrComboBox.SelectedItem = If(row.Cells(7).Value IsNot Nothing, row.Cells(7).Value.ToString(), Nothing)
            End If
        End If
    End Sub


    ' Updates an existing employee
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If EmpNameTab.Text = "" Or empAddrsTb.Text = "" Or empPhoneTb.Text = "" Or
           empPositionComboBox.SelectedItem Is Nothing Or empGndrComboBox.SelectedItem Is Nothing Then
            MsgBox("Missing Information")
        Else
            Try
                sqlConnection.Open()
                Dim query As String = "UPDATE EmployeeTb1 
                                       SET EmpName=@EmpName, empAdd=@EmpAddress, EmpPos=@EmpPosition, empDOB=@EmpDOB, 
                                           empPhone=@EmpPhone, EmpEdu=@EmpEdu, Empgndr=@EmpGndr 
                                       WHERE Id=@Id"
                Dim cmd As New SqlCommand(query, sqlConnection)

                ' Add Parameters
                cmd.Parameters.AddWithValue("@EmpName", EmpNameTab.Text)
                cmd.Parameters.AddWithValue("@EmpAddress", empAddrsTb.Text)
                cmd.Parameters.AddWithValue("@EmpPosition", empPositionComboBox.SelectedItem?.ToString())
                cmd.Parameters.AddWithValue("@EmpDOB", empDOB.Value.ToString("yyyy-MM-dd"))
                cmd.Parameters.AddWithValue("@EmpPhone", empPhoneTb.Text)
                cmd.Parameters.AddWithValue("@EmpEdu", empQuliComboBox.SelectedItem?.ToString())
                cmd.Parameters.AddWithValue("@EmpGndr", empGndrComboBox.SelectedItem?.ToString())
                cmd.Parameters.AddWithValue("@Id", key)

                cmd.ExecuteNonQuery()
                MsgBox("Employee Updated Successfully")
                Populate()
                Clear()
            Catch ex As Exception
                MsgBox("Error: " & ex.Message)
            Finally
                sqlConnection.Close()
            End Try
        End If
    End Sub

    ' Navigates to Home Form
    Private Sub HomeLabel_Click(sender As Object, e As EventArgs) Handles HomeLabel.Click
        Me.Hide()
        Dim main As New HomeForm()
        main.Show()
    End Sub

    ' Closes the application
    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles CloseButton.Click
        Application.Exit()
    End Sub

    ' Load event to populate DataGridView
    Private Sub Employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Populate()
    End Sub
End Class
