Public Class iTicket

    Property _order As Order

    Private Sub iLoad(sender As Object, e As EventArgs) Handles Me.Load

        TicketTextBox.Text += "TELEBURYER Order: " & _order.id & vbTab & "Date: " & _order.dat & vbCrLf
        TicketTextBox.Text += "------------------------------------------------------------------------------------------------" & vbCrLf
        TicketTextBox.Text += vbCrLf & "Client: " & _order.client.telephone & " Address: " & _order.client.address & vbCrLf
        TicketTextBox.Text += "Points: " & _order.client.points & " Used: " & _order.discount & vbCrLf
        TicketTextBox.Text += vbCrLf & "Amount" & vbTab & "Product" & vbTab & "Unit Price" & vbTab & "Total Price" & vbCrLf
        TicketTextBox.Text += "------------------------------------------------------------------------------------------------" & vbCrLf

        For Each product As Product In _order.products
            TicketTextBox.Text += vbCrLf & product.amount & vbTab & product.description & vbTab & product.price & vbTab & (product.amount * product.price)
        Next
        TicketTextBox.Text += vbCrLf & "------------------------------------------------------------------------------------------------" & vbCrLf

        Dim price_discount As Decimal
        If _order.discount > 0 Then
            price_discount = CDec(_order.initial_price * _order.discount / 100)
        Else
            price_discount = 0
        End If

        TicketTextBox.Text += vbCrLf & "Without discount: " & _order.initial_price & "€"
        TicketTextBox.Text += vbCrLf & "Discount: " & _order.discount & "% " & price_discount & "€"
        TicketTextBox.Text += vbCrLf & "Total: " & _order.final_price & " €" & vbCrLf
        TicketTextBox.Text += "------------------------------------------------------------------------------------------------" & vbCrLf
        TicketTextBox.Text += "               Thank you. Hope to see you again soon!"
        TicketTextBox.Text += vbTab & vbTab & vbTab & "TELEBURYER Inc."
        TicketTextBox.Text += vbCrLf & "------------------------------------------------------------------------------------------------" & vbCrLf
    End Sub
End Class