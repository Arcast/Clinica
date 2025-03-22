<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarUsuario
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
        txtContraseña = New TextBox()
        txtUsuario = New TextBox()
        btnIngresar = New Button()
        Label3 = New Label()
        Label2 = New Label()
        Label1 = New Label()
        frmLimpiar = New Button()
        btnCancelar = New Button()
        txtConfirmarContrasena = New TextBox()
        Label4 = New Label()
        SuspendLayout()
        ' 
        ' txtContraseña
        ' 
        txtContraseña.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtContraseña.Location = New Point(254, 136)
        txtContraseña.Name = "txtContraseña"
        txtContraseña.Size = New Size(192, 34)
        txtContraseña.TabIndex = 11
        ' 
        ' txtUsuario
        ' 
        txtUsuario.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtUsuario.Location = New Point(254, 85)
        txtUsuario.Name = "txtUsuario"
        txtUsuario.Size = New Size(192, 34)
        txtUsuario.TabIndex = 10
        ' 
        ' btnIngresar
        ' 
        btnIngresar.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnIngresar.Location = New Point(344, 253)
        btnIngresar.Name = "btnIngresar"
        btnIngresar.Size = New Size(102, 45)
        btnIngresar.TabIndex = 13
        btnIngresar.Text = "Agregar"
        btnIngresar.UseVisualStyleBackColor = True
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(22, 139)
        Label3.Name = "Label3"
        Label3.Size = New Size(110, 28)
        Label3.TabIndex = 8
        Label3.Text = "Contraseña"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(22, 88)
        Label2.Name = "Label2"
        Label2.Size = New Size(79, 28)
        Label2.TabIndex = 7
        Label2.Text = "Usuario"
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(72, 9)
        Label1.Name = "Label1"
        Label1.Size = New Size(374, 31)
        Label1.TabIndex = 6
        Label1.Text = "Ingrese los datos del nuevo usuario"
        ' 
        ' frmLimpiar
        ' 
        frmLimpiar.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        frmLimpiar.Location = New Point(236, 253)
        frmLimpiar.Name = "frmLimpiar"
        frmLimpiar.Size = New Size(102, 45)
        frmLimpiar.TabIndex = 14
        frmLimpiar.Text = "Limpiar"
        frmLimpiar.UseVisualStyleBackColor = True
        ' 
        ' btnCancelar
        ' 
        btnCancelar.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCancelar.Location = New Point(128, 253)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(102, 45)
        btnCancelar.TabIndex = 15
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = True
        ' 
        ' txtConfirmarContrasena
        ' 
        txtConfirmarContrasena.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtConfirmarContrasena.Location = New Point(254, 186)
        txtConfirmarContrasena.Name = "txtConfirmarContrasena"
        txtConfirmarContrasena.Size = New Size(192, 34)
        txtConfirmarContrasena.TabIndex = 12
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(22, 189)
        Label4.Name = "Label4"
        Label4.Size = New Size(188, 28)
        Label4.TabIndex = 14
        Label4.Text = "Cambiar Contraseña"
        ' 
        ' frmAgregarUsuario
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(500, 339)
        Controls.Add(txtConfirmarContrasena)
        Controls.Add(Label4)
        Controls.Add(btnCancelar)
        Controls.Add(frmLimpiar)
        Controls.Add(txtContraseña)
        Controls.Add(txtUsuario)
        Controls.Add(btnIngresar)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmAgregarUsuario"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Agregar Usuario"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtContraseña As TextBox
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents btnIngresar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents frmLimpiar As Button
    Friend WithEvents btnCancelar As Button
    Friend WithEvents txtConfirmarContrasena As TextBox
    Friend WithEvents Label4 As Label
End Class
