using System;

namespace Questão4
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int mod = 1;
            Console.WriteLine("Informe um número: ");
            numero = int.Parse(Console.ReadLine());
            mod = numero % 2;
            if (mod == 1)
            {
                Console.WriteLine("O número informado é ímpar.");
            }
            else
                Console.WriteLine("O número informado não é ímpar."); 
        }
    }
}
