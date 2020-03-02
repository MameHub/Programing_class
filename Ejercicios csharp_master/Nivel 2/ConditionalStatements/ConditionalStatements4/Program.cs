using System;

namespace ConditionalStatements4
{
    class Program
    {
        static void Main(string[] args)
        {
            // El usuario introduce su edad y le decimos si es jubilado, mayor de edad o menor de edad.

            Console.Write("Introduzca su edad: ");
            int age = int.Parse(Console.ReadLine());

            if (age >= 65)
            {
                Console.WriteLine("Es usted un jubilado.");
            }
            else if (age >= 18)
            {
                Console.WriteLine("Es mayor de edad.");
            }
            else if (age >= 0 && age < 18)
            {
                Console.WriteLine("Eres menor de edad.");
            }
            else
            {
                Console.WriteLine("La edad introducida es erronea");
            }
        }
    }
}
