Imports System.ComponentModel

Public Class Form6
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Public Sub limpiar()
        txtidDetalle.Text = ""
        txtHora_de_Salida.Text = ""
        txtHora_de_Retorno.Text = ""
        txtFecha_de_Salida.ResetText()
        txtFecha_de_Retorno.ResetText()
    End Sub

    Private Sub ocultar_columnas()
        datalistado.Columns(1).Visible = False
    End Sub

    Private dt As New DataTable

    Private Sub mostrar()
        Try
            Dim func As New cliente
            dt = func.mostrar
            datalistado.Columns.Item("Eliminar").Visible = False

            If dt.Rows.Count <> 0 Then
                datalistado.DataSource = dt
                txtbuscar.Enabled = True
                datalistado.ColumnHeadersVisible = True
                inexistente.Visible = False

            Else
                datalistado.DataSource = Nothing
                txtbuscar.Enabled = False
                datalistado.ColumnHeadersVisible = False
                inexistente.Visible = True

            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try
        buscar()

    End Sub

    Private Sub buscar()
        Try
            Dim ds As New DataSet
            ds.Tables.Add(dt.Copy)
            Dim dv As New DataView(ds.Tables(0))

            dv.RowFilter = cbocampo.Text & "like '" & txtbuscar.Text & "%'"


            If dv.Count <> 0 Then
                inexistente.Visible = False
                datalistado.DataSource = dv
                ocultar_columnas()
            Else
                inexistente.Visible = True
                datalistado.DataSource = Nothing

            End If

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub txtidDetalle_Validating(sender As Object, e As CancelEventArgs) Handles txtidDetalle.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "CAMPO OBLIGATORIO")
        End If
    End Sub

    Private Sub txtHoraSalida_Validating(sender As Object, e As CancelEventArgs) Handles txtHora_de_Salida.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "CAMPO OBLIGATORIO")
        End If
    End Sub
    Private Sub txtHoraRetorno_TextChanged(sender As Object, e As EventArgs) Handles txtHora_de_Retorno.TextChanged

    End Sub

    Private Sub txtHoraRetorno_Validating(sender As Object, e As CancelEventArgs) Handles txtHora_de_Retorno.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "CAMPO OBLIGATORIO")
        End If
    End Sub

    Private Sub DateTimePicker1_Validating(sender As Object, e As CancelEventArgs) Handles txtFecha_de_Salida.Validating
        If DirectCast(sender, DateTimePicker).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "CAMPO OBLIGATORIO")
        End If
    End Sub

    Private Sub DateTimePicker2_Validating(sender As Object, e As CancelEventArgs) Handles txtFecha_de_Retorno.Validating
        If DirectCast(sender, DateTimePicker).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "CAMPO OBLIGATORIO")
        End If
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If Me.ValidateChildren = True And txtidDetalle.Text <> "" And txtFecha_de_Salida.Text <> "" And txtHora_de_Salida.Text <> "" And txtFecha_de_Retorno.Text <> "" And txtHora_de_Retorno.Text <> "" Then
            Try
                Dim dbs As New vdetalle
                Dim func As New detalle

                dbs.gidDetalle = txtidDetalle.Text
                'dbs.gFecha_de_Salida = txtFecha_de_Salida.Text
                dbs.gHora_de_Salida = txtHora_de_Salida.Text
                'dbs.gFecha_de_Retorno = txtFecha_de_Retorno.Text
                dbs.gHora_de_Retorno = txtHora_de_Retorno.Text
                If func.insertar(dbs) Then
                    MessageBox.Show("REGISTRO EXITOSO", "GUARDANDO REGISTROS", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    mostrar()
                    limpiar()
                Else
                    MessageBox.Show("CLIENTE NO FUE REGISTRADO, INTENTE DE NUEVO", "GUARDANDO REGISTROS", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    mostrar()
                    limpiar()

                End If
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try
        Else
            MessageBox.Show("FALTA INGRESAR ALGUNOS CAMPOS OBLIGATORIOS", "GUARDANDO REGISTROS", MessageBoxButtons.OK, MessageBoxIcon.Information)

        End If
    End Sub

End Class