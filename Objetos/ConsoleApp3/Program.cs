using System;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Aplicación de banco.
            // 1.- Crear cuenta -> Nombre.
            // 2.- Buscar cuenta -> a) Ingresar/Sacar dinero -> I.- Cantidad. II.- Concepto. b) Mostrar info. c) Salir.
            // 3.- Salir. Struct -> Transacción.
            // class -> Cliente.
            // clase -> bank

            Transaccion transaccion = new Transaccion(20, "Porque si");
            Cuenta cuenta = new Cuenta("Álvaro");
            cuenta.AñadirTransaccion(transaccion);
            cuenta.AñadirTransaccion(transaccion);
            cuenta.AñadirTransaccion(transaccion);
            cuenta.MostrarTransacciones();
        }
    }
}
