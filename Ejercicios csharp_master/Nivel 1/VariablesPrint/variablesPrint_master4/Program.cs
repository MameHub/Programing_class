using System;

namespace variablesPrint_master4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mostrar en pantalla el resultado de sumar, restar, multiplicar, dividir y resto de dos números.

            Console.Write("Introduzca el primer número: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Introduzca el segundo número: ");
            int y = int.Parse(Console.ReadLine());

            Console.WriteLine("El resultado de la suma es: " + (x + y));
            Console.WriteLine("El resultado de la resta es: " + (x - y));
            Console.WriteLine("El resultado de la multiplicación es: " + (x * y));
            Console.WriteLine("El resultado de la división es: " + (x / y));
            Console.WriteLine("El resto de la división es: " + (x % y));

        }
    }
}
