using System;

namespace ejercicioBuclesAnidados4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Buscar en una lista el número más pequeño y el número más grande y mostrarlos en pantalla.

            int[] array = new int[] { 32, 890, -372, -100 };
            int highest = int.MinValue;
            int lowest = int.MaxValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > highest)
                {
                    highest = array[i];
                }
                if (array[i] < lowest)
                {
                    lowest = array[i];
                }
            }
            Console.WriteLine("Mayor: " + highest + "\nMenor: " + lowest);
        }
    }
}
