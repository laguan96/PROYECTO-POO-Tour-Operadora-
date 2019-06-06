Imports System.Data.SqlClient
Public Class ope
    Inherits Conexión
    Dim cmd As New SqlCommand

    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_operador")
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

    Public Function insertar(ByVal dts As vope) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("Insertar Operador")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@Nombre", dts.gNombre)
            cmd.Parameters.AddWithValue("@DUI", dts.gDUI)
            cmd.Parameters.AddWithValue("@Dirección", dts.gDireccion)
            cmd.Parameters.AddWithValue("@Número de Teléfono", dts.gNumero_de_Telefono)
            cmd.Parameters.AddWithValue("Estado del Operador", dts.gEstado_de_Operador)


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