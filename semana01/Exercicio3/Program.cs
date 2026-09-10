using System;

class Program
{
    static void Main(string[] args)
    {
        string jogarNovamente = "sim";

        while (jogarNovamente == "sim")
        {
            Random random = new Random();
            int numeroMagico = random.Next(1, 101);
            int palpite = 0;
            int quantidadePalpites = 0;

            while (palpite != numeroMagico)
            {
                Console.Write("Qual é o seu palpite? ");
                palpite = int.Parse(Console.ReadLine());
                quantidadePalpites++;

                if (palpite > numeroMagico)
                {
                    Console.WriteLine("Mais baixo");
                }
                else if (palpite < numeroMagico)
                {
                    Console.WriteLine("Mais alto");
                }
                else
                {
                    Console.WriteLine("Você adivinhou!");
                }
            }

            Console.WriteLine($"Você precisou de {quantidadePalpites} palpites.");

            Console.Write("Você deseja jogar novamente? ");
            jogarNovamente = Console.ReadLine().ToLower();
        }

        Console.WriteLine("Obrigado por jogar!");
    }
}