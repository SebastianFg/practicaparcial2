Public Class tienda


    ' aca no se como seguir! ayuda! correcciones! jaja
    'muy muy perdido!!
    Private _valorDescarga As Single
    Private _descargas As List(Of Descarga)
    Sub New(valorDescarga As Single, pepe As Descarga)
        ''MyBase.New(pepe.id, pepe.nombre)
        _valorDescarga = valorDescarga
        _descargas = New List(Of Descarga)
    End Sub

    Public Property ValorDescarga As Single
        Get
            Return _valorDescarga
        End Get
        Set(value As Single)
            _valorDescarga = value
        End Set
    End Property
    Public Function addDescarga(value As Descarga)
        _descargas.Add(value)
    End Function


    Public Function getAllDescargas() As List(Of Descarga)
        Return _descargas
    End Function
    Public Function getAllDescargasByDiscografica(value As Interprete) As List(Of Descarga)
        For Each interprete In _descargas
            If (interprete.id = value.id) Then
                Return _descargas
            End If
        Next
    End Function
End Class
