Imports MetroFramework.Forms
Public Class frmLogin
    Dim psswrdShow As Boolean
    Private Sub frmLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblCredits.Text = Chr(169) + " Mannasoft Technology Corporation alright reserved 2017"
        txtPassword.UseSystemPasswordChar = True
    End Sub

    Private Sub btnClose_MouseHover(sender As Object, e As EventArgs) Handles btnClose.MouseHover
        btnClose.FlatAppearance.BorderColor = Color.FromArgb(239, 72, 54)
        btnClose.BackColor = Color.FromArgb(239, 72, 54)
    End Sub

    Private Sub btnClose_MouseLeave(sender As Object, e As EventArgs) Handles btnClose.MouseLeave
        btnClose.FlatAppearance.BorderColor = Color.FromArgb(38, 166, 91)
        btnClose.BackColor = Color.FromArgb(38, 166, 91)
    End Sub

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        'modDBconnection.login(txtUsername.Text, txtPassword.Text)
        If txtUsername.Text = "dev" And txtPassword.Text = "dev" Then
            frmMain.lblUsername.Text = "Username: " + txtUsername.Text.Trim
            frmMain.lblPCname.Text = "Machinename: " + Environment.MachineName.ToString.Trim

            frmMain.Show()
            Me.Hide()
        End If
       
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        frmMain.Close()
        Me.Close()
    End Sub
End Class
