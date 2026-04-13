<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        txtUID = New TextBox()
        txtUsername = New TextBox()
        txtLevel = New TextBox()
        txtServer = New TextBox()
        txtCari = New TextBox()
        btnSimpan = New Button()
        btnUbah = New Button()
        btnHapus = New Button()
        btnRefresh = New Button()
        dgvData = New DataGridView()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        Label5 = New Label()
        ErrorProvider1 = New ErrorProvider(components)
        CType(dgvData, ComponentModel.ISupportInitialize).BeginInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtUID
        ' 
        txtUID.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        txtUID.Location = New Point(198, 21)
        txtUID.Name = "txtUID"
        txtUID.Size = New Size(357, 31)
        txtUID.TabIndex = 0
        ' 
        ' txtUsername
        ' 
        txtUsername.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        txtUsername.Location = New Point(198, 87)
        txtUsername.Name = "txtUsername"
        txtUsername.Size = New Size(357, 31)
        txtUsername.TabIndex = 1
        ' 
        ' txtLevel
        ' 
        txtLevel.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        txtLevel.Location = New Point(198, 151)
        txtLevel.Name = "txtLevel"
        txtLevel.Size = New Size(357, 31)
        txtLevel.TabIndex = 2
        ' 
        ' txtServer
        ' 
        txtServer.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        txtServer.Location = New Point(198, 216)
        txtServer.Name = "txtServer"
        txtServer.Size = New Size(357, 31)
        txtServer.TabIndex = 3
        ' 
        ' txtCari
        ' 
        txtCari.BackColor = Color.FromArgb(CByte(64), CByte(0), CByte(0))
        txtCari.Location = New Point(198, 291)
        txtCari.Name = "txtCari"
        txtCari.Size = New Size(357, 31)
        txtCari.TabIndex = 4
        ' 
        ' btnSimpan
        ' 
        btnSimpan.BackColor = Color.Gold
        btnSimpan.Location = New Point(198, 375)
        btnSimpan.Name = "btnSimpan"
        btnSimpan.Size = New Size(112, 34)
        btnSimpan.TabIndex = 5
        btnSimpan.Text = "Simpan"
        btnSimpan.UseVisualStyleBackColor = False
        ' 
        ' btnUbah
        ' 
        btnUbah.BackColor = Color.Gold
        btnUbah.Location = New Point(339, 375)
        btnUbah.Name = "btnUbah"
        btnUbah.Size = New Size(112, 34)
        btnUbah.TabIndex = 6
        btnUbah.Text = "Ubah"
        btnUbah.UseVisualStyleBackColor = False
        ' 
        ' btnHapus
        ' 
        btnHapus.BackColor = Color.Gold
        btnHapus.Location = New Point(484, 375)
        btnHapus.Name = "btnHapus"
        btnHapus.Size = New Size(112, 34)
        btnHapus.TabIndex = 7
        btnHapus.Text = "Hapus"
        btnHapus.UseVisualStyleBackColor = False
        ' 
        ' btnRefresh
        ' 
        btnRefresh.BackColor = Color.Gold
        btnRefresh.Location = New Point(623, 375)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.Size = New Size(112, 34)
        btnRefresh.TabIndex = 8
        btnRefresh.Text = "Refresh"
        btnRefresh.UseVisualStyleBackColor = False
        ' 
        ' dgvData
        ' 
        dgvData.BackgroundColor = Color.Brown
        dgvData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvData.Location = New Point(55, 430)
        dgvData.Name = "dgvData"
        dgvData.RowHeadersWidth = 62
        dgvData.Size = New Size(875, 358)
        dgvData.TabIndex = 9
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.ForeColor = Color.Transparent
        Label1.Location = New Point(55, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(42, 25)
        Label1.TabIndex = 10
        Label1.Text = "UID"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.ForeColor = Color.Transparent
        Label2.Location = New Point(55, 87)
        Label2.Name = "Label2"
        Label2.Size = New Size(91, 25)
        Label2.TabIndex = 11
        Label2.Text = "Username"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.ForeColor = Color.Transparent
        Label3.Location = New Point(55, 151)
        Label3.Name = "Label3"
        Label3.Size = New Size(51, 25)
        Label3.TabIndex = 12
        Label3.Text = "Level"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.ForeColor = Color.Transparent
        Label4.Location = New Point(55, 219)
        Label4.Name = "Label4"
        Label4.Size = New Size(61, 25)
        Label4.TabIndex = 13
        Label4.Text = "Server"
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.ForeColor = Color.Transparent
        Label5.Location = New Point(55, 291)
        Label5.Name = "Label5"
        Label5.Size = New Size(89, 25)
        Label5.TabIndex = 14
        Label5.Text = "Searching"
        ' 
        ' ErrorProvider1
        ' 
        ErrorProvider1.ContainerControl = Me
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Teal
        ClientSize = New Size(976, 810)
        Controls.Add(Label5)
        Controls.Add(Label4)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(dgvData)
        Controls.Add(btnRefresh)
        Controls.Add(btnHapus)
        Controls.Add(btnUbah)
        Controls.Add(btnSimpan)
        Controls.Add(txtCari)
        Controls.Add(txtServer)
        Controls.Add(txtLevel)
        Controls.Add(txtUsername)
        Controls.Add(txtUID)
        Name = "Form1"
        Text = "Form1"
        CType(dgvData, ComponentModel.ISupportInitialize).EndInit()
        CType(ErrorProvider1, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtUID As TextBox
    Friend WithEvents txtUsername As TextBox
    Friend WithEvents txtLevel As TextBox
    Friend WithEvents txtServer As TextBox
    Friend WithEvents txtCari As TextBox
    Friend WithEvents btnSimpan As Button
    Friend WithEvents btnUbah As Button
    Friend WithEvents btnHapus As Button
    Friend WithEvents btnRefresh As Button
    Friend WithEvents dgvData As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ErrorProvider1 As ErrorProvider

End Class
