﻿using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mostrar en pantalla la cantidad de números impares e pares de una lista.
            // análogo a lo anterior.

            int[] numbers = new int[] { 3, 2, 1, 4 };
            int par = 0;
            int impar = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)
                {
                    par++;
                }
                else
                {
                    impar++;
                }
            }
            Console.WriteLine("Números par: " + par + ".");
            Console.WriteLine("Números impar: " + impar + ".");
        }
    }
}
