<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mbdynRunnerForm
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
        Me.RunBtn = New System.Windows.Forms.Button()
        Me.InputOpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.InputTextBox = New System.Windows.Forms.TextBox()
        Me.BrowseBtn = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'RunBtn
        '
        Me.RunBtn.Location = New System.Drawing.Point(124, 61)
        Me.RunBtn.Name = "RunBtn"
        Me.RunBtn.Size = New System.Drawing.Size(75, 23)
        Me.RunBtn.TabIndex = 0
        Me.RunBtn.Text = "Run"
        Me.RunBtn.UseVisualStyleBackColor = True
        '
        'InputOpenFileDialog
        '
        Me.InputOpenFileDialog.FileName = "InputFile"
        '
        'InputTextBox
        '
        Me.InputTextBox.Location = New System.Drawing.Point(15, 28)
        Me.InputTextBox.Name = "InputTextBox"
        Me.InputTextBox.Size = New System.Drawing.Size(215, 20)
        Me.InputTextBox.TabIndex = 1
        '
        'BrowseBtn
        '
        Me.BrowseBtn.Location = New System.Drawing.Point(236, 27)
        Me.BrowseBtn.Name = "BrowseBtn"
        Me.BrowseBtn.Size = New System.Drawing.Size(75, 23)
        Me.BrowseBtn.TabIndex = 2
        Me.BrowseBtn.Text = "Browse"
        Me.BrowseBtn.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Select input file:"
        '
        'mbdynRunnerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(319, 90)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.BrowseBtn)
        Me.Controls.Add(Me.InputTextBox)
        Me.Controls.Add(Me.RunBtn)
        Me.Name = "mbdynRunnerForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "MbdynRunner"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RunBtn As Button
    Friend WithEvents InputOpenFileDialog As OpenFileDialog
    Friend WithEvents InputTextBox As TextBox
    Friend WithEvents BrowseBtn As Button
    Friend WithEvents Label1 As Label
End Class
