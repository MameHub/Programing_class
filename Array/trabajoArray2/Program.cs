using System;

namespace trabajoArray2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Le pedimos al usuario que rellene un array de números y luego trasladamos los datos de ese array a otra array

            Console.Write("¿Cuantos números quieres introducir?: ");
            int cantidad = int.Parse(Console.ReadLine());
            int[] array = new int[cantidad];
            
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Introduce un número: ");
                int number = int.Parse(Console.ReadLine());
                array[i] = number;
            }
            int[] cantidad2 = new int[array.Length];
            for (int i = 0; i < array.Length; i++)
            {
                
            }

        }
    }
}
