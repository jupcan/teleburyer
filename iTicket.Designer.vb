<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class iTicket
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
        Me.TicketTextBox = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'TicketTextBox
        '
        Me.TicketTextBox.Location = New System.Drawing.Point(20, 20)
        Me.TicketTextBox.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.TicketTextBox.Name = "TicketTextBox"
        Me.TicketTextBox.ReadOnly = True
        Me.TicketTextBox.Size = New System.Drawing.Size(439, 537)
        Me.TicketTextBox.TabIndex = 0
        Me.TicketTextBox.Text = ""
        '
        'iTicket
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(477, 574)
        Me.Controls.Add(Me.TicketTextBox)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "iTicket"
        Me.Text = "Ticket Printout"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents TicketTextBox As System.Windows.Forms.RichTextBox
End Class
