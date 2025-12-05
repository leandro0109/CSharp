using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MaquinaCafe
{
    internal class MaquinaCafe
    {
        private double agua;
        private double cafe;
        private double leite;
        private double acucar;
        private double dinheiro;
        private const double precoExpresso = 0.80;
        private const double precoLeite = 1.20;
        private const double precoCappuccino = 1.50;

        public MaquinaCafe(double agua, double cafe, double leite, double acucar, double dinheiro) {
            this.agua = agua;
            this.cafe = cafe;
            this.leite = leite;
            this.acucar = acucar;
            this.dinheiro = dinheiro;
        }

        public string menuOpcoes()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Bem vindo à máquina de café da esquina");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("1 - Expresso " + precoExpresso.ToString("F2") + "€");
            Console.WriteLine("2 - Leite " + precoLeite.ToString("F2") + "€");
            Console.WriteLine("3 - Cappuccino " + precoCappuccino.ToString("F2") + "€");
            Console.Write("Insira o nº ou nome da opção desejada: ");
            string op = Console.ReadLine();
            Console.WriteLine();
            return op;
        }

        public bool verificarIngredientes(double quantAgua, double quantCafe, double quantLeite, double quantAcucar)
        {
            bool possuiIngredientes = true;

            Console.ForegroundColor= ConsoleColor.DarkRed;
            if (agua < quantAgua)
            {
                Console.WriteLine("Água insuficiente");
                Console.WriteLine(agua + "ml diponivel necessita de mais " + (quantAgua - agua) + "ml");
                possuiIngredientes = false;
            }

            if (cafe < quantCafe)
            {
                Console.WriteLine("Café insuficiente");
                Console.WriteLine(cafe + "g diponivel necessita de mais " + (quantCafe - cafe) + "g");
                possuiIngredientes = false;
            }

            if (acucar < quantAcucar)
            {
                Console.WriteLine("Açúcar insuficiente");
                Console.WriteLine(acucar + "g diponivel necessita de mais " + (quantAcucar - acucar) + "g");
                possuiIngredientes = false;
            }

            if (leite < quantLeite)
            {
                Console.WriteLine("Leite insuficiente");
                Console.WriteLine(leite + "ml diponivel necessita de mais " + (quantLeite - leite) + "ml");
                possuiIngredientes = false;
            }
            Console.ForegroundColor = ConsoleColor.White;

            return possuiIngredientes;
        }

        public double inserirDinheiro()
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
            return totalInserido;
        }

        public bool fazerExpresso()
        {
            double montanteInserido = inserirDinheiro();
            if (verificarIngredientes(30, 10, 0, 10) == true && montanteInserido >= precoExpresso)
            {
                agua -= 30;
                cafe -= 10;
                acucar -= 10;
                dinheiro += montanteInserido;
                if (montanteInserido - precoExpresso > 0)
                {
                    double troco = montanteInserido - precoExpresso;
                    dinheiro -= troco;
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Aqui tem o seu troco: " + troco.ToString("F2") + "€");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                return true;
            }
            else if (montanteInserido < precoExpresso)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Montante inserido insuficiente! Transação cancelada.");
                Console.ForegroundColor = ConsoleColor.White;
                return false;
            }

            return false;
        }

        public bool fazerLeite()
        {
            double montanteInserido = inserirDinheiro();
            if (verificarIngredientes(30, 10, 150, 10) == true && montanteInserido >= precoLeite)
            {
                agua -= 30;
                cafe -= 10;
                acucar -= 10;
                leite -= 150;
                dinheiro += montanteInserido;
                if (montanteInserido - precoLeite > 0)
                {
                    double troco = montanteInserido - precoLeite;
                    dinheiro -= troco;
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine("Aqui tem o seu troco: " + troco.ToString("F2") + "€");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                return true;
            }
            else if (montanteInserido < precoLeite)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Montante inserido insuficiente! Transação cancelada.");
                Console.ForegroundColor = ConsoleColor.White;
                return false;
            }

            return false;
        }

        public bool fazerCappuccino()
        {
            double montanteInserido = inserirDinheiro();
            if (verificarIngredientes(30, 15, 80, 10) == true && montanteInserido >= precoCappuccino)
            {
                agua -= 30;
                cafe -= 15;
                acucar -= 10;
                leite -= 80;
                dinheiro += montanteInserido;
                if (montanteInserido - precoCappuccino > 0)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    double troco = montanteInserido - precoCappuccino;
                    dinheiro -= troco;
                    Console.WriteLine("Aqui tem o seu troco: " + troco.ToString("F2") + "€");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                return true;
            }
            else if (montanteInserido < precoCappuccino)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Montante inserido insuficiente! Transação cancelada.");
                Console.ForegroundColor = ConsoleColor.White;
                return false;
            }

            return false;
        }

        public void estadoMaquina()
        {
            Console.WriteLine();
            Console.ForegroundColor =  ConsoleColor.DarkYellow;
            Console.WriteLine("Estado da máquina");
            Console.WriteLine("Água: " + agua + " ml" + "\nCafé: " + cafe + " g" + "\nLeite: " + leite + " ml" + "\nAçúcar: " + acucar + " g" + "\nDinheiro: " + dinheiro.ToString("F2") + "€");
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}
