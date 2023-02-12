Public Class CustomizeButtonDesign
    Private Sub Label5_Click(sender As Object, e As EventArgs) 

    End Sub

    Private Sub CustomizeButtonDesign_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = TableHelper.BtnSize
        TextBox2.Text = TableHelper.BtnColor
        TextBox4.Text = TableHelper.BtnBackGround
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        TableHelper.BtnSize = TextBox1.Text
        TableHelper.BtnColor = TextBox2.Text
        TableHelper.BtnBackGround = TextBox4.Text
        Me.Close()
    End Sub
End Class