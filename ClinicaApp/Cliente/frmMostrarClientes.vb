Imports Microsoft.Data.SqlClient

Public Class frmMostrarClientes

    Dim dbManager As New DatabaseManager()

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dispose()
    End Sub

    Private Sub frmMostrarClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MostrarClientes()
    End Sub


    Public Sub MostrarClientes()

        Try

            Dim listaClientes As New List(Of Cliente)()

            Using conn As New SqlConnection(dbManager._connString.Value)
                conn.Open()

                Dim query As String = "Select * from Cliente"
                Using cmd As New SqlCommand(query, conn)
                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        While reader.Read()
                            ' Mapear cada fila a un objeto Usuario y agregarlo a la lista
                            Dim cliente As New Cliente With {
                                .IdClientes = Convert.ToInt32(reader("IdCliente")),
                                .PrimerNombre = reader("PrimerNombre").ToString(),
                                .SegundoNombre = reader("SegundoNombre").ToString(),
                                .PrimerApellido = reader("PrimerApellido").ToString(),
                                .SegundoApellido = reader("SegundoApellido").ToString(),
                                .Cedula = reader("Cedula").ToString(),
                                .Direccion = reader("Direccion").ToString(),
                                .Telefono = Convert.ToInt32(reader("Telefono")),
                                .Estado = Convert.ToBoolean(reader("Estado"))
                            }
                            listaClientes.Add(cliente)
                        End While
                    End Using

                End Using

                ' Asignar los datos al DataGridView
                dgvMostrarClientes.DataSource = listaClientes

                ' Ocultar la columna "IdClientes"
                If dgvMostrarClientes.Columns.Contains("IdClientes") Then
                    dgvMostrarClientes.Columns("IdClientes").Visible = False
                End If

            End Using

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al procesar los clientes")
        End Try

    End Sub

End Class