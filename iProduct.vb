Public Class iProduct

    Private _product As Product

    Private Sub iLoad(sender As Object, e As EventArgs) Handles Me.Load
        iMain.CallButton.Enabled = False
        LoadDatabase()
    End Sub

    Private Sub iClose(sender As Object, e As EventArgs) Handles Me.FormClosing
        iMain.CallButton.Enabled = True
    End Sub

    Private Sub LoadDatabase()
        ProductsList.Items.Clear()
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
            ProductsList.Items.Add(item)
        Next
    End Sub

    Private Sub ProductsList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ProductsList.SelectedIndexChanged
        If ProductsList.SelectedItems.Count > 0 Then
            IDTextBox.Text = ProductsList.SelectedItems(0).SubItems(0).Text
            PriceTextBox.Text = ProductsList.SelectedItems(0).SubItems(1).Text
            DescriptionTextBox.Text = ProductsList.SelectedItems(0).SubItems(2).Text
        End If
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        If IDTextBox.Text <> String.Empty And PriceTextBox.Text <> String.Empty And DescriptionTextBox.Text <> String.Empty Then
            Try
                System.Convert.ToInt32(IDTextBox.Text)
                System.Convert.ToDouble(PriceTextBox.Text)
            Catch excp As Exception
                MessageBox.Show("Please insert them using a correct one.", "Values incorrect format error")
                Exit Sub
            End Try

            Try
                _product = New Product(System.Convert.ToInt32(IDTextBox.Text), DescriptionTextBox.Text, System.Convert.ToDecimal(PriceTextBox.Text))
                _product.Add()
                LoadDatabase()
            Catch excp As Exception
                MessageBox.Show(excp.Message, excp.Source)
            End Try
        Else
            MessageBox.Show("Please complete them all.", "Empty fields error")
        End If
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        If IDTextBox.Text <> String.Empty And PriceTextBox.Text <> String.Empty And DescriptionTextBox.Text <> String.Empty Then
            Try
                System.Convert.ToInt32(IDTextBox.Text)
                System.Convert.ToDouble(PriceTextBox.Text)
            Catch excp As Exception
                MessageBox.Show("Please insert them using a correct one.", "Values incorrect format error")
                Exit Sub
            End Try

            Try
                _product = New Product(System.Convert.ToInt32(IDTextBox.Text), DescriptionTextBox.Text, System.Convert.ToDouble(PriceTextBox.Text))
                _product.Update()
                LoadDatabase()
            Catch excp As Exception
                MessageBox.Show(excp.Message, excp.Source)
                Exit Sub
            End Try
        Else
            MessageBox.Show("Please complete them all.", "Empty fields error")
        End If
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        If IDTextBox.Text <> String.Empty And PriceTextBox.Text <> String.Empty And DescriptionTextBox.Text <> String.Empty Then
            Try
                System.Convert.ToInt32(IDTextBox.Text)
            Catch excp As Exception
                MessageBox.Show("Please insert them using a correct one.", "Values incorrect format error")
                Exit Sub
            End Try

            Try
                _product = New Product(System.Convert.ToInt32(IDTextBox.Text))
                _product.Delete()
                LoadDatabase()
            Catch excp As Exception
                MessageBox.Show(excp.Message, excp.Source)
                Exit Sub
            End Try
        Else
            MessageBox.Show("Please complete them all.", "Empty fields error")
        End If
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        IDTextBox.Text = String.Empty
        PriceTextBox.Text = String.Empty
        DescriptionTextBox.Text = String.Empty
    End Sub
End Class