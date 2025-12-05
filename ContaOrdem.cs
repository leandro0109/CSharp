using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    internal class ContaOrdem : Conta
    {
        private double limite;

        public ContaOrdem(string nome, int numero, double saldo, double limite)
            : base(nome, numero, saldo)
        {
            this.limite = limite;
        }

        public override void imprimirDados()
        {
            Console.WriteLine("Conta a ordem\nNome: " + getNome() + "\nNumero conta: " + getNumero() + "\nSaldo: " + getSaldo());
        }

        public override void levantar(double valor)
        {
                if (valor > getSaldo() + limite)
                    Console.WriteLine("Levantamento impossivel");
                else
                {
                    Console.WriteLine("Levantados " + valor + " euros com sucesso!");
                    setSaldo(getSaldo() - valor);
                }
        }
    }
}
