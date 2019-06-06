Public Class vope
    Dim idOperador, DUI, Numero_de_Telefono As Integer
    Dim Nombre, Direccion As String
    Dim Estado_de_Operador As ComboBox


    Public Property gidOperador
        Get
            Return idOperador
        End Get
        Set(value)
            idOperador = value
        End Set
    End Property
    Public Property gNombre
        Get
            Return Nombre
        End Get
        Set(value)
            Nombre = value
        End Set
    End Property
    Public Property gDUI
        Get
            Return DUI
        End Get
        Set(value)
            DUI = value
        End Set
    End Property
    Public Property gDireccion
        Get
            Return Direccion
        End Get
        Set(value)
            Direccion = value
        End Set
    End Property
    Public Property gNumero_de_Telefono
        Get
            Return Numero_de_Telefono
        End Get
        Set(value)
            Numero_de_Telefono = value
        End Set
    End Property
    Public Property gEstado_de_Operador
        Get
            Return Estado_de_Operador
        End Get
        Set(value)
            Estado_de_Operador = value
        End Set
    End Property

    Public Sub New()

    End Sub

    Public Sub New(ByVal idOperador As Integer, ByVal Nombre As String, ByVal DUI As Integer, ByVal Direccion As String, ByVal Numero_de_Telefono As Integer, ByVal Estado_de_Operador As String)

        gidOperador = idOperador
        gNombre = Nombre
        gDUI = DUI
        gDireccion = Direccion
        gNumero_de_Telefono = Numero_de_Telefono
        gEstado_de_Operador = Estado_de_Operador

    End Sub
End Class
