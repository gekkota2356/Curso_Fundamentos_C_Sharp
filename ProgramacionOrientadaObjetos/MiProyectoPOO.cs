using System;
using System.Collections.Generic; // colecciones 
using System.Linq; // Consultas SQL traductor de SQL con codigo
using System.Text;
using System.Threading.Tasks;

namespace ProgramacionOrientadaObjetos
{
        
    public class MiProyectoPOO 
    {
        
        public string nombre;
        public int edad;
        public void Saludar()
        {
            Console.WriteLine("Hola, mi nombre es " + nombre + " y tengo " + edad + " años.");  
        }
    }
}
