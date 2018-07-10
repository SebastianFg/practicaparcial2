Imports Entidades9_7
Module discografiaTest
    Sub main()
        Dim disco1 As New Discografia(1, "Aba", 10)

        Console.WriteLine("disco1 nombre >> " & disco1.nombre)
        Console.WriteLine("toString >> " & disco1.ToString())
        Console.ReadKey()
    End Sub
End Module
