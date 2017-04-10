Imports System.Data.SqlClient
Imports System.Configuration
Module modDBconnection
    Public constr As ConnectionStringSettings = ConfigurationManager.ConnectionStrings("DBConnect")
    Public connectionstring As String = constr.ConnectionString
    Public sqlconn As New SqlClient.SqlConnection
    Public sqlcmd As New SqlCommand
    Public sqlreader As SqlDataReader
    Public qry As String

    Public Sub connectToDb()
        sqlconn.ConnectionString = connectionstring
        Try
            sqlconn.Open()
            MessageBox.Show("connected")
            sqlconn.Close()
        Catch ex As Exception
            MessageBox.Show("failed")
            sqlconn.Close()
        End Try
    End Sub
    Public Sub login(ByVal username As String, ByVal password As String)
        qry = "SELECT * FROM tSysMasterUserlist WHERE sysUserName = '" & username & "' AND sysUserPassword = '" & password & "'"
        sqlconn.ConnectionString = connectionstring
        sqlconn.Open()
        sqlcmd.CommandText = qry
        sqlcmd.Connection = sqlconn
        sqlcmd.CommandType = CommandType.Text
        sqlreader = sqlcmd.ExecuteReader()

        If sqlreader.Read = True Then
            MessageBox.Show("welcome")
        End If
        sqlconn.Close()

    End Sub
End Module
