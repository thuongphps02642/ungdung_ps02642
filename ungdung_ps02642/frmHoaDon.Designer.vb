<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHoaDon
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
        Me.txttimkiem = New System.Windows.Forms.TextBox()
        Me.btntimkiem = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbthongtinthanhvien = New System.Windows.Forms.GroupBox()
        Me.txtMaKH = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMaNV = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtmahoadon = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnxoa = New System.Windows.Forms.Button()
        Me.txttonghoadon = New System.Windows.Forms.TextBox()
        Me.btnsua = New System.Windows.Forms.Button()
        Me.txtngaylap = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnthem = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.gbdanhsachhoadon = New System.Windows.Forms.GroupBox()
        Me.dgvdanhsachhoadon = New System.Windows.Forms.DataGridView()
        Me.gbthongtinthanhvien.SuspendLayout()
        Me.gbdanhsachhoadon.SuspendLayout()
        CType(Me.dgvdanhsachhoadon, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txttimkiem
        '
        Me.txttimkiem.Location = New System.Drawing.Point(382, 12)
        Me.txttimkiem.Name = "txttimkiem"
        Me.txttimkiem.Size = New System.Drawing.Size(157, 20)
        Me.txttimkiem.TabIndex = 13
        Me.txttimkiem.Text = "Gõ từ tìm kiếm"
        '
        'btntimkiem
        '
        Me.btntimkiem.Location = New System.Drawing.Point(545, 8)
        Me.btntimkiem.Name = "btntimkiem"
        Me.btntimkiem.Size = New System.Drawing.Size(72, 24)
        Me.btntimkiem.TabIndex = 12
        Me.btntimkiem.Text = "Tìm kiếm"
        Me.btntimkiem.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label1.Location = New System.Drawing.Point(185, 44)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(223, 25)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "QUẢN LÝ HÓA ĐƠN"
        '
        'gbthongtinthanhvien
        '
        Me.gbthongtinthanhvien.Controls.Add(Me.txtMaKH)
        Me.gbthongtinthanhvien.Controls.Add(Me.Label3)
        Me.gbthongtinthanhvien.Controls.Add(Me.txtMaNV)
        Me.gbthongtinthanhvien.Controls.Add(Me.Label2)
        Me.gbthongtinthanhvien.Controls.Add(Me.txtmahoadon)
        Me.gbthongtinthanhvien.Controls.Add(Me.Label9)
        Me.gbthongtinthanhvien.Controls.Add(Me.btnxoa)
        Me.gbthongtinthanhvien.Controls.Add(Me.txttonghoadon)
        Me.gbthongtinthanhvien.Controls.Add(Me.btnsua)
        Me.gbthongtinthanhvien.Controls.Add(Me.txtngaylap)
        Me.gbthongtinthanhvien.Controls.Add(Me.Label7)
        Me.gbthongtinthanhvien.Controls.Add(Me.btnthem)
        Me.gbthongtinthanhvien.Controls.Add(Me.Label8)
        Me.gbthongtinthanhvien.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.gbthongtinthanhvien.Location = New System.Drawing.Point(18, 72)
        Me.gbthongtinthanhvien.Name = "gbthongtinthanhvien"
        Me.gbthongtinthanhvien.Size = New System.Drawing.Size(598, 192)
        Me.gbthongtinthanhvien.TabIndex = 14
        Me.gbthongtinthanhvien.TabStop = False
        Me.gbthongtinthanhvien.Text = "Thông tin"
        '
        'txtMaKH
        '
        Me.txtMaKH.Location = New System.Drawing.Point(103, 166)
        Me.txtMaKH.Name = "txtMaKH"
        Me.txtMaKH.Size = New System.Drawing.Size(224, 20)
        Me.txtMaKH.TabIndex = 24
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "Mã khách hàng"
        '
        'txtMaNV
        '
        Me.txtMaNV.Location = New System.Drawing.Point(103, 136)
        Me.txtMaNV.Name = "txtMaNV"
        Me.txtMaNV.Size = New System.Drawing.Size(224, 20)
        Me.txtMaNV.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 136)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(72, 13)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Mã nhân viên"
        '
        'txtmahoadon
        '
        Me.txtmahoadon.Location = New System.Drawing.Point(103, 30)
        Me.txtmahoadon.Name = "txtmahoadon"
        Me.txtmahoadon.Size = New System.Drawing.Size(224, 20)
        Me.txtmahoadon.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 30)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(65, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Mã hóa đơn"
        '
        'btnxoa
        '
        Me.btnxoa.Location = New System.Drawing.Point(441, 101)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(75, 23)
        Me.btnxoa.TabIndex = 20
        Me.btnxoa.Text = "Xóa"
        Me.btnxoa.UseVisualStyleBackColor = True
        '
        'txttonghoadon
        '
        Me.txttonghoadon.Location = New System.Drawing.Point(103, 101)
        Me.txttonghoadon.Name = "txttonghoadon"
        Me.txttonghoadon.Size = New System.Drawing.Size(224, 20)
        Me.txttonghoadon.TabIndex = 15
        '
        'btnsua
        '
        Me.btnsua.Location = New System.Drawing.Point(441, 65)
        Me.btnsua.Name = "btnsua"
        Me.btnsua.Size = New System.Drawing.Size(75, 23)
        Me.btnsua.TabIndex = 19
        Me.btnsua.Text = "Sửa"
        Me.btnsua.UseVisualStyleBackColor = True
        '
        'txtngaylap
        '
        Me.txtngaylap.Location = New System.Drawing.Point(103, 65)
        Me.txtngaylap.Name = "txtngaylap"
        Me.txtngaylap.Size = New System.Drawing.Size(224, 20)
        Me.txtngaylap.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 101)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(75, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Tổng hóa đơn"
        '
        'btnthem
        '
        Me.btnthem.Location = New System.Drawing.Point(441, 30)
        Me.btnthem.Name = "btnthem"
        Me.btnthem.Size = New System.Drawing.Size(75, 23)
        Me.btnthem.TabIndex = 18
        Me.btnthem.Text = "Thêm"
        Me.btnthem.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(15, 65)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Ngày lập"
        '
        'gbdanhsachhoadon
        '
        Me.gbdanhsachhoadon.Controls.Add(Me.dgvdanhsachhoadon)
        Me.gbdanhsachhoadon.Location = New System.Drawing.Point(12, 270)
        Me.gbdanhsachhoadon.Name = "gbdanhsachhoadon"
        Me.gbdanhsachhoadon.Size = New System.Drawing.Size(605, 307)
        Me.gbdanhsachhoadon.TabIndex = 15
        Me.gbdanhsachhoadon.TabStop = False
        Me.gbdanhsachhoadon.Text = "Danh sách hóa đơn"
        '
        'dgvdanhsachhoadon
        '
        Me.dgvdanhsachhoadon.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdanhsachhoadon.Location = New System.Drawing.Point(6, 19)
        Me.dgvdanhsachhoadon.Name = "dgvdanhsachhoadon"
        Me.dgvdanhsachhoadon.Size = New System.Drawing.Size(599, 289)
        Me.dgvdanhsachhoadon.TabIndex = 0
        '
        'frmHoaDon
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(628, 579)
        Me.Controls.Add(Me.gbdanhsachhoadon)
        Me.Controls.Add(Me.gbthongtinthanhvien)
        Me.Controls.Add(Me.txttimkiem)
        Me.Controls.Add(Me.btntimkiem)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmHoaDon"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Hóa đơn"
        Me.gbthongtinthanhvien.ResumeLayout(False)
        Me.gbthongtinthanhvien.PerformLayout()
        Me.gbdanhsachhoadon.ResumeLayout(False)
        CType(Me.dgvdanhsachhoadon, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txttimkiem As System.Windows.Forms.TextBox
    Friend WithEvents btntimkiem As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gbthongtinthanhvien As System.Windows.Forms.GroupBox
    Friend WithEvents txtmahoadon As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnxoa As System.Windows.Forms.Button
    Friend WithEvents txttonghoadon As System.Windows.Forms.TextBox
    Friend WithEvents btnsua As System.Windows.Forms.Button
    Friend WithEvents txtngaylap As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnthem As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents gbdanhsachhoadon As System.Windows.Forms.GroupBox
    Friend WithEvents dgvdanhsachhoadon As System.Windows.Forms.DataGridView
    Friend WithEvents txtMaKH As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtMaNV As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
