using System;

namespace ParImpar
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = new int[] { 3, 2, 1, 4, 5 };
            int par = 0;
            int impar = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] % 2 == 0)
                {
                    par++;
                }
                else
                {
                    impar++;
                }
            }
            Console.WriteLine("Numeros par: " + par);
            Console.WriteLine("Numeros impar: " + impar);
        }
    }
}
