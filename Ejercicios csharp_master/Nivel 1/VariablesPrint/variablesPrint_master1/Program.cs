using System;

namespace variablesPrint_master1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Pintar en pantalla "Hola: y el nombre del usuario"

            Console.Write("Introduzca su nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Hola " + nombre);
        }
    }
}
