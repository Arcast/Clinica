<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmEditarCliente
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
        dgvMostrarClientes = New DataGridView()
        Label1 = New Label()
        txtDireccion = New TextBox()
        txtCorreo = New TextBox()
        txtTelefono = New TextBox()
        txtCedula = New TextBox()
        Label9 = New Label()
        Label8 = New Label()
        Label7 = New Label()
        Label2 = New Label()
        txtSegundoApellido = New TextBox()
        Label6 = New Label()
        txtPrimerApellido = New TextBox()
        Label5 = New Label()
        txtSegundoNombre = New TextBox()
        Label4 = New Label()
        txtPrimerNombre = New TextBox()
        Label3 = New Label()
        txtIdCliente = New TextBox()
        Label10 = New Label()
        txtEstado = New TextBox()
        Label11 = New Label()
        btnCancelar = New Button()
        frmLimpiar = New Button()
        btnEditar = New Button()
        CType(dgvMostrarClientes, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgvMostrarClientes
        ' 
        dgvMostrarClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
        dgvMostrarClientes.Location = New Point(12, 74)
        dgvMostrarClientes.Name = "dgvMostrarClientes"
        dgvMostrarClientes.RowHeadersWidth = 51
        dgvMostrarClientes.Size = New Size(923, 249)
        dgvMostrarClientes.TabIndex = 19
        ' 
        ' Label1
        ' 
        Label1.AutoSize = True
        Label1.Font = New Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Label1.Location = New Point(12, 23)
        Label1.Name = "Label1"
        Label1.Size = New Size(258, 38)
        Label1.TabIndex = 20
        Label1.Text = "Listado de clientes"
        ' 
        ' txtDireccion
        ' 
        txtDireccion.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtDireccion.Location = New Point(663, 495)
        txtDireccion.Name = "txtDireccion"
        txtDireccion.Size = New Size(234, 34)
        txtDireccion.TabIndex = 49
        ' 
        ' txtCorreo
        ' 
        txtCorreo.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtCorreo.Location = New Point(663, 453)
        txtCorreo.Name = "txtCorreo"
        txtCorreo.Size = New Size(234, 34)
        txtCorreo.TabIndex = 48
        ' 
        ' txtTelefono
        ' 
        txtTelefono.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtTelefono.Location = New Point(663, 410)
        txtTelefono.Name = "txtTelefono"
        txtTelefono.Size = New Size(234, 34)
        txtTelefono.TabIndex = 47
        ' 
        ' txtCedula
        ' 
        txtCedula.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtCedula.Location = New Point(663, 364)
        txtCedula.Name = "txtCedula"
        txtCedula.Size = New Size(234, 34)
        txtCedula.TabIndex = 46
        ' 
        ' Label9
        ' 
        Label9.AutoSize = True
        Label9.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label9.Location = New Point(551, 459)
        Label9.Name = "Label9"
        Label9.Size = New Size(72, 28)
        Label9.TabIndex = 45
        Label9.Text = "Correo"
        ' 
        ' Label8
        ' 
        Label8.AutoSize = True
        Label8.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label8.Location = New Point(551, 413)
        Label8.Name = "Label8"
        Label8.Size = New Size(99, 28)
        Label8.TabIndex = 44
        Label8.Text = "Teléfono *"
        ' 
        ' Label7
        ' 
        Label7.AutoSize = True
        Label7.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label7.Location = New Point(551, 367)
        Label7.Name = "Label7"
        Label7.Size = New Size(85, 28)
        Label7.TabIndex = 43
        Label7.Text = "Cédula *"
        ' 
        ' Label2
        ' 
        Label2.AutoSize = True
        Label2.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label2.Location = New Point(551, 504)
        Label2.Name = "Label2"
        Label2.Size = New Size(94, 28)
        Label2.TabIndex = 42
        Label2.Text = "Dirección"
        ' 
        ' txtSegundoApellido
        ' 
        txtSegundoApellido.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSegundoApellido.Location = New Point(267, 538)
        txtSegundoApellido.Name = "txtSegundoApellido"
        txtSegundoApellido.Size = New Size(234, 34)
        txtSegundoApellido.TabIndex = 41
        ' 
        ' Label6
        ' 
        Label6.AutoSize = True
        Label6.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label6.Location = New Point(49, 538)
        Label6.Name = "Label6"
        Label6.Size = New Size(170, 28)
        Label6.TabIndex = 40
        Label6.Text = "Segundo Apellido"
        ' 
        ' txtPrimerApellido
        ' 
        txtPrimerApellido.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPrimerApellido.Location = New Point(267, 495)
        txtPrimerApellido.Name = "txtPrimerApellido"
        txtPrimerApellido.Size = New Size(234, 34)
        txtPrimerApellido.TabIndex = 39
        ' 
        ' Label5
        ' 
        Label5.AutoSize = True
        Label5.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label5.Location = New Point(50, 495)
        Label5.Name = "Label5"
        Label5.Size = New Size(161, 28)
        Label5.TabIndex = 38
        Label5.Text = "Primer Apellido *"
        ' 
        ' txtSegundoNombre
        ' 
        txtSegundoNombre.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtSegundoNombre.Location = New Point(267, 453)
        txtSegundoNombre.Name = "txtSegundoNombre"
        txtSegundoNombre.Size = New Size(234, 34)
        txtSegundoNombre.TabIndex = 37
        ' 
        ' Label4
        ' 
        Label4.AutoSize = True
        Label4.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label4.Location = New Point(50, 456)
        Label4.Name = "Label4"
        Label4.Size = New Size(169, 28)
        Label4.TabIndex = 36
        Label4.Text = "Segundo Nombre"
        ' 
        ' txtPrimerNombre
        ' 
        txtPrimerNombre.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtPrimerNombre.Location = New Point(267, 410)
        txtPrimerNombre.Name = "txtPrimerNombre"
        txtPrimerNombre.Size = New Size(234, 34)
        txtPrimerNombre.TabIndex = 35
        ' 
        ' Label3
        ' 
        Label3.AutoSize = True
        Label3.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label3.Location = New Point(50, 416)
        Label3.Name = "Label3"
        Label3.Size = New Size(160, 28)
        Label3.TabIndex = 34
        Label3.Text = "Primer Nombre *"
        ' 
        ' txtIdCliente
        ' 
        txtIdCliente.Enabled = False
        txtIdCliente.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtIdCliente.Location = New Point(267, 364)
        txtIdCliente.Name = "txtIdCliente"
        txtIdCliente.Size = New Size(234, 34)
        txtIdCliente.TabIndex = 51
        ' 
        ' Label10
        ' 
        Label10.AutoSize = True
        Label10.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label10.Location = New Point(49, 370)
        Label10.Name = "Label10"
        Label10.Size = New Size(89, 28)
        Label10.TabIndex = 50
        Label10.Text = "IdCliente"
        ' 
        ' txtEstado
        ' 
        txtEstado.Enabled = False
        txtEstado.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        txtEstado.Location = New Point(663, 538)
        txtEstado.Name = "txtEstado"
        txtEstado.Size = New Size(234, 34)
        txtEstado.TabIndex = 53
        ' 
        ' Label11
        ' 
        Label11.AutoSize = True
        Label11.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Label11.Location = New Point(551, 544)
        Label11.Name = "Label11"
        Label11.Size = New Size(71, 28)
        Label11.TabIndex = 52
        Label11.Text = "Estado"
        ' 
        ' btnCancelar
        ' 
        btnCancelar.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnCancelar.Location = New Point(579, 613)
        btnCancelar.Name = "btnCancelar"
        btnCancelar.Size = New Size(102, 45)
        btnCancelar.TabIndex = 56
        btnCancelar.Text = "Cancelar"
        btnCancelar.UseVisualStyleBackColor = True
        ' 
        ' frmLimpiar
        ' 
        frmLimpiar.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        frmLimpiar.Location = New Point(687, 613)
        frmLimpiar.Name = "frmLimpiar"
        frmLimpiar.Size = New Size(102, 45)
        frmLimpiar.TabIndex = 55
        frmLimpiar.Text = "Limpiar"
        frmLimpiar.UseVisualStyleBackColor = True
        ' 
        ' btnEditar
        ' 
        btnEditar.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        btnEditar.Location = New Point(795, 613)
        btnEditar.Name = "btnEditar"
        btnEditar.Size = New Size(102, 45)
        btnEditar.TabIndex = 54
        btnEditar.Text = "Editar"
        btnEditar.UseVisualStyleBackColor = True
        ' 
        ' frmEditarCliente
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(947, 678)
        Controls.Add(btnCancelar)
        Controls.Add(frmLimpiar)
        Controls.Add(btnEditar)
        Controls.Add(txtEstado)
        Controls.Add(Label11)
        Controls.Add(txtIdCliente)
        Controls.Add(Label10)
        Controls.Add(txtDireccion)
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
        Controls.Add(dgvMostrarClientes)
        Name = "frmEditarCliente"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Editar Cliente"
        CType(dgvMostrarClientes, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents dgvMostrarClientes As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents txtDireccion As TextBox
    Friend WithEvents txtCorreo As TextBox
    Friend WithEvents txtTelefono As TextBox
    Friend WithEvents txtCedula As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents txtSegundoApellido As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtPrimerApellido As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSegundoNombre As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtPrimerNombre As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtIdCliente As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents txtEstado As TextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents btnCancelar As Button
    Friend WithEvents frmLimpiar As Button
    Friend WithEvents btnEditar As Button
End Class
