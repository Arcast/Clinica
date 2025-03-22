<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditarUsuario
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
        btnCancelar = New Button()
        frmLimpiar = New Button()
        txtUsuario = New TextBox()
        btnIngresar = New Button()
        Label2 = New Label()
        Label1 = New Label()
        dgvMostrarUsuarior = New DataGridView()
        txtIdUsuario = New TextBox()
        Label5 = New Label()
        Label3 = New Label()
        Label4 = New Label()
        txtContraseña = New MaskedTextBox()
        txtConfirmarContrasena = New MaskedTextBox()
        CType(dgvMostrarUsuarior, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnCancelar
        ' 
        btnCancelar.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCancelar.Location = New Point(149, 515)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(102, 45)
        btnCancelar.TabIndex = 25
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = True
        ' 
        ' frmLimpiar
        ' 
        frmLimpiar.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        frmLimpiar.Location = New Point(257, 515)
        frmLimpiar.Name = "frmLimpiar"
        frmLimpiar.Size = New Size(102, 45)
        frmLimpiar.TabIndex = 24
        frmLimpiar.Text = "Limpiar"
        frmLimpiar.UseVisualStyleBackColor = True
        ' 
        ' txtUsuario
        ' 
        txtUsuario.Enabled = False
        txtUsuario.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUsuario.Location = New Point(275, 354)
        txtUsuario.Name = "txtUsuario"
        txtUsuario.Size = New Size(192, 34)
        txtUsuario.TabIndex = 19
        ' 
        ' btnIngresar
        ' 
        btnIngresar.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnIngresar.Location = New Point(365, 515)
        btnIngresar.Name = "btnIngresar"
        btnIngresar.Size = New Size(102, 45)
        btnIngresar.TabIndex = 22
        btnIngresar.Text = "Editar"
        btnIngresar.UseVisualStyleBackColor = True
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(43, 357)
        Label2.Name = "Label2"
        Label2.Size = New Size(79, 28)
        Label2.TabIndex = 17
        Label2.Text = "Usuario"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(136, 21)
        Label1.Name = "Label1"
        Label1.Size = New Size(211, 31)
        Label1.TabIndex = 16
        Label1.Text = "Listado de usuarios"
        ' 
        ' dgvMostrarUsuarior
        ' 
        dgvMostrarUsuarior.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMostrarUsuarior.Location = New Point(40, 76)
        dgvMostrarUsuarior.Name = "dgvMostrarUsuarior"
        dgvMostrarUsuarior.RowHeadersWidth = 51
        dgvMostrarUsuarior.Size = New Size(441, 204)
        dgvMostrarUsuarior.TabIndex = 26
        ' 
        ' txtIdUsuario
        ' 
        txtIdUsuario.Enabled = False
        txtIdUsuario.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtIdUsuario.Location = New Point(275, 300)
        txtIdUsuario.Name = "txtIdUsuario"
        txtIdUsuario.Size = New Size(192, 34)
        txtIdUsuario.TabIndex = 28
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(43, 303)
        Label5.Name = "Label5"
        Label5.Size = New Size(29, 28)
        Label5.TabIndex = 27
        Label5.Text = "Id"
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(43, 460)
        Label3.Name = "Label3"
        Label3.Size = New Size(110, 28)
        Label3.TabIndex = 30
        Label3.Text = "Contraseña"
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(43, 409)
        Label4.Name = "Label4"
        Label4.Size = New Size(79, 28)
        Label4.TabIndex = 29
        Label4.Text = "Usuario"
        ' 
        ' txtContraseña
        ' 
        txtContraseña.Location = New Point(275, 413)
        txtContraseña.Name = "txtContraseña"
        txtContraseña.PasswordChar = "*"c
        txtContraseña.Size = New Size(192, 27)
        txtContraseña.TabIndex = 31
        ' 
        ' txtConfirmarContrasena
        ' 
        txtConfirmarContrasena.Location = New Point(275, 461)
        txtConfirmarContrasena.Name = "txtConfirmarContrasena"
        txtConfirmarContrasena.PasswordChar = "*"c
        txtConfirmarContrasena.Size = New Size(192, 27)
        txtConfirmarContrasena.TabIndex = 32
        ' 
        ' frmEditarUsuario
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(519, 574)
        Controls.Add(txtConfirmarContrasena)
        Controls.Add(txtContraseña)
        Controls.Add(Label3)
        Controls.Add(Label4)
        Controls.Add(txtIdUsuario)
        Controls.Add(Label5)
        Controls.Add(dgvMostrarUsuarior)
        Controls.Add(btnCancelar)
        Controls.Add(frmLimpiar)
        Controls.Add(txtUsuario)
        Controls.Add(btnIngresar)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Name = "frmEditarUsuario"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Cambiar contraseña"
        CType(dgvMostrarUsuarior, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents btnCancelar As Button
    Friend WithEvents frmLimpiar As Button
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents btnIngresar As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvMostrarUsuarior As DataGridView
    Friend WithEvents txtIdUsuario As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtContraseña As MaskedTextBox
    Friend WithEvents txtConfirmarContrasena As MaskedTextBox
End Class
