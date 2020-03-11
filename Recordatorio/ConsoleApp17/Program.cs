using System;

namespace ConsoleApp17
{
    class Program
    {
        static void Main(string[] args)
        {
            // El usuario introduce los números y rellenamos el array y nosotros le mostramos cuantos números están duplicados.

            // 1.- Le pedimos al usuario que introduzca 4 números para rellenar el array.
            int[] array = new int[4];
            // 2.- Creamos el array con los números introducidos por el usuario.
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Introduzca un número: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            // 3.- Bucle anidado para recorrer el array y ver los números repetidos, utilizamos un if.
            bool duplicado = false;
            for (int i = 0; i < array.Length && !duplicado; i++)
            {
                for (int j = i + 1; j < array.Length && !duplicado; j++)
                {
                    if (array[i] == array[j])
                    {
                        Console.WriteLine("Hay un duplicado.");
                        duplicado = true;
                    }
                }
            }
        }
    }
}
