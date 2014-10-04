using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App_________While2
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor, contador=1;
            Console.WriteLine("Programa Valor Ingresado");
            Console.WriteLine("Digite El Valor: ");
            valor = int.Parse(Console.ReadLine());
            while (contador <= valor)
            {
                Console.WriteLine(contador);
                contador++;
            }
            Console.ReadKey();
        }
    }
}
