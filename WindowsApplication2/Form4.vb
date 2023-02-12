Public Class Form4
    Public Shared NameStorage As New ArrayList
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles Button11.Click

        For i As Integer = 0 To DataGridView1.Rows.Count() - 1
            Dim Head As TextBox = CType(Me.GroupBox1.Controls("Head" + (i + 1).ToString()), TextBox)
            GenerateAll(i + 1, NameStorage.Item(i), Head)
        Next

    End Sub
    Function GenerateAll(ByVal Index As String, ByVal Name As String, ByVal HeadBox As TextBox)
        HeadBox.Text = "<p Class='table_s1_thead_title'>" + TextBox1.Text + "</p>" + Name + ""
    End Function

    Private Sub CopyHead1_Click(sender As Object, e As EventArgs) Handles CopyHead1.Click
        Clipboard.SetText(Head1.Text)
    End Sub

    Private Sub CopyHead2_Click(sender As Object, e As EventArgs) Handles CopyHead2.Click
        Clipboard.SetText(Head2.Text)
    End Sub

    Private Sub CopyHead3_Click(sender As Object, e As EventArgs) Handles CopyHead3.Click
        Clipboard.SetText(Head3.Text)
    End Sub

    Private Sub CopyHead4_Click(sender As Object, e As EventArgs) Handles CopyHead4.Click
        Clipboard.SetText(Head4.Text)
    End Sub

    Private Sub CopyHead5_Click(sender As Object, e As EventArgs) Handles CopyHead5.Click
        Clipboard.SetText(Head5.Text)
    End Sub

    Private Sub CopyHead6_Click(sender As Object, e As EventArgs) Handles CopyHead6.Click
        Clipboard.SetText(Head6.Text)
    End Sub

    Private Sub CopyHead7_Click(sender As Object, e As EventArgs) Handles CopyHead7.Click
        Clipboard.SetText(Head7.Text)
    End Sub

    Private Sub CopyHead8_Click(sender As Object, e As EventArgs) Handles CopyHead8.Click
        Clipboard.SetText(Head8.Text)
    End Sub

    Private Sub CopyHead9_Click(sender As Object, e As EventArgs) Handles CopyHead9.Click
        Clipboard.SetText(Head9.Text)
    End Sub

    Private Sub CopyHead10_Click(sender As Object, e As EventArgs) Handles CopyHead10.Click
        Clipboard.SetText(Head10.Text)
    End Sub

    Private Sub FlatButton3_Click(sender As Object, e As EventArgs) Handles FlatButton3.Click
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

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim sb As New System.Text.StringBuilder
        For i As Integer = 0 To 9
            Dim Head As TextBox = CType(Me.GroupBox1.Controls("Head" + (i + 1).ToString()), TextBox)
            sb.AppendLine(Head.Text)

        Next

        sfd.Filter = "TXT Files (*.txt*)|*.txt"
        If sfd.ShowDialog = System.Windows.Forms.DialogResult.OK Then
            My.Computer.FileSystem.WriteAllText(sfd.FileName, sb.ToString(), True)

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        DataGridView1.Rows.Clear()
        For Each MyGroupBox As Control In Me.Controls
            If TypeOf MyGroupBox Is GroupBox Then
                For Each MyTextBox As Control In MyGroupBox.Controls
                    If TypeOf MyTextBox Is TextBox Then
                        MyTextBox.Text = ""
                    End If
                Next

            End If
        Next
    End Sub
End Class