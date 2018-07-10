Public MustInherit Class Entidad
    Private _id As Integer
    Private _Nombre As String

    Sub New(id As Integer, nombre As String)
        Me.nombre = nombre
        Me.id = id
    End Sub


    Public Property id As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property


    Public Property nombre As String
        Get
            Return _Nombre
        End Get
        Set(ByVal value As String)
            _Nombre = value
        End Set
    End Property
End Class
