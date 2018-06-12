Imports Microsoft.VisualBasic

Public Class ProductDAO
    Property _products As Collection

    Public Sub New()
        Me._products = New Collection
    End Sub

    Public Function AddProduct(ByVal product As Product) As Integer
        Return Broker.getInstance().change("INSERT INTO Productos VALUES ('" & product.id & "','" & product.description & "', '" & product.price & "');")
    End Function

    Public Function UpdateProduct(ByVal product As Product) As Integer
        Return Broker.getInstance().change("UPDATE Productos SET PrecioProducto='" & System.Convert.ToString(product.price) & "', DescripciónProducto='" & product.description & "' WHERE IdProducto=" & product.id & ";")
    End Function

    Public Function DeleteProduct(ByVal product As Product) As Integer
        Return Broker.getInstance().change("DELETE FROM Productos WHERE IdProducto=" & product.id & ";")
    End Function

    Public Sub ReadProduct(ByRef product As Product)
        Dim scanner As OleDb.OleDbDataReader = Broker.getInstance.read("SELECT * FROM Productos WHERE IdProducto='" & product.id & "';")
        scanner.Read()
        product.id = CInt(scanner.GetString(0))
        product.price = CDbl(scanner.GetString(1))
        product.description = scanner.GetString(2)
    End Sub

    Public Sub ReadAllProducts(ByRef product As Product)
        Dim AuxScanner As OleDb.OleDbDataReader = Broker.getInstance().read("SELECT * FROM Productos ORDER BY IdProducto;")
        While AuxScanner.Read()
            product.dao._products.Add(New Product(CInt(AuxScanner.GetValue(0)), AuxScanner.GetString(1), CDbl(AuxScanner.GetValue(2))))
        End While
    End Sub
End Class