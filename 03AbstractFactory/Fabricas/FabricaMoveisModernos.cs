public class FabricaMoveisModernos : FabricaMoveis
{
    public override Cadeira CriarCadeira()
    {
        var cadeira = new Cadeira();
        cadeira.Estilo = "Moderno";
        cadeira.NumeroPernas = 3;
        return cadeira;
    }

    public override Mesa CriarMesa()
    {
        var mesa = new Mesa();
        mesa.Estilo = "Moderno";
        return mesa;
    }

    public override Sofa CriarSofa()
    {
        var sofa = new Sofa();
        sofa.Estilo = "Moderno";
        return sofa;
    }
}