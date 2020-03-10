using System;

namespace ConsoleApp11
{
    class Program
    {
        static void Main(string[] args)
        {
            // El usuario introduce un número y le mostramos los números impares hasta llegar a ese número.

            Console.Write("Introduzca un número: ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x; i += 2)
            {
                Console.WriteLine(i);  
            }
        }
    }
}
