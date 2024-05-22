using System;

namespace Excessoes_customizadas
{
    internal static class Program
    {
        public class Conta
        {
            private decimal saldoConta;

            public void Sacar(decimal valor)
            {
                if (saldoConta < valor)
                {
                    throw new SaldoInsuficienteException("Saldo insuficiente para sacar.");
                }
                saldoConta -= valor;
            }

            public void Depositar(decimal valor)
            {
                saldoConta += valor;
            }
        }

        private static void Main()
        {
            Conta conta = new Conta();
            conta.Depositar(100);
            conta.Sacar(75);
            conta.Sacar(50);
        }
    }
}