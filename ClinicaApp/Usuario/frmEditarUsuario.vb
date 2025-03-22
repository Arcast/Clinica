Imports System.Security
Imports Microsoft.Data.SqlClient

Public Class frmEditarUsuario

    Dim dbManager As New DatabaseManager()

    Private Sub frmEditarUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarUsuarios()
    End Sub

    Public Sub MostrarUsuarios()

        Try

            Dim listaUsuarios As New List(Of Usuario)()

            Using conn As New SqlConnection(dbManager._connString.Value)
                conn.Open()

                Dim query As String = "Select * from Usuario"
                Using cmd As New SqlCommand(query, conn)
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            ' Mapear cada fila a un objeto Usuario y agregarlo a la lista
                            Dim user As New Usuario With {
                                .IdUsuario = Convert.ToInt32(reader("IdUsuario")),
                                .Usuario = reader("Usuario").ToString(),
                                .Pass = reader("Pass").ToString(),
                                .Estado = Convert.ToBoolean(reader("Estado"))
                            }
                            listaUsuarios.Add(user)
                        End While
                    End Using

                End Using

                ' Asignar los datos al DataGridView
                dgvMostrarUsuarior.DataSource = listaUsuarios

                ' Ocultar la columna "Pass"
                If dgvMostrarUsuarior.Columns.Contains("Pass") Then
                    dgvMostrarUsuarior.Columns("Pass").Visible = False
                End If

            End Using

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al procesar el inicio de sesión")
        End Try

    End Sub

    Private Sub dgvMostrarUsuarior_DoubleClick(sender As Object, e As EventArgs) Handles dgvMostrarUsuarior.DoubleClick
        ' Verifica que la fila sea válida (para evitar errores si se hace clic en el encabezado)
        If dgvMostrarUsuarior.CurrentRow IsNot Nothing Then
            ' Obtiene el valor de la columna "id" de la fila seleccionada
            Dim idValor As String = dgvMostrarUsuarior.CurrentRow.Cells("Idusuario").Value.ToString()

            If idValor IsNot Nothing Then
                Dim id As Integer = Convert.ToInt32(idValor)
                If id > 0 Then
                    txtIdUsuario.Text = ""
                    txtUsuario.Text = ""
                    txtContraseña.Text = ""
                    txtConfirmarContrasena.Text = ""

                    ObtenerUsuario(id)

                End If
            End If

        End If

    End Sub

    Public Sub ObtenerUsuario(ByVal Id As Integer)

        Try

            Using conn As New SqlConnection(dbManager._connString.Value)
                conn.Open()

                Dim query As String = "Select * from Usuario where IdUsuario = @Usuario"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Usuario", Id)

                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        If reader.Read Then 'Si hay resultados
                            Dim IdUsuario As String = reader("IdUsuario")
                            Dim Usuario As String = reader("Usuario")

                            txtIdUsuario.Text = IdUsuario
                            txtUsuario.Text = Usuario

                        Else
                            MessageBox.Show("Usuario no encontrado", "Mensaje de Sisitema", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            limpiar()
                        End If

                    End Using

                End Using

            End Using

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al procesar el inicio de sesión")
        End Try

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dispose()
    End Sub

    Private Sub frmLimpiar_Click(sender As Object, e As EventArgs) Handles frmLimpiar.Click
        limpiar()
    End Sub

    Public Sub limpiar()
        MostrarUsuarios()
        txtIdUsuario.Text = ""
        txtUsuario.Text = ""
        txtContraseña.Text = ""
        txtConfirmarContrasena.Text = ""
    End Sub

    Public Sub EditarUsuario()
        Dim Id As String = txtIdUsuario.Text
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

                Dim query As String = "update Usuario set Pass = @Pass where IdUsuario = @Id"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Id", Id)
                    cmd.Parameters.AddWithValue("@Pass", Pass)

                    Dim filasAfectadas As Integer = cmd.ExecuteNonQuery()

                    If filasAfectadas > 0 Then
                        MessageBox.Show("Usuario editado correctamente", "Mensaje de Sisitema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("No se pudo editar el usuario.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

                    limpiar()

                End Using

            End Using

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al guardar usuario")
        End Try

    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        EditarUsuario()
    End Sub
End Class