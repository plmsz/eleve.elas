using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Grupos;

internal class Anfibios : INadadores, IAndadores
{
    public int ProfundidadeMáxima { get; set; }
    public int ProfundidadeAtual { get; set; }
}