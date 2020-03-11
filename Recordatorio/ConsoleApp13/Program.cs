using System;

namespace ConsoleApp13
{
    class Program
    {
        static void Main(string[] args)
        {
            // Introducir datos del 1 al 10 en un array.
            // Podemos añadir los datos manualmente ( { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 } ) o como esta realizado en el ejercicio.
            int[] array = new int[10];
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i] = i + 1 );
            }
        }
    }
}
