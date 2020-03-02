using System;

namespace ConditionalStatements8
{
    class Program
    {
        static void Main(string[] args)
        {
            // El usuario introduce el dinero gastado este mes y el dinero que ha tenido que pagar. Le diremos si ha ganado o ha perdido y le mostraremos el resultado.

            Console.Write("Introduce el dinero ganado este mes: ");
            int ganado = int.Parse(Console.ReadLine());
            Console.Write("Introduce el dinero gastado este mes: ");
            int perdidas = int.Parse(Console.ReadLine());
            int resultado = ganado - perdidas;

            if (resultado >= 0)
            {
                Console.WriteLine("Este mes has ganado " + resultado + ".");
            }
            else
            {
                Console.WriteLine("Este mes has perdido " + resultado + ".");
            }
        }
    }
}
