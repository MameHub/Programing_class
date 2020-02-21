using System;
// Cuando trabajamos con listas debemos añadir funcionalidades nuevas, que se encuentran en la línea que vemos a continuación.
using System.Collections.Generic;

namespace bonusRound
{
    class Program
    {
        static void Main(string[] args)
        {
            // Creación de listas.
            // Lo primero es lo que hay entre mayor y menor que es el tipo de datos con los que va a trabajar, a continuación va el nombre de la lista
            // Lo final es llamada al constructor y el tipo de datos con los que se va a trabajar.

            // List<tipo variable> nombre = new List<int>();

            // Lista de variable int.
            List<int> numbers = new List<int>();
            //Añade datos.
            numbers.Add(1);
            numbers.Add(1000);
            //Elimina datos por celda.
            numbers.Remove(1000);
            //Elimina datos por posición.
            numbers.RemoveAt(0);
            //Añade datos.
            numbers.Add(20);
            numbers.Add(1000);
            numbers.Add(10);
            numbers.Add(1200);
            //Elimina datos de la celda de indice 2.
            numbers.RemoveAt(2);
            //Para acceder a un celda y restarle 40 a dicha celda.
            numbers[1] = -40;

            //Lista de tipo float.
            List<float> decimals = new List<float>();

            //Lista de tipo double.
            List<double> doble = new List<double>();

            //Lista de tipo charset.
            List<char> charset = new List<char>();

            //Lista de tipo string.
            List<string> cadena = new List<string>();


            //Lista declarada pero no inicializada.
            // List<int> decla;

            foreach (int numeros in numbers)
            {
                Console.WriteLine(numeros);
            }
        }
    }
}
