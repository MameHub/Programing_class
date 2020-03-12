using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public struct Fecha
    {
        public int dia;
        public string mes;
        public int año;

        public Fecha(int dia, string mes, int año)
        {
            this.dia = dia;
            this.mes = mes;
            this.año = año;
        }

        public string ConvertirString()
        {
            return (dia + " de " + mes + " del " + año);
        }
    }
}
