Public Class form
    Private Sub btnResize_Click(sender As Object, e As EventArgs) Handles btnResize.Click
        'HookUtil.SetWindowPos("Worlds Adrift", 0, 0, 800, 800)

        Dim pid = getSelectedPID()

        If pid = -1 Then
            MessageBox.Show(Me, "Please select a process first.")
            Return
        ElseIf pid = -2 Then
            Return
        End If

        Debug.WriteLine("Selected process with PID: {0}", pid)

        Try
            HookUtil.SetWindowPos(
                pid,
                CType(valueX.Value, Integer),
                CType(valueY.Value, Integer),
                CType(valueWidth.Value, Integer),
                CType(valueHeight.Value, Integer),
                CheckBoxPosition.Checked,
                CheckBoxSize.Checked
            )
        Catch ex As Exception
            MessageBox.Show(Me, ex.Message, "Failed to resize window", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        refresh()
    End Sub

    Public Sub refresh() Handles btnRefresh.Click
        cbProcessList.Items.Clear()

        Dim Processes As Process() = Process.GetProcesses

        Dim biggestPID As Integer = 0
        For Each p As Process In Processes
            If p.Id > biggestPID Then
                biggestPID = p.Id
            End If
        Next

        Dim noTitleList As New List(Of String)

        For Each p As Process In Processes
            Dim spacing As String = ""
            Do While spacing.Length + p.Id.ToString().Length < biggestPID.ToString().Length
                spacing = spacing + "0"
            Loop

            Dim fileName As String = ""
            Try
                'fileName = " - " + p.MainModule.FileName
            Catch ex As Exception
            End Try


            If p.MainWindowTitle IsNot "" Then
                Dim name As String = spacing + p.Id.ToString() + " - " + p.MainWindowTitle + fileName
                cbProcessList.Items.Add(name)
            Else
                Dim name As String = spacing + p.Id.ToString() + " - <no title>" + fileName
                noTitleList.Add(name)
            End If
        Next
        noTitleList.Sort()
        For Each name As String In noTitleList
            cbProcessList.Items.Add(name)
        Next
    End Sub

    Public Function getSelectedPID() As Integer
        If cbProcessList.SelectedItem IsNot Nothing Then
            Dim text As String = cbProcessList.SelectedItem.ToString()
            'Debug.WriteLine(text)
            'Debug.WriteLine(text.Split(" - ").First)
            'Return Integer.Parse(text.Split(" - ").First)

            Try
                Return Integer.Parse(text.Split(" - ").First)
            Catch ex As Exception
                Return -1
            End Try

        End If

        Dim pid = cbProcessList.Text.Split(" ").First

        Try
            Return Integer.Parse(pid)
        Catch ex As Exception
            MessageBox.Show(Me, "Failed to parse input """ & cbProcessList.Text & """ as an integer", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return -2
        End Try
    End Function

    Private Sub CheckGroupBox_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBoxPosition.CheckedChanged, CheckBoxSize.CheckedChanged
        Dim checkbox As CheckBox = sender

        For Each control As Control In checkbox.Parent.Controls
            If control Is checkbox Then
                Continue For
            End If
            control.Enabled = checkbox.Checked
        Next
    End Sub
End Class
