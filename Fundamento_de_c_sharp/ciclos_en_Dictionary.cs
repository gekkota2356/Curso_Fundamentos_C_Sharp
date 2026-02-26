using System.Collections.Generic;
class ciclos_en_Dictionary
{
    public static void Ejecutar9()
    {
        Dictionary<string, int> estudiantes = new Dictionary<string, int>
{
    {"Ana", 20},
    {"Luis", 22},
    {"Marta", 19}
};

        foreach (var kvp in estudiantes)
        {
            Console.WriteLine($"{kvp.Key} tiene {kvp.Value} años");
        }
    }
}
