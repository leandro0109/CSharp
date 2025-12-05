using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    abstract class Conta
    {
        private string nome;
        private int numero;
        private double saldo;

        public Conta(string nome, int numero, double saldo)
        {
            this.nome = nome;
            this.numero = numero;
            this.saldo = saldo;
        }

        public void setSaldo(double novoSaldo) { this.saldo = novoSaldo; } 
        public string getNome() { return nome; }
        public int getNumero() { return numero; }
        public double getSaldo() { return saldo; }

        public abstract void imprimirDados();

        public void depositar(double valor, int numero)
        {
            saldo += valor;
            Console.WriteLine("Depositados " + valor + " euros com sucesso!");
        }

        public abstract void levantar(double valor);
        
        public void transferir(Conta contaRemete, Conta contaDestino, double valor)
        {
            contaRemete.saldo -= valor;
            contaDestino.saldo += valor;
            Console.WriteLine("Transação efetuada com sucesso.");
            Console.WriteLine("Montante: " + valor + "EUR");
            Console.WriteLine("Comissão: 0EUR");
            Console.WriteLine("Imposto: 0EUR");
            Console.WriteLine();
            Console.WriteLine("Dados da conta do remetente:");
            contaRemete.imprimirDados();
            Console.WriteLine();
            Console.WriteLine("Dados da conta do destinatário:");
            contaDestino.imprimirDados();
        }


    }
}
