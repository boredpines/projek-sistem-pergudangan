<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TambahBarang
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BtnAddBarang = New System.Windows.Forms.Button()
        Me.TxtStock = New System.Windows.Forms.TextBox()
        Me.TxtBarang = New System.Windows.Forms.TextBox()
        Me.TxtJenis = New System.Windows.Forms.TextBox()
        Me.TxtIDB = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnAddBarang
        '
        Me.BtnAddBarang.Location = New System.Drawing.Point(555, 351)
        Me.BtnAddBarang.Name = "BtnAddBarang"
        Me.BtnAddBarang.Size = New System.Drawing.Size(131, 47)
        Me.BtnAddBarang.TabIndex = 21
        Me.BtnAddBarang.Text = "Add Barang"
        Me.BtnAddBarang.UseVisualStyleBackColor = True
        '
        'TxtStock
        '
        Me.TxtStock.Location = New System.Drawing.Point(372, 275)
        Me.TxtStock.Name = "TxtStock"
        Me.TxtStock.Size = New System.Drawing.Size(150, 31)
        Me.TxtStock.TabIndex = 20
        '
        'TxtBarang
        '
        Me.TxtBarang.Location = New System.Drawing.Point(372, 220)
        Me.TxtBarang.Name = "TxtBarang"
        Me.TxtBarang.Size = New System.Drawing.Size(150, 31)
        Me.TxtBarang.TabIndex = 19
        '
        'TxtJenis
        '
        Me.TxtJenis.Location = New System.Drawing.Point(372, 167)
        Me.TxtJenis.Name = "TxtJenis"
        Me.TxtJenis.Size = New System.Drawing.Size(150, 31)
        Me.TxtJenis.TabIndex = 18
        '
        'TxtIDB
        '
        Me.TxtIDB.Location = New System.Drawing.Point(372, 122)
        Me.TxtIDB.Name = "TxtIDB"
        Me.TxtIDB.Size = New System.Drawing.Size(150, 31)
        Me.TxtIDB.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(182, 275)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 25)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Stock"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(182, 167)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(130, 25)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "ID jenis Barang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(182, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 25)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "ID Barang"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(182, 220)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(119, 25)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Nama Barang"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Showcard Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(115, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(158, 23)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Tambah Barang"
        '
        'TambahBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.BtnAddBarang)
        Me.Controls.Add(Me.TxtStock)
        Me.Controls.Add(Me.TxtBarang)
        Me.Controls.Add(Me.TxtJenis)
        Me.Controls.Add(Me.TxtIDB)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "TambahBarang"
        Me.Text = "TambahBarang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnAddBarang As Button
    Friend WithEvents TxtStock As TextBox
    Friend WithEvents TxtBarang As TextBox
    Friend WithEvents TxtJenis As TextBox
    Friend WithEvents TxtIDB As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
