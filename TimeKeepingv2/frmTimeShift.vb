Public Class frmTimeShift
    Private Sub frmTimeShift_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        pnlTable.BringToFront()
        pnlInfo.SendToBack()
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        pnlInfo.Visible = True
        pnlInfo.BringToFront()
        pnlTable.Visible = False
        pnlTable.SendToBack()
    End Sub


End Class