Public Class Form1
    Private Sub btnCalculateMPG_Click(sender As Object, e As EventArgs) Handles btnCalculateMPG.Click
        ' Variable declarations
        Dim dblGallons As Double = 0.0              ' Gallons of gas the car can hold
        Dim dblMiles As Double = 0.0                ' Miles the car can be driven on a full tank
        Dim dblMilesPerGallon As Double = 0.0       ' Miles per Gallon the car can get

        Try
            ' Get the number of gallons of gas the car can hold
            dblGallons = CDbl(txtGallons.Text)

            ' Get the number of miles the car can be driven on a full tank
            dblMiles = CDbl(txtNumberOfMiles.Text)

            ' Calculate the Miles per Gallon
            dblMilesPerGallon = dblMiles / dblGallons

            ' Display the Miles per Gallon
            lblMilesPerGallon.Text = dblMilesPerGallon.ToString()

        Catch ex As Exception

            ' Error message if user doesn't enter a number
            MessageBox.Show("Error: No number detected. Please enter a number and try again.")
        End Try
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' Clear the Text Boxes and Label control.
        txtGallons.Clear()
        txtNumberOfMiles.Clear()
        lblMilesPerGallon.Text = String.Empty
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        ' Close the form
        Me.Close()
    End Sub
End Class
