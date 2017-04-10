Imports System.Net.NetworkInformation
Public Class frmEmployee

    Private Sub frmEmployee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MetroTextBox1.Text = getMacAddress()
        If MetroTextBox1.Text = getMacAddress() Then
            MetroTextBox2.Text = "match"
        End If
    End Sub
    Function getMacAddress()
        Dim nics() As NetworkInterface = _
              NetworkInterface.GetAllNetworkInterfaces
        Return nics(0).GetPhysicalAddress.ToString
    End Function

End Class