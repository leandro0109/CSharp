using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaCafeAvaliacao
{
    abstract class Bebida
    {
        private string nome;
        private double preco;
        private double agua;
        private double cafe;
        private double leite;
        private double acucar;

        public Bebida(string nome, double preco, double cafe, double agua, double leite, double acucar)
        {
            this.nome = nome;
            this.preco = preco;
            this.cafe = cafe;
            this.agua = agua;
            this.leite = leite;
            this.acucar = acucar;
        }

        public string Nome { get => nome;}
        public double Preco { get => preco;}
        public double Agua { get => agua;}
        public double Cafe { get => cafe;}
        public double Leite { get => leite;}
        public double Acucar { get => acucar;}

        public abstract void prepararBebida();
    }
}
