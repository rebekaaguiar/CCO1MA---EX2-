using System;

namespace Questão2
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            Console.WriteLine("Informe um número: ");
            numero = int.Parse(Console.ReadLine());
            if (numero < 0) 
            {
	            Console.WriteLine("O número informado é negativo.");
            }else
	            Console.WriteLine("O número informado é positivo.");
        }
    }
}
