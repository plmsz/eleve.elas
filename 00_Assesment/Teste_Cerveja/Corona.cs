using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_Cerveja
{
    internal class Corona : Cerveja
    {
        public Corona(string marca, string tipo, double teorAlcoolico, double volume) : base(marca, tipo, teorAlcoolico, volume)
        {
        }

        public override string Descrever()
        {
            return base.Descrever() + "A cerveja Corona, uma bebida nascida no México com sabor distinto e marca icônica, deixou uma marca indelével na indústria cervejeira.";
        }
    }
}
