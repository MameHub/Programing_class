using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public struct Empleado
    {
        public string nombre;
        public Fecha fechaNacimiento;

        public Empleado(string nombre, Fecha fechaNacimiento)
        {
            this.nombre = nombre;
            this.fechaNacimiento = fechaNacimiento;
        }

        public void MostrarDatos()
        {
            Console.WriteLine("Información del empleado:\n");
            Console.WriteLine("El nombre del empleado es: " + nombre + ".\n");
            Console.WriteLine("La fecha de nacimiento del empleado es: " + fechaNacimiento.ConvertirString() + ".\n");
        }
    }
}
