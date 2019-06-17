using System;

namespace uri1114
{
    class Program
    {
        static void Main(string[] args)
        {
            int senha;
            string nome;

            Console.WriteLine("DIGITE SEU NOME");
            nome = Console.ReadLine();

            Console.WriteLine("DIGITE SUA SENHA");
            senha = int.Parse(Console.ReadLine());

            while (senha != 2002)
            {
                Console.WriteLine("Olá," + nome + " SENHA INVALIDA TENTE NOVAMENTE");
                senha = int.Parse(Console.ReadLine());

            }

            Console.WriteLine("OLÁ " + nome + " SENHA CORRETA");
            Console.ReadLine();

        }
    }
}
