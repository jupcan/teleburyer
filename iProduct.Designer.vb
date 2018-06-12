<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class iProduct
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
        Me.pList = New System.Windows.Forms.GroupBox()
        Me.DescriptionTextBox = New System.Windows.Forms.TextBox()
        Me.DescriptionLabel = New System.Windows.Forms.Label()
        Me.LabelDBOperationsInfo = New System.Windows.Forms.Label()
        Me.ProductsList = New System.Windows.Forms.ListView()
        Me.ID = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Price = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Description = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.IDLabel = New System.Windows.Forms.Label()
        Me.PriceTextBox = New System.Windows.Forms.TextBox()
        Me.IDTextBox = New System.Windows.Forms.TextBox()
        Me.PriceLabel = New System.Windows.Forms.Label()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.pList.SuspendLayout()
        Me.SuspendLayout()
        '
        'pList
        '
        Me.pList.Controls.Add(Me.DescriptionTextBox)
        Me.pList.Controls.Add(Me.DescriptionLabel)
        Me.pList.Controls.Add(Me.LabelDBOperationsInfo)
        Me.pList.Controls.Add(Me.ProductsList)
        Me.pList.Controls.Add(Me.IDLabel)
        Me.pList.Controls.Add(Me.PriceTextBox)
        Me.pList.Controls.Add(Me.IDTextBox)
        Me.pList.Controls.Add(Me.PriceLabel)
        Me.pList.Controls.Add(Me.ResetButton)
        Me.pList.Controls.Add(Me.AddButton)
        Me.pList.Controls.Add(Me.DeleteButton)
        Me.pList.Controls.Add(Me.UpdateButton)
        Me.pList.Location = New System.Drawing.Point(13, 14)
        Me.pList.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pList.Name = "pList"
        Me.pList.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.pList.Size = New System.Drawing.Size(584, 426)
        Me.pList.TabIndex = 15
        Me.pList.TabStop = False
        Me.pList.Text = "Products List"
        '
        'DescriptionTextBox
        '
        Me.DescriptionTextBox.Location = New System.Drawing.Point(111, 318)
        Me.DescriptionTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DescriptionTextBox.MaxLength = 20
        Me.DescriptionTextBox.Name = "DescriptionTextBox"
        Me.DescriptionTextBox.Size = New System.Drawing.Size(453, 26)
        Me.DescriptionTextBox.TabIndex = 15
        '
        'DescriptionLabel
        '
        Me.DescriptionLabel.AutoSize = True
        Me.DescriptionLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DescriptionLabel.Location = New System.Drawing.Point(14, 324)
        Me.DescriptionLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.DescriptionLabel.Name = "DescriptionLabel"
        Me.DescriptionLabel.Size = New System.Drawing.Size(89, 20)
        Me.DescriptionLabel.TabIndex = 14
        Me.DescriptionLabel.Text = "Description"
        '
        'LabelDBOperationsInfo
        '
        Me.LabelDBOperationsInfo.AutoSize = True
        Me.LabelDBOperationsInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.LabelDBOperationsInfo.Location = New System.Drawing.Point(250, 372)
        Me.LabelDBOperationsInfo.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LabelDBOperationsInfo.Name = "LabelDBOperationsInfo"
        Me.LabelDBOperationsInfo.Size = New System.Drawing.Size(0, 20)
        Me.LabelDBOperationsInfo.TabIndex = 13
        '
        'ProductsList
        '
        Me.ProductsList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ProductsList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ID, Me.Price, Me.Description})
        Me.ProductsList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ProductsList.FullRowSelect = True
        Me.ProductsList.GridLines = True
        Me.ProductsList.Location = New System.Drawing.Point(18, 33)
        Me.ProductsList.Margin = New System.Windows.Forms.Padding(5)
        Me.ProductsList.Name = "ProductsList"
        Me.ProductsList.Size = New System.Drawing.Size(546, 197)
        Me.ProductsList.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.ProductsList.TabIndex = 1
        Me.ProductsList.UseCompatibleStateImageBehavior = False
        Me.ProductsList.View = System.Windows.Forms.View.Details
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
        Me.Description.Width = 245
        '
        'IDLabel
        '
        Me.IDLabel.AutoSize = True
        Me.IDLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.IDLabel.Location = New System.Drawing.Point(14, 252)
        Me.IDLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.IDLabel.Name = "IDLabel"
        Me.IDLabel.Size = New System.Drawing.Size(26, 20)
        Me.IDLabel.TabIndex = 9
        Me.IDLabel.Text = "ID"
        '
        'PriceTextBox
        '
        Me.PriceTextBox.Location = New System.Drawing.Point(111, 285)
        Me.PriceTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.PriceTextBox.MaxLength = 200
        Me.PriceTextBox.Name = "PriceTextBox"
        Me.PriceTextBox.Size = New System.Drawing.Size(453, 26)
        Me.PriceTextBox.TabIndex = 12
        '
        'IDTextBox
        '
        Me.IDTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.IDTextBox.Location = New System.Drawing.Point(111, 249)
        Me.IDTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.IDTextBox.MaxLength = 9
        Me.IDTextBox.Name = "IDTextBox"
        Me.IDTextBox.Size = New System.Drawing.Size(453, 26)
        Me.IDTextBox.TabIndex = 11
        '
        'PriceLabel
        '
        Me.PriceLabel.AutoSize = True
        Me.PriceLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.PriceLabel.Location = New System.Drawing.Point(14, 288)
        Me.PriceLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.PriceLabel.Name = "PriceLabel"
        Me.PriceLabel.Size = New System.Drawing.Size(44, 20)
        Me.PriceLabel.TabIndex = 10
        Me.PriceLabel.Text = "Price"
        '
        'ResetButton
        '
        Me.ResetButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.ResetButton.Location = New System.Drawing.Point(451, 372)
        Me.ResetButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(113, 29)
        Me.ResetButton.TabIndex = 5
        Me.ResetButton.Text = "Reset"
        Me.ResetButton.UseVisualStyleBackColor = True
        '
        'AddButton
        '
        Me.AddButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.AddButton.Location = New System.Drawing.Point(18, 372)
        Me.AddButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(113, 29)
        Me.AddButton.TabIndex = 2
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'DeleteButton
        '
        Me.DeleteButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.DeleteButton.Location = New System.Drawing.Point(306, 372)
        Me.DeleteButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(113, 29)
        Me.DeleteButton.TabIndex = 4
        Me.DeleteButton.Text = "Delete"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'UpdateButton
        '
        Me.UpdateButton.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.UpdateButton.Location = New System.Drawing.Point(159, 372)
        Me.UpdateButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(113, 29)
        Me.UpdateButton.TabIndex = 3
        Me.UpdateButton.Text = "Update"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'iProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(610, 454)
        Me.Controls.Add(Me.pList)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "iProduct"
        Me.Text = "Products Management"
        Me.pList.ResumeLayout(False)
        Me.pList.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents pList As System.Windows.Forms.GroupBox
    Friend WithEvents LabelDBOperationsInfo As System.Windows.Forms.Label
    Friend WithEvents IDLabel As System.Windows.Forms.Label
    Friend WithEvents PriceTextBox As System.Windows.Forms.TextBox
    Friend WithEvents IDTextBox As System.Windows.Forms.TextBox
    Friend WithEvents PriceLabel As System.Windows.Forms.Label
    Friend WithEvents ResetButton As System.Windows.Forms.Button
    Friend WithEvents AddButton As System.Windows.Forms.Button
    Friend WithEvents DeleteButton As System.Windows.Forms.Button
    Friend WithEvents UpdateButton As System.Windows.Forms.Button
    Friend WithEvents DescriptionTextBox As System.Windows.Forms.TextBox
    Friend WithEvents DescriptionLabel As System.Windows.Forms.Label
    Friend WithEvents ID As System.Windows.Forms.ColumnHeader
    Friend WithEvents Price As System.Windows.Forms.ColumnHeader
    Friend WithEvents Description As System.Windows.Forms.ColumnHeader
    Friend WithEvents ProductsList As System.Windows.Forms.ListView
End Class
