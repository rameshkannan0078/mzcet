Imports System.Data.SqlClient


Public Class Sales_Update_Stock
    Private Sub Sales_Update_Stock_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Submit_Click(sender As Object, e As EventArgs) Handles Submit.Click
        Dim con As SqlConnection = New SqlConnection("Data Source=DATABANK;Initial Catalog=canteen;User ID=canteen;Password=Billing@321")
        Dim cmd As SqlCommand = New SqlCommand("SELECT * from product_details  where id='" & TextBox1.Text & "'", con)
        Dim a As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        a.Fill(dt)
        DataGridView1.DataSource = dt

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub TextBox5_TextChanged(sender As Object, e As EventArgs) Handles TextBox5.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As SqlConnection = New SqlConnection("Data Source=DATABANK;Initial Catalog=canteen;User ID=canteen;Password=Billing@321")
        Dim cmd As SqlCommand = New SqlCommand("UPDATE  product_details SET id='" & TextBox2.Text & "',product_name='" & TextBox3.Text & "',price='" & TextBox4.Text & "',quantity='" & TextBox5.Text & "' WHERE id='" & TextBox2.Text & "'", con)
        Dim a As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        a.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Splitter2_SplitterMoved(sender As Object, e As SplitterEventArgs) Handles Splitter2.SplitterMoved

    End Sub

    Private Sub Delete_Click(sender As Object, e As EventArgs) Handles Delete.Click
        Dim con As SqlConnection = New SqlConnection("Data Source=DATABANK;Initial Catalog=canteen;User ID=canteen;Password=Billing@321")
        Dim cmd As SqlCommand = New SqlCommand(" Delete From product_details Where id ='" & TextBox1.Text & "'", con)



        Dim a As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        a.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub
End Class