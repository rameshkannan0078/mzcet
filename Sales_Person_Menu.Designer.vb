<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Sales_Person_Menu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.home = New System.Windows.Forms.Button()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Add_stocks = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Update_stocks = New System.Windows.Forms.Button()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Show_All = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel4.SuspendLayout()
        Me.Panel5.SuspendLayout()
        Me.SuspendLayout()
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.Color.Cyan
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel2)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel3)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel4)
        Me.FlowLayoutPanel1.Controls.Add(Me.Panel5)
        Me.FlowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(200, 616)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.home)
        Me.Panel2.Location = New System.Drawing.Point(3, 3)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 50)
        Me.Panel2.TabIndex = 1
        '
        'home
        '
        Me.home.BackColor = System.Drawing.Color.Blue
        Me.home.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.home.Location = New System.Drawing.Point(9, 3)
        Me.home.Name = "home"
        Me.home.Size = New System.Drawing.Size(176, 40)
        Me.home.TabIndex = 0
        Me.home.Text = "Home"
        Me.home.UseVisualStyleBackColor = False
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Add_stocks)
        Me.Panel3.Location = New System.Drawing.Point(3, 59)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(200, 50)
        Me.Panel3.TabIndex = 2
        '
        'Add_stocks
        '
        Me.Add_stocks.BackColor = System.Drawing.Color.Blue
        Me.Add_stocks.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Add_stocks.Location = New System.Drawing.Point(9, 3)
        Me.Add_stocks.Name = "Add_stocks"
        Me.Add_stocks.Size = New System.Drawing.Size(176, 40)
        Me.Add_stocks.TabIndex = 0
        Me.Add_stocks.Text = "Add Stocks"
        Me.Add_stocks.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Update_stocks)
        Me.Panel4.Location = New System.Drawing.Point(3, 115)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(200, 50)
        Me.Panel4.TabIndex = 3
        '
        'Update_stocks
        '
        Me.Update_stocks.BackColor = System.Drawing.Color.Blue
        Me.Update_stocks.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Update_stocks.Location = New System.Drawing.Point(9, 3)
        Me.Update_stocks.Name = "Update_stocks"
        Me.Update_stocks.Size = New System.Drawing.Size(176, 40)
        Me.Update_stocks.TabIndex = 0
        Me.Update_stocks.Text = "Update Stocks"
        Me.Update_stocks.UseVisualStyleBackColor = False
        '
        'Panel5
        '
        Me.Panel5.Controls.Add(Me.Show_All)
        Me.Panel5.Location = New System.Drawing.Point(3, 171)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(200, 50)
        Me.Panel5.TabIndex = 4
        '
        'Show_All
        '
        Me.Show_All.BackColor = System.Drawing.Color.Blue
        Me.Show_All.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Show_All.Location = New System.Drawing.Point(9, 0)
        Me.Show_All.Name = "Show_All"
        Me.Show_All.Size = New System.Drawing.Size(176, 40)
        Me.Show_All.TabIndex = 0
        Me.Show_All.Text = "Show All Stocks"
        Me.Show_All.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(206, 6)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1098, 604)
        Me.Panel1.TabIndex = 1
        '
        'Sales_Person_Menu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 616)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Name = "Sales_Person_Menu"
        Me.Text = "Sales_Person_Menu"
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.Panel4.ResumeLayout(False)
        Me.Panel5.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FlowLayoutPanel1 As FlowLayoutPanel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents home As Button
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Add_stocks As Button
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Update_stocks As Button
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Show_All As Button
    Friend WithEvents Panel1 As Panel
End Class
