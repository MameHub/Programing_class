using System;

namespace ConsoleApp2
{
    class Program
    {
        // Creación de funciones, se deben de crear dentro de class program para no crearlas dentro de otra función.
        static int Suma(int x, int y)
        {
            return x + y;
        }

        static int Resta(int x, int y)
        {
            return x - y;
        }

        static int Multiplicacion(int x, int y)
        {
            return x * y;
        }

        static int Division(int x, int y)
        {
            return x / y;
        }

        static int PreguntarNumero(string texto)
        {
            Console.WriteLine(texto);
            return int.Parse(Console.ReadLine());
        }

        static void PintarOpciones()
        {
            Console.WriteLine("1.- Suma");
            Console.WriteLine("2.- Resta");
            Console.WriteLine("3.- Multiplicación");
            Console.WriteLine("4.- División");
            Console.WriteLine("5.- Salir");
        }

        static void Main(string[] args)
        {
            // Creación de funciones para suma, resta, multiplicación y división.
            //Se hará una llamada a las funciones en cada caso.

            int x;
            int y;

            int op;

            do
            {
                x = PreguntarNumero("Introduzca un número: ");
                y = PreguntarNumero("Introduzca un número: ");
                Console.WriteLine();
                PintarOpciones();

                switch (op = int.Parse(Console.ReadLine()))
                {
                    case 1:
                        Console.WriteLine("El resultado de la suma es: " + Suma(x, y) + ".");
                        break;
                    case 2:
                        Console.WriteLine("El resultado de la resta es: " + Resta(x, y) + ".");
                        break;
                    case 3:
                        Console.WriteLine("El resultado de la multiplicación es: " + Multiplicacion(x, y) + ".");
                        break;
                    case 4:
                        Console.WriteLine("El resultado de la división es: " + Division(x, y) + ".");
                        break;
                    case 5:
                        Console.WriteLine("Hasta luego.");
                        break;
                    default:
                        Console.WriteLine("Esa opción no está disponible..");
                        break;
                }
            } while (op != 5);
        }
    }
}
