using System;

namespace ejercicioBuclesAnidados5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacer una serie de filas que van autoincrementanto.
            Console.Write("Filas: ");
            int rows = int.Parse(Console.ReadLine());
            int number = 1;
            // Este primer for serián las filas
            for (int i = 0; i < rows; i++)
            {
                // Este segundo for serián la suma de autoincremento
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write((number++) + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
