<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddOrderBarang
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
        Me.Lblidbrng = New System.Windows.Forms.Label()
        Me.LblTglOrder = New System.Windows.Forms.Label()
        Me.LblJmlhOrder = New System.Windows.Forms.Label()
        Me.LblStatus = New System.Windows.Forms.Label()
        Me.BtnOrder = New System.Windows.Forms.Button()
        Me.DateTimePickerOrder = New System.Windows.Forms.DateTimePicker()
        Me.TextBoxJmlhOrder = New System.Windows.Forms.TextBox()
        Me.GroupBoxStatus = New System.Windows.Forms.GroupBox()
        Me.RadioButton0 = New System.Windows.Forms.RadioButton()
        Me.RadioButton1 = New System.Windows.Forms.RadioButton()
        Me.LblIDBarang = New System.Windows.Forms.Label()
        Me.TextBoxIDBarang = New System.Windows.Forms.TextBox()
        Me.GroupBoxStatus.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(136, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "  "
        '
        'Lblidbrng
        '
        Me.Lblidbrng.AutoSize = True
        Me.Lblidbrng.Location = New System.Drawing.Point(154, 34)
        Me.Lblidbrng.Name = "Lblidbrng"
        Me.Lblidbrng.Size = New System.Drawing.Size(0, 15)
        Me.Lblidbrng.TabIndex = 1
        '
        'LblTglOrder
        '
        Me.LblTglOrder.AutoSize = True
        Me.LblTglOrder.Location = New System.Drawing.Point(154, 79)
        Me.LblTglOrder.Name = "LblTglOrder"
        Me.LblTglOrder.Size = New System.Drawing.Size(81, 15)
        Me.LblTglOrder.TabIndex = 2
        Me.LblTglOrder.Text = "Tanggal Order"
        '
        'LblJmlhOrder
        '
        Me.LblJmlhOrder.AutoSize = True
        Me.LblJmlhOrder.Location = New System.Drawing.Point(154, 130)
        Me.LblJmlhOrder.Name = "LblJmlhOrder"
        Me.LblJmlhOrder.Size = New System.Drawing.Size(78, 15)
        Me.LblJmlhOrder.TabIndex = 3
        Me.LblJmlhOrder.Text = "Jumlah Order"
        '
        'LblStatus
        '
        Me.LblStatus.AutoSize = True
        Me.LblStatus.Location = New System.Drawing.Point(154, 177)
        Me.LblStatus.Name = "LblStatus"
        Me.LblStatus.Size = New System.Drawing.Size(39, 15)
        Me.LblStatus.TabIndex = 4
        Me.LblStatus.Text = "Status"
        '
        'BtnOrder
        '
        Me.BtnOrder.Location = New System.Drawing.Point(301, 292)
        Me.BtnOrder.Name = "BtnOrder"
        Me.BtnOrder.Size = New System.Drawing.Size(75, 23)
        Me.BtnOrder.TabIndex = 5
        Me.BtnOrder.Text = "Order"
        Me.BtnOrder.UseVisualStyleBackColor = True
        '
        'DateTimePickerOrder
        '
        Me.DateTimePickerOrder.Location = New System.Drawing.Point(301, 73)
        Me.DateTimePickerOrder.Name = "DateTimePickerOrder"
        Me.DateTimePickerOrder.Size = New System.Drawing.Size(200, 23)
        Me.DateTimePickerOrder.TabIndex = 6
        '
        'TextBoxJmlhOrder
        '
        Me.TextBoxJmlhOrder.Location = New System.Drawing.Point(301, 122)
        Me.TextBoxJmlhOrder.Name = "TextBoxJmlhOrder"
        Me.TextBoxJmlhOrder.Size = New System.Drawing.Size(200, 23)
        Me.TextBoxJmlhOrder.TabIndex = 8
        '
        'GroupBoxStatus
        '
        Me.GroupBoxStatus.Controls.Add(Me.RadioButton0)
        Me.GroupBoxStatus.Controls.Add(Me.RadioButton1)
        Me.GroupBoxStatus.Location = New System.Drawing.Point(312, 176)
        Me.GroupBoxStatus.Name = "GroupBoxStatus"
        Me.GroupBoxStatus.Size = New System.Drawing.Size(142, 73)
        Me.GroupBoxStatus.TabIndex = 9
        Me.GroupBoxStatus.TabStop = False
        Me.GroupBoxStatus.Text = "status"
        '
        'RadioButton0
        '
        Me.RadioButton0.AutoSize = True
        Me.RadioButton0.Location = New System.Drawing.Point(14, 48)
        Me.RadioButton0.Name = "RadioButton0"
        Me.RadioButton0.Size = New System.Drawing.Size(94, 19)
        Me.RadioButton0.TabIndex = 1
        Me.RadioButton0.TabStop = True
        Me.RadioButton0.Text = "0 (Terpenuhi)"
        Me.RadioButton0.UseVisualStyleBackColor = True
        '
        'RadioButton1
        '
        Me.RadioButton1.AutoSize = True
        Me.RadioButton1.Location = New System.Drawing.Point(14, 23)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(67, 19)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.TabStop = True
        Me.RadioButton1.Text = "1 (Aktif)"
        Me.RadioButton1.UseVisualStyleBackColor = True
        '
        'LblIDBarang
        '
        Me.LblIDBarang.AutoSize = True
        Me.LblIDBarang.Location = New System.Drawing.Point(151, 34)
        Me.LblIDBarang.Name = "LblIDBarang"
        Me.LblIDBarang.Size = New System.Drawing.Size(58, 15)
        Me.LblIDBarang.TabIndex = 10
        Me.LblIDBarang.Text = "ID Barang"
        '
        'TextBoxIDBarang
        '
        Me.TextBoxIDBarang.Location = New System.Drawing.Point(301, 32)
        Me.TextBoxIDBarang.Name = "TextBoxIDBarang"
        Me.TextBoxIDBarang.Size = New System.Drawing.Size(200, 23)
        Me.TextBoxIDBarang.TabIndex = 11
        '
        'AddOrderBarang
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(711, 450)
        Me.Controls.Add(Me.TextBoxIDBarang)
        Me.Controls.Add(Me.LblIDBarang)
        Me.Controls.Add(Me.GroupBoxStatus)
        Me.Controls.Add(Me.TextBoxJmlhOrder)
        Me.Controls.Add(Me.DateTimePickerOrder)
        Me.Controls.Add(Me.BtnOrder)
        Me.Controls.Add(Me.LblStatus)
        Me.Controls.Add(Me.LblJmlhOrder)
        Me.Controls.Add(Me.LblTglOrder)
        Me.Controls.Add(Me.Lblidbrng)
        Me.Controls.Add(Me.Label1)
        Me.Name = "AddOrderBarang"
        Me.Text = "AddOrderBarang"
        Me.GroupBoxStatus.ResumeLayout(False)
        Me.GroupBoxStatus.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Lblidbrng As Label
    Friend WithEvents LblTglOrder As Label
    Friend WithEvents LblJmlhOrder As Label
    Friend WithEvents LblStatus As Label
    Friend WithEvents BtnOrder As Button
    Friend WithEvents DateTimePickerOrder As DateTimePicker
    Friend WithEvents TextBoxJmlhOrder As TextBox
    Friend WithEvents GroupBoxStatus As GroupBox
    Friend WithEvents RadioButton0 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents LblIDBarang As Label
    Friend WithEvents TextBoxIDBarang As TextBox
End Class
