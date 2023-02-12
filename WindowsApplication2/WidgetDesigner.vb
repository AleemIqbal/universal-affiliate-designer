Public Class Widget_Designer
    Public BtnColor As String
    Private Sub Widget_Designer_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        BtnColor = "#00bf08"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ItemsBox.Text = ""
        BigBox.Text = ""
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Clipboard.SetText(BigBox.Text)
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Dim ProsTotalCode As String
        If (Not ItemsBox.Text = "") Then
            For i As Integer = 0 To ItemsBox.Lines.Length - 1
                ProsTotalCode += "<li><i class='fa fa-arrow-right' style='color: " + BtnColor + ";'></i><a href='#" + ItemsIdBox.Lines(i) + "' />" + ItemsBox.Lines(i) + "</a></li>" + Environment.NewLine
            Next
        End If
        BigBox.Text = "<div Class='su-list su-list-style-'>
<ul>
       " + ProsTotalCode + "
</ul>
<a href = '" + TextBox1.Text + "' target='_blank' rel='nofollow noopener'><img src='" + LinkBox3.Text + "' alt='Editors Choice' /></a>

</div>
"


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        WidgetCustom.Show()
    End Sub

    Private Sub IdLabel7_Click(sender As Object, e As EventArgs) Handles IdLabel7.Click, Label3.Click

    End Sub
End Class