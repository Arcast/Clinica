Imports Microsoft.Data.SqlClient

Public Class ConnectionStrings
    Public Class ConnectionString
        Private _connectionString As String

        ' Constructor que recibe los parámetros para construir la cadena de conexión
        Public Sub New(Optional ByVal server As String = "", Optional ByVal database As String = "", Optional ByVal user As String = "", Optional ByVal password As String = "")
            If server <> "" And database <> "" And user <> "" And password <> "" Then
                BuildConnectionString(server, database, user, password)
            Else
                _connectionString = ""
            End If
        End Sub

        ' Propiedad para obtener o establecer la cadena de conexión
        Public Property Value() As String
            Get
                Return _connectionString
            End Get
            Set(ByVal value As String)
                _connectionString = value
            End Set
        End Property

        ' Método privado para construir la cadena de conexión dinámicamente
        Private Sub BuildConnectionString(ByVal server As String, ByVal database As String, ByVal user As String, ByVal password As String)
            _connectionString = $"Server={server};Database={database};User Id={user};Password={password};TrustServerCertificate=True;"
        End Sub

    End Class



End Class
