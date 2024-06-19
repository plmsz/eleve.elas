using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zoo.Animais;

internal class Gaivota : Aves, IVoadores
{
    void IVoadores.LevantarVoo()
    {
    }

    void IVoadores.Pousar()
    {
    }
}