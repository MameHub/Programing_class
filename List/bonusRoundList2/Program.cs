﻿using System;
using System.Collections.Generic;

namespace bonusRoundList2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio de devolver si el número introducido es par o inpar pero on listas.
            // Extra intentar hacer que el usuario proporcione los datos de la lista.

            /*Console.Write("Introduce el primer número: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Introduce el segundo número: ");
            int num2 = int.Parse(Console.ReadLine());
            Console.Write("Introduce el tercer número: ");
            int num3 = int.Parse(Console.ReadLine());
            Console.Write("Introduce el cuarto número: ");
            int num4 = int.Parse(Console.ReadLine());
            Console.Write("Introduce el quinto número: ");
            int num5 = int.Parse(Console.ReadLine());
            */
            
            Console.Write("Introduce la cantidad de números que quieres introducir: ");
            int cantidad = int.Parse(Console.ReadLine());
            int[] numeros = new int[cantidad];
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.Write("Introduzca un número: ");

            }
            
            List<int> parInpar = new List<int>();
            parInpar.Add(cantidad);
            parInpar.Add(cantidad);
            parInpar.Add(cantidad);
            parInpar.Add(cantidad);
            parInpar.Add(cantidad);
            
            foreach (var numbers in parInpar)
            {
                if (numbers % 2 == 0)
                {
                    Console.WriteLine("El número " + numbers + " es par.");
                }
                else
                {
                    Console.WriteLine("El número " + numbers + " es inpar.");
                }
            }
            
            // foreach con string.
            /*
            string nombre = "Alvaro";
            foreach (char letter in nombre)
            {
                Console.WriteLine(letter);
            }
            */
        }
    }
}
