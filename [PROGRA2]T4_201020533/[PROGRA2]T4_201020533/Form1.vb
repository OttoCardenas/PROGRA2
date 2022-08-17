Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim num, factorial As Integer
        factorial = 1

        num = Val(TextBox1.Text)
        Label3.Text = ""
        Label5.Text = ""

        If num <= 12 Then

            For i = 1 To num Step 1
                factorial = factorial * i
            Next
            Label3.Text = factorial
        Else
            Label3.Text = "El factorial es muy grande"
            Label5.Text = "Ingrese un número menor"
        End If





    End Sub
End Class
