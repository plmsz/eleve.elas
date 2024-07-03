using ModificadoresAcesso;

internal class Program
{
    private static void Main()
    {
        ExemploClass exemplo = new()
        {
            PublicProp = 1,
            InternalProp = 3,
            ProtectedInternalProp = 5
        };

        HerdeiClasse herdeiClasse = new()
        {
            PublicProp = 1,
            InternalProp = 3,
            ProtectedInternalProp = 5
        };
    }
}