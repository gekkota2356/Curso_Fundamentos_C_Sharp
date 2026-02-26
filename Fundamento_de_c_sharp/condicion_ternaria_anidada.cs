using System.Collections.Generic;
using System.Linq;

class condicion_ternaria_anidada
{
    public static void Ejecutar6()
    {
        // Lista de números ya definida
        List<int> numeros = new List<int> { 3, 7, 12, 1, 8, 0, 15, 5 };

        // Filtrar y clasificar usando LINQ con Select
        var resultado = numeros
            .Where(x => x >= 0) // Filtra números positivos (if implícito)
            .Select(x =>
            {
                // Clasificación usando if anidado y ternario
                if (x > 10)
                    return "Muy grande";
                else
                    return (x > 5) ? "Grande" : "Pequeño";
            });

        Console.WriteLine("Clasificación de los números positivos: " + string.Join(", ", resultado));

        // Verificar si alguno es mayor a 12 usando Any (equivalente a if)
        bool hayMuyGrandes = numeros.Any(x => x > 12);
        Console.WriteLine(hayMuyGrandes ? "Hay números muy grandes (>12)" : "No hay números muy grandes");
    }
}
