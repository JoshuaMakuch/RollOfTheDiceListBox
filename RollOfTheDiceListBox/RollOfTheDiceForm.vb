'Joshua Makuch
'RCET0265
'Spring 2023
'Rolld Of The Dice List Box
'https://github.com/JoshuaMakuch/RollOfTheDiceListBox.git

Option Strict On
Option Explicit On

Public Class RollOfTheDiceForm

    'Exits the form when exit button clicked
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    'Clears the list box when the clear button is clicked
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click

    End Sub

    'Activates the roll the dice code (from the previous code) when button is pressed
    Private Sub RollButton_Click(sender As Object, e As EventArgs) Handles RollButton.Click
        Dim rolls(10) As Integer 'Initializes an array conatining 11 toltal values
        Dim roll1 As Integer
        Dim roll2 As Integer
        Dim Total As Integer
        Dim random As New Random() 'Creates an instance of the random class and the new generates a new seed each run through to provide pseudo randomness

        For i As Integer = 0 To 999
            roll1 = random.Next(1, 7) 'First die roll. Also the .next generates a random integer (>= first and < second), but .NextDouble can be used to generate a random double
            roll2 = random.Next(1, 7) 'Second die roll
            Total = roll1 + roll2 'The combination of the two rolls
            rolls(Total - 2) += 1 'Increments the amount of times the total was rolled based on what the total is. (Shifted -2 to match appropriate array value)
        Next

        DisplayListBox.Text() = "AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA"

    End Sub

End Class
