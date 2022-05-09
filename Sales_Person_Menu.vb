Public Class Sales_Person_Menu
    Private Sub Sales_Person_Menu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Sub switchPanel(ByVal panel As Form)
        Panel1.Controls.Clear()
        panel.TopLevel = False
        Panel1.Controls.Add(panel)
        panel.Show()
    End Sub

    Private Sub home_Click(sender As Object, e As EventArgs) Handles home.Click
        switchPanel(Sales_Home)
    End Sub

    Private Sub Add_stocks_Click(sender As Object, e As EventArgs) Handles Add_stocks.Click
        switchPanel(Form4)
    End Sub

    Private Sub Update_stocks_Click(sender As Object, e As EventArgs) Handles Update_stocks.Click
        switchPanel(Sales_Update_Stock)
    End Sub

    Private Sub delete_stocks_Click(sender As Object, e As EventArgs)
        switchPanel(Sales_Delete_Stock)
    End Sub

    Private Sub Show_All_Click(sender As Object, e As EventArgs) Handles Show_All.Click
        switchPanel(Sales_Show_AllStocks)
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub


End Class