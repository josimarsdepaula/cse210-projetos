
public class MetaDeListaDeTarefas : Meta
{
    private int _quantidadeRealizada;
    private int _quantidadeNecessaria;
    private int _bonus;

    public MetaDeListaDeTarefas(
        string nome,
        string descricao,
        int pontos,
        int quantidadeNecessaria,
        int bonus)
        : base(nome, descricao, pontos)
    {
        _quantidadeRealizada = 0;
        _quantidadeNecessaria = quantidadeNecessaria;
        _bonus = bonus;
    }

    public override int RegistrarEvento()
    {
        if (EstaConcluida())
        {
            return 0;
        }

        _quantidadeRealizada++;

        int pontosGanhos = ObterPontos();

        if (EstaConcluida())
        {
            pontosGanhos += _bonus;
        }

        return pontosGanhos;
    }

    public override bool EstaConcluida()
    {
        return _quantidadeRealizada >= _quantidadeNecessaria;
    }

    public override string ObterDetalhesTexto()
    {
        return $"{base.ObterDetalhesTexto()} -- Concluída {_quantidadeRealizada}/{_quantidadeNecessaria} vezes";
    }

    public override string ObterRepresentacaoEmTexto()
    {
        return $"MetaDeListaDeTarefas:{ObterNome()}|{ObterDescricao()}|{ObterPontos()}|{_quantidadeRealizada}|{_quantidadeNecessaria}|{_bonus}";
    }

    public void DefinirQuantidadeRealizada(int quantidade)
    {
        _quantidadeRealizada = quantidade;
    }
}
