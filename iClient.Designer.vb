<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class iClient
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
        Me.TelephoneLabel = New System.Windows.Forms.Label()
        Me.AddressLabel = New System.Windows.Forms.Label()
        Me.TelephoneTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.information_label = New System.Windows.Forms.Label()
        Me.OrderButton = New System.Windows.Forms.Button()
        Me.cList = New System.Windows.Forms.GroupBox()
        Me.ClientsList = New System.Windows.Forms.ListView()
        Me.Telephone = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.Address = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cList.SuspendLayout()
        Me.SuspendLayout()
        '
        'TelephoneLabel
        '
        Me.TelephoneLabel.AutoSize = True
        Me.TelephoneLabel.Location = New System.Drawing.Point(17, 252)
        Me.TelephoneLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.TelephoneLabel.Name = "TelephoneLabel"
        Me.TelephoneLabel.Size = New System.Drawing.Size(84, 20)
        Me.TelephoneLabel.TabIndex = 0
        Me.TelephoneLabel.Text = "Telephone"
        '
        'AddressLabel
        '
        Me.AddressLabel.AutoSize = True
        Me.AddressLabel.Location = New System.Drawing.Point(17, 288)
        Me.AddressLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.AddressLabel.Name = "AddressLabel"
        Me.AddressLabel.Size = New System.Drawing.Size(68, 20)
        Me.AddressLabel.TabIndex = 1
        Me.AddressLabel.Text = "Address"
        '
        'TelephoneTextBox
        '
        Me.TelephoneTextBox.Location = New System.Drawing.Point(109, 249)
        Me.TelephoneTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TelephoneTextBox.Name = "TelephoneTextBox"
        Me.TelephoneTextBox.Size = New System.Drawing.Size(455, 26)
        Me.TelephoneTextBox.TabIndex = 2
        '
        'AddressTextBox
        '
        Me.AddressTextBox.Location = New System.Drawing.Point(109, 285)
        Me.AddressTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.Size = New System.Drawing.Size(455, 26)
        Me.AddressTextBox.TabIndex = 3
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(21, 333)
        Me.AddButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(145, 38)
        Me.AddButton.TabIndex = 5
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'UpdateButton
        '
        Me.UpdateButton.Location = New System.Drawing.Point(174, 333)
        Me.UpdateButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(158, 38)
        Me.UpdateButton.TabIndex = 6
        Me.UpdateButton.Text = "Update"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'information_label
        '
        Me.information_label.AutoSize = True
        Me.information_label.Location = New System.Drawing.Point(430, 155)
        Me.information_label.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.information_label.Name = "information_label"
        Me.information_label.Size = New System.Drawing.Size(0, 20)
        Me.information_label.TabIndex = 7
        '
        'OrderButton
        '
        Me.OrderButton.Location = New System.Drawing.Point(340, 333)
        Me.OrderButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.OrderButton.Name = "OrderButton"
        Me.OrderButton.Size = New System.Drawing.Size(224, 38)
        Me.OrderButton.TabIndex = 8
        Me.OrderButton.Text = "Make Order"
        Me.OrderButton.UseVisualStyleBackColor = True
        '
        'cList
        '
        Me.cList.Controls.Add(Me.ClientsList)
        Me.cList.Controls.Add(Me.information_label)
        Me.cList.Controls.Add(Me.OrderButton)
        Me.cList.Controls.Add(Me.AddressTextBox)
        Me.cList.Controls.Add(Me.UpdateButton)
        Me.cList.Controls.Add(Me.TelephoneLabel)
        Me.cList.Controls.Add(Me.AddressLabel)
        Me.cList.Controls.Add(Me.TelephoneTextBox)
        Me.cList.Controls.Add(Me.AddButton)
        Me.cList.Location = New System.Drawing.Point(13, 14)
        Me.cList.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cList.Name = "cList"
        Me.cList.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.cList.Size = New System.Drawing.Size(588, 392)
        Me.cList.TabIndex = 10
        Me.cList.TabStop = False
        Me.cList.Text = "Clients List"
        '
        'ClientsList
        '
        Me.ClientsList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.ClientsList.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.Telephone, Me.Address})
        Me.ClientsList.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ClientsList.FullRowSelect = True
        Me.ClientsList.GridLines = True
        Me.ClientsList.Location = New System.Drawing.Point(21, 31)
        Me.ClientsList.Margin = New System.Windows.Forms.Padding(5)
        Me.ClientsList.Name = "ClientsList"
        Me.ClientsList.Size = New System.Drawing.Size(543, 196)
        Me.ClientsList.Sorting = System.Windows.Forms.SortOrder.Ascending
        Me.ClientsList.TabIndex = 10
        Me.ClientsList.UseCompatibleStateImageBehavior = False
        Me.ClientsList.View = System.Windows.Forms.View.Details
        '
        'Telephone
        '
        Me.Telephone.Text = "Telephone"
        Me.Telephone.Width = 91
        '
        'Address
        '
        Me.Address.Text = "Address"
        Me.Address.Width = 108
        '
        'iClient
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(614, 420)
        Me.Controls.Add(Me.cList)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "iClient"
        Me.Text = "Clients Management"
        Me.cList.ResumeLayout(False)
        Me.cList.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TelephoneLabel As System.Windows.Forms.Label
    Friend WithEvents AddressLabel As System.Windows.Forms.Label
    Friend WithEvents TelephoneTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddressTextBox As System.Windows.Forms.TextBox
    Friend WithEvents AddButton As System.Windows.Forms.Button
    Friend WithEvents UpdateButton As System.Windows.Forms.Button
    Friend WithEvents information_label As System.Windows.Forms.Label
    Friend WithEvents OrderButton As System.Windows.Forms.Button
    Friend WithEvents cList As System.Windows.Forms.GroupBox
    Friend WithEvents ClientsList As System.Windows.Forms.ListView
    Friend WithEvents Telephone As System.Windows.Forms.ColumnHeader
    Friend WithEvents Address As System.Windows.Forms.ColumnHeader
End Class
