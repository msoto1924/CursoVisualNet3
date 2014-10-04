using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 1, suma = 0, valor, promedio,num=0;
            string linea;
            while (x<=10) 
            {
                Console.Write("Cuantos Numeros: ");
                num = int.Parse (Console.ReadLine());
                Console.Write("Ingrese su Valor: ");
                linea = Console.ReadLine();
                valor=int.Parse(linea);
                suma=suma+valor;
                x=num;
            }
            promedio=suma/num;
            Console.WriteLine ("La suma de los 10 valores es: " + suma);
            Console.WriteLine("El promedio es: " + promedio);
            Console.ReadKey();
        }
    }
}
