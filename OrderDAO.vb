Imports Microsoft.VisualBasic

Public Class OrderDAO
    Property _orders As Collection

    Public Sub New()
        Me._orders = New Collection
    End Sub

    Public Function AddOrder(ByRef order As Order) As Integer
        Return Broker.getInstance().change("INSERT INTO Pedidos(FechaPedido, Cliente, DescuentoAplicado, PrecioPedido) VALUES ('" & order.dat & "', " & order.client.telephone & ", " & order.discount & ", '" & CStr(order.final_price) & "');")
    End Function

    Public Function AddOrderDetails(ByVal order_number As Integer, ByRef product As Product) As Integer
        Return Broker.getInstance().change("INSERT INTO Detalles_de_pedidos VALUES ('" & order_number & "','" & product.id & "', '" & product.amount & "');")
    End Function

    Public Sub getLastId(ByRef order As Order)
        Dim scanner As OleDb.OleDbDataReader = Broker.getInstance.read("SELECT MAX(IdPedido) FROM Pedidos")
        scanner.Read()
        order.id = CInt(scanner.GetValue(0).ToString())
    End Sub
End Class