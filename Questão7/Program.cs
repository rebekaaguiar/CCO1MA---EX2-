using System;

namespace Questão7
{
    class Program
    {
        static void Main(string[] args)
        {
            int dia, mes, ano;
            Console.WriteLine("Informe o dia: ");
            dia = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o mês: ");
            mes = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o ano: ");
            ano = int.Parse(Console.ReadLine());
            if (dia <= 31 && mes <= 12 && ano >= 1)
            {
                Console.WriteLine("Data válida.");
            }else
                Console.WriteLine("Data inválida.");
        }
    }
}
