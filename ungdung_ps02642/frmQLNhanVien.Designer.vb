<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmQLNhanVien
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
        Me.btntimkiem = New System.Windows.Forms.Button()
        Me.txttimkiem = New System.Windows.Forms.TextBox()
        Me.gbthongtinthanhvien = New System.Windows.Forms.GroupBox()
        Me.btnthoat = New System.Windows.Forms.Button()
        Me.txtmanhanvien = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnxoa = New System.Windows.Forms.Button()
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.btnsua = New System.Windows.Forms.Button()
        Me.txttennhanvien = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.btnthem = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.gbdanhsachthanhvien = New System.Windows.Forms.GroupBox()
        Me.dgvdanhsachthanhvien = New System.Windows.Forms.DataGridView()
        Me.gbthongtinthanhvien.SuspendLayout()
        Me.gbdanhsachthanhvien.SuspendLayout()
        CType(Me.dgvdanhsachthanhvien, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label1.Location = New System.Drawing.Point(126, 55)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(241, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "QUẢN LÝ NHÂN VIÊN"
        '
        'btntimkiem
        '
        Me.btntimkiem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btntimkiem.Location = New System.Drawing.Point(487, 4)
        Me.btntimkiem.Name = "btntimkiem"
        Me.btntimkiem.Size = New System.Drawing.Size(72, 24)
        Me.btntimkiem.TabIndex = 1
        Me.btntimkiem.Text = "Tìm kiếm"
        Me.btntimkiem.UseVisualStyleBackColor = True
        '
        'txttimkiem
        '
        Me.txttimkiem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txttimkiem.Location = New System.Drawing.Point(324, 8)
        Me.txttimkiem.Name = "txttimkiem"
        Me.txttimkiem.Size = New System.Drawing.Size(157, 20)
        Me.txttimkiem.TabIndex = 2
        Me.txttimkiem.Text = "Gõ từ tìm kiếm"
        '
        'gbthongtinthanhvien
        '
        Me.gbthongtinthanhvien.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbthongtinthanhvien.Controls.Add(Me.btnthoat)
        Me.gbthongtinthanhvien.Controls.Add(Me.txtmanhanvien)
        Me.gbthongtinthanhvien.Controls.Add(Me.Label9)
        Me.gbthongtinthanhvien.Controls.Add(Me.btnxoa)
        Me.gbthongtinthanhvien.Controls.Add(Me.txtpassword)
        Me.gbthongtinthanhvien.Controls.Add(Me.btnsua)
        Me.gbthongtinthanhvien.Controls.Add(Me.txttennhanvien)
        Me.gbthongtinthanhvien.Controls.Add(Me.Label7)
        Me.gbthongtinthanhvien.Controls.Add(Me.btnthem)
        Me.gbthongtinthanhvien.Controls.Add(Me.Label8)
        Me.gbthongtinthanhvien.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.gbthongtinthanhvien.Location = New System.Drawing.Point(12, 83)
        Me.gbthongtinthanhvien.Name = "gbthongtinthanhvien"
        Me.gbthongtinthanhvien.Size = New System.Drawing.Size(549, 175)
        Me.gbthongtinthanhvien.TabIndex = 10
        Me.gbthongtinthanhvien.TabStop = False
        Me.gbthongtinthanhvien.Text = "Thông tin"
        '
        'btnthoat
        '
        Me.btnthoat.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnthoat.Location = New System.Drawing.Point(441, 133)
        Me.btnthoat.Name = "btnthoat"
        Me.btnthoat.Size = New System.Drawing.Size(75, 23)
        Me.btnthoat.TabIndex = 21
        Me.btnthoat.Text = "Thoát"
        Me.btnthoat.UseVisualStyleBackColor = True
        '
        'txtmanhanvien
        '
        Me.txtmanhanvien.Location = New System.Drawing.Point(103, 30)
        Me.txtmanhanvien.Name = "txtmanhanvien"
        Me.txtmanhanvien.Size = New System.Drawing.Size(224, 20)
        Me.txtmanhanvien.TabIndex = 11
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(15, 30)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(72, 13)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Mã nhân viên"
        '
        'btnxoa
        '
        Me.btnxoa.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnxoa.Location = New System.Drawing.Point(441, 101)
        Me.btnxoa.Name = "btnxoa"
        Me.btnxoa.Size = New System.Drawing.Size(75, 23)
        Me.btnxoa.TabIndex = 20
        Me.btnxoa.Text = "Xóa"
        Me.btnxoa.UseVisualStyleBackColor = True
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(103, 65)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.Size = New System.Drawing.Size(224, 20)
        Me.txtpassword.TabIndex = 15
        '
        'btnsua
        '
        Me.btnsua.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnsua.Location = New System.Drawing.Point(441, 65)
        Me.btnsua.Name = "btnsua"
        Me.btnsua.Size = New System.Drawing.Size(75, 23)
        Me.btnsua.TabIndex = 19
        Me.btnsua.Text = "Sửa"
        Me.btnsua.UseVisualStyleBackColor = True
        '
        'txttennhanvien
        '
        Me.txttennhanvien.Location = New System.Drawing.Point(103, 101)
        Me.txttennhanvien.Name = "txttennhanvien"
        Me.txttennhanvien.Size = New System.Drawing.Size(224, 20)
        Me.txttennhanvien.TabIndex = 13
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(15, 65)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(76, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Tên nhân viên"
        '
        'btnthem
        '
        Me.btnthem.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
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
        Me.Label8.Location = New System.Drawing.Point(15, 101)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(52, 13)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Mật khẩu"
        '
        'gbdanhsachthanhvien
        '
        Me.gbdanhsachthanhvien.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.gbdanhsachthanhvien.Controls.Add(Me.dgvdanhsachthanhvien)
        Me.gbdanhsachthanhvien.Location = New System.Drawing.Point(12, 268)
        Me.gbdanhsachthanhvien.Name = "gbdanhsachthanhvien"
        Me.gbdanhsachthanhvien.Size = New System.Drawing.Size(549, 249)
        Me.gbdanhsachthanhvien.TabIndex = 11
        Me.gbdanhsachthanhvien.TabStop = False
        Me.gbdanhsachthanhvien.Text = "Danh sách thành viên"
        '
        'dgvdanhsachthanhvien
        '
        Me.dgvdanhsachthanhvien.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.dgvdanhsachthanhvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvdanhsachthanhvien.Location = New System.Drawing.Point(6, 19)
        Me.dgvdanhsachthanhvien.Name = "dgvdanhsachthanhvien"
        Me.dgvdanhsachthanhvien.Size = New System.Drawing.Size(537, 224)
        Me.dgvdanhsachthanhvien.TabIndex = 0
        '
        'frmQLNhanVien
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(567, 529)
        Me.Controls.Add(Me.gbdanhsachthanhvien)
        Me.Controls.Add(Me.gbthongtinthanhvien)
        Me.Controls.Add(Me.txttimkiem)
        Me.Controls.Add(Me.btntimkiem)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmQLNhanVien"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Quản lý nhân viên"
        Me.gbthongtinthanhvien.ResumeLayout(False)
        Me.gbthongtinthanhvien.PerformLayout()
        Me.gbdanhsachthanhvien.ResumeLayout(False)
        CType(Me.dgvdanhsachthanhvien, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btntimkiem As System.Windows.Forms.Button
    Friend WithEvents txttimkiem As System.Windows.Forms.TextBox
    Friend WithEvents gbthongtinthanhvien As System.Windows.Forms.GroupBox
    Friend WithEvents btnthoat As System.Windows.Forms.Button
    Friend WithEvents txtmanhanvien As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btnxoa As System.Windows.Forms.Button
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents btnsua As System.Windows.Forms.Button
    Friend WithEvents txttennhanvien As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnthem As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents gbdanhsachthanhvien As System.Windows.Forms.GroupBox
    Friend WithEvents dgvdanhsachthanhvien As System.Windows.Forms.DataGridView
End Class
