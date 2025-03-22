Imports ClinicaApp.ConnectionStrings

Public Class DatabaseManager
    Public _connString As ConnectionString

    ' Constructor que recibe la configuración de la conexión
    Public Sub New()
        _connString = New ConnectionString("DESKTOP-ARCAST\SQLEXPRESS", "ClinicaBD", "admin", "admin")
    End Sub

End Class
