using System;
using System.Collections.Generic;

namespace bonusRoundList2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio de devolver si el número introducido es par o inpar pero on listas.
            // Extra intentar hacer que el usuario proporcione los datos de la lista.
            Console.Write("Introduce el número de veces que quieras añadir un número: ");
            int repeat = int.Parse(Console.ReadLine());
            

            List<int> parInpar = new List<int>();
            parInpar.Add(4);
            parInpar.Add(7);
            parInpar.Add(19);
            parInpar.Add(22);
            parInpar.Add(13);
            
            foreach (var numbers in parInpar)
            {
                if (numbers % 2 == 0)
                {
                    Console.WriteLine("El número " + numbers + " es par.");
                }
                else
                {
                    Console.WriteLine("El número " + numbers + " es inpar.");
                }
            }
            
            /*
            string nombre = "Alvaro";
            foreach (char letter in nombre)
            {
                Console.WriteLine(letter);
            }
            */
        }
    }
}
