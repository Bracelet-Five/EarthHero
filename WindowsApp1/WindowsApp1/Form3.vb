Public Class Form3
    Dim Counter As Integer = 0

    Private Sub Label3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If (Counter Mod 2) = 0 Then
            Avatar2.Show()
            Avatar1.Hide()
        ElseIf (Counter Mod 2) = 1 Then
            Avatar1.Show()
            Avatar2.Hide()
        End If
        Counter = Counter + 1

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles Avatar2.Click

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If (Counter Mod 2) = 0 Then
            Avatar2.Show()
            Avatar1.Hide()
        ElseIf (Counter Mod 2) = 1 Then
            Avatar1.Show()
            Avatar2.Hide()
        End If
        Counter = Counter + 1
    End Sub

    Private Sub Avatar1_Click(sender As Object, e As EventArgs) Handles Avatar1.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form5.Show()
        Me.Hide()

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click

    End Sub
End Class