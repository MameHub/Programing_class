using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class Cuenta
    {
        public string nombrePropietarios;
        public List<Transaccion> transacciones;

        public Cuenta(string nombrePropietario)
        {
            this.nombrePropietarios = nombrePropietario;
            transacciones = new List<Transaccion>();
        }

        public void AñadirTransaccion(Transaccion transaccion)
        {
            transacciones.Add(transaccion);
        }

        public void MostrarTransacciones()
        {
            Console.WriteLine("Transacciones: ");
            for (int i = 0; i < transacciones.Count; i++)
            {
                Console.WriteLine("------------");
                Console.WriteLine(transacciones[i].ToString());
                Console.WriteLine("------------");
            }
        }
    }
}
