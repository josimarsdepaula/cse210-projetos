using System;

class Program
{
    static void Main(string[] args)
    {
        // Pedido 1 - Cliente nos Estados Unidos
        Endereco endereco1 = new Endereco(
            "123 Main Street",
            "Orlando",
            "Florida",
            "USA"
        );

        Cliente cliente1 = new Cliente("John Smith", endereco1);

        Pedido pedido1 = new Pedido(cliente1);

        pedido1.AdicionarProduto(
            new Produto("Notebook", "P001", 800.00, 1)
        );

        pedido1.AdicionarProduto(
            new Produto("Mouse", "P002", 25.00, 2)
        );

        // Pedido 2 - Cliente no Brasil
        Endereco endereco2 = new Endereco(
            "Rua das Flores, 150",
            "Curitiba",
            "Paraná",
            "Brasil"
        );

        Cliente cliente2 = new Cliente("Maria Silva", endereco2);

        Pedido pedido2 = new Pedido(cliente2);

        pedido2.AdicionarProduto(
            new Produto("Teclado", "P003", 50.00, 2)
        );

        pedido2.AdicionarProduto(
            new Produto("Monitor", "P004", 300.00, 1)
        );

        pedido2.AdicionarProduto(
            new Produto("Webcam", "P005", 75.00, 1)
        );

        // Exibir Pedido 1
        Console.WriteLine("===== PEDIDO 1 =====");
        Console.WriteLine();

        Console.WriteLine("Etiqueta de Embalagem:");
        Console.WriteLine(pedido1.ObterEtiquetaEmbalagem());

        Console.WriteLine("Etiqueta de Envio:");
        Console.WriteLine(pedido1.ObterEtiquetaEnvio());

        Console.WriteLine();
        Console.WriteLine($"Preço Total: ${pedido1.CalcularPrecoTotal():F2}");

        Console.WriteLine();
        Console.WriteLine("------------------------------");
        Console.WriteLine();

        // Exibir Pedido 2
        Console.WriteLine("===== PEDIDO 2 =====");
        Console.WriteLine();

        Console.WriteLine("Etiqueta de Embalagem:");
        Console.WriteLine(pedido2.ObterEtiquetaEmbalagem());

        Console.WriteLine("Etiqueta de Envio:");
        Console.WriteLine(pedido2.ObterEtiquetaEnvio());

        Console.WriteLine();
        Console.WriteLine($"Preço Total: ${pedido2.CalcularPrecoTotal():F2}");
    }
}