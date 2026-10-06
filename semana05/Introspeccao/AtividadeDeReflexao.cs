using System;
using System.Collections.Generic;

public class AtividadeDeReflexao : Atividade
{
    private List<string> _reflexoes;
    private List<string> _perguntas;
    private List<string> _perguntasDisponiveis;

    public AtividadeDeReflexao()
        : base(
            "Atividade de Reflexão",
            "Esta atividade ajudará você a refletir sobre momentos da sua vida em que você demonstrou força e resiliência. Isso ajudará você a reconhecer o poder que você tem e como pode usá-lo em outros aspectos da sua vida."
        )
    {
        _reflexoes = new List<string>
        {
            "Pense em uma ocasião em que você defendeu outra pessoa.",
            "Pense em uma ocasião em que você fez algo realmente difícil.",
            "Pense em uma ocasião em que você ajudou alguém necessitado.",
            "Pense em uma ocasião em que você fez algo verdadeiramente altruísta."
        };

        _perguntas = new List<string>
        {
            "Por que essa experiência foi significativa para você?",
            "Você já fez algo assim antes?",
            "Como você começou?",
            "Como você se sentiu quando terminou?",
            "O que tornou esse momento diferente de outras vezes em que você não teve tanto sucesso?",
            "Qual é a sua coisa favorita sobre essa experiência?",
            "O que você pode aprender com essa experiência que se aplica a outras situações?",
            "O que você aprendeu sobre si mesmo por meio dessa experiência?",
            "Como você pode manter essa experiência em mente no futuro?"
        };

        _perguntasDisponiveis = new List<string>(_perguntas);
    }

    public void Executar()
    {
        ExibirMensagemInicial();

        Console.WriteLine();
        Console.WriteLine("Considere a seguinte reflexão:");
        Console.WriteLine();
        Console.WriteLine($"--- {ObterReflexoesAleatorias()} ---");

        Console.WriteLine();
        Console.WriteLine("Quando tiver algo em mente, pressione Enter para continuar.");
        Console.ReadLine();

        Console.WriteLine("Agora reflita sobre cada uma das perguntas a seguir.");
        Console.WriteLine();

        ExibirPerguntas();

        ExibirMensagemFinal();
    }

    public string ObterReflexoesAleatorias()
    {
        Random random = new Random();
        int indice = random.Next(_reflexoes.Count);

        return _reflexoes[indice];
    }

    public string ObterPerguntasAleatorias()
    {
        if (_perguntasDisponiveis.Count == 0)
        {
            _perguntasDisponiveis = new List<string>(_perguntas);
        }

        Random random = new Random();
        int indice = random.Next(_perguntasDisponiveis.Count);

        string pergunta = _perguntasDisponiveis[indice];

        _perguntasDisponiveis.RemoveAt(indice);

        return pergunta;
    }

    public void ExibirReflexoes()
    {
        Console.WriteLine(ObterReflexoesAleatorias());
    }

    public void ExibirPerguntas()
    {
        DateTime fim = DateTime.Now.AddSeconds(ObterDuracao());

        while (DateTime.Now < fim)
        {
            Console.Write($"> {ObterPerguntasAleatorias()} ");
            ExibirProgresso(5);
            Console.WriteLine();
        }
    }
}