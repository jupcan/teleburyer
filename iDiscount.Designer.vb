<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class iDiscount
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
        Me.InitialPriceBox = New System.Windows.Forms.GroupBox()
        Me.InitialPriceAmount = New System.Windows.Forms.Label()
        Me.InitialPointsAmount = New System.Windows.Forms.Label()
        Me.InitialPriceLabel = New System.Windows.Forms.Label()
        Me.InitialPointsLabel = New System.Windows.Forms.Label()
        Me.FinalPriceBox = New System.Windows.Forms.GroupBox()
        Me.RemainingPointsAmount = New System.Windows.Forms.Label()
        Me.FinalPriceAmount = New System.Windows.Forms.Label()
        Me.FinalPriceLabel = New System.Windows.Forms.Label()
        Me.RemainingPointsLabel = New System.Windows.Forms.Label()
        Me.SelectedPointsAmount = New System.Windows.Forms.NumericUpDown()
        Me.SelectedPoints = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.ProceedButton = New System.Windows.Forms.Button()
        Me.InitialPriceBox.SuspendLayout()
        Me.FinalPriceBox.SuspendLayout()
        CType(Me.SelectedPointsAmount, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'InitialPriceBox
        '
        Me.InitialPriceBox.Controls.Add(Me.InitialPriceAmount)
        Me.InitialPriceBox.Controls.Add(Me.InitialPointsAmount)
        Me.InitialPriceBox.Controls.Add(Me.InitialPriceLabel)
        Me.InitialPriceBox.Controls.Add(Me.InitialPointsLabel)
        Me.InitialPriceBox.Location = New System.Drawing.Point(13, 14)
        Me.InitialPriceBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.InitialPriceBox.Name = "InitialPriceBox"
        Me.InitialPriceBox.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.InitialPriceBox.Size = New System.Drawing.Size(296, 111)
        Me.InitialPriceBox.TabIndex = 0
        Me.InitialPriceBox.TabStop = False
        Me.InitialPriceBox.Text = "Initial Price"
        '
        'InitialPriceAmount
        '
        Me.InitialPriceAmount.AutoSize = True
        Me.InitialPriceAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InitialPriceAmount.Location = New System.Drawing.Point(109, 65)
        Me.InitialPriceAmount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.InitialPriceAmount.Name = "InitialPriceAmount"
        Me.InitialPriceAmount.Size = New System.Drawing.Size(50, 25)
        Me.InitialPriceAmount.TabIndex = 3
        Me.InitialPriceAmount.Text = "0.00"
        '
        'InitialPointsAmount
        '
        Me.InitialPointsAmount.AutoSize = True
        Me.InitialPointsAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.InitialPointsAmount.Location = New System.Drawing.Point(109, 24)
        Me.InitialPointsAmount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.InitialPointsAmount.Name = "InitialPointsAmount"
        Me.InitialPointsAmount.Size = New System.Drawing.Size(23, 25)
        Me.InitialPointsAmount.TabIndex = 2
        Me.InitialPointsAmount.Text = "0"
        '
        'InitialPriceLabel
        '
        Me.InitialPriceLabel.AutoSize = True
        Me.InitialPriceLabel.Location = New System.Drawing.Point(8, 70)
        Me.InitialPriceLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.InitialPriceLabel.Name = "InitialPriceLabel"
        Me.InitialPriceLabel.Size = New System.Drawing.Size(85, 20)
        Me.InitialPriceLabel.TabIndex = 1
        Me.InitialPriceLabel.Text = "Initial Price"
        '
        'InitialPointsLabel
        '
        Me.InitialPointsLabel.AutoSize = True
        Me.InitialPointsLabel.Location = New System.Drawing.Point(8, 34)
        Me.InitialPointsLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.InitialPointsLabel.Name = "InitialPointsLabel"
        Me.InitialPointsLabel.Size = New System.Drawing.Size(94, 20)
        Me.InitialPointsLabel.TabIndex = 0
        Me.InitialPointsLabel.Text = "Initial Points"
        '
        'FinalPriceBox
        '
        Me.FinalPriceBox.Controls.Add(Me.RemainingPointsAmount)
        Me.FinalPriceBox.Controls.Add(Me.FinalPriceAmount)
        Me.FinalPriceBox.Controls.Add(Me.FinalPriceLabel)
        Me.FinalPriceBox.Controls.Add(Me.RemainingPointsLabel)
        Me.FinalPriceBox.Location = New System.Drawing.Point(456, 14)
        Me.FinalPriceBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.FinalPriceBox.Name = "FinalPriceBox"
        Me.FinalPriceBox.Padding = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.FinalPriceBox.Size = New System.Drawing.Size(300, 111)
        Me.FinalPriceBox.TabIndex = 1
        Me.FinalPriceBox.TabStop = False
        Me.FinalPriceBox.Text = "Final Price"
        '
        'RemainingPointsAmount
        '
        Me.RemainingPointsAmount.AutoSize = True
        Me.RemainingPointsAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RemainingPointsAmount.Location = New System.Drawing.Point(154, 24)
        Me.RemainingPointsAmount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.RemainingPointsAmount.Name = "RemainingPointsAmount"
        Me.RemainingPointsAmount.Size = New System.Drawing.Size(23, 25)
        Me.RemainingPointsAmount.TabIndex = 5
        Me.RemainingPointsAmount.Text = "0"
        '
        'FinalPriceAmount
        '
        Me.FinalPriceAmount.AutoSize = True
        Me.FinalPriceAmount.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FinalPriceAmount.Location = New System.Drawing.Point(154, 65)
        Me.FinalPriceAmount.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FinalPriceAmount.Name = "FinalPriceAmount"
        Me.FinalPriceAmount.Size = New System.Drawing.Size(50, 25)
        Me.FinalPriceAmount.TabIndex = 4
        Me.FinalPriceAmount.Text = "0.00"
        '
        'FinalPriceLabel
        '
        Me.FinalPriceLabel.AutoSize = True
        Me.FinalPriceLabel.Location = New System.Drawing.Point(13, 70)
        Me.FinalPriceLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.FinalPriceLabel.Name = "FinalPriceLabel"
        Me.FinalPriceLabel.Size = New System.Drawing.Size(82, 20)
        Me.FinalPriceLabel.TabIndex = 2
        Me.FinalPriceLabel.Text = "Final Price"
        '
        'RemainingPointsLabel
        '
        Me.RemainingPointsLabel.AutoSize = True
        Me.RemainingPointsLabel.Location = New System.Drawing.Point(13, 34)
        Me.RemainingPointsLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.RemainingPointsLabel.Name = "RemainingPointsLabel"
        Me.RemainingPointsLabel.Size = New System.Drawing.Size(133, 20)
        Me.RemainingPointsLabel.TabIndex = 1
        Me.RemainingPointsLabel.Text = "Remaining Points"
        '
        'SelectedPointsAmount
        '
        Me.SelectedPointsAmount.Location = New System.Drawing.Point(331, 60)
        Me.SelectedPointsAmount.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SelectedPointsAmount.Maximum = New Decimal(New Integer() {25, 0, 0, 0})
        Me.SelectedPointsAmount.Name = "SelectedPointsAmount"
        Me.SelectedPointsAmount.Size = New System.Drawing.Size(107, 26)
        Me.SelectedPointsAmount.TabIndex = 2
        '
        'SelectedPoints
        '
        Me.SelectedPoints.AutoSize = True
        Me.SelectedPoints.Location = New System.Drawing.Point(327, 35)
        Me.SelectedPoints.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.SelectedPoints.Name = "SelectedPoints"
        Me.SelectedPoints.Size = New System.Drawing.Size(112, 20)
        Me.SelectedPoints.TabIndex = 3
        Me.SelectedPoints.Text = "Choose Points"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(328, 96)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 20)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Max: 25 points"
        '
        'ProceedButton
        '
        Me.ProceedButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProceedButton.Location = New System.Drawing.Point(13, 146)
        Me.ProceedButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ProceedButton.Name = "ProceedButton"
        Me.ProceedButton.Size = New System.Drawing.Size(743, 43)
        Me.ProceedButton.TabIndex = 5
        Me.ProceedButton.Text = "Proceed "
        Me.ProceedButton.UseVisualStyleBackColor = True
        '
        'iDiscount
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(772, 203)
        Me.Controls.Add(Me.ProceedButton)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.SelectedPoints)
        Me.Controls.Add(Me.SelectedPointsAmount)
        Me.Controls.Add(Me.FinalPriceBox)
        Me.Controls.Add(Me.InitialPriceBox)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "iDiscount"
        Me.Text = "Discount Management"
        Me.InitialPriceBox.ResumeLayout(False)
        Me.InitialPriceBox.PerformLayout()
        Me.FinalPriceBox.ResumeLayout(False)
        Me.FinalPriceBox.PerformLayout()
        CType(Me.SelectedPointsAmount, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents InitialPriceBox As System.Windows.Forms.GroupBox
    Friend WithEvents FinalPriceBox As System.Windows.Forms.GroupBox
    Friend WithEvents SelectedPointsAmount As System.Windows.Forms.NumericUpDown
    Friend WithEvents SelectedPoints As System.Windows.Forms.Label
    Friend WithEvents InitialPointsLabel As System.Windows.Forms.Label
    Friend WithEvents InitialPriceLabel As System.Windows.Forms.Label
    Friend WithEvents FinalPriceLabel As System.Windows.Forms.Label
    Friend WithEvents RemainingPointsLabel As System.Windows.Forms.Label
    Friend WithEvents InitialPriceAmount As System.Windows.Forms.Label
    Friend WithEvents InitialPointsAmount As System.Windows.Forms.Label
    Friend WithEvents RemainingPointsAmount As System.Windows.Forms.Label
    Friend WithEvents FinalPriceAmount As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents ProceedButton As System.Windows.Forms.Button
End Class
