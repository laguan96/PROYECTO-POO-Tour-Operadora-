Imports System.ComponentModel
Imports FinalPOO

Public Class Form2

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form10.Show()
        Me.Hide()
    End Sub

    Private dt As New DataTable

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        mostrar()

    End Sub

    Public Sub limpiar()
        btnguardar.Visible = True
        btneditar.Visible = False
        lbleditar.Visible = False
        lblguardar.Visible = True

        txtnombre.Text = ""
        txtapellido.Text = ""
        txtdireccion.Text = ""
        txtgenero.Items.Clear()
        txtdui.Text = ""

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

    Private Sub txtidcliente_Validating(sender As Object, e As CancelEventArgs) Handles txtidcliente.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "CAMPO OBLIGATORIO")
        End If
    End Sub

    Private Sub txtnombre_Validating(sender As Object, e As CancelEventArgs) Handles txtnombre.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "CAMPO OBLIGATORIO")
        End If
    End Sub

    Private Sub txtapellido_Validating(sender As Object, e As CancelEventArgs) Handles txtapellido.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "CAMPO OBLIGATORIO")
        End If
    End Sub

    Private Sub txtdireccion_Validating(sender As Object, e As CancelEventArgs) Handles txtdireccion.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "CAMPO OBLIGATORIO")
        End If
    End Sub

    Private Sub txtgenero_Validating(sender As Object, e As CancelEventArgs) Handles txtgenero.Validating
        If DirectCast(sender, ComboBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "CAMPO OBLIGATORIO")
        End If
    End Sub

    Private Sub txtdui_Validating(sender As Object, e As CancelEventArgs) Handles txtdui.Validating
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
        If Me.ValidateChildren = True And txtnombre.Text <> "" And txtapellido.Text <> "" And txtdireccion.Text <> "" And txtgenero.Text <> "" And txtdui.Text <> "" Then
            Try
                Dim dts As New vcliente
                Dim func As New cliente

                dts.gNombre = txtnombre.Text
                dts.gApellido = txtapellido.Text
                dts.gDirección = txtdireccion.Text
                dts.gGenero = txtgenero.Text
                dts.gDUI = txtdui.Text

                If func.insertar(dts) Then
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

    Private Sub inexistente_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles inexistente.LinkClicked

    End Sub
End Class