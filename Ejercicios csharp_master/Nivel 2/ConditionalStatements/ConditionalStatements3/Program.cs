using System;

namespace ConditionalStatements3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Comprobar si el número introducido es negativo o positivo, el 0 cuenta como poisitivo.

            Console.Write("Introduzca un número: ");
            int x = int.Parse(Console.ReadLine());

            if (x >= 0)
            {
                Console.WriteLine("El número introducido es cero o positivo.");
            }
            else
            {
                Console.WriteLine("El número introducido es negativo.");
            }
        }
    }
}
