using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificadoresAcesso;

public class ExemploClass
{
    public int PublicProp { get; set; }
    private int PrivateProp { get; set; }
    internal int InternalProp { get; set; }
    protected int ProtectedProp { get; set; }
    protected int PrivateProtectedProp { get; set; } //private protected não está funcionando?
    protected internal int ProtectedInternalProp { get; set; }

    public void Metodo()
    {
        PublicProp = 1;
        PrivateProp = 2;
        InternalProp = 3;
        ProtectedProp = 4;
        PrivateProtectedProp = 5;
    }
}