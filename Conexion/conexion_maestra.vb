Imports System.Data.SqlClient
Imports DotNetEnv
Module conexion_maestra
    Public conexion As SqlConnection
    Sub New()
        ' Cargar las variables de entorno
        Env.Load()
        ' Obtener la cadena de conexión desde la variable de entorno
        Dim connectionString As String = Environment.GetEnvironmentVariable("DB_CONNECTION_STRING")
        conexion = New SqlConnection(connectionString)
    End Sub
    Sub abrir()
        If conexion.State = 0 Then
            conexion.Open()

        End If
    End Sub

    Sub cerrar()
        If conexion.State = 1 Then
            conexion.Close()
        End If
    End Sub
End Module
