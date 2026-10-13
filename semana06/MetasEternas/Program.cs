using System;
        // Criatividade: sistema de níveis baseado na pontuação.
        // O usuário começa como Iniciante, passa para Explorador
        // ao atingir 500 pontos e Mestre das Metas com 1000 pontos.
        // Isso ajuda a motivar o usuário a continuar realizando metas.
class Program
{
    static void Main(string[] args)
    {
        GerenciadorDeMetas gerenciador = new GerenciadorDeMetas();
        gerenciador.Iniciar();
    }
}
