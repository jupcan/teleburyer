Public Class iDiscount

    Property _client As Client
    Property _order As Order
    Property _products As Collection = New Collection()
    Property _initial_price As Double

    Private Sub iLoad(sender As Object, e As EventArgs) Handles Me.Load
        If (_client.points < 25) Then
            SelectedPointsAmount.Maximum = _client.points
        Else
            SelectedPointsAmount.Maximum = 25
        End If

        InitialPriceAmount.Text = CStr(_initial_price)
        InitialPointsAmount.Text = CStr(_client.points)
        RemainingPointsAmount.Text = CStr(_client.points)
        FinalPriceAmount.Text = CStr(_initial_price)
    End Sub

    Private Sub SelectedPointsAmount_ValueChanged(sender As Object, e As EventArgs) Handles SelectedPointsAmount.ValueChanged
        RemainingPointsAmount.Text = CStr(CDbl(InitialPointsAmount.Text) - CDbl(SelectedPointsAmount.Value))
        FinalPriceAmount.Text = CStr(CDbl(InitialPriceAmount.Text) - (SelectedPointsAmount.Value * CDbl(InitialPriceAmount.Text)) / 100)
    End Sub

    Private Sub ProceedButton_Click(sender As Object, e As EventArgs) Handles ProceedButton.Click
        _client.points = CInt(RemainingPointsAmount.Text)
        Dim remaining_points As Integer
        Dim used_points As Integer = CInt(CDbl(InitialPointsAmount.Text) - CDbl(RemainingPointsAmount.Text))

        _order = New Order(_client, CDbl(InitialPriceAmount.Text), CDbl(FinalPriceAmount.Text), used_points, _products)
        _order.Add()
        _order.AddDetails()

        If SelectedPointsAmount.Value = 0 Then
            remaining_points = CInt(_client.points + Math.Ceiling(CDec(FinalPriceAmount.Text)))
        Else
            remaining_points = CInt(RemainingPointsAmount.Text)
        End If

        _client.points = remaining_points
        _client.Update()
        iTicket._order = _order
        iTicket.Show()
        Me.Close()
    End Sub
End Class