// Criar uma hierarquia de classes representando produtos eletrônicos, como Smartphone, Tablet e Laptop. Utilize herança e o conceito de métodos virtuais para implementar um método ExibirInformacoes que retorne informações específicas de cada produto.

namespace Exercicios;

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
internal class Smartphone : Eletronicos
{
    public Smartphone(string nome, string categoria, string marca, double preco) : base(nome, categoria, marca, preco)
    {
    }

    public string? OS { get; set; }

    public override void ExibirInfo()
    {
        base.ExibirInfo();
        Console.WriteLine($"Sistema Operacional: {OS}");
    }
}
internal class Videogame : Eletronicos
{
    public Videogame(string nome, string categoria, string marca, double preco) : base(nome, categoria, marca, preco)
    {
    }

    public string? Versão { get; set; }
    public int Memoria { get; set; }
    public int Controles { get; set; }

    public override void ExibirInfo()
    {
        base.ExibirInfo();
        Console.WriteLine($"Versão: {Versão}");
        Console.WriteLine($"Memoria (GB): {Memoria}");
        Console.WriteLine($"QTD de Controles: {Controles}");
    }
}
public class ExercicioEletronicos 
{ 
    public void Executar() 
    { 
        Eletronicos eletronicoGenerico = new Eletronicos("Produto Genérico", "Geral", "Marca X", 1.0); 
        Smartphone smartphone = new Smartphone("iPhone", "Celular", "Apple", 7.0) 
        { OS = "iOS" }; 
        Videogame videogame = new Videogame("PlayStation 5", "Console", "Sony", 5.0) 
        { Versão = "Standard", Memoria = 825, Controles = 1 }; 
        Console.WriteLine("Informações dos Produtos Eletrônicos:"); 
        eletronicoGenerico.ExibirInfo(); 
        Console.WriteLine(); 
        smartphone.ExibirInfo(); 
        Console.WriteLine(); 
        videogame.ExibirInfo(); 
    } 
}