using System.Collections.Generic;

public class AtividadeDeReflexao : Atividade
{
    private List<string> _reflexoes;
    private List<string> _perguntas;

    public AtividadeDeReflexao()
    {
        _reflexoes = new List<string>();
        _perguntas = new List<string>();
    }

    public void Executar()
    {
    }

    public string ObterReflexoesAleatorias()
    {
        return "";
    }

    public string ObterPerguntasAleatorias()
    {
        return "";
    }

    public void ExibirReflexoes()
    {
    }

    public void ExibirPerguntas()
    {
    }
}