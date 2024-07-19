Imports System.Data.SqlClient
Module conexion_maestra
    Public conexion As New SqlConnection("Data source=MSI\SQLEXPRESS;Initial Catalog=basecolegio;Integrated Security=True")
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
