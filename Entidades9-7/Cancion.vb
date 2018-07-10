
Public Class Cancion
    Inherits Entidad
    Private _interpretes As List(Of Interprete)

    Sub New(id As Integer, nombre As String)
        MyBase.New(id, nombre)
        _interpretes = New List(Of Interprete)
    End Sub

    Public Function getAllInterpretes() As List(Of Interprete)
        Return _interpretes
    End Function

    Public Function addInterprete(value As Interprete)
        _interpretes.Add(value)
    End Function


    Friend Sub removeInterprete(value As Interprete)
        _interpretes.Remove(value)
    End Sub

    Public Overrides Function ToString() As String

        Return "El nombre de la cancion es: " & nombre
    End Function
End Class
