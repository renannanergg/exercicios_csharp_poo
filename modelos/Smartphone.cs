namespace Eletronicos;

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