using System;
using System.Collections.Generic;

public class Escritura
{
    private Referencia _referencia;
    private List<Palavra> _palavras;

    public Escritura(Referencia referencia, string texto)
    {
        _referencia = referencia;
        _palavras = new List<Palavra>();

        string[] palavras = texto.Split(' ');

        foreach (string palavra in palavras)
        {
            _palavras.Add(new Palavra(palavra));
        }
    }

    public void OcultarPalavrasAleatorias(int quantidade)
    {
        Random random = new Random();

        List<Palavra> palavrasVisiveis = _palavras.FindAll(
            palavra => !palavra.EstaOculta()
        );

        for (int i = 0; i < quantidade && palavrasVisiveis.Count > 0; i++)
        {
            int indice = random.Next(palavrasVisiveis.Count);

            Palavra palavra = palavrasVisiveis[indice];
            palavra.Ocultar();

            palavrasVisiveis.RemoveAt(indice);
        }
    }

    public string ObterTextoExibicao()
    {
        string texto = _referencia.ObterTextoExibicao() + "\n";

        foreach (Palavra palavra in _palavras)
        {
            texto += palavra.ObterTexto() + " ";
        }

        return texto;
    }

    public bool EstaCompletamenteOculta()
    {
        foreach (Palavra palavra in _palavras)
        {
            if (!palavra.EstaOculta())
            {
                return false;
            }
        }

        return true;
    }
}