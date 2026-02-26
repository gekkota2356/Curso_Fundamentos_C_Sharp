using System;


    class manejo_de_excepciones
    {
        public static void Ejecutar7()
        {
        int a = 10;
        int b = 0;

        try
        {
            int resultado = a / b; // Esto genera una excepción
            Console.WriteLine("Resultado: " + resultado);
        }
        catch (DivideByZeroException e)
        {
            Console.WriteLine("Error: No se puede dividir entre cero.");
        }
        finally
        {
            Console.WriteLine("Fin del bloque try-catch.");
        }


    }
}
