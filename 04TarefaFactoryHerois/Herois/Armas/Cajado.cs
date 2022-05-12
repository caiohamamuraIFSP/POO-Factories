using System;

namespace TarefaFactoryHerois.Herois.Armas
{
    public class Cajado : Arma
{

        public Cajado()
        {
            this.Forca = 10;
        }

        public override void ataca() => Console.WriteLine("");
    }
}