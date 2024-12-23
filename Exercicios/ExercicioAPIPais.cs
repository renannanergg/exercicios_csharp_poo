// Modelar e desserializar a classe Pais, que pode ser encontrada no endpoint disponibilizado
using System.Text.Json;
using System.Text.Json.Serialization;

namespace Exercicios;

public class APIPais
{
    public async Task RequestAPI()
    {
        using (HttpClient client = new HttpClient())
        {
          try
          {
            string resposta = await client.GetStringAsync("https://raw.githubusercontent.com/ArthurOcFernandes/Exerc-cios-C-/curso-4-aula-2/Jsons/Paises.json");
            var paises = JsonSerializer.Deserialize<List<Paises>>(resposta)!;
            foreach (var pais in paises)
            {
                Console.WriteLine(pais.FichaPais);
            }
          }
          catch (Exception ex)
          {
            Console.WriteLine($"Ocorreu o seguinte erro: {ex}");
          }
        }

    }
}

internal class Paises
{  
    [JsonPropertyName("nome")]
    public string? Pais { get; set; }

    [JsonPropertyName("capital")]
    public string? Capital { get; set; }

    [JsonPropertyName("populacao")]
    public int? Populacao { get; set; }

    [JsonPropertyName("continente")]
    public string? Continente { get; set; }

    [JsonPropertyName("idioma")]
    public string? Idioma { get; set; }
    public string FichaPais => $"Pais: {Pais} - Capital: {Capital} - Populacao: {Populacao}";
}

public class ExercicioAPIPaises
{
    public async Task ExecutarAsync()
    {
        APIPais aPIPais = new();
        await aPIPais.RequestAPI();
    }
}