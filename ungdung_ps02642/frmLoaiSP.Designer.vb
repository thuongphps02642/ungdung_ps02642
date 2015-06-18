<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoaiSP
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMaLoaiSP = New System.Windows.Forms.TextBox()
        Me.txtTenLoaiSP = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnthem = New System.Windows.Forms.Button()
        Me.btnSua = New System.Windows.Forms.Button()
        Me.btnxoa = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvdanhsachloaisp = New System.Windows.Forms.DataGridView()
        Me.btntimkiem = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txttimkiem = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvdanhsachloaisp, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label1.Location = New System.Drawing.Point(170, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(188, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LOẠI SẢN PHẨM"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(42, 97)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Mã loại SP"
        '
        'txtMaLoaiSP
        '
        Me.txtMaLoaiSP.Location = New System.Drawing.Point(116, 97)
        Me.txtMaLoaiSP.Name = "txtMaLoaiSP"
        Me.txtMaLoaiSP.Size = New System.Drawing.Size(149, 20)
        Me.txtMaLoaiSP.TabIndex = 2
        '
        'txtTenLoaiSP
        '
        Me.txtTenLoaiSP.Location = New System.Drawing.Point(116, 132)
        Me.txtTenLoaiSP.Name = "txtTenLoaiSP"
        Me.txtTenLoaiSP.Size = New System.Drawing.Size(149, 20)
        Me.txtTenLoaiSP.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(42, 132)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Tên loại SP"
        '
        'btnthem
        '
        Me.btnthem.Location = New System.Drawing.Point(360, 92)
        Me.btnthem.Name = "btnthem"
        Me.btnthem.Size = New System.Drawing.Size(75, 23)
        Me.btnthem.TabIndex = 5
        Me.btnthem.Text = "Thêm"
        Me.btnthem.UseVisualStyleBackColor = True
        '
        'btnSua
        '
        Me.btnSua.Location = New System.Drawing.Point(360, 132)
        Me.btnSua.Name = "btnSua"
        Me.btnSua.Size = New System.Drawing.Size(75, 23)
        Me.btnSua.TabIndex = 6
        Me.btnSua.Text = "Sửa"
        Me.btnSua.UseVisualStyleBackColor = True
        '
        'btnxoa
        '
        Me.btnxoa.AllowDrop = True
        Me.btnxoa.Location = New System.Drawing.Point(360, 170)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(75, 23)
        Me.btnxoa.TabIndex = 7
        Me.btnxoa.Text = "Xóa"
        Me.btnxoa.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvdanhsachloaisp)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 228)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(534, 275)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Danh sách loại sản phẩm"
        '
        'dgvdanhsachloaisp
        '
        Me.dgvdanhsachloaisp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdanhsachloaisp.Location = New System.Drawing.Point(6, 19)
        Me.dgvdanhsachloaisp.Name = "dgvdanhsachloaisp"
        Me.dgvdanhsachloaisp.Size = New System.Drawing.Size(522, 250)
        Me.dgvdanhsachloaisp.TabIndex = 0
        '
        'btntimkiem
        '
        Me.btntimkiem.Location = New System.Drawing.Point(475, 20)
        Me.btntimkiem.Name = "btntimkiem"
        Me.btntimkiem.Size = New System.Drawing.Size(81, 27)
        Me.btntimkiem.TabIndex = 9
        Me.btntimkiem.Text = "Tìm kiếm"
        Me.btntimkiem.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(330, 17)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 10
        '
        'txttimkiem
        '
        Me.txttimkiem.Location = New System.Drawing.Point(336, 20)
        Me.txttimkiem.Name = "txttimkiem"
        Me.txttimkiem.Size = New System.Drawing.Size(133, 20)
        Me.txttimkiem.TabIndex = 11
        '
        'frmLoaiSP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(559, 515)
        Me.Controls.Add(Me.txttimkiem)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btntimkiem)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnxoa)
        Me.Controls.Add(Me.btnSua)
        Me.Controls.Add(Me.btnthem)
        Me.Controls.Add(Me.txtTenLoaiSP)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtMaLoaiSP)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmLoaiSP"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Loại sản phẩm"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvdanhsachloaisp, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtMaLoaiSP As System.Windows.Forms.TextBox
    Friend WithEvents txtTenLoaiSP As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnthem As System.Windows.Forms.Button
    Friend WithEvents btnSua As System.Windows.Forms.Button
    Friend WithEvents btnxoa As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dgvdanhsachloaisp As System.Windows.Forms.DataGridView
    Friend WithEvents btntimkiem As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txttimkiem As System.Windows.Forms.TextBox
End Class
