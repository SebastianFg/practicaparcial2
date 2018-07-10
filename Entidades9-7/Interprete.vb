Public NotInheritable Class Interprete
    Inherits Entidad
    Implements Regalias
    Private _PorcentajeRegalias As Single

    Sub New(id As Integer, nombre As String, PorcentajeRegalias As Single)
        MyBase.New(id, nombre)
        Me.porcentajeRegalias = PorcentajeRegalias
    End Sub

    Public Overrides Function ToString() As String
        Return "El nombre del interprete es: " & nombre
    End Function

    Public Function totalRegalias(descarga As Integer, precio As Single) As Single Implements Regalias.totalRegalias
        Return (descarga * porcentajeRegalias) * precio
    End Function

    Public Property porcentajeRegalias As Single Implements Regalias.porcentajeRegalias
        Get
            Return _PorcentajeRegalias
        End Get
        Set(value As Single)
            _PorcentajeRegalias = value
        End Set
    End Property
End Class
