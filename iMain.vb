Public Class iMain
    Dim _path As String
    Dim _connected As Boolean = False

    Private Sub DatabaseButton_Click(sender As Object, e As EventArgs) Handles DatabaseButton.Click
        openFileDialog.Filter = "Access 2007 (*.accdb)|*.accdb"
        openFileDialog.CheckFileExists = True

        If openFileDialog.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            _connected = True
            Broker.FILE_PATH = openFileDialog.FileName
            DatabaseButton.Text = "Database - Conected"
            DatabaseButton.BackColor = Color.Green
            CallButton.Enabled = True
            ProductsButton.Enabled = True
        Else
            MessageBox.Show("Error conecting to the database. Please, try again.", "Connection Error")
        End If
    End Sub

    Private Sub CallButton_Click(sender As Object, e As EventArgs) Handles CallButton.Click
        If _connected Then
            iClient.Show()
        End If
    End Sub

    Private Sub ProductsButton_Click(sender As Object, e As EventArgs) Handles ProductsButton.Click
        If _connected Then
            iProduct.Show()
        End If
    End Sub

    Private Sub AboutButton_Click(sender As Object, e As EventArgs) Handles AboutButton.Click
        MessageBox.Show("Teleburyer App - Databases Lab Practice 3 - Computer Science Second Course" & vbCrLf & "Name: Juan Perea Campos - Email: Juan.Perea@alu.uclm.es " & vbCrLf & "Name: José Ramóm Moratalla Muñoz - Email: JoseRamon.Moratalla@alu.uclm.es", "Developers" & vbCrLf & "Developed in VB.NET using VisualStudio13")
    End Sub
End Class