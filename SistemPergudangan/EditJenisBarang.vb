﻿Public Class EditJenisBarang
    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        JenisBarang.JenisBarang.GSIdJenis = Integer.Parse(TxtIdJenis.Text)
        JenisBarang.JenisBarang.GSNamaJenis = TxtNamaJenis.Text.ToString()
        JenisBarang.JenisBarang.GSSatuanJenis = CbSatuanJenis.SelectedItem().ToString()
    End Sub
End Class