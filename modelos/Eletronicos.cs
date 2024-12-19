// Criar uma hierarquia de classes representando produtos eletrônicos, como Smartphone, Tablet e Laptop. Utilize herança e o conceito de métodos virtuais para implementar um método ExibirInformacoes que retorne informações específicas de cada produto.

namespace Eletronicos;

internal class Eletronicos
{
    public Eletronicos(string nome, string categoria, string marca, double preco)
    {
        Nome = nome;
        Categoria = categoria;
        Marca = marca;
        Preco = preco;
    }

    public string Nome { get; set; }
    public string Categoria { get; set; }
    public string Marca { get; set; }
    public double Preco { get; set; }

    public virtual void ExibirInfo()
    {
        Console.WriteLine($"PRODUTO ELETRONICO");
        Console.WriteLine($"\nProduto: {Nome}");
        Console.WriteLine($"Categoria: {Categoria}");
        Console.WriteLine($"Marca: {Marca}");
        Console.WriteLine($"Preco (R$): {Preco} mil");
    }
}