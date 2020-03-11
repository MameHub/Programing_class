using System;
using System.Collections.Generic;

namespace ConsoleApp20
{
    class Program
    {
        static void Main(string[] args)
        {
            // El usuario introduce una serie de números y los mostramos de mayor a menor.

            Console.Write("Introduzca la cantidad de números que quiera introducir: ");
            int lat = int.Parse(Console.ReadLine());

            List<int> numbers = new List<int>();
            for (int i = 0; i < lat; i++)
            {
                numbers.Add(int.Parse(Console.ReadLine()));
            }
            for (int i = numbers.Count - 1; i >= 0; i--)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
