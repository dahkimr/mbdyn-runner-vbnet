Public Class mbdynRunnerForm

    Private inputFile = ""
    Private ReadOnly errorCaption = "Error"
    Private ReadOnly inputFileMissingError = "Please select an input file."
    Private ReadOnly inputFileWrongExtError = "Input file should have extension .mbd"

    Private Sub RunBtn_Click(sender As Object, e As EventArgs) Handles RunBtn.Click

        If inputFile = "" Then
            Dim result = MessageBox.Show(inputFileMissingError, errorCaption,
                MessageBoxButtons.OK, MessageBoxIcon.Error)

        ElseIf inputFile.Length < 3 Or inputFile.SubString(inputFile.Length - 3) <> "mbd" Then
            Dim result = MessageBox.Show(inputFileWrongExtError, errorCaption,
                MessageBoxButtons.OK, MessageBoxIcon.Error)

        Else
            Try
                Dim mbdynCmd = "mbdyn.exe -f " + inputFile
                Dim proc As Process = Process.Start("cmd", "/k " + mbdynCmd)
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
