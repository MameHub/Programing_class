using System;

namespace ConditionalStatements
{
    class Program
    {
        static void Main(string[] args)
        {
            // OPERADORES CONDICIONALES
            // > mayor
            // >= mayor o igual
            // < menor
            // <= menor o igual
            // == igual
            // != no es igual
            // && condicional "Y"
            // || condicionar "O"

            // ENUNCIADO
            // 1. El usuario introduce dos números y comprobaremos si son
            // iguales o no.
            // RESULTADO
            Console.Write("Introduzca un número: ");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Introduzca otro número: ");
            int y = int.Parse(Console.ReadLine());
            if(x == y)
            {
                Console.WriteLine("Son iguales");
            }
            else
            {
                Console.WriteLine("No son iguales");
            }

            // ENUNCIADO
            // 2. El usuario introduce un número y comprobamos si es par o impar.
            // RESULTADO
            Console.Write("Introduzca un número: ");
            int n = int.Parse(Console.ReadLine());
            // Para comprobarlo, sabemos que un número cuyo resto dado de una
            // división por 2 es 0, es par, y si es diferente, es impar.
            // Usamos el operador módulo (%)
            if(n % 2 == 0)
            {
                Console.WriteLine("Es par");
            }
            else
            {
                Console.WriteLine("Es impar");
            }

            // ENUNCIADO
            // 3. Comprobar si un número introducido es positivo o negativo,
            // el 0 cuenta como positivo.
            // RESULTADO
            Console.Write("Introduzca un número: ");
            int number = int.Parse(Console.ReadLine());
            if(number >= 0)
            {
                Console.WriteLine("Es positivo");
            }
            else
            {
                Console.WriteLine("Es negativo");
            }

            // ENUNCIADO
            // 4. El usuario introduce una edad y nosotros le decimos si es un
            // jubilado, mayor de edad o menor de edad.
            Console.Write("Introduzca su edad: ");
            int age = int.Parse(Console.ReadLine());
            // Recordemos que el orden de las preguntas importa, primero se
            // pregunta si tiene más o igual a 65, si no es así, preguntamos
            // si tiene más o igual a 18, y si no es así, es que es menor de edad.
            if(age >= 65)
            {
                Console.WriteLine("Jubilado");
            }
            else if(age >= 18)
            {
                Console.WriteLine("Mayor de edad");
            }
            else if(age >= 0 && age < 18)
            {
                Console.WriteLine("Menor de edad");
            }
            else
            {
                Console.WriteLine("Número negativo, error");
            }

            // ENUNCIADO
            // 5. El usuario introduce una nota, y nosotros lo calificaremos como
            // sobresaliente, notable, bien, suficiente o insuficiente.
            // Obligatorio hacerlo con IF ELSE y SWITCH.
            Console.Write("Introduzca su nota: ");
            int mark = int.Parse(Console.ReadLine());
            if (mark <= 10 && mark >= 9)
            {
                Console.WriteLine("Sobresaliente");
            }
            else if(mark >= 7 && mark < 9)
            {
                Console.WriteLine("Notable");
            }
            else if(mark >= 6 && mark < 7)
            {
                Console.WriteLine("Bien");
            }
            else if(mark >= 5 && mark < 6)
            {
                Console.WriteLine("Suficiente");
            }
            else if(mark >= 0 && mark < 5)
            {
                Console.WriteLine("Insuficiente");
            }
            else
            {
                Console.WriteLine("Nota incorrecta");
            }
            // Con SWITCH es un poco diferente, vamos a examinar los distintos
            // casos de valores que puede tener la nota.
            // SWITCH es mucho más útil cuando se usa con problemas con variables
            // de valor concreto, por ejemplo, una nota.
            switch (mark)
            {
                case 10:
                case 9:
                    Console.WriteLine("Sobresaliente");
                    // La palabra clave break nos sirve para salir de la ejecución
                    // si no lo pusiéramos, seguiría ejecutando hacia abajo
                    // como si de una cascada se tratase. Por eso, si el valor es 10 o 9
                    // pintará "Sobresaliente".
                    break;
                case 8:
                case 7:
                    Console.WriteLine("Notable");
                    break;
                case 6:
                    Console.WriteLine("Bien");
                    break;
                case 5:
                    Console.WriteLine("Suficiente");
                    break;
                case 4:
                case 3:
                case 2:
                case 1:
                case 0:
                    Console.WriteLine("Insuficiente");
                    break;
                // El caso default es lo mismo que el ELSE dentro de un IF ELSE.
                // Si ninguno de los casos anteriores no se cumple, se ejecuta.
                default:
                    Console.WriteLine("Nota incorrecta");
                    break;
            }

            // ENUNCIADO
            // 6. El usuario introduce una temperatura y nosotros le diremos si está
            // Helado, Muy frío, Frío, Normal, Caliente, Muy caliente.
            // RESULTADO
            Console.Write("Introduzca una temperatura: ");
            int temperature = int.Parse(Console.ReadLine());
            if(temperature < 0)
            {
                Console.WriteLine("Helado");
            }
            else if(temperature >= 0 && temperature < 10)
            {
                Console.WriteLine("Muy frío");
            }
            else if(temperature >= 10 && temperature < 20)
            {
                Console.WriteLine("Frío");
            }
            else if(temperature >= 20 && temperature < 30)
            {
                Console.WriteLine("Normal");
            }
            else if(temperature >= 30 && temperature < 40)
            {
                Console.WriteLine("Caliente");
            }
            else
            {
                Console.WriteLine("Muy caliente");
            }

            // ENUNCIADO
            // 7. El usuario introduce 3 ángulos, y deberemos ver si podemos crear
            // un triángulo con dichos ángulos.
            // RESULTADO
            // Un triángulo puede ser formado cuando los 3 ángulos suman 180.
            Console.Write("Introduzca un ángulo: ");
            int angle1 = int.Parse(Console.ReadLine());
            Console.Write("Introduzca un ángulo: ");
            int angle2 = int.Parse(Console.ReadLine());
            Console.Write("Introduzca un ángulo: ");
            int angle3 = int.Parse(Console.ReadLine());
            if(angle1 + angle2 + angle3 == 180)
            {
                Console.WriteLine("Se puede formar el triángulo");
            }
            else
            {
                Console.WriteLine("No se puede formar el triángulo");
            }

            // ENUNCIADO
            // 8. El usuario introduce el dinero ganado este mes y el dinero que ha tenido
            // que pagar. Le diremos si ha ganado o ha perdido y le mostramos el resultado.
            Console.Write("¿Cúanto ha ganado?: ");
            int win = int.Parse(Console.ReadLine());
            Console.Write("¿Cúanto ha pagado?: ");
            int lose = int.Parse(Console.ReadLine());
            int result = win - lose;
            if(result >= 0)
            {
                Console.Write("Ha ganado: ");
            }
            else
            {
                Console.Write("Ha perdido: ");
            }
            Console.WriteLine(result);

            // ENUNCIADO
            // 9. El usuario introduce un número del 1 al 7 y nosotros le decimos que
            // día de la semana es.
            // RESULTADO
            Console.Write("Introduzca un número del 1 al 7: ");
            int day = int.Parse(Console.ReadLine());
            switch (day)
            {
                case 1:
                    Console.WriteLine("Lunes");
                    break;
                case 2:
                    Console.WriteLine("Martes");
                    break;
                case 3:
                    Console.WriteLine("Miércoles");
                    break;
                case 4:
                    Console.WriteLine("Jueves");
                    break;
                case 5:
                    Console.WriteLine("Viernes");
                    break;
                case 6:
                    Console.WriteLine("Sábado");
                    break;
                case 7:
                    Console.WriteLine("Domingo");
                    break;
                default:
                    Console.WriteLine("Error, número erróneo");
                    break;
            }
        }
    }
}
