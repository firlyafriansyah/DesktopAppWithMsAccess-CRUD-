Public Class Form1
    Private Sub MahasiswaBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.MahasiswaBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.DatabaseDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'DatabaseDataSet.mahasiswa' table. You can move, or remove it, as needed.
        Me.MahasiswaTableAdapter.Fill(Me.DatabaseDataSet.mahasiswa)

    End Sub

    Private Sub RefreshData()
        Try
            Me.MahasiswaBindingSource.Filter = Nothing
            Me.MahasiswaTableAdapter.Fill(Me.DatabaseDataSet.mahasiswa)
        Catch ex As Exception
            MsgBox("Rerfresh Data Gagal")
        End Try
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        Try
            With AddButton
                If .Text = "Tambah Data" Then
                    MahasiswaBindingSource.AddNew()
                    .Text = "Batal"
                Else
                    RefreshData()
                    .Text = "Tambah Data"
                End If
            End With

            With NIMTextBox
                If (.CanSelect) Then
                    .Text = String.Empty
                    .Select()
                End If
            End With
        Catch ex As Exception
            MsgBox("Error telah terjadi: " & ex.Message.ToString(), MsgBoxStyle.OkOnly Or MsgBoxStyle.Information, "Tambah data gagal.")
        End Try
    End Sub

    Private Sub SaveButton_Click(sender As Object, e As EventArgs) Handles SaveButton.Click
        Try
            Dim result As DialogResult
            result = MessageBox.Show("Apakah kamu yakin akan menyimpan data ini?", "Aplikasi CRUD Keren", MessageBoxButtons.YesNo, MessageBoxIcon.Information)

            If (result = DialogResult.Yes) Then
                Validate()
                MahasiswaBindingSource.EndEdit()
                TableAdapterManager.UpdateAll(Me.DatabaseDataSet)

                MessageBox.Show("Data berhasil disimpan", "Aplikasi CRUD Keren", MessageBoxButtons.OK, MessageBoxIcon.Information)

                RefreshData()

                AddButton.Text = "Tambah Data"
            End If
        Catch ex As Exception
            MessageBox.Show("Save | Data gagal di simpan!" & ex.Message.ToString(), "Aplikasi CRUD Keren", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
        Try
            If MessageBox.Show("Apakah kamu yakin akan menghapus data ini?", "Aplikasi CRUD Keren", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) = Windows.Forms.DialogResult.Yes Then
                MahasiswaBindingSource.RemoveCurrent()
                MahasiswaBindingSource.EndEdit()
                MahasiswaTableAdapter.Update(DatabaseDataSet.mahasiswa)
                RefreshData()
                MessageBox.Show("Data berhasil dihapus", "Aplikasi CRUD Keren", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Else
                Return
            End If
        Catch ex As Exception
            MessageBox.Show("Hapus data gagal: " & ex.Message.ToString(), "Aplikasi CRUD Keren", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class
