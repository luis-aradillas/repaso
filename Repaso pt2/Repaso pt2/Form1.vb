Public Class Form1
    Dim num1
    Dim num2

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim operacion = Val(numero1.Text) * 2
        Label2.Text = operacion
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles suma.Click
        num1 = Val(numero1.Text)
        num2 = Val(numero2.Text)
        Label2.Text = num1 + num2
    End Sub

    Private Sub resta_Click(sender As Object, e As EventArgs) Handles resta.Click
        Label2.Text = Val(numero1.Text) - Val(numero2.Text)
    End Sub

    Private Sub multiplicacion_Click(sender As Object, e As EventArgs) Handles multiplicacion.Click
        Label2.Text = Val(numero1.Text) * Val(numero2.Text)
    End Sub

    Private Sub division_Click(sender As Object, e As EventArgs) Handles division.Click
        If Val(numero2.Text) = 0 Then
            Label2.Text = "Error matemático"
        Else
            Label2.Text = Val(numero1.Text) / Val(numero2.Text)
        End If
    End Sub
End Class
