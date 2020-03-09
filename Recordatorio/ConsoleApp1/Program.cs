using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Le mostramos en pantalla la cantidad de veces que se repiten los números introducidos en una lista.
            // Incapaz de hacerlo, copiado del profesor.

            int[] allNumbers = new int[] { 3, 3, 3, 2, 1, 1, 5, 5, 78, 78, 24 };
            List<int> numbers = new List<int>();

            bool repeated = false;
            for (int i = 0; i < allNumbers.Length; i++)
            {
                for (int j = 0; j < numbers.Count && !repeated; j++)
                {
                    if (allNumbers[i] == numbers[j])
                    {
                        repeated = true;
                    }
                }
                if (!repeated)
                {
                    numbers.Add(allNumbers[i]);
                }
                repeated = false;
            }

            int[] frequency = new int[numbers.Count];
            for (int i = 0; i < numbers.Count; i++)
            {
                for (int j = 0; j < allNumbers.Length; j++)
                {
                    if (numbers[i] == allNumbers[j])
                    {
                        frequency[i]++;
                    }
                }
                Console.WriteLine("El número " + numbers[i] + " se repite: " + frequency[i] + " veces.");

            }
        }
    }
}
