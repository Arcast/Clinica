<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAgregarCliente
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
        Label1 = New Label()
        txtPrimerNombre = New TextBox()
        Label3 = New Label()
        txtSegundoNombre = New TextBox()
        Label4 = New Label()
        txtPrimerApellido = New TextBox()
        Label5 = New Label()
        txtSegundoApellido = New TextBox()
        Label6 = New Label()
        Label2 = New Label()
        Label7 = New Label()
        Label8 = New Label()
        Label9 = New Label()
        txtCedula = New TextBox()
        txtTelefono = New TextBox()
        txtCorreo = New TextBox()
        btnCancelar = New Button()
        frmLimpiar = New Button()
        btnIngresar = New Button()
        txtDireccion = New TextBox()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(272, 24)
        Label1.Name = "Label1"
        Label1.Size = New Size(370, 31)
        Label1.TabIndex = 7
        Label1.Text = "Ingrese los datos del nuevo Cliente"
        ' 
        ' txtPrimerNombre
        ' 
        txtPrimerNombre.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPrimerNombre.Location = New Point(272, 95)
        txtPrimerNombre.Name = "txtPrimerNombre"
        txtPrimerNombre.Size = New Size(234, 34)
        txtPrimerNombre.TabIndex = 14
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(55, 101)
        Label3.Name = "Label3"
        Label3.Size = New Size(160, 28)
        Label3.TabIndex = 13
        Label3.Text = "Primer Nombre *"
        ' 
        ' txtSegundoNombre
        ' 
        txtSegundoNombre.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSegundoNombre.Location = New Point(272, 138)
        txtSegundoNombre.Name = "txtSegundoNombre"
        txtSegundoNombre.Size = New Size(234, 34)
        txtSegundoNombre.TabIndex = 16
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(55, 141)
        Label4.Name = "Label4"
        Label4.Size = New Size(169, 28)
        Label4.TabIndex = 15
        Label4.Text = "Segundo Nombre"
        ' 
        ' txtPrimerApellido
        ' 
        txtPrimerApellido.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPrimerApellido.Location = New Point(272, 180)
        txtPrimerApellido.Name = "txtPrimerApellido"
        txtPrimerApellido.Size = New Size(234, 34)
        txtPrimerApellido.TabIndex = 18
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(55, 180)
        Label5.Name = "Label5"
        Label5.Size = New Size(161, 28)
        Label5.TabIndex = 17
        Label5.Text = "Primer Apellido *"
        ' 
        ' txtSegundoApellido
        ' 
        txtSegundoApellido.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSegundoApellido.Location = New Point(272, 223)
        txtSegundoApellido.Name = "txtSegundoApellido"
        txtSegundoApellido.Size = New Size(234, 34)
        txtSegundoApellido.TabIndex = 20
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(54, 223)
        Label6.Name = "Label6"
        Label6.Size = New Size(170, 28)
        Label6.TabIndex = 19
        Label6.Text = "Segundo Apellido"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(556, 195)
        Label2.Name = "Label2"
        Label2.Size = New Size(94, 28)
        Label2.TabIndex = 21
        Label2.Text = "Dirección"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(55, 263)
        Label7.Name = "Label7"
        Label7.Size = New Size(85, 28)
        Label7.TabIndex = 22
        Label7.Text = "Cédula *"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(556, 98)
        Label8.Name = "Label8"
        Label8.Size = New Size(99, 28)
        Label8.TabIndex = 23
        Label8.Text = "Teléfono *"
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(556, 144)
        Label9.Name = "Label9"
        Label9.Size = New Size(72, 28)
        Label9.TabIndex = 24
        Label9.Text = "Correo"
        ' 
        ' txtCedula
        ' 
        txtCedula.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtCedula.Location = New Point(272, 263)
        txtCedula.Name = "txtCedula"
        txtCedula.Size = New Size(234, 34)
        txtCedula.TabIndex = 26
        ' 
        ' txtTelefono
        ' 
        txtTelefono.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtTelefono.Location = New Point(668, 98)
        txtTelefono.Name = "txtTelefono"
        txtTelefono.Size = New Size(234, 34)
        txtTelefono.TabIndex = 27
        ' 
        ' txtCorreo
        ' 
        txtCorreo.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtCorreo.Location = New Point(668, 144)
        txtCorreo.Name = "txtCorreo"
        txtCorreo.Size = New Size(234, 34)
        txtCorreo.TabIndex = 28
        ' 
        ' btnCancelar
        ' 
        btnCancelar.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCancelar.Location = New Point(584, 328)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(102, 45)
        btnCancelar.TabIndex = 32
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = True
        ' 
        ' frmLimpiar
        ' 
        frmLimpiar.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        frmLimpiar.Location = New Point(692, 328)
        frmLimpiar.Name = "frmLimpiar"
        frmLimpiar.Size = New Size(102, 45)
        frmLimpiar.TabIndex = 31
        frmLimpiar.Text = "Limpiar"
        frmLimpiar.UseVisualStyleBackColor = True
        ' 
        ' btnIngresar
        ' 
        btnIngresar.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnIngresar.Location = New Point(800, 328)
        btnIngresar.Name = "btnIngresar"
        btnIngresar.Size = New Size(102, 45)
        btnIngresar.TabIndex = 30
        btnIngresar.Text = "Agregar"
        btnIngresar.UseVisualStyleBackColor = True
        ' 
        ' txtDireccion
        ' 
        txtDireccion.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtDireccion.Location = New Point(668, 195)
        txtDireccion.Name = "txtDireccion"
        txtDireccion.Size = New Size(234, 34)
        txtDireccion.TabIndex = 33
        ' 
        ' frmAgregarCliente
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(943, 399)
        Controls.Add(txtDireccion)
        Controls.Add(btnCancelar)
        Controls.Add(frmLimpiar)
        Controls.Add(btnIngresar)
        Controls.Add(txtCorreo)
        Controls.Add(txtTelefono)
        Controls.Add(txtCedula)
        Controls.Add(Label9)
        Controls.Add(Label8)
        Controls.Add(Label7)
        Controls.Add(Label2)
        Controls.Add(txtSegundoApellido)
        Controls.Add(Label6)
        Controls.Add(txtPrimerApellido)
        Controls.Add(Label5)
        Controls.Add(txtSegundoNombre)
        Controls.Add(Label4)
        Controls.Add(txtPrimerNombre)
        Controls.Add(Label3)
        Controls.Add(Label1)
        Name = "frmAgregarCliente"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Agregar Cliente"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents txtPrimerNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtSegundoNombre As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPrimerApellido As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSegundoApellido As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents txtCedula As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents btnCancelar As Button
    Friend WithEvents frmLimpiar As Button
    Friend WithEvents btnIngresar As Button
    Friend WithEvents lbxDireccion As ListView
    Friend WithEvents txtDireccion As TextBox
End Class
