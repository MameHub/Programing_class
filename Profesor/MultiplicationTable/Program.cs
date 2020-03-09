using System;

namespace MultiplicationTable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduzca un número: ");
            int number = int.Parse(Console.ReadLine());
            int[] multiplicationTable = new int[10];
            Console.Write("La tabla de multiplicar del número " + number + " es: ");
            for (int i = 0; i < multiplicationTable.Length; i++)
            {
                multiplicationTable[i] = number * (i + 1);
                Console.Write(multiplicationTable[i] + " ");
            }
        }
    }
}
