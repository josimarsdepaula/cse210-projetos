using System;
using System.Collections.Generic;
using System.IO;

public class Diario
{
    private List<Entrada> _entradas = new List<Entrada>();

    public void AdicionarEntrada(Entrada entrada)
    {
        _entradas.Add(entrada);
    }

    public void ExibirEntradas()
    {
        foreach (Entrada entrada in _entradas)
        {
            entrada.Exibir();
        }
    }

    public void SalvarArquivo(string nomeArquivo)
    {
        using (StreamWriter arquivo = new StreamWriter(nomeArquivo))
        {
            foreach (Entrada entrada in _entradas)
            {
                arquivo.WriteLine($"{entrada.Data}|{entrada.Pergunta}|{entrada.Resposta}");
            }
        }

        Console.WriteLine("Diário salvo com sucesso!");
    }

    public void CarregarArquivo(string nomeArquivo)
    {
        _entradas.Clear();

        string[] linhas = File.ReadAllLines(nomeArquivo);

        foreach (string linha in linhas)
        {
            string[] partes = linha.Split('|');

            Entrada entrada = new Entrada();
            entrada.Data = partes[0];
            entrada.Pergunta = partes[1];
            entrada.Resposta = partes[2];

            _entradas.Add(entrada);
        }

        Console.WriteLine("Diário carregado com sucesso!");
    }
}