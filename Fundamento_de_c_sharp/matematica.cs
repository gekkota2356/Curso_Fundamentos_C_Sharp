
using System.Numerics;

class matematica
{
    public static void Ejecutar3()
    {
        // Valores predefinidos
        double[] amplitudes = { 5.0, 10.0, 15.0 };
        double[] frecuencias = { 50.0, 60.0, 100.0 };
        double[] fasesGrados = { 0, 45, 90 };

        Console.WriteLine("--- Valores de la señal senoidal y fasor ---\n");

        for (int i = 0; i < 3; i++)
        {
            double amplitud = amplitudes[i];
            double frecuencia = frecuencias[i];
            double fase = fasesGrados[i] * Math.PI / 180; // Convertir a radianes
            double tiempo = 0.01; // Ejemplo de instante de tiempo

            // Valor instantáneo de la señal senoidal
            double valorSeno = amplitud * Math.Sin(2 * Math.PI * frecuencia * tiempo + fase);
            Console.WriteLine($"Amplitud={amplitud} V, Frecuencia={frecuencia} Hz, Fase={fasesGrados[i]}°");
            Console.WriteLine("Valor instantáneo: " + valorSeno);

            // Representación como fasor
            Complex fasor = Complex.FromPolarCoordinates(amplitud, fase);
            Console.WriteLine("Fasor: " + fasor);
            Console.WriteLine("Magnitud: " + fasor.Magnitude);
            Console.WriteLine("Ángulo (rad): " + fasor.Phase);
            Console.WriteLine("Ángulo (°): " + (fasor.Phase * 180 / Math.PI));
            Console.WriteLine("-----------------------------");

        }
    }
}