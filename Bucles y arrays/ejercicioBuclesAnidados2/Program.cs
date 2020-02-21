using System;

namespace ejercicioBuclesAnidados2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduce el número de filas que quieras: ");
            int filas = int.Parse(Console.ReadLine());

            for (int i = 0; i < filas; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }
        }
    }
}
