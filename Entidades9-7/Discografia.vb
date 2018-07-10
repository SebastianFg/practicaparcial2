Public Class Discografia
    Inherits Entidad
    Implements Regalias
    Private _porcentajeRegalias As Single

    Sub New(id As Integer, nombre As String, PorcentajeRegalias As Single)
        MyBase.New(id, nombre)
        Me.porcentajeRegalias = PorcentajeRegalias
    End Sub
    Public Overrides Function ToString() As String

        Return "El nombre del disco es: " & nombre
    End Function

    Public Function totalRegalias(descarga As Integer, precio As Single) As Single Implements Regalias.totalRegalias
        Throw New NotImplementedException
    End Function
    Public Property porcentajeRegalias As Single Implements Regalias.porcentajeRegalias
        Get
            Return _porcentajeRegalias
        End Get
        Set(value As Single)
            _porcentajeRegalias = value
        End Set
    End Property

End Class

