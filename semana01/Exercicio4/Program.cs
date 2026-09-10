using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numeros = new List<int>();

        Console.WriteLine("Insira uma lista de números e digite 0 quando terminar.");

        int numero = -1;

        while (numero != 0)
        {
            Console.Write("Insira o número: ");
            numero = int.Parse(Console.ReadLine());

            if (numero != 0)
            {
                numeros.Add(numero);
            }
        }

        if (numeros.Count > 0)
        {
            int soma = 0;

            foreach (int n in numeros)
            {
                soma += n;
            }

            double media = (double)soma / numeros.Count;

            int maior = numeros[0];

            foreach (int n in numeros)
            {
                if (n > maior)
                {
                    maior = n;
                }
            }

            int menorPositivo = 0;

            foreach (int n in numeros)
            {
                if (n > 0)
                {
                    if (menorPositivo == 0 || n < menorPositivo)
                    {
                        menorPositivo = n;
                    }
                }
            }

            numeros.Sort();

            Console.WriteLine($"A soma é: {soma}");
            Console.WriteLine($"A média é: {media}");
            Console.WriteLine($"O maior número é: {maior}");
            Console.WriteLine($"O menor número positivo é: {menorPositivo}");
            Console.WriteLine("A lista reordenada é:");

            foreach (int n in numeros)
            {
                Console.WriteLine(n);
            }
        }
        else
        {
            Console.WriteLine("Nenhum número foi inserido.");
        }
    }
}