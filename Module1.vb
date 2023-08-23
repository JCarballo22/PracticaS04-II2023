'Aqui no esta disponible la variable
Module Module1
    'Aqui no esta disponible la variable
    Private variableString As String


    Sub Main()

        Dim a, b, c As Integer

        a = 1
        b = 2
        c = 3

        Console.WriteLine(a.GetType.ToString)
        Console.WriteLine(b.GetType.ToString)
        Console.WriteLine(c.GetType.ToString)

        Dim e, f As Double, g, h As Single, i, j, k As String

        e = 2.3
        f = 14.2
        g = 6.3
        h = 7.8
        i = "Tiera"
        j = "Fuego"
        k = "Agua"



        Console.WriteLine(e.GetType.ToString)
        Console.WriteLine(f.GetType.ToString)

        Console.WriteLine(g.GetType.ToString)
        Console.WriteLine(h.GetType.ToString)

        Console.WriteLine(i.GetType.ToString)
        Console.WriteLine(j.GetType.ToString)
        Console.WriteLine(k.GetType.ToString)





        'Aqui no esta disponible la variable
        Dim miVariable As String = "Hola Estudiantes de programación II"
        'Aqui Si esta disponible la variable
        Dim valorBool = True
        If (valorBool = True) Then
            'En este bloque interior tambien esta disponible la variable
            Console.WriteLine(miVariable)
        End If

        ciclo()
        'Console.WriteLine("Estoy estudiando el Ciclo IV")

        carrera("Lic. en Computación & Tec. en Computación")

        inicializarVariablePrivada()

        usarVariablePrivada()

        Concatenar()

    End Sub

    Sub ciclo()
        Console.WriteLine("Estoy estudiando el Ciclo IV")

    End Sub

    Sub carrera(ByVal texto As String)
        Console.WriteLine("Somos de las carreras de: " + texto)

    End Sub

    Sub inicializarVariablePrivada()
        variableString = "Universidad Dr. Andres Bello"
    End Sub

    Sub usarVariablePrivada()
        Console.WriteLine(variableString)
    End Sub

    Sub Concatenar()
        Saludar()
        Dim nombre As String = "Maria", apellido As String = "Gomes"
        Dim nombreCompleto = nombre + " " + apellido
        Console.WriteLine(nombreCompleto)
        apellido = "Gómez"
        nombreCompleto = nombre + " " + apellido
        Console.WriteLine(nombreCompleto)

    End Sub

    Sub Saludar()
        Console.WriteLine("Hola Liliana")
    End Sub

    Sub boque()
        Dim N As Integer = 7
        If N < 100 Then
            Dim variable As Integer
            variable = N * 3
            Console.WriteLine(variable)
        End If

        'Console.WriteLine(variable)
    End Sub

    'Console.WriteLine(variable)

End Module
'Aqui no esta disponible la variable
