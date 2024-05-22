using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_Cerveja
{
    internal abstract class Cerveja
    {
        public string Marca { get; set; }
        public string Tipo { get; set; }
        public double TeorAlcoolico { get; set; }
        public double Volume { get; set; }

        public Cerveja(string marca, string tipo, double teorAlcoolico, double volume)
        {
            Marca = marca;
            Tipo = tipo;
            TeorAlcoolico = teorAlcoolico;
            Volume = volume;
        }
        public double CalculaPrecoCerveja()
        {
            return TeorAlcoolico > 0 ? Volume * TeorAlcoolico / 300 : Volume / 100;
        }
        public virtual string Descrever()
        {
            return $"Cerveja: {Marca}, Volume: {Volume}MML, Teor Alcoolico: {TeorAlcoolico}%, Preço Sugerido: R$ {CalculaPrecoCerveja():F2}. ";
        }
    }
}
