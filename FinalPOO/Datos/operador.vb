Imports System.Data.SqlClient

Public Class operador
    Inherits Conexión
    Dim cmd As New SqlCommand

    Public Function mostrar() As DataTable
        Try
            conectado()
            cmd = New SqlCommand("mostrar_reserva")
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

    Public Function insertar(ByVal dbs As voperador) As Boolean
        Try
            conectado()
            cmd = New SqlCommand("Insertar Reserva")
            cmd.CommandType = CommandType.StoredProcedure
            cmd.Connection = cnn
            cmd.Parameters.AddWithValue("@Fecha de Reserva", dbs.gFecha_de_Reserva)
            cmd.Parameters.AddWithValue("@Pago", dbs.gPago)
            cmd.Parameters.AddWithValue("@Valor Pendiente", dbs.gValor_Pendiente)

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
