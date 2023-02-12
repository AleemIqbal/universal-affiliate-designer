<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class List_View
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
        Me.Button17 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.LinkBox1 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TitleBox1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SchemaBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button17
        '
        Me.Button17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button17.Location = New System.Drawing.Point(66, 198)
        Me.Button17.Name = "Button17"
        Me.Button17.Size = New System.Drawing.Size(100, 34)
        Me.Button17.TabIndex = 66
        Me.Button17.Text = "Generate"
        Me.Button17.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!)
        Me.Label4.Location = New System.Drawing.Point(12, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(260, 25)
        Me.Label4.TabIndex = 65
        Me.Label4.Text = "List View Schema Generator"
        '
        'LinkBox1
        '
        Me.LinkBox1.Location = New System.Drawing.Point(11, 154)
        Me.LinkBox1.Multiline = True
        Me.LinkBox1.Name = "LinkBox1"
        Me.LinkBox1.Size = New System.Drawing.Size(255, 20)
        Me.LinkBox1.TabIndex = 61
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 13)
        Me.Label2.TabIndex = 62
        Me.Label2.Text = "Post Link:"
        '
        'TitleBox1
        '
        Me.TitleBox1.Location = New System.Drawing.Point(8, 94)
        Me.TitleBox1.Multiline = True
        Me.TitleBox1.Name = "TitleBox1"
        Me.TitleBox1.Size = New System.Drawing.Size(258, 20)
        Me.TitleBox1.TabIndex = 59
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 60
        Me.Label1.Text = "Post Title:"
        '
        'SchemaBox1
        '
        Me.SchemaBox1.Location = New System.Drawing.Point(303, 29)
        Me.SchemaBox1.Multiline = True
        Me.SchemaBox1.Name = "SchemaBox1"
        Me.SchemaBox1.Size = New System.Drawing.Size(606, 339)
        Me.SchemaBox1.TabIndex = 67
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button1.Location = New System.Drawing.Point(553, 387)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 34)
        Me.Button1.TabIndex = 68
        Me.Button1.Text = "Copy Schema"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Button2.Location = New System.Drawing.Point(396, 387)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 34)
        Me.Button2.TabIndex = 69
        Me.Button2.Text = "Reset"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'List_View
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ClientSize = New System.Drawing.Size(921, 462)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.SchemaBox1)
        Me.Controls.Add(Me.Button17)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.LinkBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TitleBox1)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Name = "List_View"
        Me.Text = "List_View"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button17 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents LinkBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TitleBox1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents SchemaBox1 As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
