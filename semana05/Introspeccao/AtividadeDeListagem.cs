using System.Collections.Generic;

public class AtividadeDeListagem : Atividade
{
    private int _contador;
    private List<string> _perguntas;

    public AtividadeDeListagem()
    {
        _contador = 0;
        _perguntas = new List<string>();
    }

    public void Executar()
    {
    }

    public void ObterPerguntaAleatoria()
    {
    }

    public List<string> ObterListaDoUsuario()
    {
        return new List<string>();
    }
}