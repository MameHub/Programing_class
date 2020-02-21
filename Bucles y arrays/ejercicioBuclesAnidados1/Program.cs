using System;

namespace ejercicioBuclesAnidados1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio con bucles anidados, asignaremos datos numéricos a una array y despues ordenaremos estos con un bucle anidado.
            // Copiado directamente de pizarra hecho por profe Nacho
            int[] numbers = new int[] { 3, 1, 2};
            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = i + 1; j < numbers.Length; j++)
                {
                    if (numbers[j] < numbers[i])
                    {
                        int aux = numbers[i];
                        numbers[i] = numbers[j];
                        numbers[j] = aux;
                    }
                }
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
