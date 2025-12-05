using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaquinaCafeAvaliacao
{
    internal class MaquinaCafe
    {
        private double dinheiro;
        private double cafe;
        private double agua;
        private double leite;
        private double acucar;

        public MaquinaCafe(double dinheiro, double cafe, double agua, double leite, double acucar)
        {
            this.dinheiro = dinheiro;
            this.cafe = cafe;
            this.agua = agua;
            this.leite = leite;
            this.acucar = acucar;
        }

        public string menuOpcoes ()
        {
            Expresso expresso = new Expresso();
            Leite leite = new Leite();
            Cappuccino cappuccino = new Cappuccino();

            Console.Clear();
            Console.WriteLine("☕==============================☕");
            Console.WriteLine("       MÁQUINA DE BEBIDAS");
            Console.WriteLine("☕==============================☕\n");

            Console.WriteLine($"1 - ☕ {expresso.Nome} — {expresso.Preco:F2}€");
            Console.WriteLine($"2 - ☕ {leite.Nome} — {leite.Preco:F2}€");
            Console.WriteLine($"3 - ☕ {cappuccino.Nome} — {cappuccino.Preco:F2}€");
            Console.WriteLine("4 - 📊 Estado Máquina");
            Console.Write("Insira nº ou nome da opção desejada: ");
            return Console.ReadLine();
        }

        public void escolherBebida(string op)
        {
            Bebida bebida = null;

            switch (op.ToLower())
            {
                case "1":
                case "expresso":
                    bebida = new Expresso();
                    if(verificarRecursos(bebida.Cafe, bebida.Agua, bebida.Leite, bebida.Acucar) == true)
                    {
                        Console.Clear();
                        if(processarPagamento(bebida.Preco) == true)
                        {
                            Console.Clear();
                            bebida.prepararBebida();
                            atualizarEstado(bebida.Cafe, bebida.Agua, bebida.Leite, bebida.Acucar);
                        }       
                    }   
                    break;
                case "2":
                case "leite":
                    bebida = new Leite();
                    if (verificarRecursos(bebida.Cafe, bebida.Agua, bebida.Leite, bebida.Acucar) == true)
                    {
                        Console.Clear();
                        if (processarPagamento(bebida.Preco) == true)
                        {
                            Console.Clear();
                            bebida.prepararBebida();
                            atualizarEstado(bebida.Cafe, bebida.Agua, bebida.Leite, bebida.Acucar);
                        }        
                    }
                    break;
                case "3":
                case "cappuccino":
                    bebida = new Cappuccino();
                    if (verificarRecursos(bebida.Cafe, bebida.Agua, bebida.Leite, bebida.Acucar) == true)
                    {
                        Console.Clear();
                        if (processarPagamento(bebida.Preco) == true)
                        {
                            Console.Clear();
                            bebida.prepararBebida();
                            atualizarEstado(bebida.Cafe, bebida.Agua, bebida.Leite, bebida.Acucar);
                        }    
                    }
                    break;
                default:
                    Console.WriteLine("\n⚠️ Opção inválida. Tente novamente.");
                    break;
            }
        }
        
        public bool verificarRecursos(double quantCafe, double quantAgua, double quantLeite, double quantAcucar)
        {
            bool temIngredientes = true;

            if (cafe < quantCafe)
            {
                Console.WriteLine("\n⚠️  Quantidade de café insuficiente para satisfazer o pedido.");
                Console.WriteLine($"☕ Café disponível: {cafe}g | Necessário: {quantCafe}g | Falta: {quantCafe - cafe}g");
                temIngredientes = false;
            }

            if (agua < quantAgua)
            {
                Console.WriteLine("\n⚠️  Quantidade de água insuficiente para satisfazer o pedido.");
                Console.WriteLine($"💧 Água disponível: {agua}ml | Necessário: {quantAgua}ml | Falta: {quantAgua - agua}ml");
                temIngredientes = false;
            }

            if (leite < quantLeite)
            {
                Console.WriteLine("\n⚠️  Quantidade de leite insuficiente para satisfazer o pedido.");
                Console.WriteLine($"🥛 Leite disponível: {leite}ml | Necessário: {quantLeite}ml | Falta: {quantLeite - leite}ml");
                temIngredientes = false;
            }

            if (acucar < quantAcucar)
            {
                Console.WriteLine("\n⚠️  Quantidade de açúcar insuficiente para satisfazer o pedido.");
                Console.WriteLine($"🍬 Açúcar disponível: {acucar}g | Necessário: {quantAcucar}g | Falta: {quantAcucar - acucar}g");
                temIngredientes = false;
            }

            return temIngredientes;
        }

        public bool processarPagamento(double precoBebida)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Menu Pagamento");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1 - Inserir 0.10€");
            Console.WriteLine("2 - Inserir 0.20€");
            Console.WriteLine("3 - Inserir 0.50€");
            Console.WriteLine("4 - Inserir 1€");
            Console.WriteLine("5 - Inserir 2€");
            Console.WriteLine("0 - Terminar");

            double totalInserido = 0;
            char op = '\0';

            do
            {
                Console.Write("Insira a opção: ");
                char.TryParse(Console.ReadLine(), out op);

                if (op != '0')
                {
                    switch (op)
                    {
                        case '1':
                            totalInserido += 0.10;
                            Console.WriteLine("Total inserido: " + totalInserido.ToString("F2") + "€");
                            break;
                        case '2':
                            totalInserido += 0.20;
                            Console.WriteLine("Total inserido: " + totalInserido.ToString("F2") + "€");
                            break;
                        case '3':
                            totalInserido += 0.50;
                            Console.WriteLine("Total inserido: " + totalInserido.ToString("F2") + "€");
                            break;
                        case '4':
                            totalInserido += 1;
                            Console.WriteLine("Total inserido: " + totalInserido.ToString("F2") + "€");
                            break;
                        case '5':
                            totalInserido += 2;
                            Console.WriteLine("Total inserido: " + totalInserido.ToString("F2") + "€");
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Opção Inválida...Tente novamente (0-5)");
                            Console.ForegroundColor = ConsoleColor.White;
                            continue;
                    }

                }

            } while (op != '0');

            Console.WriteLine();

            if (totalInserido < precoBebida)
            {
                Console.WriteLine("\n⚠️  Montante inserido insuficiente para efetuar a compra.");
                Console.WriteLine($"💶 Valor inserido: {totalInserido:F2} € | Preço da bebida: {precoBebida:F2} €");
                Console.WriteLine("Transação cancelada.");
                return false;
            }

            if (totalInserido > precoBebida) {
                Console.WriteLine($"Aqui está o seu troco: {totalInserido - precoBebida:F2}€");
            }

            dinheiro += precoBebida;
            return true;
        }

        public void atualizarEstado(double quantCafe, double quantAgua, double quantLeite, double quantAcucar)
        {
            cafe -= quantCafe;
            agua -= quantAgua;
            leite -= quantLeite;
            acucar -= quantAcucar;
        }

        public void mostrarEstado()
        {
            Console.WriteLine("\n===============================");
            Console.WriteLine("📊 ESTADO ATUAL DA MÁQUINA");
            Console.WriteLine("===============================\n");

            Console.WriteLine($"☕ Café:   {cafe} g");
            Console.WriteLine($"💧 Água:   {agua} ml");
            Console.WriteLine($"🥛 Leite:  {leite} ml");
            Console.WriteLine($"🍬 Açúcar: {acucar} g");
            Console.WriteLine($"💰 Dinheiro: {dinheiro:F2} €");

            Console.WriteLine("\n===============================");
        }
    }
}
