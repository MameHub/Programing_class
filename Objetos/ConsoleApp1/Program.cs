﻿using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.Write("Introduzca su nombre: ");
            //string nombre = Console.ReadLine();
            //Console.Write("Introduzca una nota: ");
            //float nota = float.Parse(Console.ReadLine());
            //Alumno alumno1 = new Alumno(nombre, nota);
            //Alumno alumno2 = new Alumno("Álvaro", 7.4f);
            //Alumno alumno3 = new Alumno("Ángel", 10f);
            //Alumno alumno4 = new Alumno("Joaquín", 9.4f);
            //alumno1.MostrarDatos();
            //alumno2.MostrarDatos();
            //alumno3.MostrarDatos();
            //alumno4.MostrarDatos();

            Alumno[] alumnos = new Alumno[3];
            for (int i = 0; i < alumnos.Length; i++)
            {
                Console.Write("Introduzca su nombre: ");
                string nombre = Console.ReadLine();
                Console.Write("Introduzca una nota: ");
                float nota = float.Parse(Console.ReadLine());
                alumnos[i] = new Alumno(nombre, nota);
            }
            Console.WriteLine();
            Console.WriteLine();
            for (int i = 0; i < alumnos.Length; i++)
            {
                alumnos[i].MostrarDatos();
            }

            float total = 0;
            for (int i = 0; i < alumnos.Length; i++)
            {
                total += alumnos[i].nota;
                alumnos[i].MostrarDatos();
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("La media es: " + (total / alumnos.Length));
        }
    }
}
