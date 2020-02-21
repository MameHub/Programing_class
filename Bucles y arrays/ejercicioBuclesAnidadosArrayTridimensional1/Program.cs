using System;

namespace ejercicioBuclesAnidadosArrayTridimensional1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear un array bidimensional, con los valores ya establecidos o haciendo al usuario que los introduzca, con los siguientes valores 0,0 = 1, 1,1 = 1, 2,2 = 1, el resto 0.
            Console.Write("Introduce el número de filas que quieres que tenga el array: ");
            int magnitude = int.Parse(Console.ReadLine());
            int[,] array = new int[magnitude, magnitude];
            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (i == j)
                    {
                        array[i, j] = 1;
                    }
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
