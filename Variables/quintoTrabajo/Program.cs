using System;

namespace quintoTrabajo
{
    class Program
    {
        static void Main(string[] args)
        {
            // El usuario introduce un número y le decimos si el número es positivo, negativo o 0.
            Console.Write("Introduce un número: ");
            int x = int.Parse(Console.ReadLine());

            if (x == 0)
            {
                Console.WriteLine("El número introducido es cero.");
            }
            else
            {
                if (x < 0)
                {
                    Console.WriteLine("El número introducido es negativo.");
                }
                else
                {
                    Console.WriteLine("El número introducido es positivo.");
                }
            }
            Console.ReadLine();
        }
    }
}
