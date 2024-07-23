Imports System.Data.SqlClient
Imports DotNetEnv

Module conexion_maestra
    Public conexion As SqlConnection

    Sub New()
        Env.TraversePath().Load()
        Dim server As String = Environment.GetEnvironmentVariable("DATABASE_SERVER")
        Dim database As String = Environment.GetEnvironmentVariable("DATABASE_NAME")
        Dim connectionString As String = $"Data Source={server}; Initial Catalog={database}; Integrated Security=SSPI;"
        conexion = New SqlConnection(connectionString)
    End Sub

    Sub Abrir()
        Try
            If conexion.State = 0 Then
                conexion.Open()
            End If
        Catch ex As Exception
            MessageBox.Show("Error al abrir la conexión: " & ex.Message)
        End Try
    End Sub
    Sub Cerrar()
        Try
            If conexion.State = 1 Then
                conexion.Close()
            End If
        Catch ex As Exception
            MessageBox.Show("Error al cerrar la conexión: " & ex.Message)
        End Try
    End Sub
End Module
