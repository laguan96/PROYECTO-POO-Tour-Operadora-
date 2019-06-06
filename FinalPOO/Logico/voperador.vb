Public Class voperador
    Dim idReserva, idOperador, idCliente, Pago, Valor_Pendiente As Integer
    Dim Fecha_de_Reserva As String


    Public Property gidReserva
        Get
            Return idReserva
        End Get
        Set(value)
            idReserva = value
        End Set
    End Property

    Public Property gidOperador
        Get
            Return idOperador
        End Get
        Set(value)
            idOperador = value
        End Set
    End Property

    Public Property gidCliente
        Get
            Return idCliente
        End Get
        Set(value)
            idCliente = value
        End Set
    End Property

    Public Property gPago
        Get
            Return Pago
        End Get
        Set(value)
            Pago = value
        End Set
    End Property

    Public Property gValor_Pendiente
        Get
            Return Valor_Pendiente
        End Get
        Set(value)
            Valor_Pendiente = value
        End Set
    End Property

    Public Property gFecha_de_Reserva
        Get
            Return Fecha_de_Reserva
        End Get
        Set(value)
            Fecha_de_Reserva = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal idReserva As Integer, ByVal idOperador As Integer, ByVal idCliente As Integer, ByVal Fecha_de_Reserva As String, ByVal Pago As Integer, ByVal Valor_Pendiente As Integer)
        gidReserva = idReserva
        gidOperador = idOperador
        gidCliente = idCliente
        gFecha_de_Reserva = Fecha_de_Reserva
        gPago = Pago
        gValor_Pendiente = Valor_Pendiente


    End Sub
End Class
