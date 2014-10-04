using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int piezas, contador=1; 
            float longitud;
            Console.WriteLine("Programa Fabrica De Perfiles");
            Console.WriteLine("Lea Numero De Piezas: ");
            piezas = int.Parse (Console.ReadLine());
            while (contador <= piezas) 
            {
                Console.WriteLine("Lea La Longitud");
                longitud = float.Parse(Console.ReadLine());
                if (longitud >= 1.20 && longitud <=1.30)
                {
                Console.WriteLine("La Pieza " + longitud + " Es Apta");
                contador++;

                }
                else
                {
                Console.WriteLine("Pieza No Apta");
                contador++;
                }
            }
            Console.ReadKey();
        }
    }
}
