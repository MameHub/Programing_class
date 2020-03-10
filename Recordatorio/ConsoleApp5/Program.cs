using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hay que pintar en pantalla los números del 1 al 10 utilizando los tres bucles.

            int x = 1;
            while (x <= 10)
            {
                Console.WriteLine(x);
                x++;
            }
            x = 1;
            do
            {
                Console.WriteLine(x);
                x++;
            } while (x <= 10);
            //Falta el bucle for.
           // for (int x = 0; x < 10 x++)
            {

            }
        }
    }
}
