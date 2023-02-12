Imports System.Text.RegularExpressions
Imports Microsoft.VisualBasic.CompilerServices

Public Class TableHelper
    Public BtnSize, BtnColor, BtnRadius, BtnBackGround As String
    Dim IncludeID As Integer
    Dim Prevoption As Integer
    Dim Includeprev As String
    Dim i = 0
    Dim nxt As Integer
    Dim NameStorage As New ArrayList
    Dim IdStorage As New ArrayList
    Dim LinkStorage As New ArrayList
    Dim PrevImgStorage As New ArrayList
    Dim ArrayHeadings As New ArrayList
    Dim ArrayButtons As New ArrayList
    Dim ArrayImages As New ArrayList
    Function GenerateAll(ByVal Index As String, ByVal Link As String, ByVal Name As String, ByVal ID As String, ByVal LinkIMG As String)
        Dim Alt As String
        Alt = "" + Name.Replace(" ", "-") + ""
        If (Not Name = "" And Not Link = "") Then
            Dim IDAttrib As String = ""
            Select Case IncludeID
                Case 0
                    IDAttrib = "#" + ID + ""
                Case 1
                    IDAttrib = "#" + Index + "_" + Name.Replace(" ", "_") + ""
            End Select

            Select Case Prevoption
                Case 0
                    If (Not Link = "") Then
                        ArrayHeadings.Add("<div Class='mybigitem'><div><img src='" + LinkIMG + "' alt='" + Alt + "' width='75' height='75' class='aligncenter size-medium'></div><a href='" + IDAttrib + "'>" + Name + "</a></div>")
                        ArrayButtons.Add("[su_button url='" + Link + "' rel='nofollow' target='blank' background='" + BtnBackGround + "' text-alight:'center' color='" + BtnColor + "' size='" + BtnSize + "']Check Price[/su_button]")
                    End If
                Case 1, 2, 3, 4, 5
                    If (Not Link = "") Then
                        ArrayHeadings.Add("<div Class='mybigitem'><div><img src='" + LinkIMG.Remove(Link.Length - 4) + "-" + Includeprev + ".jpg' alt='" + Alt + "' width='75' height='75' class='aligncenter size-medium'></div><a href='" + IDAttrib + "'>" + Name + "</a></div>")
                        ArrayButtons.Add("[su_button url='" + Link + "' rel='nofollow' target='blank' background='" + BtnBackGround + "' text-alight:'center' color='" + BtnColor + "' size='" + BtnSize + "']Check Price[/su_button]")
                    End If
            End Select

        End If
    End Function
    Function GenerateThumbnail(ByVal Name As String, ByVal Link As String)
        Dim Alt As String
        Alt = "" + Name.Replace(" ", "-") + ""
        Select Case Prevoption
            Case 0
                If (Not Link = "") Then
                    ArrayImages.Add("<img src='" + Link + "' alt='" + Alt + "' width='75' height='75' class='aligncenter size-medium'>")

                End If
            Case 1, 2, 3, 4, 5
                If (Not Link = "") Then
                    ArrayImages.Add("<img src='" + Link.Remove(Link.Length - 4) + "-" + Includeprev + ".jpg' alt='" + Alt + "' width='75' height='75' class='aligncenter size-medium'>")

                End If
        End Select

    End Function
    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click
        Dim flag As Boolean
        Try
            flow_headings.Controls.Clear()
            flow_buttons.Controls.Clear()
            flow_images.Controls.Clear()
            ArrayButtons.Clear()
            ArrayHeadings.Clear()
            ArrayImages.Clear()
            For i As Integer = 0 To DataGridView1.Rows.Count() - 1
                Dim Btnheading As Button = New Button()
                Btnheading.Text = "Copy Heading " + (i + 1).ToString()
                Btnheading.Size = New Size(flow_headings.Size.Width - 6, 35)
                Btnheading.ForeColor = Color.FromArgb(0, 0, 0)
                flow_headings.Controls.Add(Btnheading)
                AddHandler Btnheading.Click, AddressOf Me.CopyHeading_Click
                Dim Btnbuttons As Button = New Button()
                Btnbuttons.Text = "Copy Button " + (i + 1).ToString()
                Btnbuttons.Size = New Size(flow_buttons.Size.Width - 6, 35)
                Btnbuttons.ForeColor = Color.FromArgb(0, 0, 0)
                flow_buttons.Controls.Add(Btnbuttons)
                AddHandler Btnbuttons.Click, AddressOf Me.CopyButtons_Click
                Dim Id As String
                If IdStorage.Count() > i + 1 Then
                    Id = IdStorage.Item(i)
                Else
                    Id = ""
                End If
                GenerateAll(i + 1, LinkStorage.Item(i), NameStorage.Item(i), Id, PrevImgStorage.Item(i))
            Next

            For i As Integer = 0 To DataGridView4.Rows.Count() - 1
                Dim Btnimages As Button = New Button()
                Btnimages.Text = "Copy Image " + (i + 1).ToString()
                Btnimages.Size = New Size(flow_images.Size.Width - 6, 35)
                Btnimages.ForeColor = Color.FromArgb(0, 0, 0)
                flow_images.Controls.Add(Btnimages)
                AddHandler Btnimages.Click, AddressOf Me.CopyImages_Click
                GenerateThumbnail(NameStorage.Item(i), PrevImgStorage.Item(i))
            Next
        Catch webException As System.Net.WebException
            ProjectData.SetProjectError(webException)
            flag = False
            ProjectData.ClearProjectError()
        End Try
    End Sub

    Private Sub Button23_Click(sender As Object, e As EventArgs) Handles Button23.Click
        CustomizeButtonDesign.Show()

    End Sub

    Private Sub TableHelper_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        NameStorage = Form2.NameStorage
        LinkStorage = Form2.LinkStorage
        IdStorage = Form2.IdStorage
        For i As Integer = 0 To Form2.NameStorage.Count() - 1
            DataGridView1.Rows.Add(Form2.NameStorage.Item(i))
            DataGridView2.Rows.Add(Form2.LinkStorage.Item(i))
            Dim Id As String
            If Form2.IdStorage.Count() > i + 1 Then
                Id = IdStorage.Item(i)
            Else
                Id = ""
            End If
            DataGridView3.Rows.Add(Id)
        Next

        BtnSize = "3"
        BtnColor = "#FFFFFF"
        BtnBackGround = "#FF742F"
        ComboBox2.SelectedIndex = 0
        ComboBox1.SelectedIndex = 0
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DataGridView1.Rows.Clear()
        DataGridView2.Rows.Clear()
        DataGridView3.Rows.Clear()
        DataGridView4.Rows.Clear()
        flow_headings.Controls.Clear()
        flow_buttons.Controls.Clear()
        flow_images.Controls.Clear()
        ArrayButtons.Clear()
        ArrayHeadings.Clear()
        ArrayImages.Clear()
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        IncludeID = ComboBox2.SelectedIndex.ToString
    End Sub


    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Includeprev = ComboBox1.SelectedItem.ToString()
        Prevoption = ComboBox1.SelectedIndex.ToString()
    End Sub

    Private Sub FlatButton3_Click(sender As Object, e As EventArgs) Handles FlatButton3.Click
        Dim flag As Boolean
        Try
            NameStorage.Clear()
            If (Me.ofd.ShowDialog() = DialogResult.OK) Then
                DataGridView1.Rows.Clear()
                Dim streamReader As System.IO.StreamReader = New System.IO.StreamReader(Me.ofd.FileName)
                While streamReader.Peek() <> -1
                    Dim strArrays As String() = Strings.Split(streamReader.ReadLine(), "**--medinjojestvarnokralj:)--*", -1, CompareMethod.Binary)
                    Dim num As Integer = strArrays.Count()
                    Dim num1 As Integer = 0
                    While num1 <= num
                        Dim str As String = strArrays(0)
                        num1 = num1 + 1
                        Me.DataGridView1.Rows.Add(New Object() {str})
                        num1 = num1 + 1
                    End While
                End While
            End If
            If (DataGridView1.Rows(0).Cells(0).Value = "") Then
            Else

                For i As Integer = 0 To DataGridView1.Rows.Count() - 1
                    NameStorage.Add(DataGridView1.Rows(i).Cells(0).Value)
                Next

            End If
        Catch webException As System.Net.WebException
            ProjectData.SetProjectError(webException)
            flag = False
            ProjectData.ClearProjectError()
        End Try

    End Sub

    Private Sub FlatButton4_Click(sender As Object, e As EventArgs) Handles FlatButton4.Click
        Dim flag As Boolean
        Try
            LinkStorage.Clear()
            If (Me.ofd.ShowDialog() = DialogResult.OK) Then
                DataGridView2.Rows.Clear()
                Dim streamReader As System.IO.StreamReader = New System.IO.StreamReader(Me.ofd.FileName)
                While streamReader.Peek() <> -1
                    Dim strArrays As String() = Strings.Split(streamReader.ReadLine(), "**--medinjojestvarnokralj:)--*", -1, CompareMethod.Binary)
                    Dim num As Integer = strArrays.Count()
                    Dim num1 As Integer = 0
                    While num1 <= num
                        Dim str As String = strArrays(0)
                        num1 = num1 + 1
                        Me.DataGridView2.Rows.Add(New Object() {str})
                        num1 = num1 + 1
                    End While
                End While
            End If
            If (DataGridView2.Rows(0).Cells(0).Value = "") Then
            Else

                For i As Integer = 0 To DataGridView2.Rows.Count() - 1
                    LinkStorage.Add(DataGridView2.Rows(i).Cells(0).Value)
                Next

            End If
        Catch webException As System.Net.WebException
            ProjectData.SetProjectError(webException)
            flag = False
            ProjectData.ClearProjectError()
        End Try

    End Sub

    Private Sub FlatButton5_Click(sender As Object, e As EventArgs) Handles FlatButton5.Click
        Dim flag As Boolean
        Try
            IdStorage.Clear()
            If (Me.ofd.ShowDialog() = DialogResult.OK) Then
                DataGridView3.Rows.Clear()
                Dim streamReader As System.IO.StreamReader = New System.IO.StreamReader(Me.ofd.FileName)
                While streamReader.Peek() <> -1
                    Dim strArrays As String() = Strings.Split(streamReader.ReadLine(), "**--medinjojestvarnokralj:)--*", -1, CompareMethod.Binary)
                    Dim num As Integer = strArrays.Count()
                    Dim num1 As Integer = 0
                    While num1 <= num
                        Dim str As String = strArrays(0)
                        num1 = num1 + 1
                        Me.DataGridView3.Rows.Add(New Object() {str})
                        num1 = num1 + 1
                    End While
                End While
            End If
            If (DataGridView3.Rows(0).Cells(0).Value = "") Then
            Else

                For i As Integer = 0 To DataGridView3.Rows.Count() - 1
                    IdStorage.Add(DataGridView3.Rows(i).Cells(0).Value)
                Next

            End If
        Catch webException As System.Net.WebException
            ProjectData.SetProjectError(webException)
            flag = False
            ProjectData.ClearProjectError()
        End Try

    End Sub

    Private Sub FlatButton6_Click(sender As Object, e As EventArgs) Handles FlatButton6.Click
        Dim flag As Boolean
        Try
            PrevImgStorage.Clear()
            If (Me.ofd.ShowDialog() = DialogResult.OK) Then
                DataGridView4.Rows.Clear()
                Dim streamReader As System.IO.StreamReader = New System.IO.StreamReader(Me.ofd.FileName)
                While streamReader.Peek() <> -1
                    Dim strArrays As String() = Strings.Split(streamReader.ReadLine(), "**--medinjojestvarnokralj:)--*", -1, CompareMethod.Binary)
                    Dim num As Integer = strArrays.Count()
                    Dim num1 As Integer = 0
                    While num1 <= num
                        Dim str As String = strArrays(0)
                        num1 = num1 + 1
                        Me.DataGridView4.Rows.Add(New Object() {str})
                        num1 = num1 + 1
                    End While
                End While
            End If
            If (DataGridView4.Rows(0).Cells(0).Value = "") Then
            Else

                For i As Integer = 0 To DataGridView4.Rows.Count() - 1
                    PrevImgStorage.Add(DataGridView4.Rows(i).Cells(0).Value)
                Next

            End If
        Catch webException As System.Net.WebException
            ProjectData.SetProjectError(webException)
            flag = False
            ProjectData.ClearProjectError()
        End Try

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sb As New System.Text.StringBuilder
        For i = 0 To ArrayHeadings.Count - 1
            sb.AppendLine(ArrayHeadings(i))
        Next

        sfd.Filter = "TXT Files (*.txt*)|*.txt"
        If sfd.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            My.Computer.FileSystem.WriteAllText(sfd.FileName, sb.ToString(), True)

        End If

    End Sub

    Private Sub Button3_Click_1(sender As Object, e As EventArgs) Handles Button3.Click
        Dim sb As New System.Text.StringBuilder
        For i = 0 To ArrayButtons.Count - 1
            sb.AppendLine(ArrayButtons(i))
        Next


        sfd.Filter = "TXT Files (*.txt*)|*.txt"
        If sfd.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            My.Computer.FileSystem.WriteAllText(sfd.FileName, sb.ToString(), True)

        End If
    End Sub

    Private Sub Button4_Click_1(sender As Object, e As EventArgs) Handles Button4.Click
        Dim sb As New System.Text.StringBuilder
        For i = 0 To ArrayImages.Count - 1
            sb.AppendLine(ArrayImages(i))
        Next

        sfd.Filter = "TXT Files (*.txt*)|*.txt"
        If sfd.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            My.Computer.FileSystem.WriteAllText(sfd.FileName, sb.ToString(), True)

        End If
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        Clipboard.SetText("table_s2")
    End Sub

    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        Clipboard.SetText("table_s1")
    End Sub
    Private Sub CopyHeading_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Headingnum As Integer = Integer.Parse(Regex.Replace(sender.Text, "[^\d]", "")) - 1
        Clipboard.SetText(ArrayHeadings(Headingnum))
    End Sub

    Private Sub CopyButtons_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Buttonnum As Integer = Integer.Parse(Regex.Replace(sender.Text, "[^\d]", "")) - 1
        Clipboard.SetText(ArrayButtons(Buttonnum))
    End Sub

    Private Sub CopyImages_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Imagesnum As Integer = Integer.Parse(Regex.Replace(sender.Text, "[^\d]", "")) - 1
        Clipboard.SetText(ArrayImages(Imagesnum))
    End Sub
End Class