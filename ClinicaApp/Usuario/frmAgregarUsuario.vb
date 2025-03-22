Imports Microsoft.Data.SqlClient
Imports System.Security

Public Class frmAgregarUsuario

    Dim formulario As frmInicioSesion
    Dim dbManager As New DatabaseManager()

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Hide()
        LimpiarCampos()
    End Sub

    Public Sub LimpiarCampos()
        txtUsuario.Text = ""
        txtContraseña.Text = ""
        txtConfirmarContrasena.Text = ""
    End Sub


    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        GuardarUsuario()
    End Sub

    Private Sub frmLimpiar_Click(sender As Object, e As EventArgs) Handles frmLimpiar.Click
        LimpiarCampos()
    End Sub

    Public Sub GuardarUsuario()

        Dim Usuario As String = txtUsuario.Text
        Dim Pass As String = txtContraseña.Text.Trim
        Dim ConfirmarPass As String = txtConfirmarContrasena.Text.Trim

        If Pass.Equals("") Then
            MessageBox.Show("Ingrese la contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If ConfirmarPass.Equals("") Then
            MessageBox.Show("Confirme la contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Pass.Length < 5 Then
            MessageBox.Show("El tamaño permitido es de 5 caracteres", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Not Pass.Equals(ConfirmarPass) Then
            MessageBox.Show("Contraseñas no son iguales", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtConfirmarContrasena.Text = ""
            Exit Sub
        End If

        Try

            Using conn As New SqlConnection(dbManager._connString.Value)
                conn.Open()

                Dim query As String = "Insert into Usuario values(@Usuario, @Pass, @Estado)"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Usuario", Usuario)
                    cmd.Parameters.AddWithValue("@Pass", Pass)
                    cmd.Parameters.AddWithValue("@Estado", True)

                    Dim filasAfectadas As Integer = cmd.ExecuteNonQuery()

                    If filasAfectadas > 0 Then
                        MessageBox.Show("Usuario agregado correctamente", "Mensaje de Sisitema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("No se pudo agregar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

                    LimpiarCampos()

                End Using

            End Using

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al guardar usuario")
        End Try

    End Sub

End Class