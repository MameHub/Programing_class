using System;

namespace ejercicioBucles5
{
    class Program
    {
        static void Main(string[] args)
        {
            // El usuario introduce un número y se le mostrará el resultado de la suma de todos los números hasta llegar al que puso el usuario.

            Console.Write("Introduzca un número: ");
            int repeticiones = int.Parse(Console.ReadLine());
            int totalSum = 0;
            int counter = 0;

            while (counter <= repeticiones)
            {
                totalSum = totalSum + counter;
                counter++;
            }
            Console.WriteLine(totalSum);
            totalSum = 0;
            counter = 1;
            do
            {
                Console.WriteLine(totalSum);
            } while (counter <= repeticiones);
            Console.WriteLine(totalSum);
            for (counter = 1, totalSum = 0; counter <= repeticiones; counter++)
            {
                totalSum = totalSum + counter;
            }
            Console.WriteLine(totalSum);
        }
    }
}
