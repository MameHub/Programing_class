using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public struct Transaccion
    {
        int cantidad;
        string concepto;

        public Transaccion(int cantidad, string concepto)
        {
            this.cantidad = cantidad;
            this.concepto = concepto;
        }

        public override string ToString()
        {
            return base.ToString();
        }

        public void MostrarTransaccion()
        {
            Console.WriteLine("La cantidad de la transacción es la siguiente: " + cantidad + " y el concepto es el siguiente: " + concepto + ".");
        }
    }
}
