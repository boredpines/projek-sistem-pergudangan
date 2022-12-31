<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TambahJenisBarang
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtIdJenis = New System.Windows.Forms.TextBox()
        Me.CbSatuanJenis = New System.Windows.Forms.ComboBox()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.TxtNamaJenis = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(108, 149)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "ID Jenis Barang:"
        '
        'TxtIdJenis
        '
        Me.TxtIdJenis.Location = New System.Drawing.Point(294, 146)
        Me.TxtIdJenis.Name = "TxtIdJenis"
        Me.TxtIdJenis.Size = New System.Drawing.Size(210, 23)
        Me.TxtIdJenis.TabIndex = 1
        '
        'CbSatuanJenis
        '
        Me.CbSatuanJenis.FormattingEnabled = True
        Me.CbSatuanJenis.Location = New System.Drawing.Point(294, 254)
        Me.CbSatuanJenis.Name = "CbSatuanJenis"
        Me.CbSatuanJenis.Size = New System.Drawing.Size(210, 23)
        Me.CbSatuanJenis.TabIndex = 2
        '
        'BtnTambah
        '
        Me.BtnTambah.Location = New System.Drawing.Point(294, 320)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(75, 23)
        Me.BtnTambah.TabIndex = 3
        Me.BtnTambah.Text = "Add"
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'TxtNamaJenis
        '
        Me.TxtNamaJenis.Location = New System.Drawing.Point(294, 200)
        Me.TxtNamaJenis.Name = "TxtNamaJenis"
        Me.TxtNamaJenis.Size = New System.Drawing.Size(210, 23)
        Me.TxtNamaJenis.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(108, 200)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 15)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nama Jenis Barang:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(108, 257)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Satuan Jenis Barang:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(108, 50)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(173, 23)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Tambah Jenis Barang"
        '
        'TambahJenisBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(620, 450)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtNamaJenis)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.CbSatuanJenis)
        Me.Controls.Add(Me.TxtIdJenis)
        Me.Controls.Add(Me.Label1)
        Me.Name = "TambahJenisBarang"
        Me.Text = "TambahJenisBarang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TxtIdJenis As TextBox
    Friend WithEvents CbSatuanJenis As ComboBox
    Friend WithEvents BtnTambah As Button
    Friend WithEvents TxtNamaJenis As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
End Class
