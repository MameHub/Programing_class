using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduzca su nombre: ");
            string nombre = Console.ReadLine();
            Console.Write("Introduzca una nota: ");
            float nota = float.Parse(Console.ReadLine());
            Alumno alumno1 = new Alumno(nombre, nota);
            Alumno alumno2 = new Alumno("Álvaro", 7.4f);
            Alumno alumno3 = new Alumno("Ángel", 10f);
            Alumno alumno4 = new Alumno("Joaquín", 9.4f);
            alumno1.MostrarDatos();
            alumno2.MostrarDatos();
            alumno3.MostrarDatos();
            alumno4.MostrarDatos();
        }
    }
}
