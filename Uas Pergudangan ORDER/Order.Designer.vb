<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Order
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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.OrderToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AddOrderBarangToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BtnAdd = New System.Windows.Forms.Button()
        Me.BtnRmv = New System.Windows.Forms.Button()
        Me.ListBoxOrder = New System.Windows.Forms.ListBox()
        Me.DataGridOrder = New System.Windows.Forms.DataGridView()
        Me.BtnSelect = New System.Windows.Forms.Button()
        Me.BtnRemove = New System.Windows.Forms.Button()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.DataGridOrder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.OrderToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(932, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'OrderToolStripMenuItem
        '
        Me.OrderToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddOrderBarangToolStripMenuItem})
        Me.OrderToolStripMenuItem.Name = "OrderToolStripMenuItem"
        Me.OrderToolStripMenuItem.Size = New System.Drawing.Size(49, 20)
        Me.OrderToolStripMenuItem.Text = "Order"
        '
        'AddOrderBarangToolStripMenuItem
        '
        Me.AddOrderBarangToolStripMenuItem.Name = "AddOrderBarangToolStripMenuItem"
        Me.AddOrderBarangToolStripMenuItem.Size = New System.Drawing.Size(169, 22)
        Me.AddOrderBarangToolStripMenuItem.Text = "Add Order Barang"
        '
        'BtnAdd
        '
        Me.BtnAdd.Location = New System.Drawing.Point(94, 56)
        Me.BtnAdd.Name = "BtnAdd"
        Me.BtnAdd.Size = New System.Drawing.Size(27, 25)
        Me.BtnAdd.TabIndex = 1
        Me.BtnAdd.Text = "+"
        Me.BtnAdd.UseVisualStyleBackColor = True
        '
        'BtnRmv
        '
        Me.BtnRmv.Location = New System.Drawing.Point(147, 56)
        Me.BtnRmv.Name = "BtnRmv"
        Me.BtnRmv.Size = New System.Drawing.Size(27, 25)
        Me.BtnRmv.TabIndex = 2
        Me.BtnRmv.Text = "-"
        Me.BtnRmv.UseVisualStyleBackColor = True
        '
        'ListBoxOrder
        '
        Me.ListBoxOrder.FormattingEnabled = True
        Me.ListBoxOrder.ItemHeight = 15
        Me.ListBoxOrder.Location = New System.Drawing.Point(94, 87)
        Me.ListBoxOrder.Name = "ListBoxOrder"
        Me.ListBoxOrder.Size = New System.Drawing.Size(169, 139)
        Me.ListBoxOrder.TabIndex = 3
        '
        'DataGridOrder
        '
        Me.DataGridOrder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridOrder.Location = New System.Drawing.Point(415, 76)
        Me.DataGridOrder.Name = "DataGridOrder"
        Me.DataGridOrder.RowTemplate.Height = 25
        Me.DataGridOrder.Size = New System.Drawing.Size(424, 150)
        Me.DataGridOrder.TabIndex = 4
        '
        'BtnSelect
        '
        Me.BtnSelect.Location = New System.Drawing.Point(415, 232)
        Me.BtnSelect.Name = "BtnSelect"
        Me.BtnSelect.Size = New System.Drawing.Size(75, 23)
        Me.BtnSelect.TabIndex = 6
        Me.BtnSelect.Text = "select"
        Me.BtnSelect.UseVisualStyleBackColor = True
        '
        'BtnRemove
        '
        Me.BtnRemove.Location = New System.Drawing.Point(751, 232)
        Me.BtnRemove.Name = "BtnRemove"
        Me.BtnRemove.Size = New System.Drawing.Size(75, 23)
        Me.BtnRemove.TabIndex = 7
        Me.BtnRemove.Text = "Remove"
        Me.BtnRemove.UseVisualStyleBackColor = True
        '
        'Order
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(932, 450)
        Me.Controls.Add(Me.BtnRemove)
        Me.Controls.Add(Me.BtnSelect)
        Me.Controls.Add(Me.DataGridOrder)
        Me.Controls.Add(Me.ListBoxOrder)
        Me.Controls.Add(Me.BtnRmv)
        Me.Controls.Add(Me.BtnAdd)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "Order"
        Me.Text = "Order"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.DataGridOrder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents OrderToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AddOrderBarangToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BtnAdd As Button
    Friend WithEvents BtnRmv As Button
    Friend WithEvents ListBoxOrder As ListBox
    Friend WithEvents DataGridOrder As DataGridView
    Friend WithEvents BtnSelect As Button
    Friend WithEvents BtnRemove As Button
End Class
