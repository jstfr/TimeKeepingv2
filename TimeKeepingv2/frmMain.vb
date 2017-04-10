Public Class frmMain

    Private Sub fmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Me.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs) Handles PictureBox3.Click
        Me.Hide()
        frmLogin.Show()
    End Sub

    Private Sub tile_Click(sender As Object, e As EventArgs) Handles tileEmployee.Click, tileTimeShift.Click, tileExtract.Click, tileProcess.Click, tilePreProcess.Click, tileFiling.Click, tileApproval.Click
        Select Case True
            Case sender Is Me.tileEmployee
                frmEmployee.Show()
            Case sender Is Me.tileTimeShift
                frmTimeShift.Show()
            Case sender Is Me.tileExtract
                frmExtractLogs.Show()
            Case sender Is Me.tilePreProcess
                frmProcess.Show()
            Case sender Is Me.tileProcess
                frmProcess.Show()
            Case sender Is Me.tileFiling
                frmFiling.Show()
            Case sender Is Me.tileApproval
                frmApproval.Show()
        End Select
    End Sub


End Class