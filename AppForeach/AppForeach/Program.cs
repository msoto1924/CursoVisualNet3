using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Crear un vector de n elementos de tipo entero (n se ingresa por teclado) 
Mostrar cuantos elementos son superiores a 100 (emplear el foreach para recorrer el vector).*/

namespace AppForeach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vector;
            int tamano, contador, contador3 = 0;
            Console.WriteLine("Programa Vector 100");
            Console.Write("Digite El Tamaño Del Vector: ");
            tamano = int.Parse(Console.ReadLine());
            vector = new int[tamano];
            for (contador = 0; contador <= tamano - 1; contador++)
            {
                Console.WriteLine ("Digite El Numero");
                vector[contador] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("El Vector Es: ");
            foreach (int contador2 in vector)
            {
                Console.WriteLine(contador2);
                if (contador2 > 100)
                {
                    contador3 = contador3 + 1;
                }
            }
            Console.WriteLine("Los Numeros Mayores De 100 Son: " + contador3);
            Console.ReadKey();        
        }
    }
}
