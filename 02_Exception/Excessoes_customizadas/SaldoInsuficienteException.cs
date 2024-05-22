using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excessoes_customizadas
{
    internal class SaldoInsuficienteException : Exception
    {
        public SaldoInsuficienteException() : base("Saldo insuficiente para transação")
        {
            //O construtor padrão (SaldoInsuficienteException()) define uma mensagem de erro padrão: "Saldo insuficiente para realizar o saque.".
        }

        public SaldoInsuficienteException(string message) : base(message)
        {
            //O construtor sobrecarregado(SaldoInsuficienteException(string mensagem)) permite especificar uma mensagem de erro personalizada.
        }
    }
}