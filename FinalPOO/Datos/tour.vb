
Imports System.Data.SqlClient
Public Class tour
    Inherits Conexión
    Dim cmd As New SqlCommand

    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_tour")
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

    Public Function insertar(ByVal dts As vtour) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("Insertar Tour")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@Nombre del Tour", dts.gNombre_del_Tour)
            cmd.Parameters.AddWithValue("@Total de Asientos Cancelados", dts.gTotal_Asientos_Cancelados)
            cmd.Parameters.AddWithValue("@Total de Asientos Disponibles", dts.gTotal_Asientos_Disponibles)
            cmd.Parameters.AddWithValue("@Costo del Tour", dts.gCosto_del_Tour)
            cmd.Parameters.AddWithValue("Fecha Limite de Pago", dts.gFecha_Limite_de_Pago)


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
