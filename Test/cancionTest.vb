Imports Entidades9_7
Module cancionTest
    Sub main()
        Dim cancion1 As New Cancion(1, "Fulanito de tal")
        Dim interprete1 As New Interprete(1, "sebastian fernandes", 10)
        Dim discografica As New Discografia(1, "Alab", 10)
        Dim precio1 As Single = 2
        Dim descargas1 As Integer = 350
        Dim precio2 As Single = 1
        Dim descargas2 As Integer = 100
        Dim regalias As Single = 0.01
        interprete1.porcentajeRegalias = regalias

        Console.WriteLine("total de regalias interprete = " & interprete1.totalRegalias(descargas1, precio1))
        Console.WriteLine("Nombre de la cancion1: >> " & cancion1.nombre)

        cancion1.addInterprete(interprete1)

        Dim cancion2 As New Cancion(2, "Ela Rco")
        Console.WriteLine("total de regalias interprete = " & interprete1.totalRegalias(descargas2, precio2))
        Console.WriteLine("Nombre de la cancion2: >> " & cancion2.nombre)
        Console.WriteLine("Discografica emisiora " & discografica.nombre)
        Console.WriteLine("con un total de regalias de: " & interprete1.totalRegalias(descargas2, precio2) + interprete1.totalRegalias(descargas1, precio1))

        For Each can1 As Interprete In cancion1.getAllInterpretes
            Console.WriteLine(can1)
        Next


        Console.ReadKey()
    End Sub
End Module
