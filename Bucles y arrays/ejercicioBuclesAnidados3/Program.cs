using System;

namespace ejercicioBuclesAnidados3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Comprobar si en una lista de números hay un duplicado e imprimirlo en pantalla.

            int[] array = new int[] { 3, 1, 3 };
            bool repeated = false;
            
            for (int i = 0; i < array.Length && repeated == false; i++)
            {
                for (int j = i + 1; j < array.Length && !repeated; j++)
                {
                    if (array[i] == array[j])
                    {
                        Console.Write("Elementos repetidos.\n");
                        repeated = true;
                    }
                }
            }
            if (!repeated)
            {
                Console.WriteLine("No hay duplicados");
            }
        }
    }
}
