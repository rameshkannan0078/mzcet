Imports System.Data.SqlClient
Imports EASendMail
Imports SmtpClient = EASendMail.SmtpClient
Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click

        Dim con As SqlConnection = New SqlConnection("Data Source=DATABANK;Initial Catalog=canteen;User ID=canteen;Password=Billing@321")
        Dim cmd As SqlCommand = New SqlCommand("SELECT * from admin where username='" & TextBox1.Text & "' and password='" & TextBox2.Text & "'", con)
        Dim a As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        a.Fill(dt)

        If dt.Rows.Count > 0 Then
            MsgBox("You are Valid User")
            Sales_Person_Menu.Show()
        Else
            MsgBox("Not Allowed")


        End If

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            Dim oMail As New SmtpMail("TryIt")

            Dim s As String = "0123456789"
            Dim r As New Random
            Const passwordLength As Integer = 4
            Dim passwordChars() As Char = New Char(passwordLength - 1) {}
            Dim charIndex As Integer

            For i As Integer = 0 To passwordLength - 1
                charIndex = r.Next(s.Length)
                passwordChars(i) = s(charIndex)
            Next

            Dim password As New String(passwordChars)

            ' Your gmail email address
            oMail.From = "praramkunna98@gmail.com"
            ' Set recipient email address, please change it to yours
            oMail.To = "veeratpr123@gmail.com"

            ' Set email subject
            oMail.Subject = "new password"
            ' Set email body

            oMail.TextBody = password

            'Gmail SMTP server address
            Dim oServer As New SmtpServer("smtp.gmail.com")

            ' Gmail user authentication should use your
            ' Gmail email address as the user name.
            ' For example: your email is "gmailid@gmail.com", then the user should be "gmailid@gmail.com"
            oServer.User = "praramkunna98@gmail.com"
            oServer.Password = "ASDFGH@123"

            ' set 587 port, if you want to use 25 port, please change 587 to 25
            oServer.Port = 587

            ' detect SSL/TLS automatically
            oServer.ConnectType = SmtpConnectType.ConnectSSLAuto

            Console.WriteLine("start to send email over TLS ...")

            Dim oSmtp As New SmtpClient()
            oSmtp.SendMail(oServer, oMail)

            Console.WriteLine("email was sent successfully!")
            MsgBox("email sent ")
        Catch ep As Exception
            Console.WriteLine("failed to send email with the following error:")
            Console.WriteLine(ep.Message)
            MsgBox(ep.Message)
        End Try
    End Sub
End Class
