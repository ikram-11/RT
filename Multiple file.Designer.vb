<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Multiple_file
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.OrangeRed
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Button1.Location = New System.Drawing.Point(113, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(158, 54)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Choose multiple file"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Multiple_file
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Silver
        Me.ClientSize = New System.Drawing.Size(403, 223)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Multiple_file"
        Me.Text = "Choose multiple file"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
End Class
