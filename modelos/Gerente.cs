namespace Funcionarios;

internal class Gerente : Funcionario
{
    public Gerente(string nome, int funcional, double salario) : base(nome, funcional, salario)
    {
    }
    
    public string? Setor { get; set; }
    public int Equipe { get; set; }



    public override void Executar()
    {
        base.Executar();
        Console.WriteLine($"Cargo: Gerente");
        Console.WriteLine($"Setor: {Setor}");
        Console.WriteLine($"Equipe Responsável: Equipe {Equipe}");

    }
}