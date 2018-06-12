Imports Microsoft.VisualBasic

Public Class Broker
    Public Shared FILE_PATH As String
    Private Shared _connection_driver As String = "Provider=Microsoft.ACE.OLEDB.12.0; Data Source="
    Private Shared _connection As OleDb.OleDbConnection
    Private Shared _instance As Broker

    Private Sub New()
        Broker._connection = New OleDb.OleDbConnection(_connection_driver & FILE_PATH)
        Broker._connection.Open()
    End Sub

    Public Shared Function getInstance() As Broker
        If _instance Is Nothing Then
            _instance = New Broker()
        End If
        Return _instance
    End Function

    Public Function read(ByVal sql As String) As OleDb.OleDbDataReader
        Dim command As New OleDb.OleDbCommand(sql, _connection)
        Return command.ExecuteReader
    End Function

    Public Function change(ByVal sql As String) As Integer
        Dim command As New OleDb.OleDbCommand(sql, _connection)
        Return command.ExecuteNonQuery
    End Function
End Class