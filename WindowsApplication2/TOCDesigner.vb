Public Class TOCDesigner



    Private Sub btn_add_Click_1(sender As Object, e As EventArgs) Handles btn_add.Click
        Dim namebox As TextBox = New TextBox()
        name_box_list.Controls.Add(namebox)
        Dim linkbox As TextBox = New TextBox()
        link_box_list.Controls.Add(linkbox)
    End Sub

    Private Sub btn_add_child_Click_1(sender As Object, e As EventArgs) Handles btn_add_child.Click
        Dim child_namebox As TextBox = New TextBox()
        child_namebox.Margin = New Padding(10, 3, 3, 3)
        name_box_list.Controls.Add(child_namebox)
        Dim child_linkbox As TextBox = New TextBox()
        child_linkbox.Margin = New Padding(10, 3, 3, 3)
        link_box_list.Controls.Add(child_linkbox)
    End Sub

    Private Sub btn_remove_Click_1(sender As Object, e As EventArgs) Handles btn_remove.Click
        If name_box_list.Controls.Count <> 0 AndAlso link_box_list.Controls.Count <> 0 Then
            name_box_list.Controls.Remove(name_box_list.Controls(name_box_list.Controls.Count - 1))
            link_box_list.Controls.Remove(link_box_list.Controls(link_box_list.Controls.Count - 1))
        End If
    End Sub

    Private Sub btn_make_table_Click_1(sender As Object, e As EventArgs) Handles btn_make_table.Click
        Dim name_box_string As String = ""
        Dim link As String = ""

        For i As Integer = 0 To name_box_list.Controls.Count - 1
            Dim level As String = "1"

            If name_box_list.Controls(i).Margin.Left = 10 Then
                level = "2"
            End If


            Try
                If cus_btn_no.Checked = True Then
                    link = "#" + name_box_list.Controls(i).Text.Replace(" ", "-")
                Else
                    link = link_box_list.Controls(i).Text

                End If
            Catch ex As Exception

            End Try


            name_box_string += "<li class='toclevel-" & level & " tocsection-" & (i + 1).ToString() & "'><a href='" & link & "' title='" + name_box_list.Controls(i).Text & "'>" + name_box_list.Controls(i).Text & "</a></li>"
        Next

        Clipboard.SetText("<div id='toc-w-r-f' class='toc-w-r-f-r toc' role='navigation' aria-labelledby='mw-toc-heading'><div class='toctitle' lang='en' dir='ltr'><p id='mw-toc-heading'>" & box_1_heading.Text & "</p></div><nav><ul>" + name_box_string & "<li class='toclevel-1 tocsection-" + (name_box_list.Controls.Count + 1).ToString() & " r-s-top-p'><p>" + box_2_heading.Text & "</p><a href='" + box_2_link.Text & "' rel='nofollow noopener noreferrer' target='_blank'><img alt='" + box_2_name.Text & "' width='150' height='360' class=' ls-is-cached lazyloaded' src='" + box_2_img_link.Text & "'><p>" + box_2_name.Text & "</p></a></li></ul></nav></div>")

    End Sub

    Private Sub TOCDesigner_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub

    Private Sub GroupBox2_Enter(sender As Object, e As EventArgs) Handles GroupBox2.Enter

    End Sub

    Private Sub btn_add_name_Click(sender As Object, e As EventArgs) Handles btn_add_name.Click
        Dim namebox As TextBox = New TextBox()
        name_box_list.Controls.Add(namebox)
    End Sub

    Private Sub btn_add_child_name_Click(sender As Object, e As EventArgs) Handles btn_add_child_name.Click
        Dim child_namebox As TextBox = New TextBox()
        child_namebox.Margin = New Padding(10, 3, 3, 3)
        name_box_list.Controls.Add(child_namebox)
    End Sub

    Private Sub btn_add_link_Click(sender As Object, e As EventArgs) Handles btn_add_link.Click
        Dim linkbox As TextBox = New TextBox()
        link_box_list.Controls.Add(linkbox)
    End Sub

    Private Sub btn_add_child_link_Click(sender As Object, e As EventArgs) Handles btn_add_child_link.Click
        Dim child_linkbox As TextBox = New TextBox()
        child_linkbox.Margin = New Padding(10, 3, 3, 3)
        link_box_list.Controls.Add(child_linkbox)
    End Sub

    Private Sub btn_import_Click(sender As Object, e As EventArgs) Handles btn_import_name.Click
        If (Me.OpenFileDialog1.ShowDialog() = DialogResult.OK) Then
            Dim streamReader As System.IO.StreamReader = New System.IO.StreamReader(Me.OpenFileDialog1.FileName)
            While streamReader.Peek() <> -1
                Dim strArrays As String() = Strings.Split(streamReader.ReadLine(), "**--medinjojestvarnokralj:)--*", -1, CompareMethod.Binary)
                Dim num As Integer = strArrays.Count()
                Dim num1 As Integer = 0
                While num1 < num
                    Dim str As String = strArrays(0)
                    Dim namebox As TextBox = New TextBox()
                    namebox.Text = str
                    name_box_list.Controls.Add(namebox)
                    num1 = num1 + 1
                End While
            End While
        End If
    End Sub

    Private Sub btn_import_child_name_Click(sender As Object, e As EventArgs) Handles btn_import_child_name.Click
        If (Me.OpenFileDialog1.ShowDialog() = DialogResult.OK) Then
            Dim streamReader As System.IO.StreamReader = New System.IO.StreamReader(Me.OpenFileDialog1.FileName)
            While streamReader.Peek() <> -1
                Dim strArrays As String() = Strings.Split(streamReader.ReadLine(), "**--medinjojestvarnokralj:)--*", -1, CompareMethod.Binary)
                Dim num As Integer = strArrays.Count()
                Dim num1 As Integer = 0
                While num1 < num
                    Dim str As String = strArrays(0)
                    Dim child_namebox As TextBox = New TextBox()
                    child_namebox.Margin = New Padding(10, 3, 3, 3)
                    child_namebox.Text = str
                    name_box_list.Controls.Add(child_namebox)
                    num1 = num1 + 1
                End While
            End While
        End If
    End Sub

    Private Sub btn_import_link_Click(sender As Object, e As EventArgs) Handles btn_import_link.Click
        If (Me.OpenFileDialog1.ShowDialog() = DialogResult.OK) Then
            Dim streamReader As System.IO.StreamReader = New System.IO.StreamReader(Me.OpenFileDialog1.FileName)
            While streamReader.Peek() <> -1
                Dim strArrays As String() = Strings.Split(streamReader.ReadLine(), "**--medinjojestvarnokralj:)--*", -1, CompareMethod.Binary)
                Dim num As Integer = strArrays.Count()
                Dim num1 As Integer = 0
                While num1 < num
                    Dim str As String = strArrays(0)
                    Dim linkbox As TextBox = New TextBox()
                    linkbox.Text = str
                    link_box_list.Controls.Add(linkbox)
                    num1 = num1 + 1
                End While
            End While
        End If
    End Sub

    Private Sub btn_import_child_link_Click(sender As Object, e As EventArgs) Handles btn_import_child_link.Click
        If (Me.OpenFileDialog1.ShowDialog() = DialogResult.OK) Then
            Dim streamReader As System.IO.StreamReader = New System.IO.StreamReader(Me.OpenFileDialog1.FileName)
            While streamReader.Peek() <> -1
                Dim strArrays As String() = Strings.Split(streamReader.ReadLine(), "**--medinjojestvarnokralj:)--*", -1, CompareMethod.Binary)
                Dim num As Integer = strArrays.Count()
                Dim num1 As Integer = 0
                While num1 < num
                    Dim str As String = strArrays(0)
                    Dim child_linkbox As TextBox = New TextBox()
                    child_linkbox.Margin = New Padding(10, 3, 3, 3)
                    child_linkbox.Text = str
                    link_box_list.Controls.Add(child_linkbox)
                    num1 = num1 + 1
                End While
            End While
        End If
    End Sub

    Private Sub GroupBox3_Enter(sender As Object, e As EventArgs) Handles GroupBox3.Enter

    End Sub
End Class