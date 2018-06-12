Imports Microsoft.VisualBasic

Public Class Client
    Property telephone As String
    Property address As String
    Property points As Integer
    Property dao As ClientDAO

    Public Sub New(ByVal telephone As String, ByVal address As String)
        Me.telephone = telephone
        Me.address = address
        Me.points = 0
        dao = New ClientDAO()
    End Sub

    Public Sub New(ByVal telephone As String)
        Me.telephone = telephone
        dao = New ClientDAO()
    End Sub

    Public Sub New()
        dao = New ClientDAO()
    End Sub

    Public Function Add() As Integer
        Return Me.dao.AddClient(Me)
    End Function

    Public Function Update() As Integer
        Return Me.dao.UpdateClient(Me)
    End Function

    Public Function Delete() As Integer
        Return Me.dao.DeleteClient(Me)
    End Function

    Public Sub Read()
        Me.dao.ReadClient(Me)
    End Sub

    Public Sub ReadAll()
        Me.dao.ReadAllClients(Me)
    End Sub
End Class
