Public Class frmPrincipal
    Private Sub frmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        frmInicioSesion.Hide()
    End Sub

    Private Sub CerrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CerrarToolStripMenuItem.Click
        frmInicioSesion.Show()
        Me.Hide()
    End Sub

    Private Sub AgregarUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarUsuarioToolStripMenuItem.Click
        frmAgregarUsuario.ShowDialog()
    End Sub

    Private Sub MostrarUsuariosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarUsuariosToolStripMenuItem.Click
        frmMostrarUsuarios.ShowDialog()
    End Sub

    Private Sub EditarUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarUsuarioToolStripMenuItem.Click
        frmEditarUsuario.ShowDialog()
    End Sub

    Private Sub AgregarClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AgregarClienteToolStripMenuItem.Click
        frmAgregarCliente.ShowDialog()
    End Sub

    Private Sub MostrarClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MostrarClientesToolStripMenuItem.Click
        frmMostrarClientes.ShowDialog()
    End Sub

    Private Sub EditarClienteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EditarClienteToolStripMenuItem.Click
        frmEditarCliente.ShowDialog()
    End Sub
End Class