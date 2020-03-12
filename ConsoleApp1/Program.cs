using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduzca su nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Introduzca una nota: ");
            float nota = float.Parse(Console.ReadLine());
        }
    }
}
