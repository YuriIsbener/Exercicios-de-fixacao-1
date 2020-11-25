using System;

namespace Exercicios_de_fixação
{
    class Program
    {
        static void Main(string[] args)
        {

            int idade;

            Console.WriteLine("Em que ano estamos?");
            int anoAtual = int.Parse(Console.ReadLine());

            Console.WriteLine("Em que ano você nasceu?");
            int anoNascimento = int.Parse(Console.ReadLine());

            idade = anoAtual - anoNascimento;

            if (idade < 16)
            {
                Console.WriteLine("Você não atende os requerimentos para votar");
            }
            else
            {
                Console.WriteLine("Você atende os requerimentos para votar");
            }


        }
    }
}
