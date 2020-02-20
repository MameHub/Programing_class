using System;

namespace octavoTrabajo
{
    class Program
    {
        static void Main(string[] args)
        {
            // El usuario introduce su altura en cm y lo criticamos en función de la altura.
            Console.Write("Introduce tu altura en centimetros sin signos de puntuación: ");
            int alt = int.Parse(Console.ReadLine());

            if (alt >= 120 && alt < 155)
            {
                Console.WriteLine("Eres un puto enano, vete con frodo y comprate un taburetito, este mundo no esta hecho a tu altura.");
            }
            else
            {
                if (alt >= 155 && alt < 175)
                {
                    Console.WriteLine("Eres alto pero no te flipes, te da para ir po la vida sin un puto taburete.");
                }
                else if (alt >= 175 && alt <= 210)
                {
                    Console.WriteLine("Estas hecho un gigantón.");
                }
                else
                {
                    Console.WriteLine("O te has flipado poniendo una altura que más quisieras tu flipao de la vida, o directamente eres el enano de juego de tronos y tus mascotas son hormigas.");
                }
            }
            Console.ReadLine();
            // HOLA QUE TAL CABESAH?!
        }
    }
}
