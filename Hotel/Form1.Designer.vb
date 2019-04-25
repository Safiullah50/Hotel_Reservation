<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHotel
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblSelectHotel = New System.Windows.Forms.Label()
        Me.lblNumberOfNights = New System.Windows.Forms.Label()
        Me.NumberOfGuests = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.txtNight = New System.Windows.Forms.TextBox()
        Me.txtGuests = New System.Windows.Forms.TextBox()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.comSelectHotel = New System.Windows.Forms.ComboBox()
        Me.lstHotel = New System.Windows.Forms.ListBox()
        Me.btnReservation = New System.Windows.Forms.Button()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.grpRooms = New System.Windows.Forms.GroupBox()
        Me.radSuite = New System.Windows.Forms.RadioButton()
        Me.radOneKing = New System.Windows.Forms.RadioButton()
        Me.radTowQueen = New System.Windows.Forms.RadioButton()
        Me.grpRooms.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(16, 11)
        Me.lblName.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(121, 17)
        Me.lblName.TabIndex = 0
        Me.lblName.Text = "Name (Last, First)"
        '
        'lblSelectHotel
        '
        Me.lblSelectHotel.AutoSize = True
        Me.lblSelectHotel.Location = New System.Drawing.Point(16, 57)
        Me.lblSelectHotel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblSelectHotel.Name = "lblSelectHotel"
        Me.lblSelectHotel.Size = New System.Drawing.Size(82, 17)
        Me.lblSelectHotel.TabIndex = 1
        Me.lblSelectHotel.Text = "select Hotel"
        '
        'lblNumberOfNights
        '
        Me.lblNumberOfNights.AutoSize = True
        Me.lblNumberOfNights.Location = New System.Drawing.Point(16, 97)
        Me.lblNumberOfNights.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNumberOfNights.Name = "lblNumberOfNights"
        Me.lblNumberOfNights.Size = New System.Drawing.Size(118, 17)
        Me.lblNumberOfNights.TabIndex = 2
        Me.lblNumberOfNights.Text = "Number of Nights"
        '
        'NumberOfGuests
        '
        Me.NumberOfGuests.AutoSize = True
        Me.NumberOfGuests.Location = New System.Drawing.Point(16, 137)
        Me.NumberOfGuests.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.NumberOfGuests.Name = "NumberOfGuests"
        Me.NumberOfGuests.Size = New System.Drawing.Size(123, 17)
        Me.NumberOfGuests.TabIndex = 3
        Me.NumberOfGuests.Text = "Number of Guests"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 178)
        Me.Label5.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(82, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Arrival Date"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(143, 7)
        Me.txtName.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(317, 22)
        Me.txtName.TabIndex = 5
        '
        'txtNight
        '
        Me.txtNight.Location = New System.Drawing.Point(143, 94)
        Me.txtNight.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtNight.Name = "txtNight"
        Me.txtNight.Size = New System.Drawing.Size(65, 22)
        Me.txtNight.TabIndex = 6
        '
        'txtGuests
        '
        Me.txtGuests.Location = New System.Drawing.Point(143, 137)
        Me.txtGuests.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtGuests.Name = "txtGuests"
        Me.txtGuests.Size = New System.Drawing.Size(65, 22)
        Me.txtGuests.TabIndex = 7
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(143, 178)
        Me.txtDate.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(132, 22)
        Me.txtDate.TabIndex = 8
        '
        'comSelectHotel
        '
        Me.comSelectHotel.FormattingEnabled = True
        Me.comSelectHotel.Items.AddRange(New Object() {"Disnay (not Disney)", "Mom and Pop's Hotel", "Hotel from 'You Know Where'"})
        Me.comSelectHotel.Location = New System.Drawing.Point(143, 53)
        Me.comSelectHotel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.comSelectHotel.Name = "comSelectHotel"
        Me.comSelectHotel.Size = New System.Drawing.Size(160, 24)
        Me.comSelectHotel.TabIndex = 9
        '
        'lstHotel
        '
        Me.lstHotel.FormattingEnabled = True
        Me.lstHotel.ItemHeight = 16
        Me.lstHotel.Location = New System.Drawing.Point(20, 234)
        Me.lstHotel.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.lstHotel.Name = "lstHotel"
        Me.lstHotel.Size = New System.Drawing.Size(440, 196)
        Me.lstHotel.TabIndex = 10
        '
        'btnReservation
        '
        Me.btnReservation.Location = New System.Drawing.Point(20, 452)
        Me.btnReservation.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnReservation.Name = "btnReservation"
        Me.btnReservation.Size = New System.Drawing.Size(100, 43)
        Me.btnReservation.TabIndex = 11
        Me.btnReservation.Text = "Process the Reservation"
        Me.btnReservation.UseVisualStyleBackColor = True
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(176, 452)
        Me.btnClear.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(100, 43)
        Me.btnClear.TabIndex = 12
        Me.btnClear.Text = "Clear the Form"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(361, 452)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(100, 43)
        Me.btnClose.TabIndex = 13
        Me.btnClose.Text = "Close the Form"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'grpRooms
        '
        Me.grpRooms.Controls.Add(Me.radSuite)
        Me.grpRooms.Controls.Add(Me.radOneKing)
        Me.grpRooms.Controls.Add(Me.radTowQueen)
        Me.grpRooms.Location = New System.Drawing.Point(315, 80)
        Me.grpRooms.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpRooms.Name = "grpRooms"
        Me.grpRooms.Padding = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.grpRooms.Size = New System.Drawing.Size(155, 105)
        Me.grpRooms.TabIndex = 14
        Me.grpRooms.TabStop = False
        Me.grpRooms.Text = "Type of Rooms"
        '
        'radSuite
        '
        Me.radSuite.AutoSize = True
        Me.radSuite.Location = New System.Drawing.Point(9, 76)
        Me.radSuite.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radSuite.Name = "radSuite"
        Me.radSuite.Size = New System.Drawing.Size(61, 21)
        Me.radSuite.TabIndex = 2
        Me.radSuite.TabStop = True
        Me.radSuite.Text = "Suite"
        Me.radSuite.UseVisualStyleBackColor = True
        '
        'radOneKing
        '
        Me.radOneKing.AutoSize = True
        Me.radOneKing.Location = New System.Drawing.Point(9, 47)
        Me.radOneKing.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radOneKing.Name = "radOneKing"
        Me.radOneKing.Size = New System.Drawing.Size(117, 21)
        Me.radOneKing.TabIndex = 1
        Me.radOneKing.TabStop = True
        Me.radOneKing.Text = "One King Bed"
        Me.radOneKing.UseVisualStyleBackColor = True
        '
        'radTowQueen
        '
        Me.radTowQueen.AutoSize = True
        Me.radTowQueen.Location = New System.Drawing.Point(9, 17)
        Me.radTowQueen.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.radTowQueen.Name = "radTowQueen"
        Me.radTowQueen.Size = New System.Drawing.Size(138, 21)
        Me.radTowQueen.TabIndex = 0
        Me.radTowQueen.TabStop = True
        Me.radTowQueen.Text = "Two Queen Beds"
        Me.radTowQueen.UseVisualStyleBackColor = True
        '
        'frmHotel
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 510)
        Me.Controls.Add(Me.grpRooms)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.btnReservation)
        Me.Controls.Add(Me.lstHotel)
        Me.Controls.Add(Me.comSelectHotel)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.txtGuests)
        Me.Controls.Add(Me.txtNight)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.NumberOfGuests)
        Me.Controls.Add(Me.lblNumberOfNights)
        Me.Controls.Add(Me.lblSelectHotel)
        Me.Controls.Add(Me.lblName)
        Me.Margin = New System.Windows.Forms.Padding(4, 4, 4, 4)
        Me.Name = "frmHotel"
        Me.Text = "Hotel Reservations"
        Me.grpRooms.ResumeLayout(False)
        Me.grpRooms.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblSelectHotel As System.Windows.Forms.Label
    Friend WithEvents lblNumberOfNights As System.Windows.Forms.Label
    Friend WithEvents NumberOfGuests As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtName As System.Windows.Forms.TextBox
    Friend WithEvents txtNight As System.Windows.Forms.TextBox
    Friend WithEvents txtGuests As System.Windows.Forms.TextBox
    Friend WithEvents txtDate As System.Windows.Forms.TextBox
    Friend WithEvents comSelectHotel As System.Windows.Forms.ComboBox
    Friend WithEvents lstHotel As System.Windows.Forms.ListBox
    Friend WithEvents btnReservation As System.Windows.Forms.Button
    Friend WithEvents btnClear As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents grpRooms As System.Windows.Forms.GroupBox
    Friend WithEvents radSuite As System.Windows.Forms.RadioButton
    Friend WithEvents radOneKing As System.Windows.Forms.RadioButton
    Friend WithEvents radTowQueen As System.Windows.Forms.RadioButton

End Class
