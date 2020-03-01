using System;

namespace ConditionalStatements5
{
    class Program
    {
        static void Main(string[] args)
        {
            // El usuario introduce una nota y nosotros lo calificaremos como sobresaliente, notable, bien, suficiente o insuficiente.

            Console.Write("Introduzca su nota: ");
            int note = int.Parse(Console.ReadLine());

            // Caso con if else
            
            if (note >= 0 && note <= 4)
            {
                Console.WriteLine("Insuficiente.");
            }
            else if (note == 5)
            {
                Console.WriteLine("Suficiente.");
            }
            else if (note == 6 || note == 7)
            {
                Console.WriteLine("Bien.");
            }
            else if (note == 8 || note == 9)
            {
                Console.WriteLine("Notable.");
            }
            else if (note == 10)
            {
                Console.WriteLine("Sobresaliente.");
            }
            else
            {
                Console.WriteLine("La nota introducida es incorrecta.");
            }
            
            // Caso con switch

            switch (note)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                    Console.WriteLine("Insuficiente.");
                    break;
                case 5:
                    Console.WriteLine("Suficiente.");
                    break;
                case 6:
                case 7:
                    Console.WriteLine("Bien.");
                    break;
                case 8:
                case 9:
                    Console.WriteLine("Notable.");
                    break;
                case 10:
                    Console.WriteLine("Sobresaliente.");
                    break;
            }
        }
    }
}
