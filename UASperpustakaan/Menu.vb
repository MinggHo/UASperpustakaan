Public Class Transaksi

    Private Sub Transaksi_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call koneksi()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        report.CrystalReportViewer1.SelectionFormula = ""
        report.CrystalReportViewer1.RefreshReport()
        report.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'historipinjaman.CrystalReportViewer1.SelectionFormula = "{Pinjam.Tgl_pinjam} = CDate('" & DateTimePicker1.Value & "')"
        historipinjaman.CrystalReportViewer1.SelectionFormula = "{Pinjam.Tgl_pinjam} = ('" & Format(DateTimePicker1.Value, "yyyy-MM-dd") & "')"


        historipinjaman.CrystalReportViewer1.RefreshReport()
        historipinjaman.Show()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        insertPinjam.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        historipinjaman.CrystalReportViewer1.SelectionFormula = ""
        historipinjaman.CrystalReportViewer1.RefreshReport()
        historipinjaman.Show()
    End Sub
End Class
