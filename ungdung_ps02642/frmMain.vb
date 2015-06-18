Public Class frmMain

    Private Sub ĐổiMậtKhẩuToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ĐổiMậtKhẩuToolStripMenuItem.Click
        ExitApp()
    End Sub
    Private Sub QuảnLíToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLíToolStripMenuItem.Click
        frmQLNhanVien.ShowDialog()
    End Sub

    Private Sub QuảnLíKháchHàngToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLíKháchHàngToolStripMenuItem.Click
        frmQLKhachHang.ShowDialog()
    End Sub

    Private Sub QuảnLýHóaĐơnToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýHóaĐơnToolStripMenuItem.Click
        frmLoaiSP.ShowDialog()
    End Sub

    Private Sub QuảnLýSảnPhẩmToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles QuảnLýSảnPhẩmToolStripMenuItem.Click
        frmQLSanPham.ShowDialog()
    End Sub

    Private Sub QuảnLýHóaĐơnToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles QuảnLýHóaĐơnToolStripMenuItem1.Click
        frmHoaDon.ShowDialog()
    End Sub

    Private Sub ĐăngNhậpLạiToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ĐăngNhậpLạiToolStripMenuItem.Click
        frmLogin.ShowDialog()
    End Sub
End Class