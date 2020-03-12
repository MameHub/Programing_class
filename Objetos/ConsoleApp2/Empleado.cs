using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public struct Empleado
    {
        public string nombre;
        public int diaNacimiento;
        public string mesNacimiento;
        public int añoNacimiento;

        public Empleado(string nombre, int diaNacimiento, string mesNacimiento, int añoNacimiento)
        {
            this.nombre = nombre;
            this.diaNacimiento = diaNacimiento;
            this.mesNacimiento = mesNacimiento;
            this.añoNacimiento = añoNacimiento;
        }

        public void MostrarDatos()
        {
            Console.WriteLine("El nombre del empleado es: " + nombre + ".");
            Console.WriteLine("La fecha de nacimiento del empleado es: " + diaNacimiento + " de " + mesNacimiento + " del " + añoNacimiento + ".");
        }
    }
}
