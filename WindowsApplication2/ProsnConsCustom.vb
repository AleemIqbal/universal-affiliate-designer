Public Class ProsnConsCustom

    Private Sub ProsnConsCustom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = ProsnCons.ProsTitle
        TextBox2.Text = ProsnCons.ProxBoxColor
        TextBox3.Text = ProsnCons.ProsBoxRadius
        TextBox4.Text = ProsnCons.ProsIconColor

        TextBox5.Text = ProsnCons.ConsTitle
        TextBox6.Text = ProsnCons.ConsBoxColor
        TextBox7.Text = ProsnCons.ConsBoxRadius
        TextBox8.Text = ProsnCons.ConsIconColor
    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ProsnCons.ProsTitle = TextBox1.Text
        ProsnCons.ProxBoxColor = TextBox2.Text
        ProsnCons.ProsBoxRadius = TextBox3.Text
        ProsnCons.ProsIconColor = TextBox4.Text

        ProsnCons.ConsTitle = TextBox5.Text
        ProsnCons.ConsBoxColor = TextBox6.Text
        ProsnCons.ConsBoxRadius = TextBox7.Text
        ProsnCons.ConsIconColor = TextBox8.Text
        Me.Close()
    End Sub
End Class