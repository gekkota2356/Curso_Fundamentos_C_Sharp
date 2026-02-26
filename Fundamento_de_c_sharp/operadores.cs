class operadores 
{
    public static void Ejecutar2()
    {
        Console.Write("Ingresa el valor de a: ");
        int a = int.Parse(Console.ReadLine());//método estático

        Console.Write("Ingresa el valor de b: ");
        int b = int.Parse(Console.ReadLine());

        // Aritméticos
        Console.WriteLine("\n--- Aritméticos ---");
        Console.WriteLine("Suma: " + (a + b));
        Console.WriteLine("Resta: " + (a - b));
        Console.WriteLine("Multiplicación: " + (a * b));
        Console.WriteLine("División: " + (a / b));
        Console.WriteLine("Módulo: " + (a % b));

        // Relacionales
        Console.WriteLine("\n--- Relacionales ---");
        Console.WriteLine("a > b : " + (a > b));
        Console.WriteLine("a < b : " + (a < b));
        Console.WriteLine("a == b: " + (a == b));
        Console.WriteLine("a != b: " + (a != b));

        // Lógicos
        Console.WriteLine("\n--- Lógicos ---");
        bool p = (a > b);   // true si a es mayor que b
        bool q = (a < 0);   // true si a es menor que 0
        Console.WriteLine("p && q: " + (p && q));
        Console.WriteLine("p || q: " + (p || q));
        Console.WriteLine("!p    : " + (!p));

        // Para pausar la consola antes de cerrar
        Console.WriteLine("\nPresiona ENTER para salir...");
        Console.ReadLine();
    }
        }
