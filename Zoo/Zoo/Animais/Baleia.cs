using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Zoo.Grupos;

namespace Zoo.Animais;

internal class Baleia : Mamiferos, INadadores
{
    int INadadores.ProfundidadeMáxima { get; set; }
    int INadadores.ProfundidadeAtual { get; set; }
}