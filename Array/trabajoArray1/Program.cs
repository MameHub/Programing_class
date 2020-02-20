using System;

namespace trabajoArray1
{
    class Program
    {
        static void Main(string[] args)
        {
            // 6to Ejercicio: Le pedimos al usuario que nos diga cuantos números quiere introducir, despues de introducir los números le mostraremos la suma de todos.
            Console.Write("¿Cuantos números quieres introducir?: ");
            int cantidad = int.Parse(Console.ReadLine());
            int[] array = new int[cantidad];
            // Este primer bucle for recorre el array para introducir los datos del usuario.
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Introduce un número: ");
                int number = int.Parse(Console.ReadLine());
                array[i] = number;
            }
            int sumaTotal = 0;
            // Este segundo bucle for recorre todo el array cogiendo los datos del mismo y sumarlos.
            for (int i = 0; i < array.Length; i++)
            {
                sumaTotal += array [i];
            }
            Console.WriteLine(sumaTotal);
        }
    }
}
