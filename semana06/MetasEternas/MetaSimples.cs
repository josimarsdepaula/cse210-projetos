
public class MetaSimples : Meta
{
    private bool _estaCompletada;

    public MetaSimples(string nome, string descricao, int pontos)
        : base(nome, descricao, pontos)
    {
        _estaCompletada = false;
    }

    public override int RegistrarEvento()
    {
        if (!_estaCompletada)
        {
            _estaCompletada = true;
            return ObterPontos();
        }

        return 0;
    }

    public override bool EstaConcluida()
    {
        return _estaCompletada;
    }

    public override string ObterRepresentacaoEmTexto()
    {
        return $"MetaSimples:{ObterNome()}|{ObterDescricao()}|{ObterPontos()}|{_estaCompletada}";
    }

    public void DefinirConclusao(bool concluida)
    {
        _estaCompletada = concluida;
    }
}
