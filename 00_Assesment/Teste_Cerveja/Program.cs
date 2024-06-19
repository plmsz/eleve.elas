using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_Cerveja
{
    internal class Program
    {
        private static void Main()
        {
            List<Cerveja> cervejas = new List<Cerveja>
            {
                new Spaten("Puro Malte", "Lager", 5.20, 350),
                new Corona("Corona Extra", "Lager", 4.60, 330),
                new Budweiser("Budweiser Zero", "American Lager", 0.00, 330)
            };

            foreach (var item in cervejas)
            {
                Console.WriteLine(item.Descrever());
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}