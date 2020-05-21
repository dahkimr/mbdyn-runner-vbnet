Public Class mbdynRunnerForm

    Private inputFile = ""
    Private errorCaption = "Error"
    Private inputFileMissingError = "Please select an input file."
    Private inputFileWrongExtError = "Input file should have extension .mbd"

    Private Sub RunBtn_Click(sender As Object, e As EventArgs) Handles RunBtn.Click
        Dim pHelp As New ProcessStartInfo
        pHelp.FileName = "mbdyn.exe"
        pHelp.Arguments = "-f " + inputFile
        pHelp.UseShellExecute = ProcessWindowStyle.Normal

        If inputFile = "" Then
            Dim result = MessageBox.Show(inputFileMissingError, errorCaption,
                MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else
            Try
                Dim proc As Process = Process.Start(pHelp)
                Close()
            Catch ex As Exception
                Dim errorMessage = ex.Message + " (make sure mbdyn.exe is in the folder)"

                Dim result = MessageBox.Show(errorMessage, errorCaption,
                    MessageBoxButtons.OK, MessageBoxIcon.Error)
                If result = DialogResult.OK Then
                    Close()
                End If
            End Try
        End If


    End Sub

    Private Sub BrowseBtn_Click(sender As Object, e As EventArgs) Handles BrowseBtn.Click

        InputOpenFileDialog.InitialDirectory = Application.StartupPath()
        If InputOpenFileDialog.ShowDialog = DialogResult.OK Then
            Dim inputFileName = InputOpenFileDialog.FileName
            InputTextBox.Text = inputFileName
            inputFile = inputFileName
        End If
    End Sub
End Class
