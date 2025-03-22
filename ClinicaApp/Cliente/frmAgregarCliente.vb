Imports Microsoft.Data.SqlClient

Public Class frmAgregarCliente

    Dim dbManager As New DatabaseManager()

    Public Sub GuardarCliente()

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

                Dim query As String = "Insert into Cliente 
                                        values(@pNombre,
                                                @sNombre,
                                                @pApellido,
                                                @sApellido,
                                                @Direccion,
                                                @Cedula,
                                                @Telefono,
                                                @Correo,
                                                @Estado);"
                Using cmd As New SqlCommand(query, conn)
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
                        MessageBox.Show("Cliente agregado correctamente", "Mensaje de Sisitema", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("No se pudo agregar el Cliente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    End If

                    LimpiarCampos()

                End Using

            End Using

        Catch ex As Exception
            MessageBox.Show("Ha ocurrido un error al guardar el Cliente")
        End Try

    End Sub

    Public Sub LimpiarCampos()

        txtPrimerNombre.Text = ""
        txtSegundoNombre.Text = ""
        txtPrimerApellido.Text = ""
        txtSegundoApellido.Text = ""
        txtCedula.Text = ""
        txtTelefono.Text = ""
        txtCorreo.Text = ""
        txtDireccion.Text = ""

    End Sub

    Private Sub frmLimpiar_Click(sender As Object, e As EventArgs) Handles frmLimpiar.Click
        LimpiarCampos()
    End Sub

    Private Sub btnCancelar_Click(sender As Object, e As EventArgs) Handles btnCancelar.Click
        Dispose()
    End Sub

    Private Sub btnIngresar_Click(sender As Object, e As EventArgs) Handles btnIngresar.Click
        GuardarCliente()
    End Sub
End Class