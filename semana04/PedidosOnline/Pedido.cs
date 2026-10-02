using System.Collections.Generic;

public class Pedido
{
    private List<Produto> _produtos;
    private Cliente _cliente;

    public Pedido(Cliente cliente)
    {
        _cliente = cliente;
        _produtos = new List<Produto>();
    }

    public void AdicionarProduto(Produto produto)
    {
        _produtos.Add(produto);
    }

    public double CalcularPrecoTotal()
    {
        double total = 0;

        foreach (Produto produto in _produtos)
        {
            total += produto.CalcularCustoTotal();
        }

        if (_cliente.MoraNosEUA())
        {
            total += 5;
        }
        else
        {
            total += 35;
        }

        return total;
    }

    public string ObterEtiquetaEmbalagem()
    {
        string etiqueta = "";

        foreach (Produto produto in _produtos)
        {
            etiqueta += $"{produto.ObterNome()} - {produto.ObterIdProduto()}\n";
        }

        return etiqueta;
    }

    public string ObterEtiquetaEnvio()
    {
        return $"{_cliente.ObterNome()}\n{_cliente.ObterEndereco()}";
    }
}