Imports System.Data.SqlClient

Public Class detalle
    Inherits Conexión
    Dim cmd As New SqlCommand

    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_detalle")
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

    Public Function insertar(ByVal dts As vdetalle) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("Insertar Detalle")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@Fecha de Salida", dts.gFecha_de_Salida)
            cmd.Parameters.AddWithValue("@Hora de Salida", dts.gHora_de_Salida)
            cmd.Parameters.AddWithValue("@Fecha de Retorno", dts.gFecha_de_Retorno)
            cmd.Parameters.AddWithValue("@Hora de Retorno", dts.gHora_de_Retorno)


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
