Imports System.Data.SqlClient
Public Class Sales_Show_AllStocks
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        UpdateDGV()
    End Sub

    Private Sub UpdateDGV()



    End Sub

    Private Sub Sales_Show_AllStocks_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim timer = New Timer
        timer.Interval = 30 * 1000
        AddHandler timer.Tick, AddressOf Timer2_Tick
        timer.Start()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim con As SqlConnection = New SqlConnection("Data Source=DATABANK;Initial Catalog=canteen;User ID=canteen;Password=Billing@321")
        Dim cmd As SqlCommand = New SqlCommand("SELECT * from product_details where id='" & TextBox1.Text & "'", con)
        Dim a As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        a.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim con As SqlConnection = New SqlConnection("Data Source=DATABANK;Initial Catalog=canteen;User ID=canteen;Password=Billing@321")
        Dim cmd As SqlCommand = New SqlCommand("SELECT * from product_details", con)
        Dim a As New SqlDataAdapter(cmd)
        Dim dt As New DataTable
        a.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class