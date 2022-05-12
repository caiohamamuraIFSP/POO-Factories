using System;

namespace TarefaFactoryHerois.Herois.Itens
{
    public class PocaoMagia : Item
    {
        public override void Usar()
        {
            Console.WriteLine("Tomou poção de magia!");
        }
    }
}