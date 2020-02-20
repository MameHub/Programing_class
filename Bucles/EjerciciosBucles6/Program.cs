using System;

namespace EjerciciosBucles6
{
    class Program
    {
        static void Main(string[] args)
        {
            // El usuario introduce un número y se devuelve un cuenta regresiva.

            Console.Write("Introduce un número: ");
            int n = int.Parse(Console.ReadLine());

            for (int count = 0; count <= n; n--)
            {
                Console.WriteLine(n);
            }
            
            /*Console.WriteLine("Introduce un número: ");
            int repetitions = int.Parse(Console.ReadLine());


            Console.WriteLine();
            int contador = repetitions;
            while (contador >= 0)
            {
                Console.WriteLine(contador);
                contador--;
            }
            Console.WriteLine();
            contador = 0;
            while (contador <= repetitions)
            {
                Console.WriteLine(repetitions - contador);
                contador++;
            }*/
        }
    }
}
