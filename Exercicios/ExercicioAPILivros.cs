// Modelar e desserializar a classe Livro, que pode ser encontrada no endpoint disponibilizado
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Exercicios;

public class APILivros
{
    public async Task RequestAPI()
    {
        using (HttpClient client = new HttpClient())
        {
            try
            {
                string resposta = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Livros.json");
                var livros = JsonSerializer.Deserialize<List<Livro>>(resposta)!;
                foreach (var livro in livros)
                {
                    Console.WriteLine(livro.FichaLivro);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu o seguinte erro: {ex}");
            }
        }
    }
}

internal class Livro
{
    [JsonPropertyName("titulo")]
    public string? Nome { get; set; }

    [JsonPropertyName("autor")]
    public string? Autor { get; set; }

    [JsonPropertyName("genero")]
    public string? Gênero { get; set; }

    public string FichaLivro => $"Título: {Nome} - Gênero {Gênero} / Autor: {Autor}";
}

public class ExercicioAPILivros
{
    public async Task ExecutarAsync()
    {
        APILivros aPILivros = new();
        await aPILivros.RequestAPI();
    }
}