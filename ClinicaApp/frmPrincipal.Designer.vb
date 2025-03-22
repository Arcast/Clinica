<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPrincipal
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
        MenuStrip1 = New MenuStrip()
        InicioToolStripMenuItem = New ToolStripMenuItem()
        CerrarToolStripMenuItem = New ToolStripMenuItem()
        ClientesToolStripMenuItem = New ToolStripMenuItem()
        AgregarClienteToolStripMenuItem = New ToolStripMenuItem()
        EditarClienteToolStripMenuItem = New ToolStripMenuItem()
        MostrarClientesToolStripMenuItem = New ToolStripMenuItem()
        UsuariosToolStripMenuItem = New ToolStripMenuItem()
        AgregarUsuarioToolStripMenuItem = New ToolStripMenuItem()
        EditarUsuarioToolStripMenuItem = New ToolStripMenuItem()
        MostrarUsuariosToolStripMenuItem = New ToolStripMenuItem()
        MenuStrip1.SuspendLayout()
        SuspendLayout()
        ' 
        ' MenuStrip1
        ' 
        MenuStrip1.ImageScalingSize = New Size(20, 20)
        MenuStrip1.Items.AddRange(New ToolStripItem() {InicioToolStripMenuItem, ClientesToolStripMenuItem, UsuariosToolStripMenuItem})
        MenuStrip1.Location = New Point(0, 0)
        MenuStrip1.Name = "MenuStrip1"
        MenuStrip1.Size = New Size(800, 36)
        MenuStrip1.TabIndex = 0
        MenuStrip1.Text = "MenuStrip1"
        ' 
        ' InicioToolStripMenuItem
        ' 
        InicioToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {CerrarToolStripMenuItem})
        InicioToolStripMenuItem.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        InicioToolStripMenuItem.Name = "InicioToolStripMenuItem"
        InicioToolStripMenuItem.Size = New Size(78, 32)
        InicioToolStripMenuItem.Text = "Inicio"
        ' 
        ' CerrarToolStripMenuItem
        ' 
        CerrarToolStripMenuItem.Name = "CerrarToolStripMenuItem"
        CerrarToolStripMenuItem.Size = New Size(156, 32)
        CerrarToolStripMenuItem.Text = "Cerrar"
        ' 
        ' ClientesToolStripMenuItem
        ' 
        ClientesToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AgregarClienteToolStripMenuItem, EditarClienteToolStripMenuItem, MostrarClientesToolStripMenuItem})
        ClientesToolStripMenuItem.Font = New Font("Segoe UI", 12F, FontStyle.Bold)
        ClientesToolStripMenuItem.Name = "ClientesToolStripMenuItem"
        ClientesToolStripMenuItem.Size = New Size(101, 32)
        ClientesToolStripMenuItem.Text = "Clientes"
        ' 
        ' AgregarClienteToolStripMenuItem
        ' 
        AgregarClienteToolStripMenuItem.Name = "AgregarClienteToolStripMenuItem"
        AgregarClienteToolStripMenuItem.Size = New Size(254, 32)
        AgregarClienteToolStripMenuItem.Text = "Agregar Cliente"
        ' 
        ' EditarClienteToolStripMenuItem
        ' 
        EditarClienteToolStripMenuItem.Name = "EditarClienteToolStripMenuItem"
        EditarClienteToolStripMenuItem.Size = New Size(254, 32)
        EditarClienteToolStripMenuItem.Text = "Editar Cliente"
        ' 
        ' MostrarClientesToolStripMenuItem
        ' 
        MostrarClientesToolStripMenuItem.Name = "MostrarClientesToolStripMenuItem"
        MostrarClientesToolStripMenuItem.Size = New Size(254, 32)
        MostrarClientesToolStripMenuItem.Text = "Mostrar Clientes"
        ' 
        ' UsuariosToolStripMenuItem
        ' 
        UsuariosToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {AgregarUsuarioToolStripMenuItem, EditarUsuarioToolStripMenuItem, MostrarUsuariosToolStripMenuItem})
        UsuariosToolStripMenuItem.Font = New Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        UsuariosToolStripMenuItem.Name = "UsuariosToolStripMenuItem"
        UsuariosToolStripMenuItem.Size = New Size(107, 32)
        UsuariosToolStripMenuItem.Text = "Usuarios"
        ' 
        ' AgregarUsuarioToolStripMenuItem
        ' 
        AgregarUsuarioToolStripMenuItem.Name = "AgregarUsuarioToolStripMenuItem"
        AgregarUsuarioToolStripMenuItem.Size = New Size(260, 32)
        AgregarUsuarioToolStripMenuItem.Text = "Agregar Usuario"
        ' 
        ' EditarUsuarioToolStripMenuItem
        ' 
        EditarUsuarioToolStripMenuItem.Name = "EditarUsuarioToolStripMenuItem"
        EditarUsuarioToolStripMenuItem.Size = New Size(260, 32)
        EditarUsuarioToolStripMenuItem.Text = "Editar Usuario"
        ' 
        ' MostrarUsuariosToolStripMenuItem
        ' 
        MostrarUsuariosToolStripMenuItem.Name = "MostrarUsuariosToolStripMenuItem"
        MostrarUsuariosToolStripMenuItem.Size = New Size(260, 32)
        MostrarUsuariosToolStripMenuItem.Text = "Mostrar Usuarios"
        ' 
        ' frmPrincipal
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.ActiveCaption
        ClientSize = New Size(800, 450)
        Controls.Add(MenuStrip1)
        MainMenuStrip = MenuStrip1
        MaximizeBox = False
        MinimizeBox = False
        Name = "frmPrincipal"
        Text = "Menu Principal"
        WindowState = FormWindowState.Maximized
        MenuStrip1.ResumeLayout(False)
        MenuStrip1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents InicioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CerrarToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarUsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MostrarUsuariosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditarUsuarioToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AgregarClienteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MostrarClientesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EditarClienteToolStripMenuItem As ToolStripMenuItem
End Class
