using System;
using System.Collections.Generic;
using System.Linq;

class ciclos
{
    public static void Ejecutar8()
    {
        // Lista de números
        List<int> numeros = new List<int> { 1, 3, 5, 8, 12, -2, 0 };

        // --------------------
        // 1. Ciclo for: sumar números positivos
        int sumaPositivos = 0;
        for (int i = 0; i < numeros.Count; i++)
        {
            if (numeros[i] > 0)
                sumaPositivos += numeros[i];
        }
        Console.WriteLine("Suma de positivos (for): " + sumaPositivos);

        // --------------------
        // 2. Ciclo while: contar números mayores que 5
        int contador = 0;
        int index = 0;
        while (index < numeros.Count)
        {
            if (numeros[index] > 5)
                contador++;
            index++;
        }
        Console.WriteLine("Cantidad de números mayores a 5 (while): " + contador);

        // --------------------
        // 3. Ciclo do-while: mostrar números hasta el primer negativo
        int idx = 0;
        do
        {
            Console.WriteLine("Número (do-while): " + numeros[idx]);
            idx++;
        } while (idx < numeros.Count && numeros[idx] >= 0);

        // --------------------
        // 4. LINQ: filtrar y clasificar números positivos
        var clasificacion = numeros
            .Where(x => x > 0) // Filtra positivos
            .Select(x => (x > 10) ? "Muy grande" : (x > 5) ? "Grande" : "Pequeño");

        Console.WriteLine("Clasificación con LINQ: " + string.Join(", ", clasificacion));
    }
}
