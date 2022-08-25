Imports System
Module Program
    Function Orden()
        Dim a, b, c As Double

        Console.WriteLine("      PROBLEMA 1")
        Console.WriteLine("")
        Console.WriteLine("Ingrese 3 números")
        Console.Write("numero a: ")
        a = Console.ReadLine()
        Console.Write("numero b: ")
        b = Console.ReadLine()
        Console.Write("numero c: ")
        c = Console.ReadLine()

        Console.WriteLine("-------------------")
        Console.WriteLine("Resulado en orden descendente")
        If (a > b) Then
            If (a > c) Then
                If (b > c) Then
                    Console.WriteLine("" & a)
                    Console.WriteLine("" & b)
                    Console.WriteLine("" & c)
                Else
                    Console.WriteLine("" & a)
                    Console.WriteLine("" & c)
                    Console.WriteLine("" & b)
                End If
            Else
                If (b < c) Then
                    Console.WriteLine("" & c)
                    Console.WriteLine("" & a)
                    Console.WriteLine("" & b)
                Else
                    Console.WriteLine("" & b)
                    Console.WriteLine("" & a)
                    Console.WriteLine("" & c)
                End If
            End If
        Else
            If (a < c) Then
                If (b > c) Then
                    Console.WriteLine("" & b)
                    Console.WriteLine("" & c)
                    Console.WriteLine("" & a)
                Else
                    Console.WriteLine("" & c)
                    Console.WriteLine("" & b)
                    Console.WriteLine("" & a)
                End If
            Else
                If (b > c) Then
                    Console.WriteLine("" & b)
                    Console.WriteLine("" & a)
                    Console.WriteLine("" & c)
                Else
                    Console.WriteLine("" & c)
                    Console.WriteLine("" & a)
                    Console.WriteLine("" & b)
                End If
            End If
        End If

        Console.WriteLine("******************************************")
        Console.WriteLine("")
        menu()
    End Function
    Function triangulo()
        Dim a, b, c As Double

        Console.WriteLine("      PROBLEMA 2")
        Console.WriteLine("")
        Console.WriteLine("Ingrese la longitud de los tres lados de un triangulo")
        Console.Write("Lado a: ")
        a = Console.ReadLine()
        Console.Write("Lado b: ")
        b = Console.ReadLine()
        Console.Write("Lado c: ")
        c = Console.ReadLine()

        Console.WriteLine("-------------------")
        Console.WriteLine("El triangulo es de tipo:")

        If (a = b And b = c) Then
            Console.WriteLine("      Equilatero")
        Else
            If (a = b Or a = c Or b = c) Then
                Console.WriteLine("      Isosceles")
            Else
                Console.WriteLine("      Escaleno")
            End If
        End If

        Console.WriteLine("******************************************")
        Console.WriteLine("")
        menu()
    End Function
    Function Conteo()
        Dim num, suma As Double

        suma = 0

        Console.WriteLine("      PROBLEMA 3")
        Console.WriteLine("")
        Console.Write("Escriba un número: ")
        num = Console.ReadLine()
        Console.WriteLine("--------------------")
        Console.WriteLine("Resultado: ")

        For i As Integer = 0 To num
            Console.WriteLine(i)
            suma = suma + i
        Next

        Console.WriteLine("La suma de números es: " & suma)
        If ((suma Mod 2) = 0) Then
            Console.WriteLine("La suma es par")
        Else
            Console.WriteLine("La suma es impar")
        End If
        Console.WriteLine("******************************************")
        Console.WriteLine("")
        menu()
    End Function
    Function signo()
        Dim num, suma As Double

        suma = 0

        Console.WriteLine("      PROBLEMA 4")
        Console.WriteLine("")
        Console.Write("Escriba un número: ")
        num = Console.ReadLine()
        Console.WriteLine("--------------------")
        Console.WriteLine("Resultado: ")

        If (num < 0) Then
            For i As Double = 0 To num Step -0.5
                Console.WriteLine(i)
            Next
        Else
            For i As Double = 0 To num Step 2
                Console.WriteLine(i)
            Next
        End If

        Console.WriteLine("******************************************")
        Console.WriteLine("")
        menu()
    End Function
    Function notas()
        Dim mate, fisica, progra, promedio As Integer

        Console.WriteLine("      PROBLEMA 5")
        Console.WriteLine("")
        Console.WriteLine("Ingrese las notas obtenidas")
        Console.Write("Matematicas: ")
        mate = Console.ReadLine()
        Console.Write("Fisica: ")
        fisica = Console.ReadLine()
        Console.Write("Programacion: ")
        progra = Console.ReadLine()
        Console.WriteLine("-------------------")
        Console.Write("Resultado ")

        promedio = (mate + fisica + progra) / 3
        Console.WriteLine("Promedio: " & promedio)
        Select Case promedio
            Case < 61
                Console.WriteLine("Reprobado")
            Case > 80
                Console.WriteLine("Excelente")
            Case Else
                Console.WriteLine("Regular")
        End Select

        Console.WriteLine("******************************************")
        Console.WriteLine("")
        menu()
    End Function
    Function menu()
        Dim a As Integer

        Console.WriteLine("--------------------------------------------")
        Console.WriteLine(" 1 - Problema 1: Orde de mayor a menor")
        Console.WriteLine(" 2 - Problema 2: Tipo de triangulo")
        Console.WriteLine(" 3 - Problema 3: Suma de números")
        Console.WriteLine(" 4 - Problema 4: Número positivo o negativo")
        Console.WriteLine(" 5 - Problema 5: Promedio de notas")
        Console.WriteLine(" 0 - Salir")
        Console.WriteLine("--------------------------------------------")
        Console.WriteLine("")
        Console.Write("Ingrese el número de la opcion del problema: ")
        a = Console.ReadLine()
        Console.WriteLine("")

        Select Case a
            Case 0
                Environment.Exit(0)
            Case 1
                Console.WriteLine("******************************************")
                Orden()
            Case 2
                Console.WriteLine("******************************************")
                triangulo()
            Case 3
                Console.WriteLine("******************************************")
                Conteo()
            Case 4
                Console.WriteLine("******************************************")
                signo()
            Case 5
                Console.WriteLine("******************************************")
                notas()
            Case Else
                Console.WriteLine("Ingrese correctamente el número de la opcion")
                Console.WriteLine("")
                menu()
        End Select
    End Function
    Sub Main(args As String())
        Console.WriteLine("Nombre: Otto Fernando Cárdenas Aguilar")
        Console.WriteLine("Carnet: 201020533")
        Console.WriteLine("")
        Console.WriteLine("             HOJA DE TRABAJO 1          ")
        menu()

    End Sub
End Module