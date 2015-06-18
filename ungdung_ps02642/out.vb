Module out
    Public Sub ExitApp()
        Dim Message As String 'Tạo biến Message.

        'Gán Bảng thông báo cho biến Message.
        Message = MessageBox.Show( _
            "Bạn có chắc muốn thoát ứng dụng ?", _
            "Chú ý !", _
            MessageBoxButtons.YesNo, _
            MessageBoxIcon.Warning) 'Thông báo xác nhận thoát ứng dụng.

        If (Message = Windows.Forms.DialogResult.Yes) Then
            'Nếu người dùng chọn Yes  thì thoát ứng dụng.
            Application.Exit()
        End If 'Đóng cửa sổ ứng dụng.
    End Sub
End Module
