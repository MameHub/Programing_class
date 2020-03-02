using System;

namespace variablesPrint_master5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pintar en pantalla un número, primero todo junto varias veces y luego separado por espacios.

            Console.Write("Introduzca un número: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write(x);
            Console.Write(x);
            Console.Write(x);
            Console.WriteLine(x);
            Console.WriteLine(x + " " + x + " " + x + " " + x);
        }
    }
}
