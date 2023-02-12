Imports System.Text.RegularExpressions
Public Class Form2
    Dim X, YY As Integer
    Dim NewPoint As New System.Drawing.Point
    Dim drag As Boolean
    Dim mousex As Integer
    Dim mousey As Integer
    Dim Heading As String
    Dim Schema As Boolean
    Dim IncludeID As Integer
    Dim NewTab As String
    Public BtnSize, BtnColor, BtnRadius, BtnBackGround As String
    Public Shared NameStorage As New ArrayList
    Public Shared IdStorage As New ArrayList
    Public Shared LinkStorage As New ArrayList
    Dim ArrayHeadings As New ArrayList
    Dim ArrayButtons As New ArrayList

    Function GenerateAll(ByVal Index As String, ByVal Link As String, ByVal Name As String, ByVal ID As String)
        If (Not Name = "" And Not Link = "") Then
            Dim SchemaAttrib As String = ""
            Dim IDAttrib As String = ""

            If (Schema = False) Then
                SchemaAttrib = "name='" + Name.ToLower.Replace(" ", "-") + "'"
            Else
                SchemaAttrib = ""
            End If

            Select Case IncludeID
                Case 0
                    IDAttrib = ""
                Case 1
                    IDAttrib = "id='" + ID + "'"
                Case 2
                    IDAttrib = "id='" + Index + "_" + Name.Replace(" ", "_") + "'"
            End Select

            ArrayHeadings.Add("<div class='myproductbox'><" + Heading + " class='has-text-align-center'><strong><span " + IDAttrib + "><a href='" + Link + "' " + NewTab + " " + SchemaAttrib + " rel='nofollow'>" + Name + "</a></span></strong></" + Heading + ">")
            ArrayButtons.Add("<div class='su-button-center'>[su_button url='" + Link + "' target='blank' rel='nofollow' background='" + BtnBackGround + "' color='" + BtnColor + "' size='" + BtnSize + "' radius='" + BtnRadius + "']<div class='fa fa-chevron-circle-right'>  Buy " + Name + "</div>[/su_button]</div></div>")
        End If
    End Function

    Private Sub Form2_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseDown
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            drag = True
            mousex = System.Windows.Forms.Cursor.Position.X - Me.Left
            mousey = System.Windows.Forms.Cursor.Position.Y - Me.Top
        End If
    End Sub
    Private Sub Form2_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseMove
        If drag Then
            Me.Top = System.Windows.Forms.Cursor.Position.Y - mousey
            Me.Left = System.Windows.Forms.Cursor.Position.X - mousex
        End If

    End Sub
    Private Sub Form2_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles Me.MouseUp
        drag = False

    End Sub
    Private Sub Panel1_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs)
        X = Control.MousePosition.X - Me.Location.X
        YY = Control.MousePosition.Y - Me.Location.Y
    End Sub

    Private Sub Panel1_MouseMove(sender As Object, e As System.Windows.Forms.MouseEventArgs)
        If e.Button = System.Windows.Forms.MouseButtons.Left Then
            NewPoint = Control.MousePosition
            NewPoint.X -= (X)
            NewPoint.Y -= (YY)
            Me.Location = NewPoint
        End If
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        ComboBox1.SelectedIndex = 1
        ComboBox3.SelectedIndex = 1
        ComboBox2.SelectedIndex = 0
        ComboBox4.SelectedIndex = 0

        BtnSize = "10"
        BtnColor = "#fff"
        BtnRadius = "round"
        BtnBackGround = "#ff9900"
    End Sub


    Private Sub FlatButton1_Click(sender As Object, e As EventArgs) Handles FlatButton1.Click

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
    End Sub

    Private Sub FlatButton2_Click(sender As Object, e As EventArgs) Handles FlatButton2.Click

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
    End Sub

    Private Sub FlatButton7_Click(sender As Object, e As EventArgs) Handles FlatButton7.Click
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
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles Button15.Click
        flow_headings.Controls.Clear()
        flow_buttons.Controls.Clear()
        ArrayHeadings.Clear()
        ArrayButtons.Clear()
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
            GenerateAll(i + 1, LinkStorage.Item(i), NameStorage.Item(i), Id)
        Next

    End Sub

    Private Sub Button31_Click(sender As Object, e As EventArgs) Handles Button31.Click
        List_View.Show()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TableHelper.Show()
    End Sub

    Private Sub Button18_Click(sender As Object, e As EventArgs) Handles Button18.Click
        CustomizeButton.Show()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        DataGridView1.Rows.Clear()
        DataGridView2.Rows.Clear()
        DataGridView3.Rows.Clear()
        flow_headings.Controls.Clear()
        flow_buttons.Controls.Clear()
        ArrayHeadings.Clear()
        ArrayButtons.Clear()

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        Heading = ComboBox1.SelectedItem.ToString
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sb As New System.Text.StringBuilder
        For i = 0 To ArrayHeadings.Count - 1
            sb.AppendLine(ArrayHeadings(i))
        Next

        sfd.Filter = "TXT Files (*.txt*)|*.txt"
        If sfd.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            My.Computer.FileSystem.WriteAllText(sfd.FileName, sb.ToString(), True)

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim sb As New System.Text.StringBuilder
        For i = 0 To ArrayButtons.Count - 1
            sb.AppendLine(ArrayButtons(i))
        Next

        sfd.Filter = "TXT Files (*.txt*)|*.txt"
        If sfd.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            My.Computer.FileSystem.WriteAllText(sfd.FileName, sb.ToString(), True)

        End If
    End Sub

    Private Sub Head1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBox2.SelectedIndexChanged
        IncludeID = ComboBox2.SelectedIndex.ToString
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        Schema = ComboBox3.SelectedIndex.ToString
    End Sub

    Private Sub ComboBox4_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged
        If (ComboBox4.SelectedIndex = 0) Then
            NewTab = "target='_blank'"
        Else
            NewTab = ""
        End If
    End Sub

    Private Sub PictureBox5_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Private Sub CopyHeading_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Headingnum As Integer = Integer.Parse(Regex.Replace(sender.Text, "[^\d]", "")) - 1
        Clipboard.SetText(ArrayHeadings(Headingnum))
    End Sub

    Private Sub CopyButtons_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Dim Buttonnum As Integer = Integer.Parse(Regex.Replace(sender.Text, "[^\d]", "")) - 1
        Clipboard.SetText(ArrayButtons(Buttonnum))
    End Sub
End Class