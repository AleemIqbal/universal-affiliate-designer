Public Class WidgetCustom
    Private Sub WidgetCustom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = Widget_Designer.BtnColor
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        TableHelper.BtnColor = TextBox1.Text
        Me.Close()
    End Sub
End Class