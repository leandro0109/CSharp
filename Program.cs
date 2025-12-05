using System;
using System.Text;
using System.Threading;

namespace MaquinaCafe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Random rand = new Random();
            MaquinaCafe maquina1 = new MaquinaCafe(rand.Next(250,1500), rand.Next(50, 500), rand.Next(300, 1500), rand.Next(25, 250), 0);
            string op;

            do
            {
                op = maquina1.menuOpcoes();
                switch (op.ToLower())
                {
                    case "1":
                    case "expresso":
                        if (maquina1.fazerExpresso() == true)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Um expresso a sair quentinho...");
                            Console.WriteLine("Aqui está a sua bebida. Desfrute!");
                            Console.ForegroundColor = ConsoleColor.White;
                            maquina1.estadoMaquina();
                        }
                        Console.WriteLine();
                        break;
                    case "2":
                    case "leite":
                        if (maquina1.fazerLeite() == true)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Um leitinho a sair quentinho...");
                            Console.WriteLine("Aqui está a sua bebida. Desfrute!");
                            Console.ForegroundColor = ConsoleColor.White;
                            maquina1.estadoMaquina();
                        }
                        Console.WriteLine();
                        break;
                    case "3":
                    case "cappuccino":
                        if (maquina1.fazerCappuccino() == true)
                        {
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.WriteLine("Um cappuccino a sair quentinho...");
                            Console.WriteLine("Aqui está a sua bebida. Desfrute!");
                            Console.ForegroundColor = ConsoleColor.White;
                            maquina1.estadoMaquina();
                        }
                        Console.WriteLine();
                        break;
                    case "estado":
                        maquina1.estadoMaquina();
                        Console.WriteLine("Prima tecla para continuar...");
                        Console.ReadKey();
                        break;
                    case "off":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Máquina a ser desligada...");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Opção inválida...Tente novamente");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Aguarde 10 segundos antes de efetuar novo pedido");
                Console.ForegroundColor = ConsoleColor.White;
                Thread.Sleep(10000);
                Console.Clear();

            } while (op.ToLower() != "off");

        }
    }
}
