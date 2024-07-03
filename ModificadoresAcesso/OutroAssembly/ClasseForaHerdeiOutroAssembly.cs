using ModificadoresAcesso;

namespace OutroAssembly;

internal class ClasseForaHerdeiOutroAssembly : ExemploClass
{
    public ClasseForaHerdeiOutroAssembly()
    {
        PublicProp = 1;
        ProtectedProp = 2;
        PrivateProtectedProp = 3;
        ProtectedProp = 4;
    }
}