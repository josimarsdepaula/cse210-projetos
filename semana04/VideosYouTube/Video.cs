using System.Collections.Generic;

public class Video
{
    private string _titulo;
    private string _autor;
    private int _duracao;
    private List<Comentario> _comentarios;

    public Video(string titulo, string autor, int duracao)
    {
        _titulo = titulo;
        _autor = autor;
        _duracao = duracao;
        _comentarios = new List<Comentario>();
    }

    public void AdicionarComentario(Comentario comentario)
    {
        _comentarios.Add(comentario);
    }

    public int ObterQuantidadeComentarios()
    {
        return _comentarios.Count;
    }

    public string ObterTitulo()
    {
        return _titulo;
    }

    public string ObterAutor()
    {
        return _autor;
    }

    public int ObterDuracao()
    {
        return _duracao;
    }

    public List<Comentario> ObterComentarios()
    {
        return _comentarios;
    }
}