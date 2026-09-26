using System;

// Criatividade:
// O programa oculta somente palavras que ainda estão visíveis.
// Isso evita selecionar novamente palavras que já foram ocultadas
// e ajuda o usuário a avançar de forma constante na memorização.

class Program
{
    static void Main(string[] args)
    {
        Referencia referencia = new Referencia("Provérbios", 3, 5, 6);

        Escritura escritura = new Escritura(
            referencia,
            "Confia no Senhor de todo o teu coração e não te estribes no teu próprio entendimento. Reconhece-o em todos os teus caminhos, e ele endireitará as tuas veredas."
        );

        string resposta = "";

        while (resposta.ToLower() != "sair" &&
               !escritura.EstaCompletamenteOculta())
        {
            Console.Clear();

            Console.WriteLine(escritura.ObterTextoExibicao());

            Console.WriteLine();
            Console.WriteLine("Pressione Enter para continuar ou digite 'sair' para finalizar.");
            resposta = Console.ReadLine() ?? "";

            if (resposta.ToLower() != "sair")
            {
                escritura.OcultarPalavrasAleatorias(3);
            }
        }

        Console.Clear();
        Console.WriteLine(escritura.ObterTextoExibicao());
    }
}