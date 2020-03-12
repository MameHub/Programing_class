using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduzca su nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Introduzca su día de nacimiento: ");
            int dia = int.Parse(Console.ReadLine());
            Console.Write("Introduzca su mes de nacimiento: ");
            string mes = Console.ReadLine();
            Console.Write("Introduzca su año de nacimiento: ");
            int año = int.Parse(Console.ReadLine());
            Console.WriteLine();
            Fecha fechaNacimiento = new Fecha(dia, mes, año);
            Empleado empleado = new Empleado(nombre, fechaNacimiento);
            empleado.MostrarDatos();
        }
    }
}
