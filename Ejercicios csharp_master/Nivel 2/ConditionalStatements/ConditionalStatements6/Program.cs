using System;

namespace ConditionalStatements6
{
    class Program
    {
        static void Main(string[] args)
        {
            //El usuario introduce una temperatura y nosotros le diremos si está helado, muy frío, normal, caliente o muy caliente.

            Console.Write("Introduzca la temperatura: ");
            int temp = int.Parse(Console.ReadLine());

            if (temp <= 0)
            {
                Console.WriteLine("Helado.");
            }
            else if (temp >= 0 && temp <= 10)
            {
                Console.WriteLine("Muy frío.");
            }
            else if (temp > 10 && temp <= 20)
            {
                Console.WriteLine("Normal.");
            }
            else if (temp > 20 && temp <= 30)
            {
                Console.WriteLine("Caliente.");
            }
            else
            {
                Console.WriteLine("Muy caliente.");
            }
        }
    }
}
