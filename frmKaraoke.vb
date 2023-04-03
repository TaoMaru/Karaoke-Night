' Project Title: Karaoke Night
' Developer: Maria Jackson
' Date: April 3, 2023
' Purpose: This app lets users choose a karaoke room rental type and calculate their total cost
''          Users select to rent per song or rent a room by hour, and their cost is displayed
''          Utilizes procudures to create a modular program flow for calculating cost, hiding &
''          displaying form components/fields, and changing what is displayed to the user.

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
        cboSelectionAction.Focus() ' reset focus
        HideFields() ' hide txtBox and btns
    End Sub

    Private Sub ClearText()
        'resets just the txtValue text box & rests focus
        txtValue.Text = ""
        txtValue.Focus()
    End Sub

    Private Sub HideFields()
        'hides btns & txtBox
        btnValue.Visible = False
        btnClear.Visible = False
        txtValue.Visible = False
    End Sub

    Private Sub ShowFields()
        'reveals btns & txtBox
        btnValue.Visible = True
        btnClear.Visible = True
        txtValue.Visible = True
        txtValue.Focus()
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
                ShowFields() 'display txtBox and btns
            Case 1
                ByHour() ' display rental by hour instructions
                ShowFields() 'display txtBox and btns
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
                ClearText() ' reset txtBox
            End If
        Catch notNumeric As FormatException
            'input is not numeric, present error msg
            MsgBox("Please enter a positive number.", vbOKOnly, "Invalid Input")
            isValid = False
            ClearText() 'reset txtBox
        Catch txtOverflow As OverflowException
            'input is likely too large & no longer practical
            MsgBox("Please check your input and try again.", vbOKOnly, "Input Error")
            ClearText() ' reset txtBox
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
            decTotalCost = GetSongTotalCost(intValue)
            Return decTotalCost
        End If
        Return decTotalCost
    End Function

    Private Function GetSongTotalCost(ByVal numSongs As Integer) As Decimal
        'handles the product of input number of songs and the rental per song rate
        Dim decSongCost As Decimal ' rental per song cost
        decSongCost = numSongs * _cdecSongRate
        Return decSongCost
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
            decTotalCost = GetHourlyTotalCost(intValue)
            Return decTotalCost
        End If
        Return decTotalCost
    End Function

    Private Function GetHourlyTotalCost(ByVal numHours As Integer) As Decimal
        ' calculates the product of input number of hours and the hourly rate
        Dim decHourlyCost As Decimal ' hourly total cost
        decHourlyCost = numHours * _cdecHourlyRate
        Return decHourlyCost
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
