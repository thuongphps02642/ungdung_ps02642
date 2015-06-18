Imports System.Data.SqlClient


Public Class frmLogin

    Private Sub btnthoat_Click(sender As Object, e As EventArgs) Handles btnthoat.Click
        Me.Close()
    End Sub

    Private Sub btndangnhap_Click(sender As Object, e As EventArgs) Handles btndangnhap.Click
        Dim chuoiketnoi As String = "workstation id=PS02642.mssql.somee.com;packet size=4096;user id=thuongphps02642_SQLLogin_1;pwd=49t1i8qtru;data source=PS02642.mssql.somee.com;persist security info=False;initial catalog=PS02642"

        Dim KetNoi As SqlConnection = New SqlConnection(chuoiketnoi)
        Dim sqlAdapter As New SqlDataAdapter("select * from NHANVIEN_PS02642 where MaNhanVien='" & txttaikhoan.Text & "' and Password='" & txtmatkhau.Text & "' ", KetNoi)
        Dim tb As New DataTable

        Try
            KetNoi.Open()
            sqlAdapter.Fill(tb)
            If tb.Rows.Count > 0 Then
                MessageBox.Show("Đăng nhập thành công")
                frmMain.Show()
                Me.Hide()
            Else
                MessageBox.Show("Sai tên đăng nhập hoặc Mật khẩu")
            End If

        Catch ex As Exception

        End Try
    End Sub

End Class