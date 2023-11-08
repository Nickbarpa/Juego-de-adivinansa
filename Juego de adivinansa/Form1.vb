Public Class Form1
    Dim Adivinar As Integer
    Dim attempts As Integer

    Public Sub New()
        InitializeComponent()
        InitializeGame()
    End Sub

    Private Sub InitializeGame()
        Dim rand As New Random()
        Adivinar = rand.Next(1, 101) ' Número aleatorio entre 1 y 100
        attempts = 0
        lblMensaje.Text = "Adivina un número entre 1 y 100."
    End Sub

    Private Sub btnAdivinar_Click(sender As Object, e As EventArgs) Handles btnAdivinar.Click
        Dim userGuess As Integer

        If Integer.TryParse(txtSuposicion.Text, userGuess) Then
            attempts += 1

            If userGuess = Adivinar Then
                MessageBox.Show($"¡Felicidades! Adivinaste el número en {attempts} intentos.", "¡Adivinaste!")
                InitializeGame()
            ElseIf userGuess < Adivinar Then
                MessageBox.Show("El número es mayor. Inténtalo de nuevo.", "Número Incorrecto")
            Else
                MessageBox.Show("El número es menor. Inténtalo de nuevo.", "Número Incorrecto")
            End If

            txtSuposicion.Clear()
        Else
            MessageBox.Show("Por favor, ingresa un número válido.", "Entrada Inválida")
        End If
    End Sub
End Class
