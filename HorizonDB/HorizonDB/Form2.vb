Public Class Form2
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'Primero aumentamos el valor de la Progress Bar en 1
        ProgressBar1.Value += 1
        'Hacemos que el formulario aparezca gradualmente, para eso creamos una condición
        If Me.Opacity < 1 Then
            Me.Opacity += 0.05
            'El valor de la opacidad trabaja en porcentaje, entonces el valor máximo de la opacidad es 1 que es igual al 100%, entonces, mientras la opacidad sea menor a 100% o 1, se aumentara la opacidad un 5% por ciento o 0.05 
        End If

        'Ahora haremos que el temporizador se ejecute cada 3 segundos, donde si la barra de progreso llega a 100, es decir, ya transcurrieron 3000 milisegundos, detenemos el temporizador  
        If ProgressBar1.Value = 100 Then
            Timer1.Stop()
            Timer2.Start()
        End If

        'Para iniciar el temporizador tenemos que añadir el evento "Load" del formulario actual
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Inicializamos el valor de la barra de progreso en 0 al igual que la opacidad
        ProgressBar1.Value = 0
        Me.Opacity = 0
        Timer1.Start()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        ''Para hacer el mismo efecto pero al mostrar otro formulario, hacemos el mismo paso revertido
        Me.Opacity -= 0.1
        If Me.Opacity = 0 Then
            Timer2.Stop()
            Me.Close()
            Form3.Show()
        End If
    End Sub
End Class
