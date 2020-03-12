using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduzca su nombre: ");
            string nombre = Console.ReadLine();
            Console.WriteLine("Introduzca su día de nacimiento: ");
            int diaNacimiento = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduzca su mes de nacimiento: ");
            string mesNacimiento = Console.ReadLine();
            Console.WriteLine("Introduzca su año de nacimiento: ");
            int añoNacimiento = int.Parse(Console.ReadLine());
            Empleado empleado1 = new Empleado(nombre, diaNacimiento, mesNacimiento, añoNacimiento);
            empleado1.MostrarDatos();
        }
    }
}
