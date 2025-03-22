
Imports System.Drawing.Imaging
Imports Microsoft.Data.SqlClient
Imports Microsoft.Identity.Client

Public Class frmInicioSesion

    ' Crear una instancia de DatabaseManager, lo que a su vez creará la conexión
    Dim dbManager As New DatabaseManager()
    Dim Principal As New frmPrincipal

    Public Sub InicioSesion()

        Dim Usuario As String = txtUsuario.Text
        Dim Pass As String = txtContraseña.Text

        If Usuario = "admin" And Pass = "admin" Then
            MessageBox.Show("Bienvenido Administrador")
            Principal.Show()
            LimpiarCampos()
            Exit Sub
        End If

        Try

            Using conn As New SqlConnection(dbManager._connString.Value)
                conn.Open()

                Dim query As String = "Select * from Usuario where Usuario = @Usuario and Pass = @Pass"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@Usuario", Usuario)
                    cmd.Parameters.AddWithValue("@Pass", Pass)

                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        If reader.Read Then 'Si hay resultados
                            Dim _Usuario As String = reader("Usuario")
                            Dim _Pass As String = reader("Pass")
                            Dim _Estado As Boolean = reader("Estado")

                            If _Estado = True Then
                                MessageBox.Show("Bienvenido " + _Usuario)
                                Principal.Show()
                                LimpiarCampos()
                            Else
                                MessageBox.Show("El usuario " + _Usuario + " está suspendido", "Mensaje de Sisitema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                                LimpiarCampos()
                            End If
                        Else
                            MessageBox.Show("Usuario o contraseña incorrecta", "Mensaje de Sisitema", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            LimpiarCampos()
                        End If

                    End Using

                End Using

            End Using

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al procesar el inicio de sesión")
        End Try

    End Sub

    Public Sub LimpiarCampos()
        txtUsuario.Text = ""
        txtContraseña.Text = ""
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        InicioSesion()
    End Sub



End Class
