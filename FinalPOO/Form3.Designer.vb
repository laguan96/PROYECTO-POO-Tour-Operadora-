<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblguardar = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.lbleditar = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtPago = New System.Windows.Forms.ComboBox()
        Me.txtValor_Pendiente = New System.Windows.Forms.TextBox()
        Me.txtFecha_de_Reserva = New System.Windows.Forms.TextBox()
        Me.txtidCliente = New System.Windows.Forms.TextBox()
        Me.txtidOperador = New System.Windows.Forms.TextBox()
        Me.txtidReserva = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.cbocampo = New System.Windows.Forms.ComboBox()
        Me.inexistente = New System.Windows.Forms.LinkLabel()
        Me.datalistado = New System.Windows.Forms.DataGridView()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.erroricono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.btbcancelar = New System.Windows.Forms.Button()
        Me.btneditar = New System.Windows.Forms.Button()
        Me.btnnuevo = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(12, 415)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "REGRESAR"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblguardar)
        Me.GroupBox1.Controls.Add(Me.btnguardar)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.lbleditar)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.btbcancelar)
        Me.GroupBox1.Controls.Add(Me.btneditar)
        Me.GroupBox1.Controls.Add(Me.btnnuevo)
        Me.GroupBox1.Controls.Add(Me.txtPago)
        Me.GroupBox1.Controls.Add(Me.txtValor_Pendiente)
        Me.GroupBox1.Controls.Add(Me.txtFecha_de_Reserva)
        Me.GroupBox1.Controls.Add(Me.txtidCliente)
        Me.GroupBox1.Controls.Add(Me.txtidOperador)
        Me.GroupBox1.Controls.Add(Me.txtidReserva)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 44)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(352, 365)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Registro Reserva"
        '
        'lblguardar
        '
        Me.lblguardar.AutoSize = True
        Me.lblguardar.Location = New System.Drawing.Point(185, 343)
        Me.lblguardar.Name = "lblguardar"
        Me.lblguardar.Size = New System.Drawing.Size(61, 13)
        Me.lblguardar.TabIndex = 19
        Me.lblguardar.Text = "GUARDAR"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(252, 343)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 13)
        Me.Label9.TabIndex = 17
        Me.Label9.Text = "CANCELAR"
        '
        'lbleditar
        '
        Me.lbleditar.AutoSize = True
        Me.lbleditar.Location = New System.Drawing.Point(189, 343)
        Me.lbleditar.Name = "lbleditar"
        Me.lbleditar.Size = New System.Drawing.Size(47, 13)
        Me.lbleditar.TabIndex = 16
        Me.lbleditar.Text = "EDITAR"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(119, 343)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(45, 13)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "NUEVO"
        '
        'txtPago
        '
        Me.txtPago.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.txtPago.FormattingEnabled = True
        Me.txtPago.Items.AddRange(New Object() {"EFECTIVO", "TARJETA DE CREDITO"})
        Me.txtPago.Location = New System.Drawing.Point(116, 196)
        Me.txtPago.Name = "txtPago"
        Me.txtPago.Size = New System.Drawing.Size(201, 21)
        Me.txtPago.TabIndex = 11
        '
        'txtValor_Pendiente
        '
        Me.txtValor_Pendiente.Location = New System.Drawing.Point(116, 241)
        Me.txtValor_Pendiente.Name = "txtValor_Pendiente"
        Me.txtValor_Pendiente.Size = New System.Drawing.Size(201, 20)
        Me.txtValor_Pendiente.TabIndex = 10
        '
        'txtFecha_de_Reserva
        '
        Me.txtFecha_de_Reserva.Location = New System.Drawing.Point(116, 158)
        Me.txtFecha_de_Reserva.Name = "txtFecha_de_Reserva"
        Me.txtFecha_de_Reserva.Size = New System.Drawing.Size(201, 20)
        Me.txtFecha_de_Reserva.TabIndex = 9
        '
        'txtidCliente
        '
        Me.txtidCliente.Location = New System.Drawing.Point(116, 112)
        Me.txtidCliente.Name = "txtidCliente"
        Me.txtidCliente.Size = New System.Drawing.Size(201, 20)
        Me.txtidCliente.TabIndex = 8
        '
        'txtidOperador
        '
        Me.txtidOperador.Location = New System.Drawing.Point(116, 73)
        Me.txtidOperador.Name = "txtidOperador"
        Me.txtidOperador.Size = New System.Drawing.Size(201, 20)
        Me.txtidOperador.TabIndex = 7
        '
        'txtidReserva
        '
        Me.txtidReserva.Location = New System.Drawing.Point(116, 34)
        Me.txtidReserva.Name = "txtidReserva"
        Me.txtidReserva.Size = New System.Drawing.Size(201, 20)
        Me.txtidReserva.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 244)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(82, 13)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Valor Pendiente"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 199)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Pago"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(15, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(95, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Fecha de Reserva"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(15, 115)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "idCliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(15, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "idOperador"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(15, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "idReserva"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtbuscar)
        Me.GroupBox2.Controls.Add(Me.cbocampo)
        Me.GroupBox2.Controls.Add(Me.inexistente)
        Me.GroupBox2.Controls.Add(Me.datalistado)
        Me.GroupBox2.Controls.Add(Me.Button5)
        Me.GroupBox2.Location = New System.Drawing.Point(397, 44)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(391, 382)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Consulta Reserva"
        '
        'txtbuscar
        '
        Me.txtbuscar.Location = New System.Drawing.Point(158, 33)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(227, 20)
        Me.txtbuscar.TabIndex = 19
        '
        'cbocampo
        '
        Me.cbocampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbocampo.FormattingEnabled = True
        Me.cbocampo.Items.AddRange(New Object() {"idReserva", "idCliente"})
        Me.cbocampo.Location = New System.Drawing.Point(6, 33)
        Me.cbocampo.Name = "cbocampo"
        Me.cbocampo.Size = New System.Drawing.Size(133, 21)
        Me.cbocampo.TabIndex = 18
        '
        'inexistente
        '
        Me.inexistente.AutoSize = True
        Me.inexistente.Location = New System.Drawing.Point(155, 181)
        Me.inexistente.Name = "inexistente"
        Me.inexistente.Size = New System.Drawing.Size(94, 13)
        Me.inexistente.TabIndex = 17
        Me.inexistente.TabStop = True
        Me.inexistente.Text = "Datos Inexistentes"
        '
        'datalistado
        '
        Me.datalistado.AllowUserToAddRows = False
        Me.datalistado.AllowUserToDeleteRows = False
        Me.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.datalistado.Location = New System.Drawing.Point(6, 73)
        Me.datalistado.Name = "datalistado"
        Me.datalistado.ReadOnly = True
        Me.datalistado.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.datalistado.Size = New System.Drawing.Size(379, 252)
        Me.datalistado.TabIndex = 16
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(18, 344)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(75, 23)
        Me.Button5.TabIndex = 15
        Me.Button5.Text = "ELIMINAR"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'erroricono
        '
        Me.erroricono.ContainerControl = Me
        '
        'btnguardar
        '
        Me.btnguardar.Image = Global.FinalPOO.My.Resources.Resources.editar
        Me.btnguardar.Location = New System.Drawing.Point(181, 287)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(65, 53)
        Me.btnguardar.TabIndex = 18
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'btbcancelar
        '
        Me.btbcancelar.Image = Global.FinalPOO.My.Resources.Resources.cancelar
        Me.btbcancelar.Location = New System.Drawing.Point(252, 287)
        Me.btbcancelar.Name = "btbcancelar"
        Me.btbcancelar.Size = New System.Drawing.Size(65, 53)
        Me.btbcancelar.TabIndex = 14
        Me.btbcancelar.UseVisualStyleBackColor = True
        '
        'btneditar
        '
        Me.btneditar.Image = Global.FinalPOO.My.Resources.Resources.editar
        Me.btneditar.Location = New System.Drawing.Point(181, 287)
        Me.btneditar.Name = "btneditar"
        Me.btneditar.Size = New System.Drawing.Size(65, 53)
        Me.btneditar.TabIndex = 13
        Me.btneditar.UseVisualStyleBackColor = True
        '
        'btnnuevo
        '
        Me.btnnuevo.Image = Global.FinalPOO.My.Resources.Resources.nuevo
        Me.btnnuevo.Location = New System.Drawing.Point(110, 287)
        Me.btnnuevo.Name = "btnnuevo"
        Me.btnnuevo.Size = New System.Drawing.Size(65, 53)
        Me.btnnuevo.TabIndex = 12
        Me.btnnuevo.UseVisualStyleBackColor = True
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form3"
        Me.Text = "Form3"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtPago As ComboBox
    Friend WithEvents txtValor_Pendiente As TextBox
    Friend WithEvents txtFecha_de_Reserva As TextBox
    Friend WithEvents txtidCliente As TextBox
    Friend WithEvents txtidOperador As TextBox
    Friend WithEvents txtidReserva As TextBox
    Friend WithEvents btbcancelar As Button
    Friend WithEvents btneditar As Button
    Friend WithEvents btnnuevo As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents datalistado As DataGridView
    Friend WithEvents inexistente As LinkLabel
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents cbocampo As ComboBox
    Friend WithEvents Eliminar As DataGridViewCheckBoxColumn
    Friend WithEvents Label7 As Label
    Friend WithEvents lbleditar As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents erroricono As ErrorProvider
    Friend WithEvents lblguardar As Label
    Friend WithEvents btnguardar As Button
End Class
