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
        txtInput = New TextBox()
        TextBox2 = New TextBox()
        btnTambah = New Button()
        btnReset = New Button()
        Label1 = New Label()
        Label2 = New Label()
        SuspendLayout()
        ' 
        ' txtInput
        ' 
        txtInput.Location = New Point(280, 165)
        txtInput.Name = "txtInput"
        txtInput.Size = New Size(237, 31)
        txtInput.TabIndex = 0
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(280, 273)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(237, 31)
        TextBox2.TabIndex = 1
        ' 
        ' btnTambah
        ' 
        btnTambah.Location = New Point(280, 218)
        btnTambah.Name = "btnTambah"
        btnTambah.Size = New Size(112, 34)
        btnTambah.TabIndex = 2
        btnTambah.Text = "Tambah"
        btnTambah.UseVisualStyleBackColor = True
        ' 
        ' btnReset
        ' 
        btnReset.Location = New Point(405, 218)
        btnReset.Name = "btnReset"
        btnReset.Size = New Size(112, 34)
        btnReset.TabIndex = 3
        btnReset.Text = "Reset"
        btnReset.UseVisualStyleBackColor = True
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Location = New Point(162, 168)
        Label1.Name = "Label1"
        Label1.Size = New Size(105, 25)
        Label1.TabIndex = 4
        Label1.Text = "IP Semester"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Location = New Point(162, 276)
        Label2.Name = "Label2"
        Label2.Size = New Size(107, 25)
        Label2.TabIndex = 5
        Label2.Text = "IP Kumulatif"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(10F, 25F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(btnReset)
        Controls.Add(btnTambah)
        Controls.Add(TextBox2)
        Controls.Add(txtInput)
        Name = "Form1"
        Text = "IP Kalkulator"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtInput As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents btnTambah As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label

End Class
