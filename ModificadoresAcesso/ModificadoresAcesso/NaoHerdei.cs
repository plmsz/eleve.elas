namespace ModificadoresAcesso;

internal class NaoHerdei
{
    public int Id;

    public NaoHerdei()
    {
        ExemploClass exemplo = new()
        {
            PublicProp = 1,
            InternalProp = 3,
            ProtectedInternalProp = 5,
        };
    }
}