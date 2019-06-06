Imports System.ComponentModel

Public Class Form4
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form11.Show()
        Me.Hide()

    End Sub

    Private dt As New DataTable

    Private Sub mostrar()
        Try
            Dim func As New tour
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

    Private Sub ocultar_columnas()
        datalistado.Columns(1).Visible = False
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

    Public Sub limpiar()

        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox4.Text = ""
        cmb1.Items.Clear()
        TextBox5.Text = ""
        TextBox6.Text = ""
        TextBox7.Text = ""
        TextBox8.Text = ""
        cbocampo.Items.Clear()


    End Sub

    Private Sub cmb1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb1.SelectedIndexChanged

        If cmb1.SelectedIndex = 0 Then PictureBox1.Visible = True
        If cmb1.SelectedIndex = 0 Then PictureBox2.Visible = False
        If cmb1.SelectedIndex = 0 Then PictureBox3.Visible = False
        If cmb1.SelectedIndex = 0 Then PictureBox4.Visible = False
        If cmb1.SelectedIndex = 0 Then PictureBox5.Visible = False
        If cmb1.SelectedIndex = 0 Then PictureBox6.Visible = False
        If cmb1.SelectedIndex = 0 Then PictureBox7.Visible = False

        If cmb1.SelectedIndex = 1 Then PictureBox2.Visible = True
        If cmb1.SelectedIndex = 1 Then PictureBox1.Visible = False
        If cmb1.SelectedIndex = 1 Then PictureBox3.Visible = False
        If cmb1.SelectedIndex = 1 Then PictureBox4.Visible = False
        If cmb1.SelectedIndex = 1 Then PictureBox5.Visible = False
        If cmb1.SelectedIndex = 1 Then PictureBox6.Visible = False
        If cmb1.SelectedIndex = 1 Then PictureBox7.Visible = False

        If cmb1.SelectedIndex = 2 Then PictureBox3.Visible = True
        If cmb1.SelectedIndex = 2 Then PictureBox1.Visible = False
        If cmb1.SelectedIndex = 2 Then PictureBox2.Visible = False
        If cmb1.SelectedIndex = 2 Then PictureBox4.Visible = False
        If cmb1.SelectedIndex = 2 Then PictureBox5.Visible = False
        If cmb1.SelectedIndex = 2 Then PictureBox6.Visible = False
        If cmb1.SelectedIndex = 2 Then PictureBox7.Visible = False

        If cmb1.SelectedIndex = 3 Then PictureBox4.Visible = True
        If cmb1.SelectedIndex = 3 Then PictureBox1.Visible = False
        If cmb1.SelectedIndex = 3 Then PictureBox2.Visible = False
        If cmb1.SelectedIndex = 3 Then PictureBox3.Visible = False
        If cmb1.SelectedIndex = 3 Then PictureBox5.Visible = False
        If cmb1.SelectedIndex = 3 Then PictureBox6.Visible = False
        If cmb1.SelectedIndex = 3 Then PictureBox7.Visible = False

        If cmb1.SelectedIndex = 4 Then PictureBox5.Visible = True
        If cmb1.SelectedIndex = 4 Then PictureBox1.Visible = False
        If cmb1.SelectedIndex = 4 Then PictureBox2.Visible = False
        If cmb1.SelectedIndex = 4 Then PictureBox3.Visible = False
        If cmb1.SelectedIndex = 4 Then PictureBox4.Visible = False
        If cmb1.SelectedIndex = 4 Then PictureBox6.Visible = False
        If cmb1.SelectedIndex = 4 Then PictureBox7.Visible = False

        If cmb1.SelectedIndex = 5 Then PictureBox6.Visible = True
        If cmb1.SelectedIndex = 5 Then PictureBox1.Visible = False
        If cmb1.SelectedIndex = 5 Then PictureBox2.Visible = False
        If cmb1.SelectedIndex = 5 Then PictureBox3.Visible = False
        If cmb1.SelectedIndex = 5 Then PictureBox4.Visible = False
        If cmb1.SelectedIndex = 5 Then PictureBox5.Visible = False
        If cmb1.SelectedIndex = 5 Then PictureBox7.Visible = False

        If cmb1.SelectedIndex = 6 Then PictureBox7.Visible = True
        If cmb1.SelectedIndex = 6 Then PictureBox1.Visible = False
        If cmb1.SelectedIndex = 6 Then PictureBox2.Visible = False
        If cmb1.SelectedIndex = 6 Then PictureBox3.Visible = False
        If cmb1.SelectedIndex = 6 Then PictureBox4.Visible = False
        If cmb1.SelectedIndex = 6 Then PictureBox5.Visible = False
        If cmb1.SelectedIndex = 6 Then PictureBox6.Visible = False

    End Sub

    Private Sub TextBox1_Validating(sender As Object, e As CancelEventArgs) Handles TextBox1.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "CAMPO OBLIGATORIO")
        End If
    End Sub

    Private Sub TextBox2_Validating(sender As Object, e As CancelEventArgs) Handles TextBox2.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "CAMPO OBLIGATORIO")
        End If
    End Sub

    Private Sub TextBox3_Validating(sender As Object, e As CancelEventArgs) Handles TextBox3.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "CAMPO OBLIGATORIO")
        End If
    End Sub

    Private Sub TextBox4_Validating(sender As Object, e As CancelEventArgs) Handles TextBox4.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "CAMPO OBLIGATORIO")
        End If
    End Sub

    Private Sub TextBox5_Validating(sender As Object, e As CancelEventArgs) Handles TextBox5.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "CAMPO OBLIGATORIO")
        End If
    End Sub

    Private Sub TextBox6_Validating(sender As Object, e As CancelEventArgs) Handles TextBox6.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "CAMPO OBLIGATORIO")
        End If
    End Sub

    Private Sub TextBox7_Validating(sender As Object, e As CancelEventArgs) Handles TextBox7.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "CAMPO OBLIGATORIO")
        End If
    End Sub

    Private Sub TextBox8_Validating(sender As Object, e As CancelEventArgs) Handles TextBox8.Validating
        If DirectCast(sender, TextBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "CAMPO OBLIGATORIO")
        End If
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbocampo.SelectedIndexChanged
        If DirectCast(sender, ComboBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "CAMPO OBLIGATORIO")
        End If
    End Sub

    Private Sub cmb1_Validating(sender As Object, e As CancelEventArgs) Handles cmb1.Validating
        If DirectCast(sender, ComboBox).Text.Length > 0 Then
            Me.erroricono.SetError(sender, "")
        Else
            Me.erroricono.SetError(sender, "CAMPO OBLIGATORIO")
        End If
    End Sub

    Private Sub btnguardar_Click(sender As Object, e As EventArgs) Handles btnguardar.Click
        If Me.ValidateChildren = True And TextBox5.Text <> "" And TextBox6.Text <> "" And TextBox7.Text <> "" And TextBox8.Text <> "" Then
            Try
                Dim dts As New vtour
                Dim func As New tour

                dts.gTotal_Asientos_Cancelados = TextBox5.Text
                dts.gTotal_Asientos_Disponibles = TextBox6.Text
                dts.gCosto_del_Tour = TextBox7.Text
                dts.gFecha_Limite_de_Pago = TextBox8.Text

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

End Class