using System;

namespace Questão1
{
    class Program
    {
        static void Main(string[] args)
        {
            double numero1, numero2;
            Console.WriteLine("Informe o primeiro número: ");
            numero1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe o segundo número: ");
            numero2 = double.Parse(Console.ReadLine());
            if (numero1 > numero2)
            {
                Console.WriteLine("O primeiro número é maior.");
            }else
                Console.WriteLine("O segundo número é maior.");
        }
    }
}
