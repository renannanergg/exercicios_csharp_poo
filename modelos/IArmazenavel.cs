//Criar uma interface chamada IArmazenavel com métodos Salvar e Recuperar. Implemente essa interface em duas classes, Arquivo e BancoDeDados. Os métodos Salvar e Recuperar devem exibir mensagens simulando a ação de salvar e recuperar dados.

namespace IArmazenavel;

internal interface IArmazenavel
{
    void Salvar();
    void Recuperar();
}

public class Arquivo : IArmazenavel
{
    public string NomeArquivo { get; set; }

    public Arquivo(string nome)
    {
        NomeArquivo = nome;
    }

    public void Salvar()
    {
        Console.WriteLine($"Salvando dados no arquivo: '{NomeArquivo}'....");
        Thread.Sleep(3000);
        Console.WriteLine("Salvamento concluido!");
    }

    public void Recuperar()
    {
        Console.WriteLine($"Recuperando arquivo: '{NomeArquivo}'.....");
        Thread.Sleep(3000);
        Console.WriteLine($"Arquivo:'{NomeArquivo}' recuperado com sucesso !!");
    }
}

public class BancoDeDados : IArmazenavel
{
    public string NomeBanco { get; set; }

    public BancoDeDados(string nome)
    {
        NomeBanco = nome;
    }

    public void Salvar()
    {
        Console.WriteLine($"Salvando arquivos no bando de dados: '{NomeBanco}'");
    }

    public void Recuperar()
    {
        Console.WriteLine($"Recuperando arquivos do banco de dados '{NomeBanco}'");
    }
}