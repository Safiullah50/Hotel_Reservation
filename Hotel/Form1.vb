Public Class frmHotel
    'BY SAFI ULLAH 
    'PROJECT 3
    'CIS 115
    Dim regNumber As Integer = 500
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close()
    End Sub
    'command for clear 
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtDate.Text = ""
        txtGuests.Text = ""
        txtName.Text = ""
        txtNight.Text = ""
        comSelectHotel.SelectedIndex = -1
        lstHotel.Items.Clear()
        radOneKing.Checked = False
        radSuite.Checked = False
        radTowQueen.Checked = False
    End Sub
    'ARGUMENT COMMANDS 
    Private Sub btnReservation_Click(sender As Object, e As EventArgs) Handles btnReservation.Click
        Dim fullName, selectedHotel, arrivalDate As String
        fullName = ""
        selectedHotel = ""
        arrivalDate = ""
        Dim numberNight, numberGuests As Integer

        If Not DataOk() Then
            MessageBox.Show("enter correct data")
            Return
        End If

        lstHotel.Items.Clear()

        GetInput(fullName, selectedHotel, numberNight, numberGuests, arrivalDate)

        DisplayOutput(fullName, selectedHotel, numberGuests, numberNight, arrivalDate)
        regNumber += 1

    End Sub
    'PROGRAMING CHECKING IF THE INPUT INFORMATON IS CORRECT OR NOT , BY DATAOK COMMAND
    Function DataOk() As Boolean
        If txtDate.Text = "" Or txtDate.Text = "" Or txtGuests.Text = "" Or txtName.Text = "" Or txtNight.Text = "" _
            Or comSelectHotel.SelectedIndex = -1 Or (radOneKing.Checked = False And _
            radSuite.Checked = False And radTowQueen.Checked = False) Or Not IsNumeric(txtGuests.Text) Or _
            Not IsNumeric(txtNight.Text) Then
            Return False
        End If
        Return True
    End Function
    'SUB COMMAND TO RECIVE INPUT FROM TEXT BOX 
    Sub GetInput(ByRef fullName As String, ByRef selectedHotel As String, ByRef numberNight As Integer, ByRef numberGuests As Integer, ByRef arrivalDate As String)
        fullName = txtName.Text.ToUpper
        selectedHotel = comSelectHotel.SelectedItem
        numberNight = CInt(txtNight.Text)
        numberGuests = CInt(txtGuests.Text)
        arrivalDate = txtDate.Text
    End Sub
    'JOINING NAME AND REGISTRATION CODDING
    Function ReservationNumber(fullName As String, regNumber As Integer) As String
        Return fullName.Substring(fullName.IndexOf(" ") + 1, 1) & fullName.Substring(0, 1) & "-" & regNumber
    End Function
    'DISPLAY IN LIST BOX 
    Sub DisplayOutput(fullName As String, selectedHotel As String, numberGuests As Integer, numberNight As String, arrivalDate As String)
        lstHotel.Items.Add("Hotel Reservation for " & fullName & ": " & ReservationNumber(fullName, regNumber))
        lstHotel.Items.Add(selectedHotel)
        lstHotel.Items.Add("Arrival Date - " & arrivalDate)
        lstHotel.Items.Add("Number of Guests: " & numberGuests)
        lstHotel.Items.Add("Number of Nights: " & numberNight)
        lstHotel.Items.Add("")
        ProcessReservarion(numberGuests)
    End Sub
    'WORKING 
    Sub ProcessReservarion(numberGuests As Integer)
        If comSelectHotel.SelectedItem = "Disnay (not Disney)" Then

            If radTowQueen.Checked Then
                lstHotel.Items.Add("Room Rate: " & (99).ToString("c"))
                lstHotel.Items.Add("Room Cost: " & (99 * CInt(numberGuests)).ToString("c"))
                lstHotel.Items.Add("Tax: " & (99 * CInt(numberGuests) * 0.1).ToString("c"))
                lstHotel.Items.Add("Total Cost: " & ((99 * CInt(numberGuests)) + (99 * CInt(numberGuests) * 0.1)).ToString("c"))
            ElseIf radOneKing.Checked Then
                lstHotel.Items.Add("Room Rate: " & (89).ToString("c"))
                lstHotel.Items.Add("Room Cost: " & (89 * CInt(numberGuests)).ToString("c"))
                lstHotel.Items.Add("Tax: " & (89 * CInt(numberGuests) * 0.1).ToString("c"))
                lstHotel.Items.Add("Total Cost: " & ((89 * CInt(numberGuests)) + (89 * CInt(numberGuests) * 0.1)).ToString("c"))
            ElseIf radSuite.Checked Then
                lstHotel.Items.Add("Room Rate: " & (109).ToString("c"))
                lstHotel.Items.Add("Room Cost: " & (109 * CInt(numberGuests)).ToString("c"))
                lstHotel.Items.Add("Tax: " & (109 * CInt(numberGuests) * 0.1).ToString("c"))
                lstHotel.Items.Add("Total Cost: " & ((109 * CInt(numberGuests)) + (109 * CInt(numberGuests) * 0.1)).ToString("c"))
            End If

        End If

        If comSelectHotel.SelectedItem = "Mom and Pop's Hotel" Then

            If radTowQueen.Checked Then
                lstHotel.Items.Add("Room Rate: " & (49).ToString("c"))
                lstHotel.Items.Add("Room Cost: " & (49 * CInt(numberGuests)).ToString("c"))
                lstHotel.Items.Add("Tax: " & (49 * CInt(numberGuests) * 0.1).ToString("c"))
                lstHotel.Items.Add("Total Cost: " & ((49 * CInt(numberGuests)) + (49 * CInt(numberGuests) * 0.1)).ToString("c"))
            ElseIf radOneKing.Checked Then
                lstHotel.Items.Add("Room Rate: " & (48).ToString("c"))
                lstHotel.Items.Add("Room Cost: " & (48 * CInt(numberGuests)).ToString("c"))
                lstHotel.Items.Add("Tax: " & (48 * CInt(numberGuests) * 0.1).ToString("c"))
                lstHotel.Items.Add("Total Cost: " & ((48 * CInt(numberGuests)) + (48 * CInt(numberGuests) * 0.1)).ToString("c"))
            ElseIf radSuite.Checked Then
                lstHotel.Items.Add("Room Rate: " & (65).ToString("c"))
                lstHotel.Items.Add("Room Cost: " & (65 * CInt(numberGuests)).ToString("c"))
                lstHotel.Items.Add("Tax: " & (65 * CInt(numberGuests) * 0.1).ToString("c"))
                lstHotel.Items.Add("Total Cost: " & ((65 * CInt(numberGuests)) + (65 * CInt(numberGuests) * 0.1)).ToString("c"))
            End If

        End If

        If comSelectHotel.SelectedItem = "Hotel from 'You Know Where'" Then

            If radTowQueen.Checked Then
                lstHotel.Items.Add("Room Rate: " & (19).ToString("c"))
                lstHotel.Items.Add("Room Cost: " & (19 * CInt(numberGuests)).ToString("c"))
                lstHotel.Items.Add("Tax: " & (19 * CInt(numberGuests) * 0.1).ToString("c"))
                lstHotel.Items.Add("Total Cost: " & ((19 * CInt(numberGuests)) + (19 * CInt(numberGuests) * 0.1)).ToString("c"))
            ElseIf radOneKing.Checked Then
                lstHotel.Items.Add("Room Rate: " & (16.99).ToString("c"))
                lstHotel.Items.Add("Room Cost: " & (16.99 * CInt(numberGuests)).ToString("c"))
                lstHotel.Items.Add("Tax: " & (16.99 * CInt(numberGuests) * 0.1).ToString("c"))
                lstHotel.Items.Add("Total Cost: " & ((16.99 * CInt(numberGuests)) + (16.99 * CInt(numberGuests) * 0.1)).ToString("c"))
            ElseIf radSuite.Checked Then
                lstHotel.Items.Add("Room Rate: " & (24.99).ToString("c"))
                lstHotel.Items.Add("Room Cost: " & (24.99 * CInt(numberGuests)).ToString("c"))
                lstHotel.Items.Add("Tax: " & (24.99 * CInt(numberGuests) * 0.1).ToString("c"))
                lstHotel.Items.Add("Total Cost: " & ((24.99 * CInt(numberGuests)) + (24.99 * CInt(numberGuests) * 0.1)).ToString("c"))
            End If

        End If
    End Sub
End Class
