<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnguardar = New System.Windows.Forms.Button()
        Me.txtFecha_de_Retorno = New System.Windows.Forms.DateTimePicker()
        Me.txtHora_de_Retorno = New System.Windows.Forms.TextBox()
        Me.txtHora_de_Salida = New System.Windows.Forms.TextBox()
        Me.txtFecha_de_Salida = New System.Windows.Forms.DateTimePicker()
        Me.txtidDetalle = New System.Windows.Forms.TextBox()
        Me.erroricono = New System.Windows.Forms.ErrorProvider(Me.components)
        Me.datalistado = New System.Windows.Forms.DataGridView()
        Me.cbocampo = New System.Windows.Forms.ComboBox()
        Me.txtbuscar = New System.Windows.Forms.TextBox()
        Me.inexistente = New System.Windows.Forms.LinkLabel()
        Me.Eliminar = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).BeginInit()
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(48, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "idDetalle"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Fecha de Salida"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 113)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(77, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Hora de Salida"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 154)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(93, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Fecha de Retorno"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 190)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(86, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Hora de Retorno"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.btnguardar)
        Me.GroupBox1.Controls.Add(Me.txtFecha_de_Retorno)
        Me.GroupBox1.Controls.Add(Me.txtHora_de_Retorno)
        Me.GroupBox1.Controls.Add(Me.txtHora_de_Salida)
        Me.GroupBox1.Controls.Add(Me.txtFecha_de_Salida)
        Me.GroupBox1.Controls.Add(Me.txtidDetalle)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(377, 397)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(136, 314)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(61, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "GUARDAR"
        '
        'btnguardar
        '
        Me.btnguardar.Image = Global.FinalPOO.My.Resources.Resources.nuevo
        Me.btnguardar.Location = New System.Drawing.Point(129, 241)
        Me.btnguardar.Name = "btnguardar"
        Me.btnguardar.Size = New System.Drawing.Size(75, 61)
        Me.btnguardar.TabIndex = 11
        Me.btnguardar.UseVisualStyleBackColor = True
        '
        'txtFecha_de_Retorno
        '
        Me.txtFecha_de_Retorno.Location = New System.Drawing.Point(129, 148)
        Me.txtFecha_de_Retorno.Name = "txtFecha_de_Retorno"
        Me.txtFecha_de_Retorno.Size = New System.Drawing.Size(221, 20)
        Me.txtFecha_de_Retorno.TabIndex = 10
        '
        'txtHora_de_Retorno
        '
        Me.txtHora_de_Retorno.Location = New System.Drawing.Point(129, 187)
        Me.txtHora_de_Retorno.Name = "txtHora_de_Retorno"
        Me.txtHora_de_Retorno.Size = New System.Drawing.Size(221, 20)
        Me.txtHora_de_Retorno.TabIndex = 9
        '
        'txtHora_de_Salida
        '
        Me.txtHora_de_Salida.Location = New System.Drawing.Point(129, 113)
        Me.txtHora_de_Salida.Name = "txtHora_de_Salida"
        Me.txtHora_de_Salida.Size = New System.Drawing.Size(221, 20)
        Me.txtHora_de_Salida.TabIndex = 8
        '
        'txtFecha_de_Salida
        '
        Me.txtFecha_de_Salida.Location = New System.Drawing.Point(129, 71)
        Me.txtFecha_de_Salida.Name = "txtFecha_de_Salida"
        Me.txtFecha_de_Salida.Size = New System.Drawing.Size(221, 20)
        Me.txtFecha_de_Salida.TabIndex = 7
        '
        'txtidDetalle
        '
        Me.txtidDetalle.Location = New System.Drawing.Point(129, 40)
        Me.txtidDetalle.Name = "txtidDetalle"
        Me.txtidDetalle.Size = New System.Drawing.Size(221, 20)
        Me.txtidDetalle.TabIndex = 6
        '
        'erroricono
        '
        Me.erroricono.ContainerControl = Me
        '
        'datalistado
        '
        Me.datalistado.AllowUserToAddRows = False
        Me.datalistado.AllowUserToDeleteRows = False
        Me.datalistado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datalistado.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Eliminar})
        Me.datalistado.Location = New System.Drawing.Point(422, 121)
        Me.datalistado.Name = "datalistado"
        Me.datalistado.ReadOnly = True
        Me.datalistado.Size = New System.Drawing.Size(366, 288)
        Me.datalistado.TabIndex = 7
        '
        'cbocampo
        '
        Me.cbocampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbocampo.FormattingEnabled = True
        Me.cbocampo.Items.AddRange(New Object() {"idDetalle"})
        Me.cbocampo.Location = New System.Drawing.Point(422, 81)
        Me.cbocampo.Name = "cbocampo"
        Me.cbocampo.Size = New System.Drawing.Size(121, 21)
        Me.cbocampo.TabIndex = 8
        '
        'txtbuscar
        '
        Me.txtbuscar.Location = New System.Drawing.Point(567, 82)
        Me.txtbuscar.Name = "txtbuscar"
        Me.txtbuscar.Size = New System.Drawing.Size(221, 20)
        Me.txtbuscar.TabIndex = 13
        '
        'inexistente
        '
        Me.inexistente.AutoSize = True
        Me.inexistente.Location = New System.Drawing.Point(564, 253)
        Me.inexistente.Name = "inexistente"
        Me.inexistente.Size = New System.Drawing.Size(59, 13)
        Me.inexistente.TabIndex = 14
        Me.inexistente.TabStop = True
        Me.inexistente.Text = "LinkLabel1"
        '
        'Eliminar
        '
        Me.Eliminar.HeaderText = "Eliminar"
        Me.Eliminar.Name = "Eliminar"
        Me.Eliminar.ReadOnly = True
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.inexistente)
        Me.Controls.Add(Me.txtbuscar)
        Me.Controls.Add(Me.cbocampo)
        Me.Controls.Add(Me.datalistado)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form6"
        Me.Text = "Form6"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.erroricono, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.datalistado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtFecha_de_Salida As DateTimePicker
    Friend WithEvents txtidDetalle As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btnguardar As Button
    Friend WithEvents txtFecha_de_Retorno As DateTimePicker
    Friend WithEvents txtHora_de_Retorno As TextBox
    Friend WithEvents txtHora_de_Salida As TextBox
    Friend WithEvents erroricono As ErrorProvider
    Friend WithEvents txtbuscar As TextBox
    Friend WithEvents cbocampo As ComboBox
    Friend WithEvents datalistado As DataGridView
    Friend WithEvents inexistente As LinkLabel
    Friend WithEvents Eliminar As DataGridViewCheckBoxColumn
End Class
