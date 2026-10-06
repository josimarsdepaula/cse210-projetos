using System;

// EXCEDE OS REQUISITOS:
// Na atividade de reflexão, o programa evita repetir perguntas
// até que todas as perguntas disponíveis tenham sido exibidas.
// Depois que todas são utilizadas, a lista é reiniciada.

class Program
{
    static void Main(string[] args)
    {
        string opcao = "";

        while (opcao != "4")
        {
            Console.Clear();

            Console.WriteLine("Menu de Opções:");
            Console.WriteLine("  1. Iniciar atividade de respiração");
            Console.WriteLine("  2. Iniciar atividade de reflexão");
            Console.WriteLine("  3. Iniciar atividade de listagem");
            Console.WriteLine("  4. Sair");

            Console.Write("Selecione uma opção do menu: ");
            opcao = Console.ReadLine();

            if (opcao == "1")
            {
                AtividadeDeRespiracao atividade = new AtividadeDeRespiracao();
                atividade.Executar();
            }
            else if (opcao == "2")
            {
                AtividadeDeReflexao atividade = new AtividadeDeReflexao();
                atividade.Executar();
            }
            else if (opcao == "3")
            {
                AtividadeDeListagem atividade = new AtividadeDeListagem();
                atividade.Executar();
            }
            else if (opcao == "4")
            {
                Console.WriteLine("Até logo!");
            }
            else
            {
                Console.WriteLine("Opção inválida.");
                Thread.Sleep(1500);
            }
        }
    }
}