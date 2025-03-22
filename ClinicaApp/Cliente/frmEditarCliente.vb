Imports Microsoft.Data.SqlClient

Public Class frmEditarCliente
    Dim dbManager As New DatabaseManager()

    Private Sub frmEditarCliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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

    Private Sub dgvMostrarClientes_DoubleClick(sender As Object, e As EventArgs) Handles dgvMostrarClientes.DoubleClick
        ' Verifica que la fila sea válida (para evitar errores si se hace clic en el encabezado)
        If dgvMostrarClientes.CurrentRow IsNot Nothing Then
            ' Obtiene el valor de la columna "id" de la fila seleccionada
            Dim idValor As String = dgvMostrarClientes.CurrentRow.Cells("IdClientes").Value.ToString()

            If idValor IsNot Nothing Then
                Dim id As Integer = Convert.ToInt32(idValor)
                If id > 0 Then
                    txtPrimerNombre.Text = ""
                    txtSegundoNombre.Text = ""
                    txtPrimerApellido.Text = ""
                    txtSegundoApellido.Text = ""
                    txtCedula.Text = ""
                    txtTelefono.Text = ""
                    txtCorreo.Text = ""
                    txtDireccion.Text = ""

                    ObtenerCliente(id)

                End If
            End If

        End If
    End Sub

    Public Sub LimpiarCampos()

        txtIdCliente.Text = ""
        txtPrimerNombre.Text = ""
        txtSegundoNombre.Text = ""
        txtPrimerApellido.Text = ""
        txtSegundoApellido.Text = ""
        txtCedula.Text = ""
        txtTelefono.Text = ""
        txtCorreo.Text = ""
        txtDireccion.Text = ""
        txtEstado.Text = ""

        MostrarClientes()

    End Sub

    Public Sub ObtenerCliente(ByVal Id As Integer)

        Try

            Using conn As New SqlConnection(dbManager._connString.Value)
                conn.Open()

                Dim query As String = "Select * from Cliente where IdCliente = @IdCliente"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@IdCliente", Id)

                    Using reader As SqlDataReader = cmd.ExecuteReader()
                        If reader.Read Then 'Si hay resultados
                            txtIdCliente.Text = reader("IdCliente")
                            txtPrimerNombre.Text = reader("PrimerNombre")
                            txtSegundoNombre.Text = reader("SegundoNombre")
                            txtPrimerApellido.Text = reader("PrimerApellido")
                            txtSegundoApellido.Text = reader("SegundoApellido")
                            txtDireccion.Text = reader("Direccion")
                            txtCedula.Text = reader("Cedula")
                            txtTelefono.Text = reader("Telefono")
                            txtCorreo.Text = reader("Correo")
                            txtEstado.Text = reader("Estado")
                        Else
                            MessageBox.Show("Cliente no encontrado", "Mensaje de Sisitema", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            LimpiarCampos()
                        End If

                    End Using

                End Using

            End Using

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al procesar Cliente")
        End Try

    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dispose()
    End Sub

    Private Sub frmLimpiar_Click(sender As Object, e As EventArgs) Handles frmLimpiar.Click
        LimpiarCampos()
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnEditar.Click
        EditarCliente()
    End Sub

    Public Sub EditarCliente()

        Dim IdCliente As String = txtIdCliente.Text
        Dim PrimerNombre As String = txtPrimerNombre.Text.Trim
        Dim SegundoNombre As String = txtSegundoNombre.Text.Trim
        Dim Primerpellido As String = txtPrimerApellido.Text.Trim
        Dim SegundoApellido As String = txtSegundoApellido.Text.Trim
        Dim Cedula As String = txtCedula.Text.Trim
        Dim Direccion As String = txtDireccion.Text.Trim
        Dim Telefono As String = txtTelefono.Text.Trim
        Dim Correo As String = txtCorreo.Text.Trim


        If PrimerNombre.Equals("") Or Primerpellido.Equals("") Or Cedula.Equals("") Or Telefono.Equals("") Then
            MessageBox.Show("Los campos con * son requeridos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        If Not IsNumeric(Telefono) Then
            MessageBox.Show("El numero de teléfono debe de ser numerico", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        End If

        Try

            Using conn As New SqlConnection(dbManager._connString.Value)
                conn.Open()

                Dim query As String = "Update Cliente 
                                       set PrimerNombre = @pNombre,
                                            SegundoNombre = @sNombre,
                                            PrimerApellido = @pApellido,
                                            SegundoApellido = @sApellido,
                                            Direccion = @Direccion,
                                            Cedula = @Cedula,
                                            Telefono = @Telefono,
                                            Correo = @Correo
                                       where IdCliente = @IdCliente"
                Using cmd As New SqlCommand(query, conn)
                    cmd.Parameters.AddWithValue("@IdCliente", IdCliente)
                    cmd.Parameters.AddWithValue("@pNombre", PrimerNombre)
                    cmd.Parameters.AddWithValue("@sNombre", SegundoNombre)
                    cmd.Parameters.AddWithValue("@pApellido", Primerpellido)
                    cmd.Parameters.AddWithValue("@sApellido", SegundoApellido)
                    cmd.Parameters.AddWithValue("@Direccion", Direccion)
                    cmd.Parameters.AddWithValue("@Cedula", Cedula)
                    cmd.Parameters.AddWithValue("@Telefono", Telefono)
                    cmd.Parameters.AddWithValue("@Correo", Correo)
                    cmd.Parameters.AddWithValue("@Estado", True)

                    Dim filasAfectadas As Integer = cmd.ExecuteNonQuery()

                    If filasAfectadas > 0 Then
                        MessageBox.Show("Cliente editado correctamente", "Mensaje de Sisitema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("No se pudo editar el Cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

                    LimpiarCampos()

                End Using

            End Using

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al editar el Cliente")
        End Try

    End Sub


End Class