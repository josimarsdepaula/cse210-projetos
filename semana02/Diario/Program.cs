using System;

class Program
{
    static void Main(string[] args)
    {
        Diario diario = new Diario();

        string[] perguntas =
        {
            "Qual foi a melhor parte do meu dia?",
            "Quem foi a pessoa mais interessante com quem interagi hoje?",
            "Qual foi a emoção mais forte que senti hoje?",
            "O que eu aprendi hoje?",
            "Pelo que sou grato hoje?"
        };

        Random random = new Random();

        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("\nDiário");
            Console.WriteLine("1. Escrever novo registro");
            Console.WriteLine("2. Exibir diário");
            Console.WriteLine("3. Salvar diário");
            Console.WriteLine("4. Carregar diário");
            Console.WriteLine("5. Sair");
            Console.Write("Escolha uma opção: ");

            string opcao = Console.ReadLine();

            if (opcao == "1")
            {
                string pergunta = perguntas[random.Next(perguntas.Length)];

                Console.WriteLine($"\n{pergunta}");
                Console.Write("> ");
                string resposta = Console.ReadLine();

                Entrada entrada = new Entrada();
                entrada.Data = DateTime.Now.ToShortDateString();
                entrada.Pergunta = pergunta;
                entrada.Resposta = resposta;

                diario.AdicionarEntrada(entrada);

                Console.WriteLine("Registro salvo no diário!");
            }
            else if (opcao == "2")
            {
                diario.ExibirEntradas();
            }
            else if (opcao == "3")
            {
                Console.Write("Digite o nome do arquivo: ");
                string nomeArquivo = Console.ReadLine();

                diario.SalvarArquivo(nomeArquivo);
            }
            else if (opcao == "4")
            {
                Console.Write("Digite o nome do arquivo: ");
                string nomeArquivo = Console.ReadLine();

                diario.CarregarArquivo(nomeArquivo);
            }
            else if (opcao == "5")
            {
                continuar = false;
                Console.WriteLine("Até mais!");
            }
            else
            {
                Console.WriteLine("Opção inválida.");
            }
        }
    }
}