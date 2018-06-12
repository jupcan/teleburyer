Imports Microsoft.VisualBasic

Public Class ClientDAO
    Property _clients As Collection

    Public Sub New()
        Me._clients = New Collection
    End Sub

    Public Function AddClient(ByVal client As Client) As Integer
        Return Broker.getInstance().change("INSERT INTO Clientes VALUES ('" & client.telephone & "','" & client.address & "', '" & 0 & "');")
    End Function

    Public Function UpdateClient(ByVal client As Client) As Integer
        Return Broker.getInstance().change("UPDATE Clientes SET  SaldoDePuntos='" & client.points & "',  Dirección='" & client.address & "' WHERE Telefono='" & client.telephone & "';")
    End Function

    Public Function DeleteClient(ByVal client As Client) As Integer
        Return Broker.getInstance().change("DELETE FROM Clientes WHERE Telefono='" & client.telephone & "';")
    End Function

    Public Sub ReadClient(ByRef client As Client)
        Dim reader As OleDb.OleDbDataReader = Broker.getInstance.read("SELECT * FROM Clientes WHERE Telefono='" & client.telephone & "';")
        reader.Read()
        client.address = reader.GetString(1)
        client.points = reader.GetInt32(2)
    End Sub

    Public Sub ReadAllClients(ByRef client As Client)
        Dim readerAux As OleDb.OleDbDataReader = Broker.getInstance().read("SELECT * FROM Clientes ORDER BY Telefono;")
        While readerAux.Read()
            client.dao._clients.Add(New Client(readerAux.GetString(0), readerAux.GetString(1)))
        End While
    End Sub
End Class