<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class RollOfTheDiceForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.DisplayListBox = New System.Windows.Forms.ListBox()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.RollButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.VScrollBar1 = New System.Windows.Forms.VScrollBar()
        Me.SuspendLayout()
        '
        'DisplayListBox
        '
        Me.DisplayListBox.Font = New System.Drawing.Font("Consolas", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.DisplayListBox.FormattingEnabled = True
        Me.DisplayListBox.ItemHeight = 18
        Me.DisplayListBox.Location = New System.Drawing.Point(12, 10)
        Me.DisplayListBox.Name = "DisplayListBox"
        Me.DisplayListBox.Size = New System.Drawing.Size(776, 310)
        Me.DisplayListBox.TabIndex = 0
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(536, 347)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(173, 91)
        Me.ExitButton.TabIndex = 2
        Me.ExitButton.Text = "Exit"
        Me.ToolTip1.SetToolTip(Me.ExitButton, "Exits the form")
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'RollButton
        '
        Me.RollButton.Location = New System.Drawing.Point(76, 347)
        Me.RollButton.Name = "RollButton"
        Me.RollButton.Size = New System.Drawing.Size(173, 91)
        Me.RollButton.TabIndex = 0
        Me.RollButton.Text = "Roll"
        Me.ToolTip1.SetToolTip(Me.RollButton, "Rolls a new set of dice")
        Me.RollButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(309, 347)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(173, 91)
        Me.ClearButton.TabIndex = 1
        Me.ClearButton.Text = "Clear"
        Me.ToolTip1.SetToolTip(Me.ClearButton, "Clears the current list box")
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'VScrollBar1
        '
        Me.VScrollBar1.Location = New System.Drawing.Point(762, 10)
        Me.VScrollBar1.Name = "VScrollBar1"
        Me.VScrollBar1.Size = New System.Drawing.Size(26, 313)
        Me.VScrollBar1.TabIndex = 3
        '
        'RollOfTheDiceForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.VScrollBar1)
        Me.Controls.Add(Me.ClearButton)
        Me.Controls.Add(Me.RollButton)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.DisplayListBox)
        Me.Name = "RollOfTheDiceForm"
        Me.Text = "Roll Of The Dice"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DisplayListBox As ListBox
    Friend WithEvents ExitButton As Button
    Friend WithEvents RollButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents VScrollBar1 As VScrollBar
End Class
