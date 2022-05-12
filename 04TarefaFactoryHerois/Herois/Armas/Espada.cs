using System;

namespace TarefaFactoryHerois.Herois.Armas
{
    public class Espada : Arma
{

        public Espada()
        {
            this.Forca = 10;
        }
        public override void ataca() => Console.WriteLine("Golpeou com a espada!");
    }
}