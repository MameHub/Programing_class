using System;

namespace ejercicioBucles1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Le pedimos al usuario un número y repetimos el bucle tantas veces como sea el número que el usuario nos ha dado, mostrandole al usuario el resultado.

            Console.Write("Escribe el número de veces que quieras que se ejecute el código: ");
            int repeat = int.Parse(Console.ReadLine());
            // Esto sería el contador.
            int counter = 0;

            do
            {
                Console.WriteLine(counter);
                counter = counter + 1;
            } while (counter < repeat);

            /*while (counter < repeat)
            {
                Console.WriteLine(counter);
                counter = counter + 1;
              /*  counter += 1;
                counter++;
                ++counter; 
            }
            Console.ReadLine();*/
            Console.ReadLine();
        }
    }
}
