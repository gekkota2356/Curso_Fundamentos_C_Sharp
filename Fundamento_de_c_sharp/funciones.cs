using System.Linq;

class funciones
{
    // Función que valida si una contraseña es segura
    static bool EsContraseñaSegura(string password)
    {
        // Reglas: mínimo 8 caracteres, al menos un número, al menos una mayúscula
        bool longitud = password.Length >= 8;
        bool tieneNumero = password.Any(char.IsDigit);// Verifica si alguno o todos cumplen condición
        bool tieneMayuscula = password.Any(char.IsUpper);// Verifica si alguno o todos cumplen condición

        return longitud && tieneNumero && tieneMayuscula;
    }

    public static void Ejecutar4()
    {
        Console.Write("Ingresa tu contraseña: ");
        string contraseña = Console.ReadLine();

        if (EsContraseñaSegura(contraseña))
            Console.WriteLine("Contraseña segura");
        else
            Console.WriteLine("Contraseña débil");
    }
}
