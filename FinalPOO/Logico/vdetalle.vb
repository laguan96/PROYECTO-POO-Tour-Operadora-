Public Class vdetalle
    Dim idDetalle, Hora_de_Salida, Hora_de_Retorno As String
    Dim Fecha_de_Salida, Fecha_de_Retorno As DateTimePicker

    Public Property gidDetalle
        Get
            Return idDetalle
        End Get
        Set(value)
            idDetalle = value
        End Set
    End Property


    Public Property gFecha_de_Salida
        Get
            Return Fecha_de_Salida
        End Get
        Set(value)
            Fecha_de_Salida = value
        End Set
    End Property

    Public Property gHora_de_Salida
        Get
            Return Hora_de_Salida
        End Get
        Set(value)
            Hora_de_Salida = value
        End Set
    End Property

    Public Property gFecha_de_Retorno
        Get
            Return Fecha_de_Retorno
        End Get
        Set(value)
            Fecha_de_Retorno = value
        End Set
    End Property

    Public Property gHora_de_Retorno
        Get
            Return Hora_de_Retorno
        End Get
        Set(value)
            Hora_de_Retorno = value
        End Set
    End Property
End Class
