Imports System.ComponentModel

Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form10.Show()
        Me.Hide()
    End Sub

    Private dt As New DataTable

    Public Sub limpiar()
        btnguardar.Visible = True
        btneditar.Visible = False
        lblguardar.Visible = True
        lbleditar.Visible = False

        txtidReserva.Text = ""
        txtidOperador.Text = ""
        txtidCliente.Text = ""
        txtFecha_de_Reserva.Text = ""
        txtPago.Items.Clear()
        txtValor_Pendiente.Text = ""

    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mostrar()

    End Sub

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
        btnnuevo.Visible = True
        btneditar.Visible = False

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

    Private Sub ocultar_columnas()
        datalistado.Columns(1).Visible = False
    End Sub

    Private Sub txtidReserva_Validating(sender As Object, e As CancelEventArgs) Handles txtidReserva.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "CAMPO OBLIGATORIO")
        End If
    End Sub

    Private Sub txtidOperador_Validating(sender As Object, e As CancelEventArgs) Handles txtidOperador.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "CAMPO OBLIGATORIO")
        End If
    End Sub

    Private Sub txtidCliente_Validating(sender As Object, e As CancelEventArgs) Handles txtidCliente.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "CAMPO OBLIGATORIO")
        End If
    End Sub

    Private Sub txtFechadeReserva_Validating(sender As Object, e As CancelEventArgs) Handles txtFecha_de_Reserva.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "CAMPO OBLIGATORIO")
        End If
    End Sub

    Private Sub txtPago_Validating(sender As Object, e As CancelEventArgs) Handles txtPago.Validating
        If DirectCast(sender, ComboBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "CAMPO OBLIGATORIO")
        End If
    End Sub

    Private Sub txtValorPendiente_Validating(sender As Object, e As CancelEventArgs) Handles txtValor_Pendiente.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "CAMPO OBLIGATORIO")
        End If
    End Sub

    Private Sub btnnuevo_Click(sender As Object, e As EventArgs) Handles btnnuevo.Click
        limpiar()
        mostrar()

    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If Me.ValidateChildren = True And txtValor_Pendiente.Text <> "" And txtPago.Text <> "" And txtValor_Pendiente.Text <> "" Then
            Try
                Dim dbs As New voperador
                Dim func As New operador

                dbs.gFecha_de_Reserva = txtValor_Pendiente.Text
                dbs.gPago = txtPago.Text
                dbs.gValor_Pendiente = txtValor_Pendiente.Text

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