' Project Title: Karaoke Night
' Developer: Maria Jackson
' Date: April 1, 2023
' Purpose: This app lets users choose a karaoke room rental type and calculate their total cost
''          Users select to rent per song or sent a room by hour, and their cost is displayed

Public Class frmKaraoke

    ' declare constant program variables:
    Private _cdecSongRate As Decimal = 2.99D
    Private _cdecHourlyRate As Decimal = 8.99D

    Private Sub fmKaraoke_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Pauses the splash screen after 3 seconds
        Threading.Thread.Sleep(3000)
        ' reset form
        ClearForm()
    End Sub

    Private Sub ClearForm()
        txtValue.Text = ""
        cboSelectionAction.Text = "Select Rental Type:"
        lblTotalCost.Text = ""
        lblInstructions.Text = ""
        txtValue.Focus()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearForm()
    End Sub

    Private Sub cboSelectionAction_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSelectionAction.SelectedIndexChanged
        ' Handles rental type selection
        Dim intRentalType As Integer
        ' use selected rental type
        intRentalType = cboSelectionAction.SelectedIndex()
        Select Case intRentalType
            Case 0
                BySong()
            Case 1
                ByHour()
        End Select

    End Sub

    Private Function ValidateInput(ByVal strInputValue As String) As Boolean
        Dim isValid As Boolean = False
        Dim intInputValue As Integer
        Dim alert
        Try
            intInputValue = Convert.ToInt32(strInputValue)
            If intInputValue > 0 Then
                isValid = True
            End If
        Catch notNumeric As FormatException
            alert = MsgBox("Please enter a positive number.", vbOKOnly, "Invalid Input")
            isValid = False
            ClearForm()
        End Try
        Return isValid
    End Function

    Private Sub BySong()
        Dim strSong = "Please enter the number of songs:"
        lblInstructions.Text = strSong
    End Sub

    Private Sub ByHour()
        ' calculate cost based on number of hours
        Dim strHour = "Please enter the number of hours:"
        lblInstructions.Text = strHour
    End Sub

    Private Function CalculateCostBySong() As Decimal
        'calculate cost based on number of songs
        Dim validInput As Boolean
        Dim strValue As String
        Dim intValue As Integer
        Dim decTotalCost As Decimal = 0D
        strValue = txtValue.Text
        validInput = ValidateInput(strValue)
        If validInput Then
            intValue = Convert.ToInt32(strValue)
            decTotalCost = intValue * _cdecSongRate
            Return decTotalCost
        End If
        Return decTotalCost
    End Function

    Private Function CalculateCostByHour() As Decimal
        'calculate cost based on number of songs
        Dim validInput As Boolean
        Dim strValue As String
        Dim intValue As Integer
        Dim decTotalCost As Decimal = 0D
        strValue = txtValue.Text
        validInput = ValidateInput(strValue)
        If validInput Then
            intValue = Convert.ToInt32(strValue)
            decTotalCost = intValue * _cdecHourlyRate
            Return decTotalCost
        End If
        Return decTotalCost
    End Function

    Private Sub btnValue_Click(sender As Object, e As EventArgs) Handles btnValue.Click
        Dim decCost As Decimal = 0D
        Dim strCost As String = ""
        Dim strCostOutput As String = "Your total cost is: {0}"
        If cboSelectionAction.SelectedIndex = 0 Then
            decCost = CalculateCostBySong()
            strCost = decCost.ToString("C2")
        Else
            decCost = CalculateCostByHour()
            strCost = decCost.ToString("C2")
        End If
        lblTotalCost.Text = String.Format(strCostOutput, strCost)
    End Sub
End Class
