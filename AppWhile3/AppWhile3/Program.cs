using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppWhile3
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor, numero, suma = 0, promedio, contador = 1;
            Console.WriteLine("Programa Suma Y Promedio");
            Console.WriteLine("ingrese el Numero De Valores");
            valor = int.Parse(Console.ReadLine());
            while (contador <= valor)
            {
                Console.WriteLine("Digite El Numero");
                numero = int.Parse(Console.ReadLine());
                suma = suma + numero;
                contador++;
            }
            promedio = suma / valor;
            Console.WriteLine("La Suma Es " + suma);
            Console.WriteLine("El Promedio Es " + promedio);
            Console.ReadKey();
        }
    }
}
