//Dada uma lista de livros com título, autor e ano de publicação, criar uma consulta LINQ para retornar uma lista com os títulos dos livros publicados após o ano 2000, ordenados alfabeticamente.

namespace Exercicios;

internal class LinqLivro
{
    public string? Titulo { get; set; }
    public int AnoPublicacao { get; set; }
    public string? Autor { get; set; }
}

internal class ExercicioLinqLivros
{
    public void ConsultaLinq(List<LinqLivro> livros)
    {
        var livrosFiltrados = livros.Where(l => l.AnoPublicacao > 2000).OrderBy(l => l.Titulo).Select(l => l.Titulo);

        Console.WriteLine($"Livros publicados no século XXI");
        foreach(var livro in livrosFiltrados)
        {
            Console.WriteLine($"-{livro}");
        }
    }

    public void Executar()
    {
        List<LinqLivro> livros = new()
        {
            new LinqLivro { Titulo = "Aprendendo Sobre a Vida", Autor = "Horácio Sabino", AnoPublicacao = 1963 },
            new LinqLivro { Titulo = "Programação em C#", Autor = "Márcia Morgado", AnoPublicacao = 2008 },
            new LinqLivro { Titulo = "Algoritmos e Estruturas de Dados", Autor = "Julio Casares", AnoPublicacao = 2003 },
        };

        ExercicioLinqLivros exercicioLinqLivros = new();
        exercicioLinqLivros.ConsultaLinq(livros);

    }
}