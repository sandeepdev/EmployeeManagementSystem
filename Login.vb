Public Class login
    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click
        Application.Exit()
    End Sub

    Private Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If UidTb.Text = "" Or PassTb.Text = "" Then
            MsgBox("Enter Valid User Data")
        ElseIf UidTb.Text = "user" And PassTb.Text = "password" Then
            Dim main = New HomeForm
            main.Show()
            Me.Hide()
        Else
            MsgBox("Username or Password is incorrect")


        End If
    End Sub
End Class