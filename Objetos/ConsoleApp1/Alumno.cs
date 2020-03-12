using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public struct Alumno
    {
        public string nombre;
        public float nota;

        public Alumno(string nombre, float nota)
        {
            this.nombre = nombre;
            this.nota = nota;
        }

        public void MostrarDatos()
        {
            Console.WriteLine("El nombre del alumno es: " + nombre + ".");
            Console.WriteLine("La nombre del nota es: " + nota + ".");
        }
    }
}
