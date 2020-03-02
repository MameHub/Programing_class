using System;

namespace ConditionalStatements7
{
    class Program
    {
        static void Main(string[] args)
        {
            // El usuario introduce 3 ángulos y deberemos ver si podemos crear un triángulo con dichos ángulos.

            Console.Write("Introduzca un ángulo: ");
            int angulo1 = int.Parse(Console.ReadLine());
            Console.Write("Introduzca un ángulo: ");
            int angulo2 = int.Parse(Console.ReadLine());
            Console.Write("Introduzca un ángulo: ");
            int angulo3 = int.Parse(Console.ReadLine());

            if (angulo1 + angulo2 + angulo3 == 180)
            {
                Console.WriteLine("Se puede formar el triángulo.");
            }
            else
            {
                Console.WriteLine("No se puede formar el triángulo.");
            }
        }
    }
}
