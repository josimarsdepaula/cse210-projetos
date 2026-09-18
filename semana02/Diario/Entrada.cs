using System;

public class Entrada
{
    public string Data { get; set; }
    public string Pergunta { get; set; }
    public string Resposta { get; set; }

    public void Exibir()
    {
        Console.WriteLine($"Data: {Data}");
        Console.WriteLine($"Pergunta: {Pergunta}");
        Console.WriteLine($"Resposta: {Resposta}");
        Console.WriteLine("----------------------------");
    }
}