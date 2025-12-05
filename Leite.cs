using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaCafeAvaliacao
{
    internal class Leite : Bebida
    {
        private const string nome = "Leite";
        private const double preco = 0.85;
        private const double quantCafe = 6;
        private const double quantAgua = 20;
        private const double quantLeite = 60;
        private const double quantAcucar = 6;

        public Leite()
            : base(nome, preco, quantCafe, quantAgua, quantLeite, quantAcucar) { }

        public override void prepararBebida()
        {
            Console.WriteLine($"☕ {nome} — {preco} €\r\nIngredientes: {quantCafe}g café | {quantAgua}ml água | {quantAcucar}g açúcar | {quantLeite}ml leite\r\n");
            Console.WriteLine("\n➡️ A preparar o seu Leite cremoso e suave...");
        }
    }
}
