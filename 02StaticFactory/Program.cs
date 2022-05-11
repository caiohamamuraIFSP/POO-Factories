using System;

namespace _02StaticFabric
{
    class Program
    {
        static void Main(string[] args)
        {
            var gerador = GeradorInteiroAleatorio.Entre(10, 15);
            Console.WriteLine(gerador.ProximoAleatorio());
            Console.WriteLine(gerador.ProximoAleatorio());
            Console.WriteLine(gerador.ProximoAleatorio());
            Console.WriteLine(gerador.ProximoAleatorio());
            Console.WriteLine(gerador.ProximoAleatorio());
            Console.WriteLine(gerador.ProximoAleatorio());
        }
    }

    class GeradorInteiroAleatorio
    {
        Random random = new Random();
        protected int minimo = 0;
        protected int maximo = int.MaxValue;

        public static GeradorInteiroAleatorio Ate(int maximo)
        {
            var gerador =  new GeradorInteiroAleatorio();
            gerador.maximo = maximo;
            return gerador;
        }

        public static GeradorInteiroAleatorio PeloMenos(int minimo)
        {
            var gerador =  new GeradorInteiroAleatorio();
            gerador.maximo = 100;
            gerador.minimo = minimo;
            return gerador;
        }

        public static GeradorInteiroAleatorio Entre(int minimo, int maximo)
        {
            var gerador =  new GeradorInteiroAleatorio();
            gerador.minimo = minimo;
            gerador.maximo = maximo;
            return gerador;
        }

        private GeradorInteiroAleatorio() { }

        public int ProximoAleatorio()
        {
            return random.Next(minimo, maximo + 1);
        }
    }
}
