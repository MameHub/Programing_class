using System;

namespace ConsoleApp15
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mostramos en pantalla la suma de los números introducidos en el array.

            // 1. Primer paso preguntar al usuario cuántos números quiere introducir. : cant
            Console.WriteLine("Introduzca el número de datos que quiere introducir: ");
            int cant = int.Parse(Console.ReadLine());
            // 2. Preguntar al usuario los valores a introducir. : Bucles e inicialización de elementos.
            Console.WriteLine("Ahora introduzca los datos en el array:");
            int[] numbers = new int[cant];
            for (int i = 0; i < cant; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            // 3. Sumamos elementos del array. : Bucles, acceder elementos y variable auxiliar.
            int total = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                total += numbers[i];
            }
            // 4. Mostrar al usuario. :WriteLine.
            Console.WriteLine(total);
        }
    }
}
