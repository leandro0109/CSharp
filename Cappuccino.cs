using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaCafeAvaliacao
{
    internal class Cappuccino : Bebida
    {
        private const string nome = "Cappuccino";
        private const double preco = 0.95;
        private const double quantCafe = 6.5;
        private const double quantAgua = 25;
        private const double quantLeite = 50;
        private const double quantAcucar = 7.5;

        public Cappuccino()
            : base(nome, preco, quantCafe, quantAgua, quantLeite, quantAcucar) { }

        public override void prepararBebida()
        {
            Console.WriteLine($"☕ {nome} — {preco} €\r\nIngredientes: {quantCafe}g café | {quantAgua}ml água | {quantAcucar}g açúcar | {quantLeite}ml leite\r\n");
            Console.WriteLine("\n➡️ A preparar o seu Cappuccino com espuma deliciosa...");
        }
    }
}
