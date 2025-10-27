Option Strict On
Option Explicit On

Imports System.Configuration
Imports MySqlConnector

Module Db
    Public Function conexao() As MySqlConnection
        Dim cs As String = ConfigurationManager.ConnectionStrings("DbFanchive").ConnectionString
        Return New MySqlConnection(cs)
    End Function
End Module


