using System;

namespace Questão8
{
    class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, media;
            Console.WriteLine("Informe a primeira nota: ");
            nota1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Informe a segunda nota: ");
            nota2 = double.Parse(Console.ReadLine());
            media = (nota1+nota2)/2;
            Console.WriteLine("A sua média é: {0}", media);
            if (media >= 7)
            {
                Console.WriteLine("Aprovado!");
            }else
                Console.WriteLine("Reprovado!");
            if (media == 10)
            {
                Console.WriteLine("Aprovado com Distinção!");
            }
        }
    }
}
