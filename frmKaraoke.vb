' Project Title: Karaoke Night
' Developer: Maria Jackson
' Date: April 1, 2023
' Purpose: This app lets users choose a karaoke room rental type and calculate their total cost
''          Users select to rent per song or sent a room by hour, and their cost is displayed

Public Class frmKaraoke
    Private Sub fmKaraoke_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Pauses the splash screen after 3 seconds
        Threading.Thread.Sleep(3000)
        ' reset form
        ClearForm()
    End Sub

    Private Sub ClearForm()
        txtValue.Text = ""
        cboSelectionAction.SelectedIndex = 0
        lblTotalCost.Text = ""
        lblInstructions.Text = ""
        txtValue.Focus()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        ClearForm()
    End Sub
End Class
