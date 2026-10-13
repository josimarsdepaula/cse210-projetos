
using System;
using System.Collections.Generic;
using System.IO;

public class GerenciadorDeMetas
{
    private List<Meta> _metas = new List<Meta>();
    private int _pontuacao = 0;

    public void Iniciar()
    {
        string opcao = "";

        while (opcao != "6")
        {
            Console.WriteLine("\n===== METAS ETERNAS =====");
            Console.WriteLine($"Você tem {_pontuacao} pontos.");
            Console.WriteLine("1. Criar nova meta");
            Console.WriteLine("2. Listar metas");
            Console.WriteLine("3. Salvar metas");
            Console.WriteLine("4. Carregar metas");
            Console.WriteLine("5. Registrar evento");
            Console.WriteLine("6. Sair");
            Console.Write("Escolha uma opção: ");

            opcao = Console.ReadLine() ?? "";

            switch (opcao)
            {
                case "1":
                    CriarMeta();
                    break;
                case "2":
                    ListarMetas();
                    break;
                case "3":
                    SalvarMetas();
                    break;
                case "4":
                    CarregarMetas();
                    break;
                case "5":
                    RegistrarEvento();
                    break;
                case "6":
                    Console.WriteLine("Até logo!");
                    break;
                default:
                    Console.WriteLine("Opção inválida.");
                    break;
            }
        }
    }

    private void CriarMeta()
    {
        Console.WriteLine("\nTipos de metas:");
        Console.WriteLine("1. Meta simples");
        Console.WriteLine("2. Meta eterna");
        Console.WriteLine("3. Meta de lista de tarefas");
        Console.Write("Escolha o tipo: ");
        string tipo = Console.ReadLine() ?? "";

        if (tipo != "1" && tipo != "2" && tipo != "3")
        {
            Console.WriteLine("Tipo inválido.");
            return;
        }

        Console.Write("Nome da meta: ");
        string nome = Console.ReadLine() ?? "";

        Console.Write("Descrição: ");
        string descricao = Console.ReadLine() ?? "";

        Console.Write("Pontos por realização: ");
        int pontos = LerNumero();

        if (tipo == "1")
        {
            _metas.Add(new MetaSimples(nome, descricao, pontos));
        }
        else if (tipo == "2")
        {
            _metas.Add(new MetaEterna(nome, descricao, pontos));
        }
        else
        {
            Console.Write("Quantas vezes precisa realizar? ");
            int quantidade = LerNumero();

            if (quantidade <= 0)
            {
                Console.WriteLine("A quantidade deve ser maior que zero.");
                return;
            }

            Console.Write("Bônus ao concluir: ");
            int bonus = LerNumero();

            _metas.Add(new MetaDeListaDeTarefas(
                nome, descricao, pontos, quantidade, bonus));
        }

        Console.WriteLine("Meta criada com sucesso!");
    }

    private void ListarMetas()
    {
        Console.WriteLine("\n===== SUAS METAS =====");

        if (_metas.Count == 0)
        {
            Console.WriteLine("Nenhuma meta cadastrada.");
            return;
        }

        for (int i = 0; i < _metas.Count; i++)
        {
            Meta meta = _metas[i];
            string marcada = meta.EstaConcluida() ? "X" : " ";

            Console.WriteLine(
                $"{i + 1}. [{marcada}] {meta.ObterDetalhesTexto()}");
        }
    }

    private void RegistrarEvento()
    {
        if (_metas.Count == 0)
        {
            Console.WriteLine("Você ainda não tem metas.");
            return;
        }

        ListarMetas();

        Console.Write("Qual meta você realizou? ");
        int numero = LerNumero();

        if (numero < 1 || numero > _metas.Count)
        {
            Console.WriteLine("Meta inválida.");
            return;
        }

        Meta meta = _metas[numero - 1];
        int pontosGanhos = meta.RegistrarEvento();

        _pontuacao += pontosGanhos;

        if (pontosGanhos > 0)
        {
            Console.WriteLine($"Parabéns! Você ganhou {pontosGanhos} pontos.");
        }
        else
        {
            Console.WriteLine("Essa meta já foi concluída.");
        }

        // Criatividade: mensagem de nível conforme os pontos.
        if (_pontuacao >= 1000)
        {
            Console.WriteLine("Nível: Mestre das Metas!");
        }
        else if (_pontuacao >= 500)
        {
            Console.WriteLine("Nível: Explorador!");
        }
        else
        {
            Console.WriteLine("Nível: Iniciante!");
        }
    }

    private void SalvarMetas()
    {
        Console.Write("Nome do arquivo (exemplo: metas.txt): ");
        string arquivo = Console.ReadLine() ?? "";

        try
        {
            using (StreamWriter escritor = new StreamWriter(arquivo))
            {
                escritor.WriteLine(_pontuacao);

                foreach (Meta meta in _metas)
                {
                    escritor.WriteLine(meta.ObterRepresentacaoEmTexto());
                }
            }

            Console.WriteLine("Metas salvas com sucesso!");
        }
        catch (Exception)
        {
            Console.WriteLine("Não foi possível salvar o arquivo.");
        }
    }

    private void CarregarMetas()
    {
        Console.Write("Nome do arquivo: ");
        string arquivo = Console.ReadLine() ?? "";

        try
        {
            string[] linhas = File.ReadAllLines(arquivo);

            int pontuacaoCarregada = int.Parse(linhas[0]);
            List<Meta> metasCarregadas = new List<Meta>();

            for (int i = 1; i < linhas.Length; i++)
            {
                string[] partesTipo = linhas[i].Split(':', 2);
                string tipo = partesTipo[0];
                string[] dados = partesTipo[1].Split('|');

                if (tipo == "MetaSimples")
                {
                    MetaSimples meta = new MetaSimples(
                        dados[0], dados[1], int.Parse(dados[2]));

                    meta.DefinirConclusao(bool.Parse(dados[3]));
                    metasCarregadas.Add(meta);
                }
                else if (tipo == "MetaEterna")
                {
                    metasCarregadas.Add(new MetaEterna(
                        dados[0], dados[1], int.Parse(dados[2])));
                }
                else if (tipo == "MetaDeListaDeTarefas")
                {
                    MetaDeListaDeTarefas meta = new MetaDeListaDeTarefas(
                        dados[0],
                        dados[1],
                        int.Parse(dados[2]),
                        int.Parse(dados[4]),
                        int.Parse(dados[5]));

                    meta.DefinirQuantidadeRealizada(int.Parse(dados[3]));
                    metasCarregadas.Add(meta);
                }
            }

            _pontuacao = pontuacaoCarregada;
            _metas = metasCarregadas;

            Console.WriteLine("Metas carregadas com sucesso!");
        }
        catch (Exception)
        {
            Console.WriteLine("Não foi possível carregar o arquivo.");
        }
    }

    private int LerNumero()
    {
        while (true)
        {
            string texto = Console.ReadLine() ?? "";

            if (int.TryParse(texto, out int numero) && numero >= 0)
            {
                return numero;
            }

            Console.Write("Digite um número válido: ");
        }
    }
}
