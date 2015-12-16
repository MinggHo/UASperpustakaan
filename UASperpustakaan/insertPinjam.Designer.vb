<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class insertPinjam
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
        Me.tb_kodepinjam = New System.Windows.Forms.TextBox()
        Me.tb_kodebuku = New System.Windows.Forms.TextBox()
        Me.tb_noinduk = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.dgPinjam = New System.Windows.Forms.DataGridView()
        Me.dt_pinjam = New System.Windows.Forms.DateTimePicker()
        Me.dt_hkembali = New System.Windows.Forms.DateTimePicker()
        Me.dt_kembali = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgPinjam, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tb_kodepinjam
        '
        Me.tb_kodepinjam.Location = New System.Drawing.Point(146, 19)
        Me.tb_kodepinjam.Name = "tb_kodepinjam"
        Me.tb_kodepinjam.Size = New System.Drawing.Size(100, 20)
        Me.tb_kodepinjam.TabIndex = 0
        '
        'tb_kodebuku
        '
        Me.tb_kodebuku.Location = New System.Drawing.Point(146, 54)
        Me.tb_kodebuku.Name = "tb_kodebuku"
        Me.tb_kodebuku.Size = New System.Drawing.Size(100, 20)
        Me.tb_kodebuku.TabIndex = 1
        '
        'tb_noinduk
        '
        Me.tb_noinduk.Location = New System.Drawing.Point(146, 92)
        Me.tb_noinduk.Name = "tb_noinduk"
        Me.tb_noinduk.Size = New System.Drawing.Size(100, 20)
        Me.tb_noinduk.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(62, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Kode Pinjaman"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(62, 57)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Kode Buku"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(62, 95)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "No Induk"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(16, 26)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Tanggal Pinjam"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 56)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(117, 13)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Tanggal Harus Kembali"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(16, 89)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 13)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "Tanggal Kembali"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dt_kembali)
        Me.GroupBox1.Controls.Add(Me.dt_hkembali)
        Me.GroupBox1.Controls.Add(Me.dt_pinjam)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(280, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(254, 145)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tanggal"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button1)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.tb_kodepinjam)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.tb_kodebuku)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.tb_noinduk)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(252, 147)
        Me.GroupBox2.TabIndex = 10
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Info Buku"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(171, 118)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'dgPinjam
        '
        Me.dgPinjam.BackgroundColor = System.Drawing.Color.Firebrick
        Me.dgPinjam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgPinjam.Location = New System.Drawing.Point(12, 173)
        Me.dgPinjam.Name = "dgPinjam"
        Me.dgPinjam.Size = New System.Drawing.Size(522, 150)
        Me.dgPinjam.TabIndex = 11
        '
        'dt_pinjam
        '
        Me.dt_pinjam.CustomFormat = "yyyy/MM/dd"
        Me.dt_pinjam.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt_pinjam.Location = New System.Drawing.Point(155, 20)
        Me.dt_pinjam.Name = "dt_pinjam"
        Me.dt_pinjam.Size = New System.Drawing.Size(93, 20)
        Me.dt_pinjam.TabIndex = 13
        Me.dt_pinjam.Value = New Date(2015, 1, 18, 0, 0, 0, 0)
        '
        'dt_hkembali
        '
        Me.dt_hkembali.CustomFormat = "yyyy/MM/dd"
        Me.dt_hkembali.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt_hkembali.Location = New System.Drawing.Point(155, 51)
        Me.dt_hkembali.Name = "dt_hkembali"
        Me.dt_hkembali.Size = New System.Drawing.Size(93, 20)
        Me.dt_hkembali.TabIndex = 14
        '
        'dt_kembali
        '
        Me.dt_kembali.CustomFormat = "yyyy/MM/dd"
        Me.dt_kembali.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dt_kembali.Location = New System.Drawing.Point(155, 83)
        Me.dt_kembali.Name = "dt_kembali"
        Me.dt_kembali.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.dt_kembali.Size = New System.Drawing.Size(93, 20)
        Me.dt_kembali.TabIndex = 15
        Me.dt_kembali.Value = New Date(2015, 11, 16, 15, 22, 0, 0)
        '
        'insertPinjam
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(546, 335)
        Me.Controls.Add(Me.dgPinjam)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "insertPinjam"
        Me.Text = "insertPinjam"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgPinjam, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents dgPinjam As System.Windows.Forms.DataGridView
    Public WithEvents dt_kembali As System.Windows.Forms.DateTimePicker
    Public WithEvents dt_hkembali As System.Windows.Forms.DateTimePicker
    Public WithEvents dt_pinjam As System.Windows.Forms.DateTimePicker
    Public WithEvents tb_kodepinjam As System.Windows.Forms.TextBox
    Public WithEvents tb_kodebuku As System.Windows.Forms.TextBox
    Public WithEvents tb_noinduk As System.Windows.Forms.TextBox
End Class
