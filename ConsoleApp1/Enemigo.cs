using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Enemigo
    {
        public int vida;
        public int maxAtk;
        public int minAtk;

        public Enemigo(int vida, int maxAtk, int minAtk)
        {
            this.vida = vida;
            this.maxAtk = maxAtk;
            this.minAtk = minAtk;
        }

        public void Atacar(Enemigo enemy)
        {
            Random random = new Random();
            Enemigo.RecibirDaño(Random.Next(minAtk, maxAtk + 1));
        }

        public void RecibirDaño(int daño)
        {
            vida -= daño;
            if(vida <= 0)
            {
                Random random = new Random();
                Enemigo.RecibirDaño(random.Next(minAtk));
            }
        }
    }
}
