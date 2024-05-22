using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teste_Cerveja
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Cerveja> cervejas = new List<Cerveja>();

            cervejas.Add(new Spaten("Puro Malte", "Lager", 5.20, 350));
            cervejas.Add(new Corona("Corona Extra", "Lager", 4.60, 330));
            cervejas.Add(new Budweiser("Budweiser Zero", "American Lager", 0.00, 330));
            
            foreach (var item in cervejas)
            {
                Console.WriteLine(item.Descrever());
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}
