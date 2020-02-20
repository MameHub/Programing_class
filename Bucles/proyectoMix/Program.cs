using System;

namespace proyectoMix
{
    class Program
    {
        static void Main(string[] args)
        {
            // Se le muestra al usuario una interfaz donde 1 es un refrán, 2 es un chiste, 3 te insulta y 4 es salir. Hasta que el usuario no le de a salir el código se seguira ejecutando.
            // Esta variable se ha declarado fuera globalmente y se inicializara localmente en do switch. De manera que al estar declarada fuera globalmente se conoce por todo el código y el valor de la misma se le dará localmente. Para que el programa la conozca globalmente con solo declararla globalmente sin inicializar dentro de la misma se conocera en todo el código.
            // variable-scope
            int n;
            do
            {
                Console.WriteLine("Que quiereh mi alma \t 1. Refrán \n 2. Chiste \n  3. Insulto \n 4. Salir.");
                n = int.Parse(Console.ReadLine());

                switch (n)
                {
                    case 1:
                        Console.WriteLine("Más vale pajaro en mano que ciento volando.");
                        break;
                    case 2:
                        Console.WriteLine("¿Que hace un mudo en un baile? Mudanza.");
                        break;
                    case 3:
                        Console.WriteLine("Cago en tu estampa.");
                        break;
                    case 4:
                        Console.WriteLine("Salir.");
                        break;
                    default:
                        Console.WriteLine("Te has equivocado de número.");
                        break;
                }
            } while (n != 4);
        }
    }
}
