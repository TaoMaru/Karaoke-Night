' Project Title: Karaoke Night
' Developer: Maria Jackson
' Date: April 3, 2023
' Purpose: This app lets users choose a karaoke room rental type and calculate their total cost
''          Users select to rent per song or sent a room by hour, and their cost is displayed

Option Strict On
Option Explicit On

Public Class frmKaraoke

    ' declare constant program variables:
    Private _cdecSongRate As Decimal = 2.99D ' cost per song
    Private _cdecHourlyRate As Decimal = 8.99D 'cost per hour

    Private Sub fmKaraoke_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Pauses the splash screen after 3 seconds & uses call to ClearForm to reset all
        Threading.Thread.Sleep(3000)
        ' reset form
        ClearForm()
    End Sub

    Private Sub ClearForm()
        ' resets form: clears text box, resets focus, resets cboSelection to start state
        txtValue.Text = "" ' reset txt box text
        cboSelectionAction.Text = "Select Rental Type:" ' reset cboSelection
        lblTotalCost.Text = "" ' reset totalCost text
        lblInstructions.Text = "" ' rest instructions text
        txtValue.Focus() ' reset focus
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ' uses clearForm call to reset the form fields
        ClearForm()
    End Sub

    Private Sub cboSelectionAction_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboSelectionAction.SelectedIndexChanged
        ' Handles rental type selection: changes instructions text to display song or hourly type
        Dim intRentalType As Integer
        ' use selected rental type
        intRentalType = cboSelectionAction.SelectedIndex()
        Select Case intRentalType
            Case 0
                BySong() ' display rental per song instructions
            Case 1
                ByHour() ' display rental by hour instructions
        End Select

    End Sub

    Private Function ValidateInput(ByVal strInputValue As String) As Boolean
        ' handles input validation: uses exception handler to check if input is numeric
        Dim isValid As Boolean = False ' indicates valid input
        Dim intInputValue As Integer ' holds user input from txtValue

        Try
            intInputValue = Convert.ToInt32(strInputValue)
            If intInputValue > 0 Then ' input is a number greater than 0, & is valid
                isValid = True
            Else
                ' input not greater than 0, present error msg
                MsgBox("Please enter a positive number.", vbOKOnly, "Invalid Input")
                isValid = False
                ClearForm() ' reset form
            End If
        Catch notNumeric As FormatException
            'input is not numeric, present error msg
            MsgBox("Please enter a positive number.", vbOKOnly, "Invalid Input")
            isValid = False
            ClearForm() 'reset form
        End Try
        Return isValid
    End Function

    Private Sub BySong()
        ' change instructions to display for rental by song
        Dim strSong = "Please enter the number of songs:"
        lblInstructions.Text = strSong
    End Sub

    Private Sub ByHour()
        ' change instruction to display for rental by hour
        Dim strHour = "Please enter the number of hours:"
        lblInstructions.Text = strHour
    End Sub

    Private Function CalculateCostBySong() As Decimal
        'calculate cost based on number of songs
        Dim validInput As Boolean
        Dim strValue As String
        Dim intValue As Integer
        Dim decTotalCost As Decimal = 0D
        'get and validate number of songs input
        strValue = txtValue.Text
        validInput = ValidateInput(strValue)
        'convert input to int and calculate total cost
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
        ' get and validate input for number of hours
        strValue = txtValue.Text
        validInput = ValidateInput(strValue)
        ' convert input to int and calculate total cost
        If validInput Then
            intValue = Convert.ToInt32(strValue)
            decTotalCost = intValue * _cdecHourlyRate
            Return decTotalCost
        End If
        Return decTotalCost
    End Function

    Private Sub btnValue_Click(sender As Object, e As EventArgs) Handles btnValue.Click
        ' handles total cost calculation: determines if rental by song or by hour
        ' displays total cost
        Dim decCost As Decimal = 0D
        Dim strCost As String = ""
        Dim strCostOutput As String = "Your total cost is: {0}"
        If cboSelectionAction.SelectedIndex = 0 Then
            'calculate cost for rental by song
            decCost = CalculateCostBySong()
            If decCost > 0 Then
                strCost = decCost.ToString("C2")
                lblTotalCost.Text = String.Format(strCostOutput, strCost)
            End If
        ElseIf cboSelectionAction.SelectedIndex = 1 Then
            ' calculate cost for rental by hour
            decCost = CalculateCostByHour()
            If decCost > 0 Then
                strCost = decCost.ToString("C2")
                lblTotalCost.Text = String.Format(strCostOutput, strCost)
            End If
        Else
            lblTotalCost.Text = "" ' do not display total cost 
        End If
    End Sub
End Class
