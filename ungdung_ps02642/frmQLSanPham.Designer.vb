<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQLSanPham
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
        Me.txtSoLuong = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtDonGia = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtTenSP = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMaSP = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnthem = New System.Windows.Forms.Button()
        Me.btnsua = New System.Windows.Forms.Button()
        Me.btnxoa = New System.Windows.Forms.Button()
        Me.btnthoat = New System.Windows.Forms.Button()
        Me.txtChiTietSP = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txttimkiem = New System.Windows.Forms.TextBox()
        Me.btntimkiem = New System.Windows.Forms.Button()
        Me.gbdanhsachsanpham = New System.Windows.Forms.GroupBox()
        Me.dgvdanhsachsanpham = New System.Windows.Forms.DataGridView()
        Me.txtMaLoaiSP = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.gbdanhsachsanpham.SuspendLayout()
        CType(Me.dgvdanhsachsanpham, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtSoLuong
        '
        Me.txtSoLuong.Location = New System.Drawing.Point(112, 181)
        Me.txtSoLuong.Name = "txtSoLuong"
        Me.txtSoLuong.Size = New System.Drawing.Size(118, 20)
        Me.txtSoLuong.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 188)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Số lượng"
        '
        'txtDonGia
        '
        Me.txtDonGia.Location = New System.Drawing.Point(112, 143)
        Me.txtDonGia.Name = "txtDonGia"
        Me.txtDonGia.Size = New System.Drawing.Size(118, 20)
        Me.txtDonGia.TabIndex = 17
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(21, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(44, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Đơn giá"
        '
        'txtTenSP
        '
        Me.txtTenSP.Location = New System.Drawing.Point(112, 106)
        Me.txtTenSP.Name = "txtTenSP"
        Me.txtTenSP.Size = New System.Drawing.Size(194, 20)
        Me.txtTenSP.TabIndex = 15
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(21, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "Tên sản phẩm"
        '
        'txtMaSP
        '
        Me.txtMaSP.Location = New System.Drawing.Point(112, 71)
        Me.txtMaSP.Name = "txtMaSP"
        Me.txtMaSP.Size = New System.Drawing.Size(118, 20)
        Me.txtMaSP.TabIndex = 13
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label2.Location = New System.Drawing.Point(120, 28)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(260, 25)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "THÔNG TIN SẢN PHẨM"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 13)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Mã sản phẩm"
        '
        'btnthem
        '
        Me.btnthem.Location = New System.Drawing.Point(511, 132)
        Me.btnthem.Name = "btnthem"
        Me.btnthem.Size = New System.Drawing.Size(75, 23)
        Me.btnthem.TabIndex = 24
        Me.btnthem.Text = "Thêm"
        Me.btnthem.UseVisualStyleBackColor = True
        '
        'btnsua
        '
        Me.btnsua.Location = New System.Drawing.Point(511, 169)
        Me.btnsua.Name = "btnsua"
        Me.btnsua.Size = New System.Drawing.Size(75, 23)
        Me.btnsua.TabIndex = 25
        Me.btnsua.Text = "Sửa"
        Me.btnsua.UseVisualStyleBackColor = True
        '
        'btnxoa
        '
        Me.btnxoa.Location = New System.Drawing.Point(511, 206)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(75, 23)
        Me.btnxoa.TabIndex = 26
        Me.btnxoa.Text = "Xóa"
        Me.btnxoa.UseVisualStyleBackColor = True
        '
        'btnthoat
        '
        Me.btnthoat.Location = New System.Drawing.Point(511, 242)
        Me.btnthoat.Name = "btnthoat"
        Me.btnthoat.Size = New System.Drawing.Size(75, 23)
        Me.btnthoat.TabIndex = 27
        Me.btnthoat.Text = "Thoát"
        Me.btnthoat.UseVisualStyleBackColor = True
        '
        'txtChiTietSP
        '
        Me.txtChiTietSP.Location = New System.Drawing.Point(112, 221)
        Me.txtChiTietSP.Name = "txtChiTietSP"
        Me.txtChiTietSP.Size = New System.Drawing.Size(393, 20)
        Me.txtChiTietSP.TabIndex = 30
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 228)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 13)
        Me.Label6.TabIndex = 29
        Me.Label6.Text = "Chi tiết SP"
        '
        'txttimkiem
        '
        Me.txttimkiem.Location = New System.Drawing.Point(366, 68)
        Me.txttimkiem.Name = "txttimkiem"
        Me.txttimkiem.Size = New System.Drawing.Size(139, 20)
        Me.txttimkiem.TabIndex = 31
        '
        'btntimkiem
        '
        Me.btntimkiem.Location = New System.Drawing.Point(511, 68)
        Me.btntimkiem.Name = "btntimkiem"
        Me.btntimkiem.Size = New System.Drawing.Size(75, 23)
        Me.btntimkiem.TabIndex = 32
        Me.btntimkiem.Text = "Tìm kiếm"
        Me.btntimkiem.UseVisualStyleBackColor = True
        '
        'gbdanhsachsanpham
        '
        Me.gbdanhsachsanpham.Controls.Add(Me.dgvdanhsachsanpham)
        Me.gbdanhsachsanpham.Location = New System.Drawing.Point(24, 305)
        Me.gbdanhsachsanpham.Name = "gbdanhsachsanpham"
        Me.gbdanhsachsanpham.Size = New System.Drawing.Size(582, 222)
        Me.gbdanhsachsanpham.TabIndex = 33
        Me.gbdanhsachsanpham.TabStop = False
        Me.gbdanhsachsanpham.Text = "Danh sách sản phẩm"
        '
        'dgvdanhsachsanpham
        '
        Me.dgvdanhsachsanpham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdanhsachsanpham.Location = New System.Drawing.Point(4, 19)
        Me.dgvdanhsachsanpham.Name = "dgvdanhsachsanpham"
        Me.dgvdanhsachsanpham.Size = New System.Drawing.Size(572, 193)
        Me.dgvdanhsachsanpham.TabIndex = 29
        '
        'txtMaLoaiSP
        '
        Me.txtMaLoaiSP.Location = New System.Drawing.Point(112, 259)
        Me.txtMaLoaiSP.Name = "txtMaLoaiSP"
        Me.txtMaLoaiSP.Size = New System.Drawing.Size(118, 20)
        Me.txtMaLoaiSP.TabIndex = 35
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(21, 266)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 13)
        Me.Label7.TabIndex = 34
        Me.Label7.Text = "Mã loại SP"
        '
        'frmQLSanPham
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(618, 529)
        Me.Controls.Add(Me.txtMaLoaiSP)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.gbdanhsachsanpham)
        Me.Controls.Add(Me.btntimkiem)
        Me.Controls.Add(Me.txttimkiem)
        Me.Controls.Add(Me.txtChiTietSP)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.btnthoat)
        Me.Controls.Add(Me.btnxoa)
        Me.Controls.Add(Me.btnsua)
        Me.Controls.Add(Me.btnthem)
        Me.Controls.Add(Me.txtSoLuong)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtDonGia)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtTenSP)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txtMaSP)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmQLSanPham"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quản lý sản phẩm"
        Me.gbdanhsachsanpham.ResumeLayout(False)
        CType(Me.dgvdanhsachsanpham, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtSoLuong As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtDonGia As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtTenSP As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtMaSP As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnthem As System.Windows.Forms.Button
    Friend WithEvents btnsua As System.Windows.Forms.Button
    Friend WithEvents btnxoa As System.Windows.Forms.Button
    Friend WithEvents btnthoat As System.Windows.Forms.Button
    Friend WithEvents txtChiTietSP As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txttimkiem As System.Windows.Forms.TextBox
    Friend WithEvents btntimkiem As System.Windows.Forms.Button
    Friend WithEvents gbdanhsachsanpham As System.Windows.Forms.GroupBox
    Friend WithEvents dgvdanhsachsanpham As System.Windows.Forms.DataGridView
    Friend WithEvents txtMaLoaiSP As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
End Class
