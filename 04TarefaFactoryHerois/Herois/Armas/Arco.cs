using System;

namespace TarefaFactoryHerois.Herois.Armas
{
    public class Arco : Arma
{
        public Arco()
        {
            this.Forca = 10;
        }

        public override void ataca() => Console.WriteLine("Atirou uma flecha!");
    }
}