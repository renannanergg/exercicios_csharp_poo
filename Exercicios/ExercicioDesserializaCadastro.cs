//Criar um programa que lê um arquivo JSON contendo informações de uma pessoa, desserializa essas informações e exibe na tela.

using System.Text.Json;

namespace Exercicios;

internal class ExercicioDesserializaCadastro 
{
    public static void LerJson(string nomeDoArquivo)
    {
        if (File.Exists(nomeDoArquivo))
        {
            string arquivoJson = File.ReadAllText(nomeDoArquivo);

            Cadastro? cadastro = JsonSerializer.Deserialize<Cadastro>(arquivoJson)!;

            Console.WriteLine($"\nNome: {cadastro.Nome}");
            Console.WriteLine($"Idade: {cadastro.Idade}");
            Console.WriteLine($"Email: {cadastro.Email}");
        }
        else
        {
            Console.WriteLine("Arquivo não encontrado !");
        }
    }

    public void Executar()
    {
        Console.Write("Digite o nome do arquivo: ");
        string nomeDoArquivo = Console.ReadLine()!;

        LerJson(nomeDoArquivo);
    }
}