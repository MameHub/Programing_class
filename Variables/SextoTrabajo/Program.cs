using System;

namespace SextoTrabajo
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mostrar una interfaz con 3 opciones: 1 - refrán, 2 - chiste, 3 - insultar. Dependiendo del número que introduzca el usuario se le mostrará una opción u otra y si introduce un número que no corresponde con los mostrados se le dirá que se ha equivocado.
            Console.Write("Pide por esa boquita, para un refrán pulse 1, para un chiste pulse 2 y para que te insulte pulsa 3. ");
            int x = int.Parse(Console.ReadLine());

            switch (x)
            {
                case 1:
                    Console.WriteLine("A falta de pan, buenas son tortas.");
                    break;
                case 2:
                    Console.WriteLine("¿Porque una foca en el circo siempre mira para arriba? Porque es donde estan los focos.");
                    break;
                case 3:
                    Console.WriteLine("Pedazo de IRIPOIA!");
                    break;
                default:
                    Console.WriteLine("Te has equivocado de número imbecil.");
                    break;
            }
            Console.ReadLine();
        }
    }
}
