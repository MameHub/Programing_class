using System;

namespace ConsoleApp12
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dibujar en pantalla con bucles anidados filas consecutivas de "x", números "1, 1 2, 1 2 3", "1, 2 2, 3 3 3" y "1 2 3 4 5".

            Console.Write("Introduce el número de filas que quieras: ");
            int rows = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write("x ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            
            int number = 1;
            for (int i = 0; i < rows; i++, number = 1)
            {
                for (int j = 0; j < i + 1; j++, number++)
                {
                    Console.Write(number + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < i + 1; j++)
                {
                    Console.Write((i + 1) + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();

            int numb = 1;
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < i + 1; j++, number++)
                {
                    Console.Write(number + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
