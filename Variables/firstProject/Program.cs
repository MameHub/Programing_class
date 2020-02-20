/*using System;

namespace firstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaración de variables de tipo interger
            // llamada "x".
            //int x;
            // Inicialización de variables llamada "x"
            // con el valor 4.
            //x = 4;
            // Declaración e incialización.
            //int p = 3;
            // Declaración e inicialización de la variable interger.
            //int y = 3;
            // Declaración e inicialización de la variable floating point.
            //float z = 3.3f;
            // Declaración e inicialización de la variable double.
            //double w = 3.32d;
            // Convierto la variable z que es float a integral.
            //y = (int)z;
            // Las comillas simples para letras.
            //char letra = 'A';
            // Las comillas dobles para frases (cadena de caractéres).
            //string frase = "Paco Pepe cabronazo";
            // El valor booleano devuelve si un valor es verdadero o falso
            //bool booleanoFalso = false;
            //bool booleanoVerdadero = true;
            //Console.WriteLine("Hello World!");
            //Console.WriteLine(p);
            //Console.WriteLine(y);
            //Console.WriteLine(z);
            //Console.WriteLine(w);
            //Console.WriteLine(letra);
            //Console.WriteLine(frase);
            //Console.WriteLine(booleanoFalso);
            //Console.WriteLine(booleanoVerdadero);
            //Console.WriteLine("Interger: " + x + " Bool: " + booleanoFalso);

            //Vamos a pedirle al usuario que nos dé dos números, vamos a sumarlos y vamos a enseñar el resultado por pantalla.
            // Le pido al usuario que escriba un número y la máquina lo tomara como un string
            //Console.Write("Escribe el primer número: ");
            // Almaceno el string que ha escrito el usuario en una variable de tipo int llamada "numeroTransformer1" y convierto el string a un número entero
            //int numeroTransformer1 = int.Parse(Console.ReadLine());
            //Console.Write("Escribe el segundo número: ");
            //int numeroTransformer2 = int.Parse(Console.ReadLine());
            //Console.WriteLine("El resultado de la suma es: " + (numeroTransformer1+ numeroTransformer2));
            //Console.WriteLine("El resultado de la multiplicación es: " + (numeroTransformer1 * numeroTransformer2));
            //Console.WriteLine("El resultado de la división es: " + (numeroTransformer1 / numeroTransformer2));
            //Console.WriteLine("El resto de la división es: " + (numeroTransformer1 % numeroTransformer2));

            // Función más utilizada en las versiones de 2017 para que el código al ejecutarse no se cierre de inmediato.
            //Console.ReadLine();

            // Prueba del resultado de un valor booleano con un if else
            //Console.Write("Escriba su edad: ");
            //int age = int.Parse(Console.ReadLine());
            //if (age >= 18)
            //{
            //    Console.WriteLine("Eres mayor de edad campeón!");
            //}
            //else
            //{
            //    Console.WriteLine("Estas hecho un niñato, madura coñio!");
            //}
            //Console.ReadLine();

            //Console.Write("Escriba su edad: ");
            //int age = int.Parse(Console.ReadLine());
            //if (age >= 65)
            //{
            //    Console.WriteLine("Estas jubilao, a dormir yayo");
            //}
            //else if (age >= 18)
            //{
            //    Console.WriteLine("Eres mayor de edad campeón!");
            //}

            //else
            //{
            //    Console.WriteLine("Estas hecho un niñato, madura coñio!");
            //}
            //Console.ReadLine();
            //bool windy = false;
            //bool sunny = true;
            //bool rainy = true;

            //if(!windy && (rainy || sunny))
            //{
            //    Console.WriteLine("Puedes coger el paraguas");
            //    Console.ReadLine();
            //}

            // Vamos a pedirle al usuario que nos introduzca la nota que ha sacado en el examen y lo clasificaremos por Sobresaliente, Notable, Bien, Suficiente o Insuficiente. Si el usuario introduce una nota no válida, le diremos que se ha equivocado.
            // Por ahora nos introducirá un int, una vez completado el ejercicio haremos lo mismo con un float(número con decimales).
                        Console.Write("Escribe tu nota: ");
            int nota = int.Parse(Console.ReadLine());

            if (nota <= 0)
            {
                Console.WriteLine("Te has equivocado al escribir la nota");
            }
            else if (nota <= 4)
            {
                Console.WriteLine("Estas suspenso, a estudiar");
            }
            else if (nota == 5)
            {
                Console.WriteLine("Vas raspao");
            }
            else if (nota > 10)
            {
                Console.WriteLine("Te has flipao deja las puta setas yonkie de mierda");
            }
            else
            {
                Console.WriteLine("Has aprobado, te quitas una recuperación");
            }
            Console.ReadLine();
        }
    }
}
*/

/*using System;

namespace firstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Cual es tu nota?: ");
            float grade = float.Parse(Console.ReadLine());
            if(grade == 9 && grade == 10)
            {
                Console.WriteLine("Sobresaliente");
            }
            else if(grade >= 7)
            {
                Console.WriteLine("Notable");
            }
            else if(grade >= 6)
            {
                Console.WriteLine("Bien");
            }
            else if(grade >= 5)
            {
                Console.WriteLine("Suficiente");
            }
            else if(grade >= 0 && grade < 5)
            {
                Console.WriteLine("Insuficiente");
            }
            else
            {
                Console.WriteLine("Se ha equivocado");
            }
            Console.ReadLine();
        }
    }
}
*/

using System;

namespace firstProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Introduzca su nota: ");
            int note = int.Parse(Console.ReadLine());
            switch (note)
            {
                case 0:
                    Console.WriteLine ("Tienes un 10 viudo");
                    break;
                case 1:
                    Console.WriteLine("Eso es un truñaco");
                    break;
                case 2:
                    Console.WriteLine("Estudia más");
                    break;
                case 3:
                    Console.WriteLine("Suspenso");
                    break;
                case 4:
                    Console.WriteLine("Te has quedado apuntito");
                    break;
                case 5:
                    Console.WriteLine("Raspado");
                    break;
                case 6:
                    Console.WriteLine("Aprobado");
                    break;
                case 7:
                    Console.WriteLine("Notable");
                    break;
                case 8:
                    Console.WriteLine("Notable alto");
                    break;
                case 9:
                    Console.WriteLine("Por poco coges las dos cifras");
                    break;
                case 10:
                    Console.WriteLine("Sobresaliente");
                    break;
                default:
                    Console.WriteLine("Te has flipado");
                    break;
            }
            Console.ReadLine();
        }
    }
}