using System;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            // El usuario introduce 10 números por pantalla y le mostramos la suma total.

            int contador = 0;
            int total = 0;
            while (contador < 10)
            {
                Console.Write("Introduzca un número: ");
                int x = int.Parse(Console.ReadLine());
                contador++;
                total = x + total;
            }
            Console.WriteLine(total);

            contador = 0;
            total = 0;
            do
            {
                Console.Write("Introduzca un número: ");
                int x = int.Parse(Console.ReadLine());
                contador++;
                total = x + total;
            } while (contador < 10);
            Console.WriteLine(total);

            // Bucle for mal.
            for (int i = 0; i < 10; i++)
            {
                Console.Write("Introduzca un número: ");
                int x = int.Parse(Console.ReadLine());
                i++;
                total = x + total;
            }
            Console.WriteLine(total);
        }
    }
}
