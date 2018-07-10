Imports Entidades9_7

Module tiendaTest
    Sub main()
        Dim cancion1 As New Cancion(1, "Fulanito de tal")
        Dim interprete1 As New Interprete(1, "sebastian fernandes", 10)
        Dim discografica As New Discografia(1, "Alab", 10)
        Dim descarga1 As New Descarga(cancion1, "10/12/2018", 350)
        Dim tienda1 As New tienda(10)

        interprete1.porcentajeRegalias = 10
        Console.WriteLine("Lista de descargas....")
        For Each descarga As Descarga In tienda1.getAllDescargas
            Console.WriteLine(descarga)
        Next
        'Console.WriteLine("Interpretes descargados: " & tienda1.getAllDescargasByDiscografica(interprete1))
        'For Each can1 As Interprete In tienda1.getAllDescargasByDiscografica
        '    Console.WriteLine(can1)
        'Next
        Console.ReadKey()
    End Sub

End Module
