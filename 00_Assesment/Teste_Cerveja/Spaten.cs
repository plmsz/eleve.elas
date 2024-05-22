using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_Cerveja
{
    internal class Spaten : Cerveja
    {
        public double Amargor { get; protected set; }

        public Spaten(string marca, string tipo, double teorAlcoolico, double volume) : base(marca, tipo, teorAlcoolico, volume)
        {
            Amargor = 16.0;
        }

        public override string Descrever()
        {
            return base.Descrever() + "A Spaten foi criada em 1397, em Munique, a capital mundial da cerveja, de intenso sabor de malte."; ;
        }
    }
}
