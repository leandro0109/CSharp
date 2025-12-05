using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MaquinaCafeAvaliacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Random rnd = new Random();
            MaquinaCafe maquinaCafe = new MaquinaCafe(rnd.Next(1, 5), rnd.Next(10, 100), rnd.Next(20, 150), rnd.Next(20, 150), rnd.Next(5, 50));

            string op;
            
            while(true) {
                op = maquinaCafe.menuOpcoes();

                if (op.ToLower() == "off")
                    break;

                if(op == "4" || op.ToLower() == "estado")
                {
                    Console.Clear();
                    maquinaCafe.mostrarEstado();
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("Clique em uma tecla para avançar ");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadKey();
                }
                else
                {
                    maquinaCafe.escolherBebida(op);
                    maquinaCafe.mostrarEstado();
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Aguarde 10 segundos para efetuar novo pedido");
                    Console.ForegroundColor = ConsoleColor.White;
                    Thread.Sleep(10000);
                }
            };

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Máquina desligada");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
