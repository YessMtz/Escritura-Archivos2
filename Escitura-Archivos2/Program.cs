using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Escitura_Archivos2
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter sw = new StreamWriter("Ejemplo.txt", true);
            Console.WriteLine("Ingresa tu nombre: ");
            string texto = Console.ReadLine().ToString();
            sw.WriteLine(texto);

            sw.Close();
            Console.WriteLine("escribiendo");
            Console.ReadLine();
        }
    }
}
