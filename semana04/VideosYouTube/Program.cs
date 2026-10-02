using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<Video> videos = new List<Video>();

        Video video1 = new Video("Como aprender C#", "João Silva", 600);
        video1.AdicionarComentario(new Comentario("Maria", "Ótima explicação!"));
        video1.AdicionarComentario(new Comentario("Carlos", "Aprendi bastante com este vídeo."));
        video1.AdicionarComentario(new Comentario("Ana", "Muito fácil de entender."));
        videos.Add(video1);

        Video video2 = new Video("Introdução à Programação", "Pedro Santos", 480);
        video2.AdicionarComentario(new Comentario("Lucas", "Excelente conteúdo."));
        video2.AdicionarComentario(new Comentario("Juliana", "Gostei muito da aula."));
        video2.AdicionarComentario(new Comentario("Marcos", "Obrigado pelas explicações."));
        videos.Add(video2);

        Video video3 = new Video("Programação Orientada a Objetos", "Fernanda Costa", 720);
        video3.AdicionarComentario(new Comentario("Paulo", "Agora entendi melhor as classes."));
        video3.AdicionarComentario(new Comentario("Beatriz", "Muito bom!"));
        video3.AdicionarComentario(new Comentario("Rafael", "Conteúdo muito útil."));
        videos.Add(video3);

        foreach (Video video in videos)
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine($"Título: {video.ObterTitulo()}");
            Console.WriteLine($"Autor: {video.ObterAutor()}");
            Console.WriteLine($"Duração: {video.ObterDuracao()} segundos");
            Console.WriteLine($"Número de comentários: {video.ObterQuantidadeComentarios()}");
            Console.WriteLine("Comentários:");

            foreach (Comentario comentario in video.ObterComentarios())
            {
                Console.WriteLine($"- {comentario.ObterNome()}: {comentario.ObterTexto()}");
            }

            Console.WriteLine();
        }
    }
}