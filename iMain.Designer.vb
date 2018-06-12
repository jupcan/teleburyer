<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class iMain
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
        Me.CallButton = New System.Windows.Forms.Button()
        Me.ProductsButton = New System.Windows.Forms.Button()
        Me.DatabaseButton = New System.Windows.Forms.Button()
        Me.AboutButton = New System.Windows.Forms.Button()
        Me.openFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.TeleBuryerPictureBox = New System.Windows.Forms.PictureBox()
        Me.OptionsGroupBox = New System.Windows.Forms.GroupBox()
        CType(Me.TeleBuryerPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.OptionsGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'CallButton
        '
        Me.CallButton.Enabled = False
        Me.CallButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CallButton.Location = New System.Drawing.Point(7, 121)
        Me.CallButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.CallButton.Name = "CallButton"
        Me.CallButton.Size = New System.Drawing.Size(583, 84)
        Me.CallButton.TabIndex = 0
        Me.CallButton.Text = "Make Call"
        Me.CallButton.UseVisualStyleBackColor = True
        '
        'ProductsButton
        '
        Me.ProductsButton.Enabled = False
        Me.ProductsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProductsButton.Location = New System.Drawing.Point(7, 215)
        Me.ProductsButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.ProductsButton.Name = "ProductsButton"
        Me.ProductsButton.Size = New System.Drawing.Size(583, 84)
        Me.ProductsButton.TabIndex = 1
        Me.ProductsButton.Text = "Product" & Global.Microsoft.VisualBasic.ChrW(13) & " Management"
        Me.ProductsButton.UseVisualStyleBackColor = True
        '
        'DatabaseButton
        '
        Me.DatabaseButton.BackColor = System.Drawing.Color.Red
        Me.DatabaseButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DatabaseButton.ForeColor = System.Drawing.Color.Black
        Me.DatabaseButton.Location = New System.Drawing.Point(7, 27)
        Me.DatabaseButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.DatabaseButton.Name = "DatabaseButton"
        Me.DatabaseButton.Size = New System.Drawing.Size(583, 84)
        Me.DatabaseButton.TabIndex = 2
        Me.DatabaseButton.Text = "Database"
        Me.DatabaseButton.UseVisualStyleBackColor = False
        '
        'AboutButton
        '
        Me.AboutButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AboutButton.Location = New System.Drawing.Point(7, 309)
        Me.AboutButton.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.AboutButton.Name = "AboutButton"
        Me.AboutButton.Size = New System.Drawing.Size(583, 84)
        Me.AboutButton.TabIndex = 3
        Me.AboutButton.Text = "About"
        Me.AboutButton.UseVisualStyleBackColor = True
        '
        'openFileDialog
        '
        Me.openFileDialog.FileName = "OpenFileDialog"
        '
        'TeleBuryerPictureBox
        '
        Me.TeleBuryerPictureBox.Image = Global.Teleburyer.My.Resources.Resources.teleburyer
        Me.TeleBuryerPictureBox.Location = New System.Drawing.Point(24, 32)
        Me.TeleBuryerPictureBox.Name = "TeleBuryerPictureBox"
        Me.TeleBuryerPictureBox.Size = New System.Drawing.Size(597, 140)
        Me.TeleBuryerPictureBox.TabIndex = 4
        Me.TeleBuryerPictureBox.TabStop = False
        '
        'OptionsGroupBox
        '
        Me.OptionsGroupBox.Controls.Add(Me.DatabaseButton)
        Me.OptionsGroupBox.Controls.Add(Me.ProductsButton)
        Me.OptionsGroupBox.Controls.Add(Me.AboutButton)
        Me.OptionsGroupBox.Controls.Add(Me.CallButton)
        Me.OptionsGroupBox.Location = New System.Drawing.Point(24, 200)
        Me.OptionsGroupBox.Name = "OptionsGroupBox"
        Me.OptionsGroupBox.Size = New System.Drawing.Size(597, 408)
        Me.OptionsGroupBox.TabIndex = 5
        Me.OptionsGroupBox.TabStop = False
        Me.OptionsGroupBox.Text = "Options"
        '
        'iMain
        '
        Me.AcceptButton = Me.DatabaseButton
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 635)
        Me.Controls.Add(Me.TeleBuryerPictureBox)
        Me.Controls.Add(Me.OptionsGroupBox)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "iMain"
        Me.Text = "Teleburyer"
        CType(Me.TeleBuryerPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.OptionsGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CallButton As System.Windows.Forms.Button
    Friend WithEvents ProductsButton As System.Windows.Forms.Button
    Friend WithEvents DatabaseButton As System.Windows.Forms.Button
    Friend WithEvents AboutButton As System.Windows.Forms.Button
    Friend WithEvents openFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents TeleBuryerPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents OptionsGroupBox As System.Windows.Forms.GroupBox

End Class
