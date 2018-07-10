Imports Entidades9_7
Module descargaTest
    Sub main()

        Dim cancion1 As New Cancion(1, "Fulanito de tal")
        Dim interprete1 As New Interprete(1, "sebastian fernandes", 10)
        Dim discografica As New Discografia(1, "Alab", 10)
        Dim descarga1 As New Descarga(cancion1, "10/12/2018", 350)
        interprete1.porcentajeRegalias = 10

        Console.WriteLine("toString >> " & descarga1.ToString())
        Console.ReadKey()
    End Sub

End Module
