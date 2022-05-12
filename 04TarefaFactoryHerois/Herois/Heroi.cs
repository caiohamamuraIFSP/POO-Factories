using System;
using System.Collections.Generic;
using System.Text;
using TarefaFactoryHerois.Herois.Armaduras;
using TarefaFactoryHerois.Herois.Armas;
using TarefaFactoryHerois.Herois.Itens;

namespace TarefaFactoryHerois.Herois
{
    public abstract class Heroi
    {
        private Arma arma;
        private Armadura armadura;
        List<Item> mochila = new List<Item>();

        public void EquipaArma(Arma arma)
        {
            this.arma = arma;
        }

        public void EquipaArmadura(Armadura armadura)
        {
            this.armadura = armadura;
        }

        public void PegaItem(Item item)
        {
            mochila.Add(item);
        }

        public override string ToString()
        {
            StringBuilder construtorTexto = new StringBuilder();
            construtorTexto.Append($"Classe: {this.GetType().Name}\n");
            construtorTexto.Append($"Arma: {arma.GetType().Name}\n");
            construtorTexto.Append($"Armadura: {armadura.GetType().Name}\n");
            construtorTexto.Append($"Mochila:\n");
            mochila.ForEach(item =>
            {
                construtorTexto.Append($" - {item.GetType().Name}\n");
            });
            return construtorTexto.ToString();
        }
    }
}