namespace Eletronicos;

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