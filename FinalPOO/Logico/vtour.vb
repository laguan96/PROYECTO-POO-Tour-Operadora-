Public Class vtour
    Dim idTour, idDetalle_Tour, idFlota As Integer
    Dim Total_Asientos_Cancelados, Total_Asientos_Disponibles, Costo_del_Tour, Fecha_Limite_de_Pago As String
    Dim Nombre_del_Tour As ComboBox


    Public Property gidTour
        Get
            Return idTour
        End Get
        Set(value)
            idTour = value
        End Set
    End Property

    Public Property gidDetalle_Tour
        Get
            Return idDetalle_Tour
        End Get
        Set(value)
            idDetalle_Tour = value
        End Set
    End Property

    Public Property gidFlota
        Get
            Return idFlota
        End Get
        Set(value)
            idFlota = value
        End Set
    End Property

    Public Property gNombre_del_Tour
        Get
            Return Nombre_del_Tour
        End Get
        Set(value)
            Nombre_del_Tour = value
        End Set
    End Property

    Public Property gTotal_Asientos_Cancelados
        Get
            Return Total_Asientos_Cancelados
        End Get
        Set(value)
            Total_Asientos_Cancelados = value
        End Set
    End Property

    Public Property gTotal_Asientos_Disponibles
        Get
            Return Total_Asientos_Disponibles
        End Get
        Set(value)
            Total_Asientos_Disponibles = value
        End Set
    End Property

    Public Property gCosto_del_Tour
        Get
            Return Costo_del_Tour
        End Get
        Set(value)
            Costo_del_Tour = value
        End Set
    End Property

    Public Property gFecha_Limite_de_Pago
        Get
            Return Fecha_Limite_de_Pago
        End Get
        Set(value)
            Fecha_Limite_de_Pago = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal idTour As Integer, ByVal idDetalle_Tour As Integer, ByVal idFlota As Integer, ByVal Total_Asientos_Cancelados As String, ByVal Total_Asientos_Disponibles As String, ByVal Costo_del_Tour As String, ByVal Fecha_Limite_de_Pago As String)

        gidTour = idTour
        gidDetalle_Tour = idDetalle_Tour
        gidFlota = idFlota
        gNombre_del_Tour = Nombre_del_Tour
        gTotal_Asientos_Cancelados = Total_Asientos_Cancelados
        gTotal_Asientos_Disponibles = Total_Asientos_Disponibles
        gCosto_del_Tour = Costo_del_Tour
        gFecha_Limite_de_Pago = Fecha_Limite_de_Pago


    End Sub
End Class
