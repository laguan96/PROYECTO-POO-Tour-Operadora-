Imports System.Data.SqlClient

Public Class cliente
    Inherits Conexión
    Dim cmd As New SqlCommand

    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_cliente")
            cmd.CommandType = CommandType.StoredProcedure

            cmd.Connection = cnn
            If cmd.ExecuteNonQuery Then
                Dim dt As New DataTable
                Dim da As New SqlDataAdapter(cmd)
                da.Fill(dt)
                Return dt
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
            Return Nothing
        Finally
            desconectado()
        End Try
    End Function

    Public Function insertar(ByVal dts As vcliente) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("Insertar Cliente")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@Nombre", dts.gNombre)
            cmd.Parameters.AddWithValue("@Apellido", dts.gApellido)
            cmd.Parameters.AddWithValue("@Dirección", dts.gDirección)
            cmd.Parameters.AddWithValue("@Genero", dts.gGenero)
            cmd.Parameters.AddWithValue("@DUI", dts.gDUI)

            If cmd.ExecuteNonQuery Then
                Return True
            Else
                Return False

            End If


        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        Finally
            desconectado()

        End Try
    End Function

End Class