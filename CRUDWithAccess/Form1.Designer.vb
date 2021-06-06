<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.components = New System.ComponentModel.Container()
        Dim NIMLabel As System.Windows.Forms.Label
        Dim NamaLengkapLabel As System.Windows.Forms.Label
        Dim TanggalLahirLabel As System.Windows.Forms.Label
        Dim EmailLabel As System.Windows.Forms.Label
        Dim UniversitasLabel As System.Windows.Forms.Label
        Dim JurusanLabel As System.Windows.Forms.Label
        Dim SemesterLabel As System.Windows.Forms.Label
        Dim StatusLabel As System.Windows.Forms.Label
        Me.DatabaseDataSet = New CRUDWithAccess.databaseDataSet()
        Me.MahasiswaBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.MahasiswaTableAdapter = New CRUDWithAccess.databaseDataSetTableAdapters.mahasiswaTableAdapter()
        Me.TableAdapterManager = New CRUDWithAccess.databaseDataSetTableAdapters.TableAdapterManager()
        Me.NIMTextBox = New System.Windows.Forms.TextBox()
        Me.NamaLengkapTextBox = New System.Windows.Forms.TextBox()
        Me.TanggalLahirDateTimePicker = New System.Windows.Forms.DateTimePicker()
        Me.EmailTextBox = New System.Windows.Forms.TextBox()
        Me.UniversitasTextBox = New System.Windows.Forms.TextBox()
        Me.JurusanTextBox = New System.Windows.Forms.TextBox()
        Me.SemesterTextBox = New System.Windows.Forms.TextBox()
        Me.StatusCheckBox = New System.Windows.Forms.CheckBox()
        Me.MahasiswaDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewCheckBoxColumn1 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.SaveButton = New System.Windows.Forms.Button()
        Me.DeleteButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.MahasiswaBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.MahasiswaBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        NIMLabel = New System.Windows.Forms.Label()
        NamaLengkapLabel = New System.Windows.Forms.Label()
        TanggalLahirLabel = New System.Windows.Forms.Label()
        EmailLabel = New System.Windows.Forms.Label()
        UniversitasLabel = New System.Windows.Forms.Label()
        JurusanLabel = New System.Windows.Forms.Label()
        SemesterLabel = New System.Windows.Forms.Label()
        StatusLabel = New System.Windows.Forms.Label()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MahasiswaBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MahasiswaDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MahasiswaBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MahasiswaBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NIMLabel
        '
        NIMLabel.AutoSize = True
        NIMLabel.Location = New System.Drawing.Point(35, 64)
        NIMLabel.Name = "NIMLabel"
        NIMLabel.Size = New System.Drawing.Size(42, 20)
        NIMLabel.TabIndex = 3
        NIMLabel.Text = "NIM:"
        '
        'NamaLengkapLabel
        '
        NamaLengkapLabel.AutoSize = True
        NamaLengkapLabel.Location = New System.Drawing.Point(35, 96)
        NamaLengkapLabel.Name = "NamaLengkapLabel"
        NamaLengkapLabel.Size = New System.Drawing.Size(121, 20)
        NamaLengkapLabel.TabIndex = 5
        NamaLengkapLabel.Text = "Nama Lengkap:"
        '
        'TanggalLahirLabel
        '
        TanggalLahirLabel.AutoSize = True
        TanggalLahirLabel.Location = New System.Drawing.Point(35, 129)
        TanggalLahirLabel.Name = "TanggalLahirLabel"
        TanggalLahirLabel.Size = New System.Drawing.Size(109, 20)
        TanggalLahirLabel.TabIndex = 7
        TanggalLahirLabel.Text = "Tanggal Lahir:"
        '
        'EmailLabel
        '
        EmailLabel.AutoSize = True
        EmailLabel.Location = New System.Drawing.Point(35, 160)
        EmailLabel.Name = "EmailLabel"
        EmailLabel.Size = New System.Drawing.Size(52, 20)
        EmailLabel.TabIndex = 9
        EmailLabel.Text = "Email:"
        '
        'UniversitasLabel
        '
        UniversitasLabel.AutoSize = True
        UniversitasLabel.Location = New System.Drawing.Point(35, 192)
        UniversitasLabel.Name = "UniversitasLabel"
        UniversitasLabel.Size = New System.Drawing.Size(91, 20)
        UniversitasLabel.TabIndex = 11
        UniversitasLabel.Text = "Universitas:"
        '
        'JurusanLabel
        '
        JurusanLabel.AutoSize = True
        JurusanLabel.Location = New System.Drawing.Point(35, 224)
        JurusanLabel.Name = "JurusanLabel"
        JurusanLabel.Size = New System.Drawing.Size(70, 20)
        JurusanLabel.TabIndex = 13
        JurusanLabel.Text = "Jurusan:"
        '
        'SemesterLabel
        '
        SemesterLabel.AutoSize = True
        SemesterLabel.Location = New System.Drawing.Point(35, 256)
        SemesterLabel.Name = "SemesterLabel"
        SemesterLabel.Size = New System.Drawing.Size(82, 20)
        SemesterLabel.TabIndex = 15
        SemesterLabel.Text = "Semester:"
        '
        'StatusLabel
        '
        StatusLabel.AutoSize = True
        StatusLabel.Location = New System.Drawing.Point(35, 290)
        StatusLabel.Name = "StatusLabel"
        StatusLabel.Size = New System.Drawing.Size(60, 20)
        StatusLabel.TabIndex = 17
        StatusLabel.Text = "Status:"
        '
        'DatabaseDataSet
        '
        Me.DatabaseDataSet.DataSetName = "databaseDataSet"
        Me.DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'MahasiswaBindingSource
        '
        Me.MahasiswaBindingSource.DataMember = "mahasiswa"
        Me.MahasiswaBindingSource.DataSource = Me.DatabaseDataSet
        '
        'MahasiswaTableAdapter
        '
        Me.MahasiswaTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.mahasiswaTableAdapter = Me.MahasiswaTableAdapter
        Me.TableAdapterManager.UpdateOrder = CRUDWithAccess.databaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'NIMTextBox
        '
        Me.NIMTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MahasiswaBindingSource, "NIM", True))
        Me.NIMTextBox.Location = New System.Drawing.Point(162, 61)
        Me.NIMTextBox.Name = "NIMTextBox"
        Me.NIMTextBox.Size = New System.Drawing.Size(343, 26)
        Me.NIMTextBox.TabIndex = 4
        '
        'NamaLengkapTextBox
        '
        Me.NamaLengkapTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MahasiswaBindingSource, "NamaLengkap", True))
        Me.NamaLengkapTextBox.Location = New System.Drawing.Point(162, 93)
        Me.NamaLengkapTextBox.Name = "NamaLengkapTextBox"
        Me.NamaLengkapTextBox.Size = New System.Drawing.Size(343, 26)
        Me.NamaLengkapTextBox.TabIndex = 6
        '
        'TanggalLahirDateTimePicker
        '
        Me.TanggalLahirDateTimePicker.DataBindings.Add(New System.Windows.Forms.Binding("Value", Me.MahasiswaBindingSource, "TanggalLahir", True))
        Me.TanggalLahirDateTimePicker.Location = New System.Drawing.Point(162, 125)
        Me.TanggalLahirDateTimePicker.Name = "TanggalLahirDateTimePicker"
        Me.TanggalLahirDateTimePicker.Size = New System.Drawing.Size(343, 26)
        Me.TanggalLahirDateTimePicker.TabIndex = 8
        '
        'EmailTextBox
        '
        Me.EmailTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MahasiswaBindingSource, "Email", True))
        Me.EmailTextBox.Location = New System.Drawing.Point(162, 157)
        Me.EmailTextBox.Name = "EmailTextBox"
        Me.EmailTextBox.Size = New System.Drawing.Size(343, 26)
        Me.EmailTextBox.TabIndex = 10
        '
        'UniversitasTextBox
        '
        Me.UniversitasTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MahasiswaBindingSource, "Universitas", True))
        Me.UniversitasTextBox.Location = New System.Drawing.Point(162, 189)
        Me.UniversitasTextBox.Name = "UniversitasTextBox"
        Me.UniversitasTextBox.Size = New System.Drawing.Size(343, 26)
        Me.UniversitasTextBox.TabIndex = 12
        '
        'JurusanTextBox
        '
        Me.JurusanTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MahasiswaBindingSource, "Jurusan", True))
        Me.JurusanTextBox.Location = New System.Drawing.Point(162, 221)
        Me.JurusanTextBox.Name = "JurusanTextBox"
        Me.JurusanTextBox.Size = New System.Drawing.Size(343, 26)
        Me.JurusanTextBox.TabIndex = 14
        '
        'SemesterTextBox
        '
        Me.SemesterTextBox.DataBindings.Add(New System.Windows.Forms.Binding("Text", Me.MahasiswaBindingSource, "Semester", True))
        Me.SemesterTextBox.Location = New System.Drawing.Point(162, 253)
        Me.SemesterTextBox.Name = "SemesterTextBox"
        Me.SemesterTextBox.Size = New System.Drawing.Size(343, 26)
        Me.SemesterTextBox.TabIndex = 16
        '
        'StatusCheckBox
        '
        Me.StatusCheckBox.DataBindings.Add(New System.Windows.Forms.Binding("CheckState", Me.MahasiswaBindingSource, "Status", True))
        Me.StatusCheckBox.Location = New System.Drawing.Point(162, 285)
        Me.StatusCheckBox.Name = "StatusCheckBox"
        Me.StatusCheckBox.Size = New System.Drawing.Size(200, 24)
        Me.StatusCheckBox.TabIndex = 18
        Me.StatusCheckBox.Text = "CheckBox1"
        Me.StatusCheckBox.UseVisualStyleBackColor = True
        '
        'MahasiswaDataGridView
        '
        Me.MahasiswaDataGridView.AllowUserToAddRows = False
        Me.MahasiswaDataGridView.AllowUserToDeleteRows = False
        Me.MahasiswaDataGridView.AutoGenerateColumns = False
        Me.MahasiswaDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MahasiswaDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewCheckBoxColumn1})
        Me.MahasiswaDataGridView.DataSource = Me.MahasiswaBindingSource
        Me.MahasiswaDataGridView.Location = New System.Drawing.Point(12, 363)
        Me.MahasiswaDataGridView.Name = "MahasiswaDataGridView"
        Me.MahasiswaDataGridView.ReadOnly = True
        Me.MahasiswaDataGridView.RowHeadersWidth = 62
        Me.MahasiswaDataGridView.RowTemplate.Height = 28
        Me.MahasiswaDataGridView.Size = New System.Drawing.Size(921, 248)
        Me.MahasiswaDataGridView.TabIndex = 19
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.DataGridViewTextBoxColumn1.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.Width = 150
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "NIM"
        Me.DataGridViewTextBoxColumn2.HeaderText = "NIM"
        Me.DataGridViewTextBoxColumn2.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        Me.DataGridViewTextBoxColumn2.Width = 150
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "NamaLengkap"
        Me.DataGridViewTextBoxColumn3.HeaderText = "NamaLengkap"
        Me.DataGridViewTextBoxColumn3.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Width = 150
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "TanggalLahir"
        Me.DataGridViewTextBoxColumn4.HeaderText = "TanggalLahir"
        Me.DataGridViewTextBoxColumn4.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Width = 150
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Email"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Email"
        Me.DataGridViewTextBoxColumn5.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        Me.DataGridViewTextBoxColumn5.Width = 150
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "Universitas"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Universitas"
        Me.DataGridViewTextBoxColumn6.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        Me.DataGridViewTextBoxColumn6.Width = 150
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "Jurusan"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Jurusan"
        Me.DataGridViewTextBoxColumn7.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        Me.DataGridViewTextBoxColumn7.Width = 150
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "Semester"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Semester"
        Me.DataGridViewTextBoxColumn8.MinimumWidth = 8
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        Me.DataGridViewTextBoxColumn8.Width = 150
        '
        'DataGridViewCheckBoxColumn1
        '
        Me.DataGridViewCheckBoxColumn1.DataPropertyName = "Status"
        Me.DataGridViewCheckBoxColumn1.HeaderText = "Status"
        Me.DataGridViewCheckBoxColumn1.MinimumWidth = 8
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.Width = 150
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(599, 32)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(334, 52)
        Me.AddButton.TabIndex = 20
        Me.AddButton.Text = "Tambah Data"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'SaveButton
        '
        Me.SaveButton.Location = New System.Drawing.Point(599, 99)
        Me.SaveButton.Name = "SaveButton"
        Me.SaveButton.Size = New System.Drawing.Size(334, 52)
        Me.SaveButton.TabIndex = 21
        Me.SaveButton.Text = "Simpan Data"
        Me.SaveButton.UseVisualStyleBackColor = True
        '
        'DeleteButton
        '
        Me.DeleteButton.Location = New System.Drawing.Point(599, 163)
        Me.DeleteButton.Name = "DeleteButton"
        Me.DeleteButton.Size = New System.Drawing.Size(334, 52)
        Me.DeleteButton.TabIndex = 22
        Me.DeleteButton.Text = "Hapus Data"
        Me.DeleteButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(599, 240)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(334, 52)
        Me.ExitButton.TabIndex = 23
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'MahasiswaBindingSource1
        '
        Me.MahasiswaBindingSource1.DataMember = "mahasiswa"
        Me.MahasiswaBindingSource1.DataSource = Me.DatabaseDataSet
        '
        'MahasiswaBindingSource2
        '
        Me.MahasiswaBindingSource2.DataMember = "mahasiswa"
        Me.MahasiswaBindingSource2.DataSource = Me.DatabaseDataSet
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 623)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.DeleteButton)
        Me.Controls.Add(Me.SaveButton)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.MahasiswaDataGridView)
        Me.Controls.Add(NIMLabel)
        Me.Controls.Add(Me.NIMTextBox)
        Me.Controls.Add(NamaLengkapLabel)
        Me.Controls.Add(Me.NamaLengkapTextBox)
        Me.Controls.Add(TanggalLahirLabel)
        Me.Controls.Add(Me.TanggalLahirDateTimePicker)
        Me.Controls.Add(EmailLabel)
        Me.Controls.Add(Me.EmailTextBox)
        Me.Controls.Add(UniversitasLabel)
        Me.Controls.Add(Me.UniversitasTextBox)
        Me.Controls.Add(JurusanLabel)
        Me.Controls.Add(Me.JurusanTextBox)
        Me.Controls.Add(SemesterLabel)
        Me.Controls.Add(Me.SemesterTextBox)
        Me.Controls.Add(StatusLabel)
        Me.Controls.Add(Me.StatusCheckBox)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MahasiswaBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MahasiswaDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MahasiswaBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MahasiswaBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DatabaseDataSet As databaseDataSet
    Friend WithEvents MahasiswaBindingSource As BindingSource
    Friend WithEvents MahasiswaTableAdapter As databaseDataSetTableAdapters.mahasiswaTableAdapter
    Friend WithEvents TableAdapterManager As databaseDataSetTableAdapters.TableAdapterManager
    Friend WithEvents NIMTextBox As TextBox
    Friend WithEvents NamaLengkapTextBox As TextBox
    Friend WithEvents TanggalLahirDateTimePicker As DateTimePicker
    Friend WithEvents EmailTextBox As TextBox
    Friend WithEvents UniversitasTextBox As TextBox
    Friend WithEvents JurusanTextBox As TextBox
    Friend WithEvents SemesterTextBox As TextBox
    Friend WithEvents StatusCheckBox As CheckBox
    Friend WithEvents MahasiswaDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents AddButton As Button
    Friend WithEvents SaveButton As Button
    Friend WithEvents DeleteButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents MahasiswaBindingSource2 As BindingSource
    Friend WithEvents MahasiswaBindingSource1 As BindingSource
End Class
