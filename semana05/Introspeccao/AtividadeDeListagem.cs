using System;
using System.Collections.Generic;

public class AtividadeDeListagem : Atividade
{
    private int _contador;
    private List<string> _perguntas;

    public AtividadeDeListagem()
        : base(
            "Atividade de Listagem",
            "Esta atividade ajudará você a refletir sobre as coisas boas da sua vida, fazendo com que você liste o máximo de coisas que puder em uma determinada área."
        )
    {
        _contador = 0;

        _perguntas = new List<string>
        {
            "Quem são as pessoas que você aprecia?",
            "Quais são seus pontos fortes pessoais?",
            "Quem são as pessoas que você ajudou esta semana?",
            "Quando você sentiu o Espírito Santo neste mês?",
            "Quem são alguns dos seus heróis pessoais?"
        };
    }

    public void Executar()
    {
        ExibirMensagemInicial();

        Console.WriteLine();
        Console.WriteLine("Liste o máximo de respostas que puder para a seguinte pergunta:");
        Console.WriteLine();

        ObterPerguntaAleatoria();

        Console.WriteLine();
        Console.Write("Você pode começar em: ");
        ExibirContagemRegressiva(5);

        Console.WriteLine();
        Console.WriteLine();

        ObterListaDoUsuario();

        Console.WriteLine();
        Console.WriteLine($"Você listou {_contador} itens.");

        ExibirMensagemFinal();
    }

    public void ObterPerguntaAleatoria()
    {
        Random random = new Random();
        int indice = random.Next(_perguntas.Count);

        Console.WriteLine($"--- {_perguntas[indice]} ---");
    }

    public List<string> ObterListaDoUsuario()
    {
        List<string> respostas = new List<string>();

        DateTime fim = DateTime.Now.AddSeconds(ObterDuracao());

        while (DateTime.Now < fim)
        {
            Console.Write("> ");
            string resposta = Console.ReadLine();

            respostas.Add(resposta);
            _contador++;
        }

        return respostas;
    }
}