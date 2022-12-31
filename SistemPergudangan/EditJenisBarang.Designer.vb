<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EditJenisBarang
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtNamaJenis = New System.Windows.Forms.TextBox()
        Me.BtnTambah = New System.Windows.Forms.Button()
        Me.CbSatuanJenis = New System.Windows.Forms.ComboBox()
        Me.TxtIdJenis = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Calibri", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.Location = New System.Drawing.Point(92, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(143, 23)
        Me.Label4.TabIndex = 15
        Me.Label4.Text = "Edit Jenis Barang"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(92, 281)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(114, 15)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Satuan Jenis Barang:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(92, 224)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(110, 15)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Nama Jenis Barang:"
        '
        'TxtNamaJenis
        '
        Me.TxtNamaJenis.Location = New System.Drawing.Point(278, 224)
        Me.TxtNamaJenis.Name = "TxtNamaJenis"
        Me.TxtNamaJenis.Size = New System.Drawing.Size(210, 23)
        Me.TxtNamaJenis.TabIndex = 12
        '
        'BtnTambah
        '
        Me.BtnTambah.Location = New System.Drawing.Point(278, 344)
        Me.BtnTambah.Name = "BtnTambah"
        Me.BtnTambah.Size = New System.Drawing.Size(75, 23)
        Me.BtnTambah.TabIndex = 11
        Me.BtnTambah.Text = "Add"
        Me.BtnTambah.UseVisualStyleBackColor = True
        '
        'CbSatuanJenis
        '
        Me.CbSatuanJenis.FormattingEnabled = True
        Me.CbSatuanJenis.Location = New System.Drawing.Point(278, 278)
        Me.CbSatuanJenis.Name = "CbSatuanJenis"
        Me.CbSatuanJenis.Size = New System.Drawing.Size(210, 23)
        Me.CbSatuanJenis.TabIndex = 10
        '
        'TxtIdJenis
        '
        Me.TxtIdJenis.Location = New System.Drawing.Point(278, 170)
        Me.TxtIdJenis.Name = "TxtIdJenis"
        Me.TxtIdJenis.Size = New System.Drawing.Size(210, 23)
        Me.TxtIdJenis.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(92, 173)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(89, 15)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "ID Jenis Barang:"
        '
        'EditJenisBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(539, 450)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtNamaJenis)
        Me.Controls.Add(Me.BtnTambah)
        Me.Controls.Add(Me.CbSatuanJenis)
        Me.Controls.Add(Me.TxtIdJenis)
        Me.Controls.Add(Me.Label1)
        Me.Name = "EditJenisBarang"
        Me.Text = "EditJenisBarang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtNamaJenis As TextBox
    Friend WithEvents BtnTambah As Button
    Friend WithEvents CbSatuanJenis As ComboBox
    Friend WithEvents TxtIdJenis As TextBox
    Friend WithEvents Label1 As Label
End Class
