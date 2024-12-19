namespace Funcionarios;

internal class Analista : Funcionario
{
    public Analista(string nome, int funcional, double salario) : base(nome, funcional, salario)
    {
    }

    public string? Nivel { get; set; }
    public string? Setor { get; set; }

    public override void Executar()
    {
        base.Executar();
        Console.WriteLine($"Nível: {Nivel}");
        Console.WriteLine($"Setor: {Setor}");

    }
}