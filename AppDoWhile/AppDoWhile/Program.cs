using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Realizar un programa que acumule (sume) valores ingresados por teclado hasta ingresar el 9999 
(no sumar dicho valor, indica que ha finalizado la carga). Imprimir el valor acumulado e informar 
si dicho valor es cero, mayor a cero o menor a cero.*/

namespace AppDoWhile
{
    class Program
    {
        static void Main(string[] args)
        {
            int suma=0, valor;
            Console.WriteLine("Programa Suma De Valores");
            do
            {
                Console.Write ("Digite El Valor:  ");
                valor = int.Parse (Console.ReadLine());
                if (valor == 9999)
                {
                    break;
                }
                else
                {
                    suma = suma + valor;
                }
            }
            while(valor != 9999);
            Console.WriteLine ("El Valor Acumulado Es: " + suma);
            if (valor == 0)
            {
                Console.WriteLine("El Valor Acumulado Es Igual A Cero");
            }
            else if (suma > 0)
            {
                Console.WriteLine("El Valor Acumulado Es Mayor A Cero");

            }
            else
            {
                Console.WriteLine("El Valor Acumulado Es Menor A Cero");

            }
            Console.ReadKey();
        }
    }
}
