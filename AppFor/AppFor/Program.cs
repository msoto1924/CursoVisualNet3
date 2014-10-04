using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppFor
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont1 = 0, cont2 = 0, cont3 = 0, valor = 0;
            float nota;
            Console.WriteLine("Programa Notas");
            Console.Write("Digite El Numero De Notas: ");
            valor = int.Parse(Console.ReadLine());
            for (cont1 = 1; cont1 <= valor; cont1++)
            {
                Console.Write("Digite La Nota: ");
                nota = float.Parse(Console.ReadLine());
                Console.WriteLine("La Nota " + cont1 + " Es: " + nota);
                if (nota >= 3)
                {
                    cont2 = cont2 + 1;
                }
                else
                {
                    cont3 = cont3 + 1;
                }
            }
            Console.WriteLine("Nota Mayores De 3 Son: " + cont2);
            Console.WriteLine("Nota Menores De 3 Son: " + cont3);
            Console.ReadKey();
        }
    }
}
