//Criar um programa que permite ao usuário inserir informações de uma pessoa (nome, idade, e e-mail), serializa essas informações em formato JSON e salva em um arquivo. 

using System.Text.Json;
using System.Text.Json.Serialization;

namespace Exercicios;

internal class Cadastro
{
    List<Cadastro> cadastros = new();
    public Cadastro() {}
    public Cadastro(string nome, int idade, string email)
    {
        Nome = nome;
        Idade = idade;
        Email = email;
    }

    [JsonPropertyName("nome")]
    public string? Nome { get; set; }

    [JsonPropertyName("idade")]
    public int Idade { get; set; }

    [JsonPropertyName("email")]
    public string? Email { get; set; }


    public void AdicionarCadastro(Cadastro cadastro)
    {
        cadastros.Add(cadastro);
        Console.WriteLine($"Cadastro do user: {cadastro.Nome} criado com sucesso! ");
    }
    public void ExibirCadastros()
    {
        Console.WriteLine(" *** Cadastros *** ");
        foreach (var cadastro in cadastros)
        {
            Console.WriteLine($"Nome: {cadastro.Nome}/ Idade: {cadastro.Idade}/ Email: {cadastro.Email}");
        }
    }
}

internal class ExercicioSerializaCadastro 
{
    public void CriarJson(Cadastro cadastro)
    {
        string json = JsonSerializer.Serialize(new {
            nome = cadastro.Nome,
            idade = cadastro.Idade,
            email = cadastro.Email,

        });

        string nomeDoArquivo = $"cadastro-{cadastro.Nome}.json";
        File.WriteAllText(nomeDoArquivo,json);

        Console.WriteLine($"Arquivo JSON criado com sucesso : {Path.GetFullPath(nomeDoArquivo)}");
    }
    

    public void Executar()
    {
        Console.Write("Digite o nome: ");
        string nome = Console.ReadLine()!;

        Console.Write("Digite a idade: ");
        int idade = int.Parse(Console.ReadLine()!);

        Console.Write("Digite o email: ");
        string email = Console.ReadLine()!;

        Cadastro cadastro = new(nome,idade,email);
        cadastro.AdicionarCadastro(cadastro);
        Console.WriteLine();
        cadastro.ExibirCadastros();

        CriarJson(cadastro);

    }
}