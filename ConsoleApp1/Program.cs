using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int vida = 100;
            int maxAtk = 80;
            int minAtk = 20;
            Enemigo enemigo1 = new Enemigo(vida, maxAtk, minAtk);
            Enemigo enemigo2 = new Enemigo(vida, maxAtk, minAtk);
            while (enemigo1.vida > 0 && enemigo2.vida > 0)
            {
                enemigo1.Atacar(enemigo2);
                Console.WriteLine("Vida enemigo 2: " + enemigo2.vida);
                enemigo2.Atacar(enemigo1);
                Console.WriteLine("Vida enemigo 1: " + enemigo1.vida);
            }
        }
    }
}
