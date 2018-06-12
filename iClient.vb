Public Class iClient
    Private _client As Client

    Private Sub iLoad(sender As Object, e As EventArgs) Handles Me.Load
        iMain.ProductsButton.Enabled = False
        LoadDatabase()
    End Sub

    Private Sub iClose(sender As Object, e As EventArgs) Handles Me.FormClosed
        iMain.ProductsButton.Enabled = True
    End Sub

    Private Sub LoadDatabase()
        ClientsList.Items.Clear()
        _client = New Client()

        Try
            _client.ReadAll()
        Catch excp As Exception
            MessageBox.Show(excp.Message, excp.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End Try

        Dim item As ListViewItem
        For Each AuxClient As Client In _client.dao._clients
            item = New ListViewItem(AuxClient.telephone)
            item.SubItems.Add(AuxClient.address)
            ClientsList.Items.Add(item)
        Next
    End Sub

    Private Sub ClientsList_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ClientsList.SelectedIndexChanged
        If ClientsList.SelectedItems.Count > 0 Then
            _client = New Client(ClientsList.SelectedItems(0).Text)

            Try
                _client.Read()
            Catch excp As Exception
                MessageBox.Show(excp.Message, excp.Source, MessageBoxButtons.OK, MessageBoxIcon.Error)
                Exit Sub
            End Try
            TelephoneTextBox.Text = _client.telephone
            AddressTextBox.Text = _client.address
        End If
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        If TelephoneTextBox.Text <> String.Empty And AddressTextBox.Text <> String.Empty Then
            _client = New Client(TelephoneTextBox.Text, AddressTextBox.Text)

            Try
                _client.Add()
            Catch excp As Exception
                MessageBox.Show("An error occurred while registrating the new client. Sorry.", "Registrating Error")
                Exit Sub
            End Try
            MessageBox.Show("New client registrated successfully.", "Registrating Completed")
        Else
            MessageBox.Show("Please complete them all.", "Empty fields error")
        End If
    End Sub

    Private Sub CheckClients(sender As Object, e As EventArgs) Handles AddButton.Click
        If TelephoneTextBox.Text <> String.Empty Then
            _client = New Client(TelephoneTextBox.Text)

            Try
                _client.Read()
            Catch
                MessageBox.Show("Please enter an address.", "Client Not Registered")
                Exit Sub
            End Try
            MessageBox.Show("Client already registered.", "Client Registered")
            AddressTextBox.Text = _client.address
        End If
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        If TelephoneTextBox.Text <> String.Empty And AddressTextBox.Text <> String.Empty Then
            _client = New Client(TelephoneTextBox.Text, AddressTextBox.Text)

            Try
                _client.Update()
            Catch excp As Exception
                MessageBox.Show("An error occurred while updating. Sorry.", "Updating Error")
                Exit Sub
            End Try

            MessageBox.Show("Client updated successfully.", "Updating Completed")
        Else
            MessageBox.Show("Please complete them all.", "Empty fields error")
        End If
    End Sub

    Private Sub OrderButton_Click(sender As Object, e As EventArgs) Handles OrderButton.Click
        If ClientsList.SelectedItems.Count > 0 Then
            iOrder._myclient = _client
            iOrder.Show()
            Me.Close()
        Else
            MessageBox.Show("Please select a client to make the order.", "Order Error")
        End If
    End Sub
End Class