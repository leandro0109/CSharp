using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    internal class ContaPrazo : Conta
    {
        private double taxaJuro;
        private DateTime dataVencimento;

        public ContaPrazo(string nome, int numero, double saldo, double taxaJuro, DateTime dataVencimento) 
            : base(nome, numero, saldo)
        {
            this.taxaJuro = taxaJuro;
            this.dataVencimento = dataVencimento;
        }

        public override void levantar(double valor)
        {
            if (DateTime.Now < dataVencimento)
            {
                Console.WriteLine("Prazo ainda não terminado");
            }
            else if (valor > getSaldo())
            {
                Console.WriteLine("Saldo insuficiente");
            }
            else
            {
                setSaldo(getSaldo() - valor);
            }
        }

        public override void imprimirDados()
        {
            Console.WriteLine("Conta a prazo\nNome: " + getNome() + "\nNumero conta: " + getNumero() + "\nSaldo: " + getSaldo());
        }
    }
}
