using System;

namespace TarefaFactoryHerois.Herois.Itens
{
    public class PocaoCura : Item
    {
        public override void Usar()
        {
            Console.WriteLine("Tomou poção de cura!");
        }
    }
}