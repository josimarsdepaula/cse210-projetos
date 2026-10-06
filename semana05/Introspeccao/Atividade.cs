using System;

public class Atividade
{
    private string _nome;
    private string _descricao;
    private int _duracao;

    public Atividade(string nome, string descricao)
    {
        _nome = nome;
        _descricao = descricao;
        _duracao = 0;
    }

    public void ExibirMensagemInicial()
    {
        Console.Clear();
        Console.WriteLine($"Bem-vindo à {_nome}.");
        Console.WriteLine();
        Console.WriteLine(_descricao);
        Console.WriteLine();

        Console.Write("Quanto tempo, em segundos, você gostaria para sua sessão? ");
        _duracao = int.Parse(Console.ReadLine());

        Console.WriteLine();
        Console.WriteLine("Prepare-se para começar...");
        ExibirProgresso(3);
    }

    public void ExibirMensagemFinal()
    {
        Console.WriteLine();
        Console.WriteLine("Muito bem!");
        ExibirProgresso(2);

        Console.WriteLine();
        Console.WriteLine($"Você completou {_duracao} segundos da {_nome}.");
        ExibirProgresso(3);
    }

    public void ExibirProgresso(int segundos)
    {
        string[] animacao = { "|", "/", "-", "\\" };

        DateTime fim = DateTime.Now.AddSeconds(segundos);
        int i = 0;

        while (DateTime.Now < fim)
        {
            Console.Write(animacao[i]);
            Thread.Sleep(250);
            Console.Write("\b \b");

            i++;

            if (i >= animacao.Length)
            {
                i = 0;
            }
        }
    }

    public void ExibirContagemRegressiva(int segundos)
    {
        for (int i = segundos; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public int ObterDuracao()
    {
        return _duracao;
    }
}