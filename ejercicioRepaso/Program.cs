using System;

namespace ejercicioArrays3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Le pedimos al usuario dos números y los almacenamos, a continuación intercambiamos el valor de las variables.

            int x = 4;
            int y = 3;
            int aux = x;

            x = y;

            Console.WriteLine("El valor de x es el siguiente: " + x + " El valor de y es el siguiente: " + y);
        }
    }
}
