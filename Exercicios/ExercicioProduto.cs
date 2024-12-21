using System.Runtime.CompilerServices;

namespace Exercicios
{
    public class Produto
    {
        public Produto(string nome,string marca,double preco)
        {
            Nome = nome;
            Marca = marca;
            Preco = preco;
        }
        private int estoque;
        public string Nome {get;}
        public string Marca {get;}
        public double Preco {get; }
        public int Estoque {
            get => estoque;
            set
            {
                if (value < 0)
                {
                    Console.WriteLine("Estoque inválido !");
                }
                else
                {
                    estoque = value;
                }
            }

        }
        public string Descricao => $"Produto: {Nome}-{Marca}/ Preço: {Preco}/QNTD: {Estoque}";

    }

    public class Estoque
    {
        private List<Produto> Produtos { get; set; } = new List<Produto>();
        public void AdicionarProduto(Produto produto)
        {
            Produtos.Add(produto);
            Console.WriteLine($"Produto {produto.Nome} adicionado ao estoque");

        }
        public void ExibirProdutos()
        {
            if (Produtos.Count == 0)
            {
                Console.WriteLine("Estoque vazio");
            }
            else
            {
                Console.WriteLine("Lista de produtos em estoque:");
                foreach (var produto in Produtos)
                {
                    Console.WriteLine($"{produto.Descricao}");
                }
            }
        }
    }

    public class ExercicioProduto
    {
        public void Executar()
        {
            Estoque estoque = new();
            
            Produto produto1 = new Produto("Notebook", "Dell", 3500.0); 
            produto1.Estoque = 10;
            estoque.AdicionarProduto(produto1);

            Produto produto2 = new Produto("Smartphone","Apple",4500.0);
            produto2.Estoque = 15;
            estoque.AdicionarProduto(produto2);

            estoque.ExibirProdutos();
        }
    }
}