Public Class Form1
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click
        End
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Aqui definiremos los usuarios que pueden acceder al programa sin necesidad de conectar con una BD
        If (TextBox1.Text = "Horizon") And (TextBox2.Text = "12345") Then
            Form2.Show()
            Me.Hide()

        Else
            MsgBox("Lo sentimos, el usuario ingresado no está registrado en la beta del programa", vbExclamation, "Error con los datos")
        End If
    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class
