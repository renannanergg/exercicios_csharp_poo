// Dada uma lista de produtos com nome e preço, criar uma consulta LINQ para calcular o preço médio dos produtos.

namespace Exercicios;

internal class ProdutosLinq
{
    public decimal Preco { get; set; }
    public string? Nome { get; set; }
    public int Quantidade { get; set; }
}

internal class ExercicioLinqPrecos
{
    public void ConsultaLinq(List<ProdutosLinq> produtos)
    {   
        var precoMedio = produtos.Average(p => p.Preco);
        Console.WriteLine($"Preço médio dos produtos: {precoMedio} R$");
    }

    public void Executar()
    {
        List<ProdutosLinq> produtos = new()
        {
            new ProdutosLinq { Nome = "Laptop Dell", Preco = 3500 },
            new ProdutosLinq { Nome = "Iphone 15", Preco = 5300 },
            new ProdutosLinq { Nome = "Ipad Mini", Preco = 3000 },
            new ProdutosLinq { Nome = "Câmera Nikon", Preco = 2300 }
        };

        ExercicioLinqPrecos exercicioLinqPrecos = new();
        exercicioLinqPrecos.ConsultaLinq(produtos);
    }
}