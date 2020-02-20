using System;

namespace primerTrabajo
{
    class Program
    {
        static void Main(string[] args)
        {
            // El usuario introduce 2 números y comprobamos si son iguales.
            Console.WriteLine("En este ejercicio vamos a comparar si dos números son iguales o no");
            Console.Write("Introduce el primer número: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Introduce el segundo número: ");
            int num2 = int.Parse(Console.ReadLine());
            if (num1 == num2)
            {
                Console.WriteLine("Los números los iguales");
            }
            else
            {
                Console.WriteLine("Los números no son iguales");
            }
            Console.ReadLine();
        }
    }
}
