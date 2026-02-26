class tipos_variables
{

    public static void Ejecutar1()
    {
        Console.Write("Ingresa tu nombre: ");
        string nombre = Console.ReadLine();

        Console.Write("Ingresa tu edad: ");
        int edad = int.Parse(Console.ReadLine());

        Console.Write("Ingresa tu estatura: ");
        float estatura = float.Parse(Console.ReadLine());

        Console.Write("¿Estás activo? (true/false): ");
        bool activo = bool.Parse(Console.ReadLine());

        Console.Write("Ingresa una letra inicial: ");
        char inicial = char.Parse(Console.ReadLine());

        // Uso de var
        var mensaje = "Hola desde C# con var";

        // Uso de dynamic
        dynamic dato = "Soy flexible";

        // Mostrar resultados
        Console.WriteLine("\n--- Resultados ---");
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Edad: " + edad);
        Console.WriteLine("Estatura: " + estatura);
        Console.WriteLine("Activo: " + activo);
        Console.WriteLine("Inicial: " + inicial);
        Console.WriteLine("Mensaje (var): " + mensaje);
        Console.WriteLine("Dato (dynamic): " + dato);
    }
        }