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
        DisplayListBox.Items.Clear()
    End Sub

    'Activates the roll the dice code (from the previous code) when button is pressed
    Private Sub RollButton_Click(sender As Object, e As EventArgs) Handles RollButton.Click

        Dim rolls(10) As Integer 'Initializes an array conatining 11 toltal values
        Dim total As Integer
        Dim rowData As String = "" 'This is used to create a row before displaying it to the list box
        Dim random As New Random() 'Creates an instance of the random class and the new generates a new seed each run through to provide pseudo randomness


        'Generates the dice roll information table formatting
        For i As Integer = 0 To 999
            total = random.Next(1, 7) + random.Next(1, 7) 'The combination of two random rolls
            rolls(total - 2) += 1 'Increments the amount of times the total was rolled based on what the total is. (Shifted -2 to match appropriate array value)
        Next

        DisplayListBox.Items.Add("Roll of The Dice".PadLeft(41)) 'Adds the roll the dice tag to the output

        'Visual Divider
        For i As Integer = 0 To rolls.Length() - 1 'Write a divider equal to the length of the rowData
            rowData = $"{rowData}------"
        Next
        DisplayListBox.Items.Add(rowData)
        rowData = ""

        'Displays the 2 to 12 count 
        For i As Integer = 0 To rolls.Length() - 1 'Write the values from 2 to 12 and formats it
            rowData = $"{rowData}{CStr((i + 2).ToString().PadLeft(5) & "|")}"
        Next
        DisplayListBox.Items.Add(rowData)
        rowData = ""

        'Visual Divider
        For i As Integer = 0 To rolls.Length() - 1 'Write a divider equal to the length of the rowData
            rowData = $"{rowData}------"
        Next
        DisplayListBox.Items.Add(rowData)
        rowData = ""

        'Dice Roll information
        For i As Integer = 0 To rolls.Length() - 1 'Outputs the stored values based on the rolls array and formats them to look nice
            rowData = $"{rowData}{rolls(i).ToString.PadLeft(5) & "|"}"
        Next
        DisplayListBox.Items.Add(rowData)
        rowData = ""

        'Visual Divider
        For i As Integer = 0 To rolls.Length() - 1 'Write a divider equal to the length of the rowData
            rowData = $"{rowData}------"
        Next
        DisplayListBox.Items.Add(rowData)
        rowData = ""

    End Sub

End Class
