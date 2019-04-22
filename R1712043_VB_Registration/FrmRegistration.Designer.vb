<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmRegistration
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
        Me.lblRegNo = New System.Windows.Forms.Label()
        Me.txtRegNo = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblDOB = New System.Windows.Forms.Label()
        Me.lblLevel = New System.Windows.Forms.Label()
        Me.lblSpecialisation = New System.Windows.Forms.Label()
        Me.lblSport = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.dateDOB = New System.Windows.Forms.DateTimePicker()
        Me.cmbLevel = New System.Windows.Forms.ComboBox()
        Me.cmbSpecialisation = New System.Windows.Forms.ComboBox()
        Me.CheckedListSpot = New System.Windows.Forms.CheckedListBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblRegNo
        '
        Me.lblRegNo.AutoSize = True
        Me.lblRegNo.Location = New System.Drawing.Point(69, 76)
        Me.lblRegNo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblRegNo.Name = "lblRegNo"
        Me.lblRegNo.Size = New System.Drawing.Size(142, 17)
        Me.lblRegNo.TabIndex = 0
        Me.lblRegNo.Text = "Registration Number:"
        '
        'txtRegNo
        '
        Me.txtRegNo.Location = New System.Drawing.Point(228, 71)
        Me.txtRegNo.Name = "txtRegNo"
        Me.txtRegNo.Size = New System.Drawing.Size(194, 22)
        Me.txtRegNo.TabIndex = 1
        Me.txtRegNo.Text = "R"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(69, 111)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(49, 17)
        Me.lblName.TabIndex = 2
        Me.lblName.Text = "Name:"
        '
        'lblDOB
        '
        Me.lblDOB.AutoSize = True
        Me.lblDOB.Location = New System.Drawing.Point(69, 148)
        Me.lblDOB.Name = "lblDOB"
        Me.lblDOB.Size = New System.Drawing.Size(91, 17)
        Me.lblDOB.TabIndex = 3
        Me.lblDOB.Text = "Date of Birth:"
        '
        'lblLevel
        '
        Me.lblLevel.AutoSize = True
        Me.lblLevel.Location = New System.Drawing.Point(69, 184)
        Me.lblLevel.Name = "lblLevel"
        Me.lblLevel.Size = New System.Drawing.Size(46, 17)
        Me.lblLevel.TabIndex = 4
        Me.lblLevel.Text = "Level:"
        '
        'lblSpecialisation
        '
        Me.lblSpecialisation.AutoSize = True
        Me.lblSpecialisation.Location = New System.Drawing.Point(69, 215)
        Me.lblSpecialisation.Name = "lblSpecialisation"
        Me.lblSpecialisation.Size = New System.Drawing.Size(99, 17)
        Me.lblSpecialisation.TabIndex = 5
        Me.lblSpecialisation.Text = "Specialisation:"
        '
        'lblSport
        '
        Me.lblSport.AutoSize = True
        Me.lblSport.Location = New System.Drawing.Point(69, 245)
        Me.lblSport.Name = "lblSport"
        Me.lblSport.Size = New System.Drawing.Size(46, 17)
        Me.lblSport.TabIndex = 6
        Me.lblSport.Text = "Sport:"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(228, 106)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(282, 22)
        Me.TextBox1.TabIndex = 7
        '
        'dateDOB
        '
        Me.dateDOB.Checked = False
        Me.dateDOB.Location = New System.Drawing.Point(228, 143)
        Me.dateDOB.Name = "dateDOB"
        Me.dateDOB.Size = New System.Drawing.Size(282, 22)
        Me.dateDOB.TabIndex = 12
        '
        'cmbLevel
        '
        Me.cmbLevel.FormattingEnabled = True
        Me.cmbLevel.Items.AddRange(New Object() {"Certificate", "Diploma", "Degree"})
        Me.cmbLevel.Location = New System.Drawing.Point(228, 177)
        Me.cmbLevel.Name = "cmbLevel"
        Me.cmbLevel.Size = New System.Drawing.Size(194, 24)
        Me.cmbLevel.TabIndex = 13
        '
        'cmbSpecialisation
        '
        Me.cmbSpecialisation.FormattingEnabled = True
        Me.cmbSpecialisation.Items.AddRange(New Object() {"Hardware", "Networking", "Software"})
        Me.cmbSpecialisation.Location = New System.Drawing.Point(228, 208)
        Me.cmbSpecialisation.Name = "cmbSpecialisation"
        Me.cmbSpecialisation.Size = New System.Drawing.Size(194, 24)
        Me.cmbSpecialisation.TabIndex = 14
        '
        'CheckedListSpot
        '
        Me.CheckedListSpot.FormattingEnabled = True
        Me.CheckedListSpot.Items.AddRange(New Object() {"Football", "Tennis", "Rugby"})
        Me.CheckedListSpot.Location = New System.Drawing.Point(228, 245)
        Me.CheckedListSpot.Name = "CheckedListSpot"
        Me.CheckedListSpot.Size = New System.Drawing.Size(194, 89)
        Me.CheckedListSpot.TabIndex = 15
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(113, 375)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(109, 42)
        Me.btnSave.TabIndex = 16
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(344, 375)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(109, 42)
        Me.btnCancel.TabIndex = 17
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'FrmRegistration
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(596, 494)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.CheckedListSpot)
        Me.Controls.Add(Me.cmbSpecialisation)
        Me.Controls.Add(Me.cmbLevel)
        Me.Controls.Add(Me.dateDOB)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.lblSport)
        Me.Controls.Add(Me.lblSpecialisation)
        Me.Controls.Add(Me.lblLevel)
        Me.Controls.Add(Me.lblDOB)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtRegNo)
        Me.Controls.Add(Me.lblRegNo)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmRegistration"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registration form"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblRegNo As System.Windows.Forms.Label
    Friend WithEvents txtRegNo As System.Windows.Forms.TextBox
    Friend WithEvents lblName As System.Windows.Forms.Label
    Friend WithEvents lblDOB As System.Windows.Forms.Label
    Friend WithEvents lblLevel As System.Windows.Forms.Label
    Friend WithEvents lblSpecialisation As System.Windows.Forms.Label
    Friend WithEvents lblSport As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents dateDOB As System.Windows.Forms.DateTimePicker
    Friend WithEvents cmbLevel As System.Windows.Forms.ComboBox
    Friend WithEvents cmbSpecialisation As System.Windows.Forms.ComboBox
    Friend WithEvents CheckedListSpot As System.Windows.Forms.CheckedListBox
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button
End Class
