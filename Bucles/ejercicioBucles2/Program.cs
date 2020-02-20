using System;

namespace ejercicioBucles2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Al usuario se le piden dos nnúmero, el primero será la tabla de multiplicar que queremos y el segundo número será hasta donde queremos ver la tabla de multiplicar.

            Console.Write("Introduce de que número quieres ver la tabla de multiplicar: ");
            int tabla = int.Parse(Console.ReadLine());
            Console.Write("Introduce número de veces a repetir: ");
            int repeat = int.Parse(Console.ReadLine());
            int contador = 1;

            while (contador <= repeat)
            {
                Console.WriteLine(tabla * contador);
                    (tabla + " x " + contador + " x " + (tabla )
            }
            Console.ReadLine();
            // EJERCICIO NO TERMINADO.
        }
    }
}
