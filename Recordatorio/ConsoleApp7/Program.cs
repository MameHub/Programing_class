using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            // El usuario introduce un número y nosotros le mostramos la suma consecutiva hasta llegar al mismo.

            Console.Write("Introduzca un número: ");
            int num = int.Parse(Console.ReadLine());
            int x = 0;
            int total = 0;
            while (x < num)
            {
                Console.WriteLine(x + 1);
                x++;
                total += x;
            }
            Console.WriteLine(total);
            x = 0;
            total = 0;
            do
            {
                Console.WriteLine(x + 1);
                x++;
                total += x;
            } while (x < num);
            Console.WriteLine(total);
            x = 0;
            total = 0;
            // Bucle for mal.
            for (x = 0, total = 0; x < num; x++, total += 1)
            {
                Console.WriteLine(x+1);
            }
            Console.WriteLine(total);
        }
    }
}
