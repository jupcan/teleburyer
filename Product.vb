Imports Microsoft.VisualBasic

Public Class Product
    Property id As Integer
    Property price As Double
    Property description As String
    Property amount As Integer
    Property dao As ProductDAO

    Public Sub New(ByVal id As Integer, ByVal descripcion As String, ByVal price As Double, ByVal amou As Integer)
        Me._id = id
        Me._price = price
        Me._description = descripcion
        Me._amount = amount
        Me._dao = New ProductDAO()
    End Sub

    Public Sub New(ByVal id As Integer, ByVal descripcion As String, ByVal price As Double)
        Me._id = id
        Me._price = price
        Me._description = descripcion
        Me._dao = New ProductDAO()
    End Sub

    Public Sub New(ByVal id As Integer)
        Me._id = id
        Me._dao = New ProductDAO()
    End Sub

    Public Sub New()
        Me._dao = New ProductDAO()
    End Sub

    Public Function Add() As Integer
        Return Me._dao.AddProduct(Me)
    End Function

    Public Function Update() As Integer
        Return Me._dao.UpdateProduct(Me)
    End Function

    Public Function Delete() As Integer
        Return Me._dao.DeleteProduct(Me)
    End Function

    Public Sub Read()
        Me._dao.ReadProduct(Me)
    End Sub

    Public Sub ReadAll()
        Me._dao.ReadAllProducts(Me)
    End Sub
End Class