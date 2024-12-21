//Crie uma hierarquia de classes representando funcionários de uma empresa. Utilize herança para criar classes como Gerente, Programador e Analista. Cada classe deve ter propriedades específicas, além das propriedades comuns a todos os funcionários, como Nome e Salário.

namespace Exercicios;

internal class Funcionario
{
    public Funcionario(string nome, int funcional ,double salario)
    {
        Nome = nome;
        Salario = salario;
        Funcional = funcional;
    }

    public string Nome { get; }
    public double Salario { get; }
    public int Funcional { get; }


    public virtual void Executar()
    {
        Console.WriteLine("***** Registro Funcionário *****");
        Console.WriteLine($"\nNome do Funcionário: {Nome}");
        Console.WriteLine($"Código Funcional: {Funcional}");
        Console.WriteLine($"Salário (R$): {Salario} mil");
    }
}
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
public class ExercicioFuncionario 
{ 
    public void Executar() 
    { 
        Funcionario gerente = new Gerente("Alice Martins", 1001, 15.0) 
        { Setor = "Tecnologia", Equipe = 5 }; 
        Funcionario analista = new Analista("Carlos Oliveira", 1002, 10.0) 
        { Nivel = "Sênior", Setor = "Financeiro" }; 
        Funcionario programador = new Programador("Beatriz Souza", 1003, 8.0) 
        { Nivel = "Pleno", Linguagem = "C#" }; 

        Console.WriteLine("Informações dos Funcionários:"); 
        gerente.Executar(); 
        Console.WriteLine(); 
        analista.Executar(); 
        Console.WriteLine(); 
        programador.Executar(); 
    } 
}