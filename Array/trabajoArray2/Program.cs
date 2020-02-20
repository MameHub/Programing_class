using System;

namespace trabajoArray2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Le pedimos al usuario que rellene un array de números y luego trasladamos los datos de ese array a otra array

            Console.Write("¿Cuántas veces quieres introducir un número?: ");
            int repetitions = int.Parse(Console.ReadLine());
            int[] numbers = new int[repetitions];
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Introduce un número: ");
                int x = int.Parse(Console.ReadLine());
                numbers[i] = x;
            }
            int[] numbers2 = new int[numbers.Length];
            for (int i = 0; i < numbers2.Length; i++)
            {
                numbers2[i] = numbers[i];
                Console.WriteLine(numbers2[i]);
            }
            // Foto pizarra clase, ejercicio resuelto por correción de Nacho
        }
    }
}
