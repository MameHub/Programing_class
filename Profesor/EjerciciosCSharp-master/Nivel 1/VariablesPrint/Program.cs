using System;

namespace VariablesPrint
{
    class Program
    {
        // La función Main es la puerta de entrada a la ejecución de nuestro programa
        // solamente puede haber una función Main dentro de nuestro programa.
        static void Main(string[] args)
        {
            // VARIABLES
            int wholeNumber = 3;
            float decimalNumber = 3.4f;
            double biggerDecimalNumber = 3.42332d;
            char letter = 'C';
            string phrase = "Hola";
            bool trueFalse = true;

            // ENUNCIADO
            // 1. Pintar en pantalla "Hola:" y el nombre del usuario
            // RESULTADO
            // La función Console.WriteLine nos sirve para pintar en pantalla
            // cualquier operación o texto que queramos, incluyendo un retorno
            // de línea al final (haciendo un INTRO, como en Word).
            Console.WriteLine("Hola: Nacho");
            // Para que sea más útil, podemos preguntarle el nombre al usuario
            // usando la función Console.ReadLine
            // La función Console.Write sirve para pintar en pantalla cualquier
            // operación o texto, pero sin incluir un retorno de línea.
            Console.Write("Introduzca su nombre: ");
            // Guardamos aquello que escriba el usuario en una variable string.
            // string = una frase.
            string name = Console.ReadLine();
            // Mostramos la frase entera mediante la concatenación de strings.
            // (string + string) = string
            Console.WriteLine("Hola: " + name);

            // ENUNCIADO
            // 2. Pintar en pantalla la suma de dos números.
            // RESULTADO
            // La función Console.WriteLine también puede recibir una variable de
            // tipo int (número entero) y mostrarla por pantalla.
            // (int + int) = int
            Console.WriteLine(2 + 3);
            // Para que sea más útil, vamos a pedirle al usuario que nos introduzca
            // él mismo los números.
            // Console.ReadLine nos devuelve un objeto de tipo string, pero nosotros
            // necesitamos que nos lo convierta a int, para eso usamos la función
            // int.Parse, que transforma un string a int.
            Console.Write("Introduzca un número: ");
            int firstNumber = int.Parse(Console.ReadLine());
            Console.Write("Introduzca otro número: ");
            int secondNumber = int.Parse(Console.ReadLine());
            // La suma de un string y un int: (string + int) = string
            // Ponemos entre paréntesis ambos números para que nos haga la suma antes
            // de convertirlo a string, si no lo pusiéramos, daría un resultado extraño.
            Console.WriteLine("La suma de ambos números es: " + (firstNumber + secondNumber));

            // ENUNCIADO
            // 3. Mostrar el resultado de distintas operaciones
            // -1 + 4 * 6
            // (35 + 5) % 7
            // 14 + -4 * 6 / 11
            // 2 + 15 / 6 * 1 - 7 % 2
            // RESULTADO
            // + operador suma
            // - operador resta
            // * operador multiplicación
            // / operador división
            // % operador módulo, nos devuelve el resto de una división
            Console.WriteLine("Operaciones:");
            Console.WriteLine(-1 + 4 * 6);
            Console.WriteLine((35 + 5) % 7);
            Console.WriteLine(14 + -4 * 6 / 11);
            Console.WriteLine(2 + 15 / 6 * 1 - 7 % 2);
            Console.WriteLine("Fin operaciones");

            // ENUNCIADO
            // 4. Pintar en pantalla el resultado de sumar, restar, multiplicar
            // dividir y módulo de dos números.
            // RESULTADO
            // Le pedimos al usuario ambos números
            Console.Write("Introduzca un número: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Introduzca otro número: ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Suma: " + (x + y));
            Console.WriteLine("Resta: " + (x - y));
            Console.WriteLine("Multiplicación: " + (x * y));
            Console.WriteLine("División: " + (x / y));
            Console.WriteLine("Resto: " + (x % y));

            // ENUNCIADO
            // 5. Pintar en pantalla un número, primero todo junto varias veces
            // y luego separado por espacios.
            // Ejemplo: 252525 y 25 25 25.
            // RESULTADO
            Console.Write("Introduzca un número: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Primera manera: ");
            Console.Write(number);
            Console.Write(number);
            Console.WriteLine(number);
            Console.Write("Segunda manera: ");
            Console.WriteLine(number + " " + number + " " + number);
        }
    }
}
