using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Digite a nota do aluno: ");
        int nota = int.Parse(Console.ReadLine());

        string letra;

        if (nota >= 90)
        {
            letra = "A";
        }
        else if (nota >= 80)
        {
            letra = "B";
        }
        else if (nota >= 70)
        {
            letra = "C";
        }
        else if (nota >= 60)
        {
            letra = "D";
        }
        else
        {
            letra = "F";
        }

        string sinal = "";
        int ultimoDigito = nota % 10;

        if (ultimoDigito >= 7)
        {
            sinal = "+";
        }
        else if (ultimoDigito < 3)
        {
            sinal = "-";
        }

        if (letra == "A" && sinal == "+")
        {
            sinal = "";
        }

        if (letra == "F")
        {
            sinal = "";
        }

        Console.WriteLine($"Nota: {letra}{sinal}");

        if (nota >= 70)
        {
            Console.WriteLine("Parabéns! Você foi aprovado no curso.");
        }
        else
        {
            Console.WriteLine("Continue se esforçando para a próxima vez.");
        }
    }
}