Public Class Descarga
    Inherits Cancion
    Private _fecha As Date
    Private _monto As Single

    Sub New(cancion As Cancion, fecha As Date, Monto As Single)
        MyBase.New(cancion.id, cancion.nombre)
        _fecha = fecha
        _monto = Monto
    End Sub

    Public Property Monto As Single
        Get
            Return _monto
        End Get
        Set(value As Single)
            _monto = value
        End Set
    End Property

    Public Property Fecha As Date
        Get
            Return _fecha
        End Get
        Set(value As Date)
            _fecha = value
        End Set
    End Property

    Public Overrides Function ToString() As String

        Return "El nombre de la cancion es: " & nombre & vbNewLine & "Fecha de descarga: " & Fecha
    End Function
End Class
