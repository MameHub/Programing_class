using System;
using System.Collections.Generic;

namespace ConsoleApp21
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mostrar los datos de una lista de menor a mayor.
            // Esta mal.

            Console.WriteLine("Cuantos datos quiere introducir: ");
            int x = int.Parse(Console.ReadLine());
            
            List<int> numbers = new List<int>();

            for (int i = 0; i < x; i++)
            {
                numbers.Add(int.Parse(Console.ReadLine()));
            }
            for (int i = numbers.Count + 1; i >= 0 ; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
