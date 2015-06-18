Imports System.Data.SqlClient
Imports System.Data.DataTable
Public Class frmQLSanPham
    Dim database As New DataTable ' Tạo đối tượng database để lưu trữ dữ liệu từ Database Online
    'Tạo chuỗi kết nối để kết nối tới Database Online
    Dim chuoiconnect As String = "workstation id=PS02642.mssql.somee.com;packet size=4096;user id=thuongphps02642_SQLLogin_1;pwd=49t1i8qtru;data source=PS02642.mssql.somee.com;persist security info=False;initial catalog=PS02642"
    Private Sub btnthoat_Click(sender As Object, e As EventArgs) Handles btnthoat.Click
        Me.Close()
    End Sub
    Private Sub frmQLSanPham_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connect As SqlConnection = New SqlConnection(chuoiconnect) ' Tạo đối tượng kết nối tới DB  Online
        ' Câu truy vấn để get dữ liệu
        Dim Query1 As SqlDataAdapter = New SqlDataAdapter("select * from SP_PS02642", connect)
        'Kết nối mở ra
        If dgvdanhsachsanpham.Rows.Count > 0 Then
            'Nếu có dữ liệu thì xóa database để load lại tránh bị trùng dữ liệu
            database.Clear()
        End If
        connect.Open()
        'Đổ dữ liệu vào đối tượng database
        Query1.Fill(database)
        'Hiển thị dữ liệu ra Datagridview
        dgvdanhsachsanpham.DataSource = database.DefaultView
    End Sub
    Private Sub LoadData()
        Dim connect As SqlConnection = New SqlConnection(chuoiconnect)
        Dim Query1 As SqlDataAdapter = New SqlDataAdapter("select * from SP_PS02642", connect)

        connect.Open()
        Query1.Fill(database)
        dgvdanhsachsanpham.DataSource = database.DefaultView
    End Sub

    Private Sub dgvdanhsachsanpham_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvdanhsachsanpham.CellContentClick
        Dim index As Integer = dgvdanhsachsanpham.CurrentCell.RowIndex
        txtMaSP.Text = dgvdanhsachsanpham.Item(0, index).Value
        txtTenSP.Text = dgvdanhsachsanpham.Item(1, index).Value
        txtDonGia.Text = dgvdanhsachsanpham.Item(2, index).Value
        txtSoLuong.Text = dgvdanhsachsanpham.Item(3, index).Value
        txtChiTietSP.Text = dgvdanhsachsanpham.Item(4, index).Value
        txtMaLoaiSP.Text = dgvdanhsachsanpham.Item(5, index).Value
    End Sub

    Private Sub btntimkiem_Click(sender As Object, e As EventArgs) Handles btntimkiem.Click
        ' Tạo đối tượng kết nối tới DB Online
        Dim connect As SqlConnection = New SqlConnection(chuoiconnect)
        'Kiểm tra DataGridView đã có dữ liệu chưa
        If dgvdanhsachsanpham.Rows.Count > 0 Then
            'Nếu có dữ liệu thì xóa database để load lại tránh bị trùng dữ liệu
            database.Clear()
        End If
        ' Câu truy vấn để get dữ liệu
        Dim Query1 As SqlDataAdapter = New SqlDataAdapter("Select * from SP_PS02642 Where MaSP Like N'%" & txttimkiem.Text & "%' or TenSP Like N'%" & txttimkiem.Text & "%' or DonGia Like N'%" & txttimkiem.Text & "%' or SoLuong Like N'%" & txttimkiem.Text & "%' or ChiTietSP Like N'%" & txttimkiem.Text & "%'", connect)
        Try
            connect.Open()
            Query1.Fill(database)
            If database.Rows.Count > 0 Then
                dgvdanhsachsanpham.DataSource = database.DefaultView
            Else
                MessageBox.Show("Không tìm thấy")
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        ' Tạo đối tượng kết nối
        Dim connect As SqlConnection = New SqlConnection(chuoiconnect)
        'Tạo query câu truy vấn Insert into
        Dim Query2 As String = "insert into SP_PS02642 values (@MaSP, @TenSP, @DonGia, @SoLuong, @ChiTietSP, @MaLoaiSP)"
        'Tạo đối tượng để thực thi câu truy vấn với DB Online
        Dim ExecuteQuery1 As New SqlCommand(Query2, connect)
        'Kết nối mở ra
        connect.Open()

        Try
            'Truyền giá trị trong các ô textbox cho các biến tương ứng
            ExecuteQuery1.Parameters.AddWithValue("@MaSP", txtMaSP.Text)
            ExecuteQuery1.Parameters.AddWithValue("@TenSP", txtTenSP.Text)
            ExecuteQuery1.Parameters.AddWithValue("@DonGia", txtDonGia.Text)
            ExecuteQuery1.Parameters.AddWithValue("@SoLuong", txtSoLuong.Text)
            ExecuteQuery1.Parameters.AddWithValue("@ChiTietSP", txtChiTietSP.Text)
            ExecuteQuery1.Parameters.AddWithValue("@MaLoaiSP", txtMaLoaiSP.Text)

            'Exucute là ghi dữ liệu vào Database
            ExecuteQuery1.ExecuteNonQuery()
            connect.Close()
            MessageBox.Show("Thêm thành công")
        Catch ex As Exception
            'Nếu thêm không được thì hiển thị thông báo
            MessageBox.Show("Không thêm được!")

        End Try
        'Refresh bang
        Dim Query3 As SqlDataAdapter = New SqlDataAdapter("select * from SP_PS02642", connect)
        database.Clear()

        Query3.Fill(database)
        dgvdanhsachsanpham.DataSource = database.DefaultView
    End Sub

    Private Sub btnsua_Click(sender As Object, e As EventArgs) Handles btnsua.Click
        Dim ketnoi1 As New SqlConnection(chuoiconnect)
        ketnoi1.Open()
        Dim Stradd1 As String = "Update SP_PS02642 Set TenSP = @TenSP, DonGia = @DonGia, SoLuong = @SoLuong, ChiTietSP = @ChiTietSP where MaSP = @MaSP"
        Dim com As New SqlCommand(Stradd1, ketnoi1)
        Try
            com.Parameters.AddWithValue("@MaSP", txtMaSP.Text)
            com.Parameters.AddWithValue("@TenSP", txtTenSP.Text)
            com.Parameters.AddWithValue("@DonGia", txtDonGia.Text)
            com.Parameters.AddWithValue("@SoLuong", txtSoLuong.Text)
            com.Parameters.AddWithValue("@ChiTietSP", txtChiTietSP.Text)
            com.ExecuteNonQuery()
            ketnoi1.Close()
            MessageBox.Show("Sửa thành công")
        Catch ex As Exception
            MessageBox.Show("Sửa không thành công")
        End Try
        database.Clear()
        dgvdanhsachsanpham.DataSource = database
        dgvdanhsachsanpham.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        Dim ketnoi As New SqlConnection(chuoiconnect)
        ketnoi.Open()
        Dim xoadl As String = "Delete from SP_PS02642 Where MaSP = @MaSP"
        Dim lenh As New SqlCommand(xoadl, ketnoi)
        Try
            lenh.Parameters.AddWithValue("@MaSP", txtMaSP.Text)
            lenh.ExecuteNonQuery()
            ketnoi.Close()
        Catch ex As Exception
            MessageBox.Show("Xoá không thành công")
        End Try
        database.Clear()
        dgvdanhsachsanpham.DataSource = database
        dgvdanhsachsanpham.DataSource = Nothing
        LoadData()
    End Sub
End Class