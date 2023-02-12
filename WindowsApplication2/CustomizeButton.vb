Public Class CustomizeButton

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Form2.BtnSize = TextBox1.Text
        Form2.BtnColor = TextBox2.Text
        Form2.BtnRadius = TextBox3.Text
        Form2.BtnBackGround = TextBox4.Text
        Me.Close()
    End Sub

    Private Sub CustomizeButton_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = Form2.BtnSize
        TextBox2.Text = Form2.BtnColor
        TextBox3.Text = Form2.BtnRadius
        TextBox4.Text = Form2.BtnBackGround
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class