using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo;

internal interface INadadores
{
    public int ProfundidadeMáxima { get; set; }
    public int ProfundidadeAtual { get; set; }

    public void Descer(int altura)
    {
        ProfundidadeAtual -= altura;

        if (Math.Abs(ProfundidadeAtual) > ProfundidadeMáxima)
        {
            throw new Exception("Não permitido");
        }
        Console.WriteLine($"Descer {altura}m, posição atual {ProfundidadeAtual}m");
    }

    public void Subir(int altura)
    {
        ProfundidadeAtual += altura;

        if (ProfundidadeAtual > 0)
        {
            throw new Exception("Não permitido");
        }

        Console.WriteLine($"Subir {altura}m, posição atual {ProfundidadeAtual}m");
    }
}