<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmMenu
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.StudentsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RegistrationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FeesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResultsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.InputResultsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewResultsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EquipmentToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LecturersToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StudentsToolStripMenuItem, Me.EquipmentToolStripMenuItem, Me.LecturersToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(8, 2, 0, 2)
        Me.MenuStrip1.Size = New System.Drawing.Size(611, 28)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'StudentsToolStripMenuItem
        '
        Me.StudentsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RegistrationToolStripMenuItem, Me.FeesToolStripMenuItem, Me.ResultsToolStripMenuItem})
        Me.StudentsToolStripMenuItem.Name = "StudentsToolStripMenuItem"
        Me.StudentsToolStripMenuItem.Size = New System.Drawing.Size(78, 24)
        Me.StudentsToolStripMenuItem.Text = "Students"
        '
        'RegistrationToolStripMenuItem
        '
        Me.RegistrationToolStripMenuItem.Name = "RegistrationToolStripMenuItem"
        Me.RegistrationToolStripMenuItem.Size = New System.Drawing.Size(158, 24)
        Me.RegistrationToolStripMenuItem.Text = "Registration"
        '
        'FeesToolStripMenuItem
        '
        Me.FeesToolStripMenuItem.Name = "FeesToolStripMenuItem"
        Me.FeesToolStripMenuItem.Size = New System.Drawing.Size(158, 24)
        Me.FeesToolStripMenuItem.Text = "Fees"
        '
        'ResultsToolStripMenuItem
        '
        Me.ResultsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.InputResultsToolStripMenuItem, Me.ViewResultsToolStripMenuItem})
        Me.ResultsToolStripMenuItem.Name = "ResultsToolStripMenuItem"
        Me.ResultsToolStripMenuItem.Size = New System.Drawing.Size(158, 24)
        Me.ResultsToolStripMenuItem.Text = "Results"
        '
        'InputResultsToolStripMenuItem
        '
        Me.InputResultsToolStripMenuItem.Name = "InputResultsToolStripMenuItem"
        Me.InputResultsToolStripMenuItem.Size = New System.Drawing.Size(162, 24)
        Me.InputResultsToolStripMenuItem.Text = "Input Results"
        '
        'ViewResultsToolStripMenuItem
        '
        Me.ViewResultsToolStripMenuItem.Name = "ViewResultsToolStripMenuItem"
        Me.ViewResultsToolStripMenuItem.Size = New System.Drawing.Size(162, 24)
        Me.ViewResultsToolStripMenuItem.Text = "View Results"
        '
        'EquipmentToolStripMenuItem
        '
        Me.EquipmentToolStripMenuItem.Name = "EquipmentToolStripMenuItem"
        Me.EquipmentToolStripMenuItem.Size = New System.Drawing.Size(93, 24)
        Me.EquipmentToolStripMenuItem.Text = "Equipment"
        '
        'LecturersToolStripMenuItem
        '
        Me.LecturersToolStripMenuItem.Name = "LecturersToolStripMenuItem"
        Me.LecturersToolStripMenuItem.Size = New System.Drawing.Size(80, 24)
        Me.LecturersToolStripMenuItem.Text = "Lecturers"
        '
        'FrmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(611, 543)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "FrmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Menu"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents MenuStrip1 As System.Windows.Forms.MenuStrip
    Friend WithEvents StudentsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents RegistrationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FeesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ResultsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents InputResultsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ViewResultsToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EquipmentToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents LecturersToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
End Class
