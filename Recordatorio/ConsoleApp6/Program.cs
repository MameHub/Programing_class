using System;

namespace ConsoleApp6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Utilizamso los bucles para hacer una suma consecutiva entre los números del 1 al 10.

            int x = 0;
            int total = 0;
            while ( x < 10 )
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
            } while (x < 10);
            Console.WriteLine(total);
            x = 0;
            total = 0;
            // Bucle for mal.
            for (x = 0, total = 0; x < 10; x++, total += 1)
            {
                Console.WriteLine(total);
                x = 0;
                total = 0;
            }
        }
    }
}
