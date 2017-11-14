using System;

namespace Questão6
{
    class Program
    {
        static void Main(string[] args)
        {
            char letra;
            Console.WriteLine("Informe uma letra: ");
            letra = char.Parse(Console.ReadLine());
            if (letra == 'a' || letra == 'e' || letra == 'i' || letra == 'o' || letra == 'u')
            {
                Console.WriteLine("A letra é uma vogal.");
            }else
                Console.WriteLine("A letra é uma consoante.");
        }
    }
}
