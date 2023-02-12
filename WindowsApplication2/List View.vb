Public Class List_View

    Function AddElements(ByVal Index As Integer, ByVal Name As String)
        Dim Element As String
        Dim Id As String

        If (Not Name = "" And Not Index = Nothing) Then
            Id = "#" + Name.ToLower.Replace(" ", "-")

            Element = "{""@type"":  ""ListItem"",
            ""position"": """ + Index.ToString + """,
            ""url"": """ + LinkBox1.Text + Id + """,
		    ""@id"": """ + Id + """,
		    ""name"": """ + Name + """	    
            },"
        End If

        Return Element
    End Function

    Private Sub Button17_Click(sender As Object, e As EventArgs) Handles Button17.Click
        If (Not TitleBox1.Text = "" And Not LinkBox1.Text = "") Then

            Dim ListElements As String

            For i As Integer = 0 To Form2.NameStorage.Count - 1
                ListElements += AddElements(i + 1, Form2.NameStorage.Item(i))
            Next

            ListElements = ListElements.Remove(ListElements.Length - 1)

            Dim Schema As String
            Schema = "<script type=""application/ld+json"" Class=""saswp-custom-schema-markup-output"">{
             ""@context"": ""http://schema.org"",
             ""@type"": ""ItemList"",
            ""url"": """ + LinkBox1.Text + """,
            ""name"": """ + TitleBox1.Text + """,
             ""itemListElement"":
             [
              " + ListElements + "
             ]
            }</script>"

            SchemaBox1.Text = Schema
        End If

    End Sub

    Private Sub List_View_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Clipboard.SetText(SchemaBox1.Text)


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For Each MyGroupBox As Control In Me.Controls
            If TypeOf MyGroupBox Is GroupBox Then
                For Each MyTextBox As Control In MyGroupBox.Controls
                    If TypeOf MyTextBox Is TextBox Then
                    End If
                Next

            End If
        Next
    End Sub
End Class