Imports System.Data.SqlClient
Imports System.Data
Public Class insertPinjam


    Private Sub insertPinjam_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call koneksi()
        Call tampilkan()
       
    End Sub

    Sub tampilkan()
        Call koneksi()
        DA = New SqlDataAdapter("SELECT * FROM pinjam", CONN)
        DS = New DataSet
        DA.Fill(DS, "pinjam")
        dgPinjam.DataSource = DS.Tables("pinjam")
        dgPinjam.ReadOnly = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Call koneksi()

        Dim Simpan As String = "insert into pinjam values('" & tb_kodepinjam.Text & "','" & dt_pinjam.Text & "','" & dt_hkembali.Text & "','" & dt_kembali.Text & "','" & tb_noinduk.Text & "','" & tb_kodebuku.Text & "')"
        CMD = New SqlCommand(Simpan, CONN)
        CMD.ExecuteNonQuery()
        MessageBox.Show(" Data Berhasil Di Simpan ", "INFO", MessageBoxButtons.OK,
        MessageBoxIcon.Information)

        Call tampilkan()
    End Sub
End Class