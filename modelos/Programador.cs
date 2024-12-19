namespace Funcionarios;

internal class Programador : Funcionario
{
    public Programador(string nome, int funcional, double salario) : base(nome, funcional, salario)
    {
    }

    public string? Nivel { get; set; }
    public string? Linguagem { get; set; }

    public override void Executar()
    {
        base.Executar();
        Console.WriteLine("Cargo: Programador");
        Console.WriteLine($"Nível: {Nivel}");
        Console.WriteLine($"Linguagem: {Linguagem}");

    }

}