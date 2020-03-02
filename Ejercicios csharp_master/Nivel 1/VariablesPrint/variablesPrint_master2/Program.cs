using System;

namespace variablesPrint_master2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Muestra en pantalla la suma de dos números.

            Console.Write("Introduzca el primero número: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Introduzca el segundo número: ");
            int num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("La suma de los dos número es la siguiente: " + (num1 + num2));
        }
    }
}
