Imports System.Data.SqlClient

Public Class Sales_Home
    Private Sub Sales_Home_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim con As SqlConnection = New SqlConnection("Data Source=DATABANK;Initial Catalog=canteen;User ID=canteen;Password=Billing@321")
        Dim cmd As SqlCommand = New SqlCommand("SELECT * from product_details where id='" & TextBox1.Text & "'", con)
        Dim a As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        a.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub
End Class