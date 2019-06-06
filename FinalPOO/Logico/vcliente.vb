Public Class vcliente
    Dim idCliente As Integer
    Dim Nombre, Apellido, Dirección, Genero As String
    Dim DUI As Integer

    Public Property gidCliente
        Get
            Return idCliente
        End Get
        Set(value)
            idCliente = value
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

    Public Property gApellido
        Get
            Return Apellido
        End Get
        Set(value)
            Apellido = value
        End Set
    End Property

    Public Property gDirección
        Get
            Return Dirección
        End Get
        Set(value)
            Dirección = value
        End Set
    End Property

    Public Property gGenero
        Get
            Return Genero
        End Get
        Set(value)
            Genero = value
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

    Public Sub New()

    End Sub

    Public Sub New(ByVal idCliente As Integer, ByVal Nombre As String, ByVal Apellido As String, ByVal Dirección As String, ByVal Genero As String, ByVal DUI As Integer)

        gidCliente = idCliente
        gNombre = Nombre
        gApellido = Apellido
        gDirección = Dirección
        gGenero = Genero
        gDUI = DUI


    End Sub
End Class
