Imports System.Data.SqlClient

Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As SqlConnection = New SqlConnection("Data Source=DATABANK;Initial Catalog=canteen;User ID=canteen;Password=Billing@321")
        Dim cmd As SqlCommand = New SqlCommand("INSERT INTO product_details([id],[product_name],[price],[quantity]) VALUES ('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "','" & TextBox4.Text & "')", con)
        Dim cmd1 As SqlCommand = New SqlCommand("SELECT * from product_details", con)
        Dim a As New SqlDataAdapter(cmd)
        Dim b As New SqlDataAdapter(cmd1)
        Dim dt As New DataTable
        a.Fill(dt)
        b.Fill(dt)
        DataGridView1.DataSource = b
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs) Handles TextBox4.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub TextBox3_TextChanged(sender As Object, e As EventArgs) Handles TextBox3.TextChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim con As SqlConnection = New SqlConnection("Data Source=(localdb)\MyInstance;Initial Catalog=Sales_Person;Integrated Security=True")
        Dim cmd As SqlCommand = New SqlCommand("SELECT * from product_details", con)
        Dim a As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        a.Fill(dt)
        DataGridView1.DataSource = dt

    End Sub
End Class