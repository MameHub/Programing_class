using System;

namespace ConsoleApp14
{
    class Program
    {
        static void Main(string[] args)
        {
            // El usuario introduce x números y nosotros se lo mostramos de mayor a menor.
            // Intento para que el usuario introduzca la longitud del array y rellenar mediante la longitud impuesta por el usuario.

            //Console.WriteLine("Introduzca el número de datos que quiere introducir a continuación: ");
            //int cant = int.Parse(Console.ReadLine());

            //int[] numbers = new int[cant];
            //for (int i = 0; i < numbers.Length; i++)
            //{
            //    numbers[i] = int.Parse(Console.ReadLine());
            //}

            //for (int i = cant; i < numbers.Length; i--)
            //{
            //    Console.WriteLine(numbers[i]);
            //}

            int[] numbers = new int[3];
            for (int i = 0; i < 3; i++)
            {
                numbers[i] = int.Parse(Console.ReadLine());
            }
            for (int i = numbers.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
