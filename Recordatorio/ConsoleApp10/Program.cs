using System;

namespace ConsoleApp10
{
    class Program
    {
        static void Main(string[] args)
        {
            // El usuario introduce un número y nosotros le mostramso la tabla de multiplicar del mismo.

            Console.Write("Introduzca un número: ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(x * i);
            }
        }
    }
}
