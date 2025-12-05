using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Conta conta1 = new ContaPrazo("Leandro", 123, 4565.43, 0.2, new DateTime(2026, 1, 1));
            Conta conta2 = new ContaPrazo("David", 345, 4567.4, 0.1, new DateTime(2025,1,1));
            Conta conta3 = new ContaOrdem("Carlos", 963, 100, 150);

            //conta1.imprimirDados();
            //Console.WriteLine();
            //conta1.depositar(123.312, 12);
            //Console.WriteLine();
            //conta1.imprimirDados();
            //Console.WriteLine();
            //conta1.levantar(1000);
            //conta1.imprimirDados();
            //Console.WriteLine();
            //conta1.transferir(conta1, conta2, 350);

            conta1.imprimirDados();
            conta2.imprimirDados();
            conta3.imprimirDados();
            Console.WriteLine();
            conta3.levantar(1000);
            conta3.levantar(200);
            conta3.imprimirDados();

            Console.ReadLine();
        }
    }
}
