<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HapusJenisBarang
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
        Me.BtnCloseHapus = New System.Windows.Forms.Button()
        Me.BtnHapusJenis = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LblHapus = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BtnCloseHapus
        '
        Me.BtnCloseHapus.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnCloseHapus.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnCloseHapus.Location = New System.Drawing.Point(419, 303)
        Me.BtnCloseHapus.Name = "BtnCloseHapus"
        Me.BtnCloseHapus.Size = New System.Drawing.Size(75, 23)
        Me.BtnCloseHapus.TabIndex = 7
        Me.BtnCloseHapus.Text = "Close"
        Me.BtnCloseHapus.UseVisualStyleBackColor = True
        '
        'BtnHapusJenis
        '
        Me.BtnHapusJenis.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.BtnHapusJenis.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.BtnHapusJenis.Location = New System.Drawing.Point(226, 223)
        Me.BtnHapusJenis.Name = "BtnHapusJenis"
        Me.BtnHapusJenis.Size = New System.Drawing.Size(75, 23)
        Me.BtnHapusJenis.TabIndex = 6
        Me.BtnHapusJenis.Text = "Hapus"
        Me.BtnHapusJenis.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Cambria", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(61, 116)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(424, 17)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "APAKAH ANDA YAKIN INGIN MENGHAPUS JENIS BARANG INI?"
        '
        'LblHapus
        '
        Me.LblHapus.AutoSize = True
        Me.LblHapus.Font = New System.Drawing.Font("Calibri", 20.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LblHapus.Location = New System.Drawing.Point(250, 158)
        Me.LblHapus.Name = "LblHapus"
        Me.LblHapus.Size = New System.Drawing.Size(31, 33)
        Me.LblHapus.TabIndex = 8
        Me.LblHapus.Text = "A"
        '
        'HapusJenisBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(530, 338)
        Me.Controls.Add(Me.LblHapus)
        Me.Controls.Add(Me.BtnCloseHapus)
        Me.Controls.Add(Me.BtnHapusJenis)
        Me.Controls.Add(Me.Label1)
        Me.Name = "HapusJenisBarang"
        Me.Text = "HapusJenisBarang"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BtnCloseHapus As Button
    Friend WithEvents BtnHapusJenis As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents LblHapus As Label
End Class
