﻿Imports System.Data.SqlClient
Imports System.Data.DataTable

Public Class frmLoaiSP
    Dim database As New DataTable ' Tạo đối tượng database để lưu trữ dữ liệu từ Database Online
    'Tạo chuỗi kết nối để kết nối tới Database Online
    Dim chuoiconnect As String = "workstation id=PS02642.mssql.somee.com;packet size=4096;user id=thuongphps02642_SQLLogin_1;pwd=49t1i8qtru;data source=PS02642.mssql.somee.com;persist security info=False;initial catalog=PS02642"
    Private Sub dgvdanhsachloaisp_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvdanhsachloaisp.CellContentClick
        Dim index As Integer = dgvdanhsachloaisp.CurrentCell.RowIndex
        txtMaLoaiSP.Text = dgvdanhsachloaisp.Item(0, index).Value
        txtTenLoaiSP.Text = dgvdanhsachloaisp.Item(1, index).Value
    End Sub

    Private Sub frmLoaiSP_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connect As SqlConnection = New SqlConnection(chuoiconnect) ' Tạo đối tượng kết nối tới DB  Online
        ' Câu truy vấn để get dữ liệu
        Dim Query1 As SqlDataAdapter = New SqlDataAdapter("select * from LOAISP_PS02642", connect)
        'Kết nối mở ra
        If dgvdanhsachloaisp.Rows.Count > 0 Then
            'Nếu có dữ liệu thì xóa database để load lại tránh bị trùng dữ liệu
            database.Clear()
        End If
        connect.Open()
        'Đổ dữ liệu vào đối tượng database
        Query1.Fill(database)
        'Hiển thị dữ liệu ra Datagridview
        dgvdanhsachloaisp.DataSource = database.DefaultView
    End Sub
    Private Sub LoadData()
        Dim connect As SqlConnection = New SqlConnection(chuoiconnect)
        Dim Query1 As SqlDataAdapter = New SqlDataAdapter("select * from LOAISP_PS02642", connect)

        connect.Open()
        Query1.Fill(database)
        dgvdanhsachloaisp.DataSource = database.DefaultView
    End Sub

    Private Sub btnthem_Click(sender As Object, e As EventArgs) Handles btnthem.Click
        ' Tạo đối tượng kết nối
        Dim connect As SqlConnection = New SqlConnection(chuoiconnect)
        'Tạo query câu truy vấn Insert into
        Dim Query2 As String = "insert into LOAISP_PS02642 values (@MaLoaiSP, @TenLoaiSP)"
        'Tạo đối tượng để thực thi câu truy vấn với DB ONline
        Dim ExecuteQuery1 As New SqlCommand(Query2, connect)
        'Kết nối mở ra
        connect.Open()

        Try
            'Truyền giá trị trong các ô textbox cho các biến tương ứng
            ExecuteQuery1.Parameters.AddWithValue("@MaLoaiSP", txtMaLoaiSP.Text)
            ExecuteQuery1.Parameters.AddWithValue("@TenLoaiSP", txtTenLoaiSP.Text)

            'Exucute là ghi dữ liệu vào Database
            ExecuteQuery1.ExecuteNonQuery()
            connect.Close()
            MessageBox.Show("Thêm thành công")
        Catch ex As Exception
            'Nếu thêm không được thì hiển thị thông báo
            MessageBox.Show("Không thêm được!")

        End Try
        'Refresh bang
        Dim Query3 As SqlDataAdapter = New SqlDataAdapter("select * from LOAISP_PS02642", connect)
        database.Clear()

        Query3.Fill(database)
        dgvdanhsachloaisp.DataSource = database.DefaultView
    End Sub

    Private Sub btnSua_Click(sender As Object, e As EventArgs) Handles btnSua.Click
        Dim ketnoi1 As New SqlConnection(chuoiconnect)
        ketnoi1.Open()
        Dim Stradd1 As String = "Update LOAISP_PS02642 Set TenLoaiSP = @TenLoaiSP where MaLoaiSP = @MaLoaiSP"
        Dim com As New SqlCommand(Stradd1, ketnoi1)
        Try
            com.Parameters.AddWithValue("@MaLoaiSP", txtMaLoaiSP.Text)
            com.Parameters.AddWithValue("@TenLoaiSP", txtTenLoaiSP.Text)
            com.ExecuteNonQuery()
            ketnoi1.Close()
            MessageBox.Show("Sửa thành công")
        Catch ex As Exception
            MessageBox.Show("Sửa không thành công")
        End Try
        database.Clear()
        dgvdanhsachloaisp.DataSource = database
        dgvdanhsachloaisp.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub btnxoa_Click(sender As Object, e As EventArgs) Handles btnxoa.Click
        Dim ketnoi As New SqlConnection(chuoiconnect)
        ketnoi.Open()
        Dim xoadl As String = "Delete from LOAISP_PS02642 Where MaLoaiSP = @MaLoaiSP"
        Dim lenh As New SqlCommand(xoadl, ketnoi)
        Try
            lenh.Parameters.AddWithValue("@MaLoaiSP", txtMaLoaiSP.Text)
            lenh.ExecuteNonQuery()
            ketnoi.Close()
        Catch ex As Exception
            MessageBox.Show("Xoá không thành công")
        End Try
        database.Clear()
        dgvdanhsachloaisp.DataSource = database
        dgvdanhsachloaisp.DataSource = Nothing
        LoadData()
    End Sub

    Private Sub btntimkiem_Click(sender As Object, e As EventArgs) Handles btntimkiem.Click
        ' Tạo đối tượng kết nối tới DB Online
        Dim connect As SqlConnection = New SqlConnection(chuoiconnect)
        'Kiểm tra DataGridView đã có dữ liệu chưa
        If dgvdanhsachloaisp.Rows.Count > 0 Then
            'Nếu có dữ liệu thì xóa database để load lại tránh bị trùng dữ liệu
            database.Clear()
        End If
        ' Câu truy vấn để get dữ liệu
        Dim Query1 As SqlDataAdapter = New SqlDataAdapter("Select * from LOAISP_PS02642 Where MaLoaiSP Like N'%" & txttimkiem.Text & "%' or TenLoaiSP Like N'%" & txttimkiem.Text & "%'", connect)
        Try
            connect.Open()
            Query1.Fill(database)
            If database.Rows.Count > 0 Then
                dgvdanhsachloaisp.DataSource = database.DefaultView
            Else
                MessageBox.Show("Không tìm thấy kết quả")
            End If
        Catch ex As Exception
        End Try
    End Sub
End Class