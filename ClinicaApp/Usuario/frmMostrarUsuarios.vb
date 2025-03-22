Imports Microsoft.Data.SqlClient
Imports System.Security

Public Class frmMostrarUsuarios

    Dim dbManager As New DatabaseManager()

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Me.Hide()
    End Sub

    Private Sub frmMostrarUsuarios_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

End Class