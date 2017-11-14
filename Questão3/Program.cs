using System;

namespace Questão3
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int mod = 0;
            Console.WriteLine("Informe um número: ");
            numero = int.Parse(Console.ReadLine());
            mod = numero % 2;
            if (mod == 0)
            {
                Console.WriteLine("O número informado é par.");
            }else
                Console.WriteLine("O número informado não é par.");   
        }
    }
}
