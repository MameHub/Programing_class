using System;

namespace tercerTrabajo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tenemos que decirle al usuario si el número que ha introducido es par o inpar.
            Console.Write("Introduce un número: ");
            int num1 = int.Parse(Console.ReadLine());
            int num2 = 2;
            int num3 = num1 % num2;
            if (num3 == 0)
            {
                Console.WriteLine("El número introducido es par, enhorabuena.");
            }
            else
            {
                Console.WriteLine("El número introducido es inpar, lo siento.");
            }
            Console.ReadLine();

            /* // Código profesor pizarra
            Console.Write("Introduce un número: ");
            int x = int.Parse(Console.ReadLine());

            if (x % 2 == 0)
            {
                Console.WriteLine("El número es par.");
            }
            else
            {
                Console.WriteLine("El número es inpar.");
            }
            Console.ReadLine(); */
        }
    }
}
