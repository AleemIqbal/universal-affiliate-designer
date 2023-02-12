Public Class ProsnCons
    Public ProsTitle, ProxBoxColor, ProsBoxRadius, ProsIconColor As String
    Public ConsTitle, ConsBoxColor, ConsBoxRadius, ConsIconColor As String

    Private Sub BigBox_TextChanged(sender As Object, e As EventArgs) Handles BigBox.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ProsnConsCustom.Show()
    End Sub

    Private Sub ProsnCons_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ProsTitle = "Pros"
        ProxBoxColor = "#009906"
        ProsBoxRadius = "0"
        ProsIconColor = "#009906"

        ConsTitle = "Cons"
        ConsBoxColor = "#bf000a"
        ConsBoxRadius = "0"
        ConsIconColor = "#bf000a"
    End Sub

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        Dim ProsTotalCode As String
        If (Not ProsBox.Text = "") Then
            For i As Integer = 0 To ProsBox.Lines.Length - 1
                ProsTotalCode += "<li>" + ProsBox.Lines(i) + "</li>" + Environment.NewLine
            Next
        End If
        Dim ConsTotalCode As String
        If (Not ConsBox.Text = "") Then
            For i As Integer = 0 To ConsBox.Lines.Length - 1
                ConsTotalCode += "<li>" + ConsBox.Lines(i) + "</li>" + Environment.NewLine
            Next
        End If
        BigBox.Text = "[su_row]
[su_column size=""1/2""][su_box title='" + ProsTitle + "' box_color='" + ProxBoxColor + "' radius='" + ProsBoxRadius + "'][su_list icon=""icon: check"" icon_color='" + ProsIconColor + "']
<ul>
" + ProsTotalCode + "
</ul>
[/su_list][/su_box][/su_column]

[su_column size=""1/2""][su_box title='" + ConsTitle + "' box_color='" + ConsBoxColor + "' radius='" + ConsBoxRadius + "'][su_list icon=""icon: ban"" icon_color='" + ConsIconColor + "']
<ul>
 	" + ConsTotalCode + "
</ul>
[/su_list][/su_box][/su_column]
[/su_row]
"

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Clipboard.SetText(BigBox.Text)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        ProsBox.Text = ""
        ConsBox.Text = ""
        BigBox.Text = ""
    End Sub
End Class