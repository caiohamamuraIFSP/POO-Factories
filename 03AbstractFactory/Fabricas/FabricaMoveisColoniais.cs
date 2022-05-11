public class FabricaMoveisColoniais : FabricaMoveis
{
    public override Cadeira CriarCadeira()
    {
        var cadeira = new Cadeira();
        cadeira.Estilo = "Colonial";
        return cadeira;
    }

    public override Mesa CriarMesa()
    {
        var mesa = new Mesa();
        mesa.Estilo = "Colonial";
        return mesa;
    }

    public override Sofa CriarSofa()
    {
        var sofa = new Sofa();
        sofa.Estilo = "Colonial";
        return sofa;
    }
}