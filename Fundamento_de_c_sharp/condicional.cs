using System.Linq;

class condicional
{
    public static void Ejecutar5()
    {
        int[] numeros = { 1, 2, 3, 4, 5, 6, 7, 8 };

        // Filtrar números mayores a 2 y clasificarlos con if/else
        var resultado = numeros
            .Where(x => x > 2)   // Filtrado (equivalente a if)
            .Select(x =>
            {
                if (x > 6)
                    return "Muy alto";
                else if (x > 4)
                    return "Alto";
                else
                    return "Moderado";
            });

        Console.WriteLine("Resultados: " + string.Join(", ", resultado));
    }
}
