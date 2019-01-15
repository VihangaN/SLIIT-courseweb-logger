Imports System.Net
Imports mshtml

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        WebBrowser1.Navigate("http://courseweb.sliit.lk/login/index.php")
    End Sub

    Private Sub WebBrowser1_DocumentCompleted(sender As Object, e As WebBrowserDocumentCompletedEventArgs) Handles WebBrowser1.DocumentCompleted
        
        login()





    End Sub


    Private Sub login()


'replace username with your it number and password with your courseweb login password 


        Dim head As HtmlElement = WebBrowser1.Document.GetElementsByTagName("head")(0)
        Dim scriptEl As HtmlElement = WebBrowser1.Document.CreateElement("script")
        Dim element As IHTMLScriptElement = CType(scriptEl.DomElement, IHTMLScriptElement)
        element.text = "function login (){ ;document.getElementById('username').value = 'Your it number ';
        document.getElementById('password').value = ' Your password';
        var button = document.getElementById('loginbtn');
        button.click(); }
"
        head.AppendChild(scriptEl)
        WebBrowser1.Document.InvokeScript("login")


        Dim navigateurl = WebBrowser1.Url.ToString
        If navigateurl = "http://courseweb.sliit.lk/my/" Then
            UserControl11.Visible = False

            WebBrowser1.Visible = True

        Else

        End If



    End Sub


End Class
