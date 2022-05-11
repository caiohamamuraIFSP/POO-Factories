public class FabricaMoveisClassicos : FabricaMoveis
{
    public override Cadeira CriarCadeira()
    {
        var cadeira = new Cadeira();
        cadeira.Estilo = "Clássico";
        return cadeira;
    }

    public override Mesa CriarMesa()
    {
        var mesa = new Mesa();
        mesa.Estilo = "Clássico";
        return mesa;
    }

    public override Sofa CriarSofa()
    {
        var sofa = new Sofa();
        sofa.Estilo = "Clássico";
        return sofa;
    }
}