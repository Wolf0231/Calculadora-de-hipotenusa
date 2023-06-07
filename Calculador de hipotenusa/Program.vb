Imports System

Module Program
    Sub Main(args As String())
        'Declarar variables
        Dim A, B, C As Double
        'Llenar y validar variables
Vuelve:
        Try
            Console.Write("Calculadora de Hipotenusa")
            Console.WriteLine()
            Console.WriteLine()

            Console.Write("Escriba el primer numero")
            A = Console.ReadLine()
            Console.WriteLine()
        Catch
            If A = "" Then
                Console.Write("Debe escribir un numero, pulse cualquier tecla para continuar")
                Console.ReadKey()
                Console.Clear()
                GoTo Vuelve
            End If
            Console.WriteLine()
            Console.WriteLine()
        End Try
Vuelve2:
        Try
            Console.Write("Escriba el segundo numero")
            B = Console.ReadLine()
            Console.WriteLine()
        Catch
            If B = "" Then
                Console.Write("Debe escribir un numero, pulse cualquier tecla para continuar")
                Console.ReadKey()
                Console.Clear()
                GoTo Vuelve2
            End If
            Console.WriteLine()
            Console.WriteLine()
        End Try
        'Calcular la hipotenusa
        C = Math.Sqrt(A ^ 2 + B ^ 2)
        'Mostrar resultados
        Console.WriteLine()
        Console.Write("El resultado es " & C)
        Console.WriteLine()
        Console.WriteLine()
        Console.Write("Desea continuar (yes=si)?")
        If Option = yes Then
            Console.Clear()
            GoTo Vuelve
        End If
    End Sub
End Module
