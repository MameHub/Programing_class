using System;
using System.Collections.Generic;

namespace ConsoleApp19
{
    class Program
    {
        static void Main(string[] args)
        {
            // Crear una lista e introducir números del 1 al 10.

            List<int> numbers = new List<int>();

            //En este bucle introduzco los números manualmente y los imprimo en pantalla.
            for (int i = 0; i < 10; i++)
            {
                numbers.Add(1);
                numbers.Add(2);
                numbers.Add(3);
                numbers.Add(4);
                numbers.Add(5);
                numbers.Add(6);
                numbers.Add(7);
                numbers.Add(8);
                numbers.Add(9);
                numbers.Add(10);
                Console.WriteLine(numbers[i]);
            }
            //Aqui elimino todos los datos de la lista.
            numbers.Clear();
            //En este bucle introducimos introducimos los datos con un autoincremento.
            for (int i = 0; i < 10; i++)
            {
                numbers.Add(i + 1);
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
