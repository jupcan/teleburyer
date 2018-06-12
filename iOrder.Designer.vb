<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class iOrder
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.AvailableLabel = New System.Windows.Forms.Label()
        Me.SelectedLabel = New System.Windows.Forms.Label()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.ProductsList = New System.Windows.Forms.GroupBox()
        Me.StatusLabel = New System.Windows.Forms.Label()
        Me.PriceLabel = New System.Windows.Forms.Label()
        Me.ProductAmount = New System.Windows.Forms.NumericUpDown()
        Me.ClientInfo = New System.Windows.Forms.Label()
        Me.SelectedProductsList = New System.Windows.Forms.ListView()
        Me.ColumnHeader4 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader1 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader2 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.ColumnHeader3 = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.AvailableProductsList = New System.Windows.Forms.ListView()
        Me.ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Price = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Description = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.FinishButton = New System.Windows.Forms.Button()
        Me.ProductsList.SuspendLayout()
        CType(Me.ProductAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AvailableLabel
        '
        Me.AvailableLabel.AutoSize = True
        Me.AvailableLabel.Location = New System.Drawing.Point(8, 24)
        Me.AvailableLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AvailableLabel.Name = "AvailableLabel"
        Me.AvailableLabel.Size = New System.Drawing.Size(72, 20)
        Me.AvailableLabel.TabIndex = 2
        Me.AvailableLabel.Text = "Available"
        '
        'SelectedLabel
        '
        Me.SelectedLabel.AutoSize = True
        Me.SelectedLabel.Location = New System.Drawing.Point(560, 24)
        Me.SelectedLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.SelectedLabel.Name = "SelectedLabel"
        Me.SelectedLabel.Size = New System.Drawing.Size(72, 20)
        Me.SelectedLabel.TabIndex = 3
        Me.SelectedLabel.Text = "Selected"
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(425, 126)
        Me.AddButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(110, 32)
        Me.AddButton.TabIndex = 4
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'DeleteButton
        '
        Me.DeleteButton.Location = New System.Drawing.Point(425, 204)
        Me.DeleteButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(110, 32)
        Me.DeleteButton.TabIndex = 6
        Me.DeleteButton.Text = "Delete"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'ProductsList
        '
        Me.ProductsList.Controls.Add(Me.AddButton)
        Me.ProductsList.Controls.Add(Me.StatusLabel)
        Me.ProductsList.Controls.Add(Me.PriceLabel)
        Me.ProductsList.Controls.Add(Me.ProductAmount)
        Me.ProductsList.Controls.Add(Me.ClientInfo)
        Me.ProductsList.Controls.Add(Me.SelectedProductsList)
        Me.ProductsList.Controls.Add(Me.AvailableProductsList)
        Me.ProductsList.Controls.Add(Me.FinishButton)
        Me.ProductsList.Controls.Add(Me.SelectedLabel)
        Me.ProductsList.Controls.Add(Me.DeleteButton)
        Me.ProductsList.Controls.Add(Me.AvailableLabel)
        Me.ProductsList.Location = New System.Drawing.Point(13, 14)
        Me.ProductsList.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ProductsList.Name = "ProductsList"
        Me.ProductsList.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ProductsList.Size = New System.Drawing.Size(959, 376)
        Me.ProductsList.TabIndex = 8
        Me.ProductsList.TabStop = False
        Me.ProductsList.Text = "Products List"
        '
        'StatusLabel
        '
        Me.StatusLabel.AutoSize = True
        Me.StatusLabel.ForeColor = System.Drawing.Color.Red
        Me.StatusLabel.Location = New System.Drawing.Point(421, 73)
        Me.StatusLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.StatusLabel.Name = "StatusLabel"
        Me.StatusLabel.Size = New System.Drawing.Size(0, 20)
        Me.StatusLabel.TabIndex = 13
        '
        'PriceLabel
        '
        Me.PriceLabel.AutoSize = True
        Me.PriceLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.PriceLabel.Location = New System.Drawing.Point(435, 263)
        Me.PriceLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PriceLabel.Name = "PriceLabel"
        Me.PriceLabel.Size = New System.Drawing.Size(58, 29)
        Me.PriceLabel.TabIndex = 12
        Me.PriceLabel.Text = "0.00"
        '
        'ProductAmount
        '
        Me.ProductAmount.Location = New System.Drawing.Point(425, 168)
        Me.ProductAmount.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ProductAmount.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.ProductAmount.Name = "ProductAmount"
        Me.ProductAmount.Size = New System.Drawing.Size(110, 26)
        Me.ProductAmount.TabIndex = 11
        Me.ProductAmount.Value = New Decimal(New Integer() {1, 0, 0, 0})
        '
        'ClientInfo
        '
        Me.ClientInfo.AutoSize = True
        Me.ClientInfo.Location = New System.Drawing.Point(8, 339)
        Me.ClientInfo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ClientInfo.Name = "ClientInfo"
        Me.ClientInfo.Size = New System.Drawing.Size(77, 20)
        Me.ClientInfo.TabIndex = 10
        Me.ClientInfo.Text = "ClientInfo"
        '
        'SelectedProductsList
        '
        Me.SelectedProductsList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.SelectedProductsList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader4, Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3})
        Me.SelectedProductsList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.SelectedProductsList.FullRowSelect = True
        Me.SelectedProductsList.GridLines = True
        Me.SelectedProductsList.Location = New System.Drawing.Point(564, 49)
        Me.SelectedProductsList.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SelectedProductsList.Name = "SelectedProductsList"
        Me.SelectedProductsList.Size = New System.Drawing.Size(383, 268)
        Me.SelectedProductsList.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.SelectedProductsList.TabIndex = 9
        Me.SelectedProductsList.UseCompatibleStateImageBehavior = False
        Me.SelectedProductsList.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Amount"
        Me.ColumnHeader4.Width = 79
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "ID"
        Me.ColumnHeader1.Width = 41
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Price"
        Me.ColumnHeader2.Width = 68
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Description"
        Me.ColumnHeader3.Width = 109
        '
        'AvailableProductsList
        '
        Me.AvailableProductsList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.AvailableProductsList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.Price, Me.Description})
        Me.AvailableProductsList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.AvailableProductsList.FullRowSelect = True
        Me.AvailableProductsList.GridLines = True
        Me.AvailableProductsList.Location = New System.Drawing.Point(12, 49)
        Me.AvailableProductsList.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AvailableProductsList.Name = "AvailableProductsList"
        Me.AvailableProductsList.Size = New System.Drawing.Size(383, 268)
        Me.AvailableProductsList.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.AvailableProductsList.TabIndex = 8
        Me.AvailableProductsList.UseCompatibleStateImageBehavior = False
        Me.AvailableProductsList.View = System.Windows.Forms.View.Details
        '
        'ID
        '
        Me.ID.Text = "ID"
        Me.ID.Width = 49
        '
        'Price
        '
        Me.Price.Text = "Price"
        Me.Price.Width = 71
        '
        'Description
        '
        Me.Description.Text = "Description"
        Me.Description.Width = 126
        '
        'FinishButton
        '
        Me.FinishButton.Location = New System.Drawing.Point(564, 327)
        Me.FinishButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.FinishButton.Name = "FinishButton"
        Me.FinishButton.Size = New System.Drawing.Size(383, 32)
        Me.FinishButton.TabIndex = 7
        Me.FinishButton.Text = "Finish Order"
        Me.FinishButton.UseVisualStyleBackColor = True
        '
        'iOrder
        '
        Me.AcceptButton = Me.AddButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(986, 404)
        Me.Controls.Add(Me.ProductsList)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "iOrder"
        Me.Text = "Order Management"
        Me.ProductsList.ResumeLayout(False)
        Me.ProductsList.PerformLayout()
        CType(Me.ProductAmount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents AvailableLabel As System.Windows.Forms.Label
    Friend WithEvents SelectedLabel As System.Windows.Forms.Label
    Friend WithEvents AddButton As System.Windows.Forms.Button
    Friend WithEvents DeleteButton As System.Windows.Forms.Button
    Friend WithEvents ProductsList As System.Windows.Forms.GroupBox
    Friend WithEvents FinishButton As System.Windows.Forms.Button
    Friend WithEvents SelectedProductsList As System.Windows.Forms.ListView
    Friend WithEvents ColumnHeader1 As System.Windows.Forms.ColumnHeader
    Friend WithEvents AvailableProductsList As System.Windows.Forms.ListView
    Friend WithEvents ID As System.Windows.Forms.ColumnHeader
    Friend WithEvents Price As System.Windows.Forms.ColumnHeader
    Friend WithEvents Description As System.Windows.Forms.ColumnHeader
    Friend WithEvents ColumnHeader4 As System.Windows.Forms.ColumnHeader
    Friend WithEvents ClientInfo As System.Windows.Forms.Label
    Friend WithEvents ProductAmount As System.Windows.Forms.NumericUpDown
    Friend WithEvents PriceLabel As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader2 As System.Windows.Forms.ColumnHeader
    Friend WithEvents StatusLabel As System.Windows.Forms.Label
    Friend WithEvents ColumnHeader3 As System.Windows.Forms.ColumnHeader
End Class
