using System;

namespace trabajosBucles1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            // El usuario pide un número, se repetira la ejecución del código ese número de veces.

            Console.Write("Introduzca el número de veces que quieras que se ejecute el cóigo: ");
            int repeat = int.Parse(Console.ReadLine());
            int counter = 0;

            while (counter <= repeat)
            {
                Console.WriteLine(counter);
                counter++;
            }

            do
            {
                Console.WriteLine(counter);
                counter++;
            } while (counter <= repeat);

            for (counter = 1; counter <= repeat; counter++)
            {
                Console.WriteLine(counter);
            }
        }
    }
}
