Imports Microsoft.VisualBasic

Public Class Order
    Property id As Integer
    Property dat As Date
    Property client As Client
    Property discount As Integer
    Property initial_price As Double
    Property final_price As Double
    Property products As Collection
    Property dao As OrderDAO

    Public Sub New(ByRef client As Client, ByRef initial_price As Double, ByRef final_price As Double, ByRef discount As Integer, products As Collection)
        Me.dat = Date.Today()
        Me.client = client
        Me.discount = discount
        Me.initial_price = initial_price
        Me.final_price = final_price
        Me.products = products
        Me.dao = New OrderDAO
    End Sub

    Public Sub Add()
        Me.dao.AddOrder(Me)
        Me.dao.getLastId(Me)
    End Sub

    Public Sub AddDetails()
        For Each p As Product In products
            Me.dao.AddOrderDetails(Me.id, p)
        Next
    End Sub
End Class