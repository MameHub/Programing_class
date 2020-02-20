using System;

namespace segundoTrabajo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Vamos a pedir dos números al usuario y le diremos si los números son iguales y si no lo son, le mostraremos en pantalla que número de los que ha introducido es el mayor.
            Console.Write("Introduce el primer número: ");
            int num1 = int.Parse(Console.ReadLine());
            Console.Write("Introduce el segundo número: ");
            int num2 = int.Parse(Console.ReadLine());
            if (num1 == num2)
            {
                Console.WriteLine("Los números son iguales");
            }
            else if (num1 > num2)
            {
                Console.WriteLine("El número " + num1 + " es mayor que " + num2);
            }
            else
            {
                Console.WriteLine("El número " + num2 + " es mayor que " + num1);
            }
            Console.ReadLine();

             /* //Solución pizarra
              if (num1 == num2)
              {
                Console.WriteLine("Son iguales");
              }
            else
            {
                if (num1 > num2)
                {
                    Console.WriteLine("Wl número " + num1 + " es mayor que " + num2);
                }
                else
                {
                    Console.WriteLine("El número " + num1 + " es menor que " + num2);
                }
                Console.ReadLine(); */
            }
        }
    }
}
