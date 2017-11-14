using System;
namespace Questão5
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int mod = 0;
            Console.WriteLine("Informe um número: ");
            numero = int.Parse(Console.ReadLine());
            mod = numero % 5;
            if (mod == 0)
            {
                Console.WriteLine("O número é múltiplo de 5.");
            }
            else
                Console.WriteLine("O número não é múltiplo de 5"); 
        }
    }
}
