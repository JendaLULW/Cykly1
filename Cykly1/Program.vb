Imports System

Module Program
    Sub Main(args As String())
        Dim cislo As Integer
        Dim soucet As Integer = 0

        Console.Write("Zadejte ��slo: ")
        cislo = Console.ReadLine
        For x = 1 To cislo
            soucet = soucet + x
        Next
        Console.WriteLine($"Sou�et od 1 do {cislo} je {soucet}")
    End Sub
End Module


