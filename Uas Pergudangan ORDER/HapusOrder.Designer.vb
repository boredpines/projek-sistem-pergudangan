<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class HapusOrder
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
        Me.LabelKet = New System.Windows.Forms.Label()
        Me.LabelHapusOrder = New System.Windows.Forms.Label()
        Me.BtnHapus = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'LabelKet
        '
        Me.LabelKet.AutoSize = True
        Me.LabelKet.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelKet.Location = New System.Drawing.Point(97, 42)
        Me.LabelKet.Name = "LabelKet"
        Me.LabelKet.Size = New System.Drawing.Size(416, 19)
        Me.LabelKet.TabIndex = 0
        Me.LabelKet.Text = "APAKAH ANDA YAKIN MENGHAPUS ORDER BARANG"
        '
        'LabelHapusOrder
        '
        Me.LabelHapusOrder.AutoSize = True
        Me.LabelHapusOrder.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LabelHapusOrder.ForeColor = System.Drawing.Color.IndianRed
        Me.LabelHapusOrder.Location = New System.Drawing.Point(244, 105)
        Me.LabelHapusOrder.Name = "LabelHapusOrder"
        Me.LabelHapusOrder.Size = New System.Drawing.Size(93, 45)
        Me.LabelHapusOrder.TabIndex = 1
        Me.LabelHapusOrder.Text = "TEST"
        '
        'BtnHapus
        '
        Me.BtnHapus.Location = New System.Drawing.Point(253, 187)
        Me.BtnHapus.Name = "BtnHapus"
        Me.BtnHapus.Size = New System.Drawing.Size(75, 23)
        Me.BtnHapus.TabIndex = 2
        Me.BtnHapus.Text = "Hapus"
        Me.BtnHapus.UseVisualStyleBackColor = True
        '
        'HapusOrder
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(645, 308)
        Me.Controls.Add(Me.BtnHapus)
        Me.Controls.Add(Me.LabelHapusOrder)
        Me.Controls.Add(Me.LabelKet)
        Me.Name = "HapusOrder"
        Me.Text = "HapusOrder"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelKet As Label
    Friend WithEvents LabelHapusOrder As Label
    Friend WithEvents BtnHapus As Button
End Class
