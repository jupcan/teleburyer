Public Class iOrder

    Private _product As Product
    Property _myclient As Client

    Private Sub iLoad(sender As Object, e As EventArgs) Handles Me.Load
        iMain.ProductsButton.Enabled = False
        LoadDatabase()
        ClientInfo.Text = "Client: " & _myclient.telephone & " Address: " & _myclient.address
    End Sub

    Private Sub iClose(sender As Object, e As EventArgs) Handles Me.FormClosing
        iMain.ProductsButton.Enabled = True
    End Sub

    Private Sub LoadDatabase()
        AvailableProductsList.Items.Clear()
        _product = New Product()

        Try
            _product.ReadAll()
        Catch excp As Exception
            MessageBox.Show(excp.Message, excp.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        Dim item As ListViewItem
        For Each AuxProduct As Product In _product.dao._products
            item = New ListViewItem(System.Convert.ToString(AuxProduct.id))
            item.SubItems.Add(System.Convert.ToString(AuxProduct.price))
            item.SubItems.Add(AuxProduct.description)
            AvailableProductsList.Items.Add(item)
        Next
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        If ProductAmount.Value <= 0 Then
            MessageBox.Show("Can not add and amount of zero.", "Amount Error")
            Exit Sub
        ElseIf AvailableProductsList.SelectedItems.Count > 0 Then
            Dim selected As String = AvailableProductsList.SelectedItems(0).SubItems(0).Text

            For Each i As ListViewItem In SelectedProductsList.Items
                If i.SubItems(1).Text = selected Then
                    i.SubItems(0).Text = CStr(CDbl(i.SubItems(0).Text) + ProductAmount.Value)

                    Dim pric As Double = (ProductAmount.Value * CDbl(AvailableProductsList.SelectedItems(0).SubItems(1).Text))
                    i.SubItems(2).Text = CStr(CDbl(i.SubItems(2).Text) + pric)
                    PriceLabel.Text = CStr(CDbl(PriceLabel.Text) + pric)
                    Exit Sub
                End If
            Next

            Dim item As ListViewItem
            item = New ListViewItem(System.Convert.ToString(ProductAmount.Value))
            item.SubItems.Add(AvailableProductsList.SelectedItems(0).SubItems(0))
            Dim price As Double = CDbl(AvailableProductsList.SelectedItems(0).SubItems(1).Text) * ProductAmount.Value
            item.SubItems.Add(System.Convert.ToString(price))
            item.SubItems.Add(AvailableProductsList.SelectedItems(0).SubItems(2))
            SelectedProductsList.Items.Add(item)
            PriceLabel.Text = CStr(CDbl(PriceLabel.Text) + price)
            StatusLabel.Text = "Product Added"
            StatusLabel.ForeColor = Color.Green
        End If
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        If SelectedProductsList.SelectedItems.Count > 0 Then
            Dim product As ListViewItem = SelectedProductsList.SelectedItems(0)
            PriceLabel.Text = CStr(CDbl(PriceLabel.Text) - CInt(product.SubItems(2).Text))
            SelectedProductsList.Items.Remove(CType(product, ListViewItem))
        End If
    End Sub

    Private Sub FinishButton_Click(sender As Object, e As EventArgs) Handles FinishButton.Click
        If CDbl(PriceLabel.Text) > 0 Then
            Dim product As Product
            For Each i As ListViewItem In SelectedProductsList.Items
                product = New Product(CInt(i.SubItems(1).Text), i.SubItems(3).Text, (CDbl(i.SubItems(2).Text) / CDbl(i.SubItems(0).Text)), CInt(i.SubItems(0).Text))
                iDiscount._products.Add(product)
            Next
            iDiscount._client = _myclient
            iDiscount._initial_price = CDbl(PriceLabel.Text)
            iDiscount.Show()
            Me.Close()
        Else
            MessageBox.Show("Please select at least one product.", "No Products Detected")
        End If
    End Sub
End Class