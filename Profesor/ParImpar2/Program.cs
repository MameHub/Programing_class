using System;
using System.Collections.Generic;

namespace ParImpar2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> listaPar = new List<int>();
            List<int> listaImpar = new List<int>();
            Console.Write("¿Cuántos números quieres introducir?: ");
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("Introduzca un número: ");
                int number = int.Parse(Console.ReadLine());
                if(number % 2 == 0)
                {
                    listaPar.Add(number);
                }
                else
                {
                    listaImpar.Add(number);
                }
            }
            Console.Write("Numeros pares: ");
            for (int i = 0; i < listaPar.Count; i++)
            {
                Console.Write(listaPar[i] + " ");
            }
            Console.WriteLine();
            Console.Write("Numeros impares: ");
            for (int i = 0; i < listaImpar.Count; i++)
            {
                Console.Write(listaImpar[i] + " ");
            }
        }
    }
}
