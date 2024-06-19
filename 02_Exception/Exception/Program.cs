using System;
using System.Collections.Generic;

namespace Excessoes
{
    internal class Program
    {
        private class Cliente
        {
            public string Nome { get; set; }
        }

        private static void Main()
        {
            try
            {
                var cliente = new Cliente();
                cliente = null;

                //Console.WriteLine(cliente.Nome);

                List<string> lista = new List<string>() { "a", "b", "c" };

                Console.WriteLine(lista[4]);
                Console.WriteLine("builda");
            }
            catch (Exception e) when (e is NullReferenceException || e is ArgumentOutOfRangeException)
            {
                Console.WriteLine($"Mensagem {e.Message}");
            }
            finally
            {
                Console.WriteLine("Passou por aqui indepedente se deu certo ou não");
            }
        }
    }
}