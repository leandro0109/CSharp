using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metodos
{
    public class teste
    {

        public static double div(int num1, int num2)//com retorno, com parâmetros
        {
            double res = 0;
            res = (double)num1 / num2;
            return res;
        }


        public static void soma(int num2)//sem retorno, com parÂmetros
        {
            int soma = 0;
            soma = multi() + num2;
            Console.WriteLine("A soma é " + soma);
        }

        static void cinel()//sem retorno, sem parÂmetros
        {
            Console.WriteLine("O CINEL é fixe");
        }


        public static void soma(int num1, int num2, int num3)
        {
            int soma = num1 + num2 + num3;
            Console.WriteLine("A soma é " + soma);
        }

        public static void soma(int num1, int num2, int num3, String nome)
        {
            int soma = num1 + num2 + num3;
            Console.WriteLine("A soma é " + soma + " e o nome é " + nome);
        }

        public static int multi()//com retorno, sem parâmtros
        {
            int x = 0, y = 0, res = 0;
            Console.WriteLine("Introduza o valor de x");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Introduza o valor de y");
            y = int.Parse(Console.ReadLine());

            res = x * y;

            return res;
        }
    }
}
