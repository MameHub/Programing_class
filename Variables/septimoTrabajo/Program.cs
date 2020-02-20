using System;

namespace septimoTrabajo
{
    class Program
    {
        static void Main(string[] args)
        {
            // El usuario introduce sus mierda de notas y yo le saco su mierda de media.
            Console.Write("Introduce tu nota de matemáticas: ");
            float mat = float.Parse(Console.ReadLine());
            Console.Write("Introduce tu nota de lengua: ");
            float len = float.Parse(Console.ReadLine());
            Console.Write("Introduce tu nota de ingles: ");
            float ingles = float.Parse(Console.ReadLine());
            Console.Write("Introduce tu nota de conocimiento del medio: ");
            float con = float.Parse(Console.ReadLine());
            Console.Write("Introduce tu nota de peleas en el recreo: ");
            float pel = float.Parse(Console.ReadLine());

            float notas = mat + len + ingles + con + pel;
            float media = notas / 5f;



            Console.WriteLine("Tu media es la siguiente " + media.ToString("0.00"));
            Console.ReadLine();

            // Otra forma de hacerlo como el profe in the pizarra Console.WriteLine("La nota media es: " + (mat + len + ingles + con + pel) / 5f);
        }
    }
}
