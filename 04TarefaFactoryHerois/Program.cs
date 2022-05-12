using System;
using TarefaFactoryHerois.Herois;
using TarefaFactoryHerois.Herois.Armas;
using TarefaFactoryHerois.Herois.Itens;
using TarefaFactoryHerois.Herois.Armaduras;

namespace TarefaFactoryHerois
{
    class Program
    {
        static void Main(string[] args)
        {
            Heroi arqueiro = CriaArqueiro();
            Heroi espadachim = CriaEspadachim();
            Heroi mago = CriaMago();

            Console.WriteLine(arqueiro);
            Console.WriteLine();
            Console.WriteLine(espadachim);
            Console.WriteLine();
            Console.WriteLine(mago);
        }

        static Heroi CriaArqueiro()
        {
            Arqueiro arqueiro = new Arqueiro();
            arqueiro.EquipaArma(new Arco());
            arqueiro.EquipaArmadura(new Couraca());
            arqueiro.PegaItem(new PocaoCura());

            // FabricaHeroi fabricaArqueiro = new FabricaArqueiro();
            // arqueiro.EquipaArma(fabricaArqueiro.CriarArma());
            // arqueiro.EquipaArmadura(fabricaArqueiro.CriarArmadura());
            // arqueiro.PegaItem(fabricaArqueiro.CriarPocao());

            return arqueiro;
        }

        static Heroi CriaEspadachim()
        {
            Espadachim espadachim = new Espadachim();
            espadachim.EquipaArma(new Espada());
            espadachim.EquipaArmadura(new Completa());
            espadachim.PegaItem(new PocaoCura());
            return espadachim;
        }

        static Heroi CriaMago()
        {
            Mago mago = new Mago();
            mago.EquipaArma(new Cajado());
            mago.EquipaArmadura(new Manto());
            mago.PegaItem(new PocaoMagia());
            return mago;
        }
    }
}
