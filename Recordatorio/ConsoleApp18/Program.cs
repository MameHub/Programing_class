using System;

namespace ConsoleApp18
{
    class Program
    {
        static void Main(string[] args)
        {
            // El usuario introduce tres números y ordenamos estos.

            // 1.- Le pedimos al usuario que introduzca 4 números para rellenar el array.
            int[] array = new int[3];
            // 2.- Creamos el array con los números introducidos por el usuario.
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Introduzca un número: ");
                array[i] = int.Parse(Console.ReadLine());
            }
            // 3.- Bucle anidado para recorrer el array y ordenar el array utilizando una variable auxiliar.
            // Habría que visualizar tres cajar, la [i], la [j] y la variable auxiliar interconectadas mediante flechas las unas a las otras.
            // 
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        int ord = 0;
                        ord = array[i];
                        array[i] = array[j];
                        array[j] = ord;
                    }
                }
                Console.WriteLine(array[i]);
            }
        }
    }
}
