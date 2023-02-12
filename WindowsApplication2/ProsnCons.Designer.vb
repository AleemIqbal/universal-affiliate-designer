<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ProsnCons
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
        Me.BigBox = New System.Windows.Forms.TextBox()
        Me.ProsBox = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ConsBox = New System.Windows.Forms.TextBox()
        Me.Button17 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'BigBox
        '
        Me.BigBox.Location = New System.Drawing.Point(481, 12)
        Me.BigBox.Multiline = True
        Me.BigBox.Name = "BigBox"
        Me.BigBox.Size = New System.Drawing.Size(781, 575)
        Me.BigBox.TabIndex = 68
        '
        'ProsBox
        '
        Me.ProsBox.Location = New System.Drawing.Point(12, 46)
        Me.ProsBox.Multiline = True
        Me.ProsBox.Name = "ProsBox"
        Me.ProsBox.Size = New System.Drawing.Size(372, 247)
        Me.ProsBox.TabIndex = 69
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(12, 30)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(31, 13)
        Me.Label19.TabIndex = 70
        Me.Label19.Text = "Pros:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 305)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(34, 13)
        Me.Label1.TabIndex = 72
        Me.Label1.Text = "Cons:"
        '
        'ConsBox
        '
        Me.ConsBox.Location = New System.Drawing.Point(12, 321)
        Me.ConsBox.Multiline = True
        Me.ConsBox.Name = "ConsBox"
        Me.ConsBox.Size = New System.Drawing.Size(372, 247)
        Me.ConsBox.TabIndex = 71
        '
        'Button17
        '
        Me.Button17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button17.Location = New System.Drawing.Point(15, 588)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(100, 34)
        Me.Button17.TabIndex = 73
        Me.Button17.Text = "Generate"
        Me.Button17.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(166, 588)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 34)
        Me.Button1.TabIndex = 74
        Me.Button1.Text = "Customize ProsnCons"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.Location = New System.Drawing.Point(786, 596)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(137, 39)
        Me.Button2.TabIndex = 149
        Me.Button2.Text = "Reset"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button3.Location = New System.Drawing.Point(617, 596)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(136, 39)
        Me.Button3.TabIndex = 150
        Me.Button3.Text = "Copy"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ProsnCons
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(1274, 637)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button17)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ConsBox)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.ProsBox)
        Me.Controls.Add(Me.BigBox)
        Me.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Name = "ProsnCons"
        Me.Text = "ProsnCons"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BigBox As TextBox
    Friend WithEvents ProsBox As TextBox
    Friend WithEvents Label19 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ConsBox As TextBox
    Friend WithEvents Button17 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
