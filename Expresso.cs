using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaCafeAvaliacao
{
    internal class Expresso : Bebida
    {
        private const string nome = "Expresso";
        private const double preco = 0.65;
        private const double quantCafe = 7.5;
        private const double quantAgua = 27.5;
        private const double quantLeite = 0;
        private const double quantAcucar = 6;

        public Expresso()
            : base(nome, preco, quantCafe, quantAgua, quantLeite, quantAcucar) { }

        public override void prepararBebida()
        {
            Console.WriteLine($"☕ {nome} — {preco} €\r\nIngredientes: {quantCafe}g café | {quantAgua}ml água | {quantAcucar}g açúcar | {quantLeite}ml leite\r\n");
            Console.WriteLine("\n➡️ A preparar o seu Expresso intenso e aromático...");
        }
    }
}
