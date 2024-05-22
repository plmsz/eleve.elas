using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_Cerveja
{
    internal class Budweiser : Cerveja
    {
        public Budweiser(string marca, string tipo, double teorAlcoolico, double volume) : base(marca, tipo, teorAlcoolico, volume)
        {
        }

        public override string Descrever()
        {
            return base.Descrever() + "O processo de produçãoda Budweiser é diferenciado, por utilizar lascas de Beechwood (madeira especial) durante os processos de fermentação e maturação. O resultado é um cerveja de sabor único e com equilíbrio perfeito: marcante no início e suave no final.";
        }
    }
}
