using System;

namespace ejercicioBucles3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Tabla de multiplicar con el bucle for

            Console.Write("Introduce un número: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Introduce un número de repeticiones: ");
            int repeticiones = int.Parse(Console.ReadLine());
            for (int i = 1; i <= repeticiones; i++)
            {
                Console.WriteLine
                    (number + " x " + i + " = " + (number * i));
            }
            Console.ReadLine();
        }
    }
}
