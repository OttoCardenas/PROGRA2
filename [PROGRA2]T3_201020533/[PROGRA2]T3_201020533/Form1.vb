Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim A As Double
        Dim B As Double
        Dim R As Double

        A = Val(TextBox1.Text)
        B = Val(TextBox2.Text)


        If (RadioButton1.Checked = True) Then
            R = A + B
            resultado.Text = R
        Else
            If (RadioButton2.Checked = True) Then
                R = A - B
                resultado.Text = R
            Else
                If (RadioButton3.Checked = True) Then
                    R = A * B
                    resultado.Text = R
                Else
                    If RadioButton4.Checked = True Then
                        R = A / B
                        resultado.Text = Format(R, "#.#0")
                    End If
                End If
            End If
        End If

    End Sub

End Class
