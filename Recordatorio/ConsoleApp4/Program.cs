using System;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Le preguntamos al usuario que tabla de multiplicar quiere ver y le mostramos la tabla de este número almacenando la tabla pedida en un array.
            // Medio copiado de pizarra
            
            Console.Write("¿Que tabla de multiplicar quieres?: ");
            int numero = int.Parse(Console.ReadLine());

            int[] multiplicar = new int[10];

            for (int i = 0; i < multiplicar.Length; i++)
            {
                multiplicar[i] = numero * (i + 1);
            }
            // Está mal
            Console.WriteLine("La tabla de multiplicar del número " + numero);
        }
    }
}
