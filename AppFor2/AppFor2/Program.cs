using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Escribir un programa que lea n números enteros y calcule la cantidad de valores mayores o iguales a 1000.//
namespace AppFor
{
    class Program
    {
        static void Main(string[] args)
        {
            int cont1 = 0, cont2 = 0, cont3 = 0, valor = 0;
            float Valores;
            Console.WriteLine("Programa Notas");
            Console.Write("Digite El Numero De Valores A Ingresar: ");
            valor = int.Parse(Console.ReadLine());
            for (cont1 = 1; cont1 <= valor; cont1++)
            {
                Console.Write("Digite Su Valor: ");
                Valores = float.Parse(Console.ReadLine());

                if (Valores >= 1000)
                {
                    cont2 = cont2 + 1;
                }
                else
                {
                    cont3 = cont3 + 1;
                }
            }
            Console.WriteLine("Los Numeros Mayores A 1000 Son: " + cont2);
            Console.ReadKey();
          }
        }
    }

