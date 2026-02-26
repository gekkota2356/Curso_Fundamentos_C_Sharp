interface IProducto
{
    void MostrarInfo();
    double CalcularPrecio();
}

/// <summary>
/// ///////
/// </summary>
class Bebida : IProducto
{
    public string Nombre;
    public double Precio;
    public bool EsAlcoholica;

    public void MostrarInfo()
    {
        Console.WriteLine("Nombre: " + Nombre);
        Console.WriteLine("Precio: " + Precio);
        Console.WriteLine("Es Alcoholica: " + EsAlcoholica);
    }

    public double CalcularPrecio()
    {
        return Precio;
    }
}

class PlatoFuerte : IProducto
{
    public string Nombre;
    public double Precio;
    public string Ingredientes;

    public void MostrarInfo()
    {
        Console.WriteLine("Nombre: " + Nombre);
        Console.WriteLine("Precio: " + Precio);
        Console.WriteLine("Ingredientes: " + Ingredientes);
    }

    public double CalcularPrecio()
    {
        return Precio * 1.10; 
    
    }
}

class Program
{
    static void Main()
    {
        IProducto bebida1 = new Bebida {Nombre="Jugo de Naranja",Precio=30,EsAlcoholica=false };
        bebida1.MostrarInfo();
        Console.WriteLine("Precio: " + bebida1.CalcularPrecio());



        IProducto plato1 = new PlatoFuerte { Nombre = "Filete", Precio = 150, Ingredientes = "Res y especias" };
        plato1.MostrarInfo();
        Console.WriteLine("Precio: " + plato1.CalcularPrecio());
    }
}






























/*using static System.Runtime.InteropServices.JavaScript.JSType;

class Persona
{
    public string nombre;
    public int edad;
    public Persona(string nombre, int edad)
    {
        this.nombre = nombre;
        this.edad = edad;
    }
    /*
    public Persona(string nombre, int edad)
    {
        nombre = Nombre;
        edad = Edad;
    }
    public Persona()
    {
        nombre = "Nombre";
        edad = 0;
    }

}
 class Program
{
    static void Main()
    {
        Persona p1 = new Persona("Ana", 28);
        Console.WriteLine("Nombre: " + p1.nombre + ", Edad: " + p1.edad);


        Persona p2 = new Persona();
        Console.WriteLine($"Nombre: {p2.nombre}, Edad:  {p2.edad}");
    }
}

class Persona
{
    public int Edad
    {
        get { return Edad; }
        set
        {
            if (value >= 0)
                Edad = value;
        }
    }
}
class Program
{
    static void Main()
    {
        Persona p1 = new Persona();
        p1.Edad = 25;
        Console.WriteLine("La edad de la persona es: " + p1.Edad);
    }
}
class Persona
{
    public string nombre;
    public int edad;
    public void Saludar()
    {
        Console.WriteLine($"Hola, mi nombre es  {nombre}   y tengo {edad} años.");

    }
    public string ObtenerNombre()
    {
        return nombre;
    }
}

class Program {    
    static void Main()
    {
        Persona p1 = new Persona();
        p1.nombre = "Juan";
        p1.edad = 30;
        p1.Saludar();
        Console.WriteLine("El nombre de la primera persona es: " + p1.ObtenerNombre());
    }





abstract class Producto{
    public string nombre;
    public double precio;

    public void MostrarInfo(){
        Console.WriteLine("Nombre: " + nombre);
        Console.WriteLine("Precio: " + precio);
    }

    public abstract double CalcularPrecioFinal();
}
class Bebida:Producto
{
    public bool EsAlcholica;


    public override double CalcularPrecioFinal() 
    {
        return EsAlcholica ? precio * 1.21 : precio * 1.10;
    }
}

class PlatoFuerte : Producto
{
    public string Ingredientes;


    public override double CalcularPrecioFinal()
    {
        return precio * 1.10;
    }
}

class Program
{
    static void Main()
    {
        //Producto p = new Producto(); // No se puede instanciar una clase abstracta

        Bebida bebida1 = new Bebida();
        bebida1.nombre = "Cerveza";
        bebida1.precio = 100;
        bebida1.EsAlcholica = false;


        PlatoFuerte plato1 = new PlatoFuerte();
        plato1.nombre = "Milanesa con papas fritas";
        plato1.precio = 500;
        plato1.Ingredientes = "Carne, pan rallado, papas";

        // Mostrar info y precio final
        bebida1.MostrarInfo();
        Console.WriteLine("Precio final: " + bebida1.CalcularPrecioFinal());
        plato1.MostrarInfo();
        Console.WriteLine("Precio final: " + plato1.CalcularPrecioFinal());
    }
}
*/








/* System;
using ProgramacionOrientadaObjetos;
    
        MiProyectoPOO p1 = new MiProyectoPOO();
        p1.nombre = Console.ReadLine();
        p1.edad = int.Parse(Console.ReadLine());

        MiProyectoPOO aime = new MiProyectoPOO();
        aime.nombre = Console.ReadLine();
        aime.edad = int.Parse(Console.ReadLine());

        // Console.WriteLine("Hola");
        p1.Saludar();
        aime.Saludar();*/

/*
namespace ProgramacionOrientadaObjetos
{
    public class Program
    {
 
        public static void Main()
        {
            MiProyectoPOO p1 = new MiProyectoPOO();
            p1.nombre = Console.ReadLine();
            p1.edad = int.Parse(Console.ReadLine()); 

            MiProyectoPOO aime = new MiProyectoPOO();
            aime.nombre = Console.ReadLine();
            aime.edad = int.Parse(Console.ReadLine());

            // Console.WriteLine("Hola");
            p1.Saludar();
            aime.Saludar();

        }
    }
}*/