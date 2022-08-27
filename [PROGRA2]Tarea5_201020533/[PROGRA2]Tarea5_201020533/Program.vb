Imports System

Module Program

    Function factorial(numero As Integer)
        Dim resultado As Integer = 1

        For i As Integer = 1 To numero
            resultado = resultado * i
        Next

        Return resultado
    End Function

    Sub Main(args As String())
        'Nombre: Otto Fernando Cárdenas Aguilar
        'Carnet: 201020533
        Dim num, multiplos As Integer


        Console.WriteLine("           Tarea 5 ")
        Console.WriteLine("")
        Console.Write("Ingrese un número: ")
        num = Console.ReadLine()

        Console.WriteLine("")
        Console.WriteLine("Factorial: " & factorial(num))

        Console.WriteLine("")
        Console.WriteLine("Multiplos de 4")
        multiplos = 0
        For i As Integer = 0 To factorial(num)
            If (i Mod 4 = 0) Then
                multiplos = multiplos + 1
                Console.WriteLine(i)
            End If
        Next

        Console.WriteLine("Hay " & multiplos & " multiplos de 4")


    End Sub
End Module
