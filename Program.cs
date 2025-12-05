using System;

namespace Ficha8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 0, contaentre=0, contafora=0;

            Random rnd = new Random();

            for (int i = 1; i <= 10; i++)
            {
                num=rnd.Next(1, 40);
                Console.WriteLine(num);
                if(num>=10 && num <= 20)
                {
                    contaentre++;
                }
                else
                {
                    contafora++;
                }
            }

            Console.WriteLine("\nExistem " + contaentre + " entre 10 e 20 e " + contafora + " fora dos limites");

            Console.ReadKey();

        }
    }
}
