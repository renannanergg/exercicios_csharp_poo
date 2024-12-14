using System.Runtime.CompilerServices;

namespace EstoqueProdutos
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
}