using System;

namespace _03AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            FabricaMoveis fabrica = new FabricaMoveisModernos();
            var movel = fabrica.CriarMesa();

            Console.WriteLine("Estilo: {0}", movel.Estilo);
        }
    }
}
