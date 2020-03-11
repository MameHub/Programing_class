using System;

namespace ConsoleApp16
{
    class Program
    {
        static void Main(string[] args)
        {
            // Copiar elemento a elemento de un array a otra.

            // 1.- Le preguntamos al usuario cuantos valores quiere introducir en el array.
            Console.WriteLine("Cuantos números quiere introducir en el array: ");
            int cant = int.Parse(Console.ReadLine());
            // 2. Creamos el array con la cantidad que introdujo el usuario.
            Console.WriteLine("Introduce los datos en el array:");
            int[] array = new int[cant];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = int.Parse(Console.ReadLine());
            }
            // 3.- Creamos el segundo array para copiar los datos a esta.
            int[] newArray = new int[cant];
            for (int i = 0; i < newArray.Length; i++)
            {
                newArray[i] = array[i];
                // 4.- Imprimimos en pantalla el nuevo array, se realiza el WriteLine dentro del bucle porque la varibale i se crea
                // dentro del bucle for y muere dentro de la misma, de manera que si lo hacemos fuera no existira la variable i.
                Console.WriteLine(newArray[i]);
            }

            // Ejercicio hecho por Nacho en la pizarra:

            //int[] array1 = new int[3];
            //int[] array2 = new int[3];

            //for (int i = 0; i < array.Length; i++)
            //{
            //    array1[i] = int.Parse(Console.ReadLine());
            //    array2[i] = array2[i];
            //    Console.WriteLine(array2[i]);
            //}
        }
    }
}
