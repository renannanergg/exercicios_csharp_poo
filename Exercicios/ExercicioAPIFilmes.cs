//Modelar e desserializar a classe Filme, que pode ser encontrada no endpoint disponibilizado
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Exercicios;
public class APIFilmes
{
    public async Task RequestAPI()
    {
        using (HttpClient client = new HttpClient() )
        {
            try
            {
                string resposta = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/TopMovies.json");
                var filmes = JsonSerializer.Deserialize<List<Filmes>>(resposta)!;
                foreach (var filme in filmes)
                {
                    Console.WriteLine(filme.FichaTecnica);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Ocorreu o seguinte erro: {ex}");
            }
        }
    }
}

public class ExercicioAPIFilmes
{
    public async Task ExecutarAsync()
    {
        APIFilmes aPIFilmes = new();
        await aPIFilmes.RequestAPI();
    }
}

internal class Filmes
{
    
    [JsonPropertyName("title")]
    public string? Nome { get; set; }

    [JsonPropertyName("year")]
    public string? Ano  { get; set; }

    [JsonPropertyName("crew")]
    public string? Elenco { get; set; }

    [JsonPropertyName("imDbRating")]
    public string? Nota { get; set; }

    public string? FichaTecnica => $"\n\nTitulo: {Nome} ({Ano}) - Nota: {Nota}\nElenco: [{Elenco}]\n\n";
}