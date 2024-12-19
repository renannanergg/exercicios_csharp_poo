//Crie uma hierarquia de classes representando funcionários de uma empresa. Utilize herança para criar classes como Gerente, Programador e Analista. Cada classe deve ter propriedades específicas, além das propriedades comuns a todos os funcionários, como Nome e Salário.

namespace Funcionarios;

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
