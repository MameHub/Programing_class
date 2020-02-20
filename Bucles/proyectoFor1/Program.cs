using System;

namespace proyectoFor1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hacemos introducir x números al usuario y le devolvemos la suma de todos los números.
            // en blanco hecho por profesor Nacho

            Console.Write("¿Cuantas veces quieres introducir un número?: ");
            int repeticiones = int.Parse(Console.ReadLine());
            int totalSuma = 0;
            for (int i = 0; i < repeticiones; i++)
            {
                Console.Write("Introduce un número: ");
                int number = int.Parse(Console.ReadLine());
                totalSuma = totalSuma + number;
            }
            Console.WriteLine("Suma total " + totalSuma);
        }
    }
}
