Module Module1

    Sub Main()
        Console.WriteLine("Ingrese el primer valor:")
        Dim valor1 As Integer = Integer.Parse(Console.ReadLine())

        Console.WriteLine("Ingrese el segundo valor:")
        Dim valor2 As Integer = Integer.Parse(Console.ReadLine())

        Console.WriteLine("Ingrese el tercer valor:")
        Dim valor3 As Integer = Integer.Parse(Console.ReadLine())

        ' Identificar el mayor de los tres valores
        Dim mayor As Integer = valor1

        If valor2 > mayor Then
            mayor = valor2
        End If

        If valor3 > mayor Then
            mayor = valor3
        End If

        ' Mostrar el mayor valor
        Console.WriteLine("El mayor de los tres valores es: " & mayor)

        ' Esperar que el usuario presione una tecla antes de salir
        Console.WriteLine("Presione cualquier tecla para salir...")
        Console.ReadKey()
    End Sub

End Module
