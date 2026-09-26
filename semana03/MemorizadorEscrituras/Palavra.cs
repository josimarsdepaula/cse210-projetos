using System;

public class Palavra
{
    private string _texto;
    private bool _estaOculta;

    public Palavra(string texto)
    {
        _texto = texto;
        _estaOculta = false;
    }

    public void Ocultar()
    {
        _estaOculta = true;
    }

    public void Exibir()
    {
        Console.Write(ObterTexto());
    }

    public bool EstaOculta()
    {
        return _estaOculta;
    }

    public string ObterTexto()
    {
        if (_estaOculta)
        {
            return new string('_', _texto.Length);
        }

        return _texto;
    }
}