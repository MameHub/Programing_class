using System;

namespace ConsoleApp9
{
    class Program
    {
        static void Main(string[] args)
        {
            // El usuario introduce un número y nosotros le mostramos el cubo de todos los números hasta llegar al que ha introducido el usuario.

            Console.Write("Introduzca un número: ");
            int x = int.Parse(Console.ReadLine());

            for (int i = 1; i <= x; i++)
            {
                int total = i * i * i;
                Console.WriteLine(total);
            }
        }
    }
}
