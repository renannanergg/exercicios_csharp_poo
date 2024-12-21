//Modelar um sistema para um restaurante com classes como Restaurante, Mesa, Pedido e Cardapio. A classe Restaurante deve ter mesas que podem ser reservadas e um cardápio com itens que podem ser pedidos. Os pedidos podem estar associados a uma mesa.

namespace Exercicios
{
    public class ProdutoRestaurante
    {
        public ProdutoRestaurante(string nome,double preco)
        {
            Nome = nome;
            Preco = preco;
        }
        public string Nome { get; }
        public double Preco { get; }
    }
    public class Pedido
    {
        public Pedido(ProdutoRestaurante produto, int qtd)
        {
            Produto = produto;
            Quantidade = qtd;
        }
        public ProdutoRestaurante Produto {get; }
        public int Quantidade { get; }
    }
    public class Mesa
    {
        public Mesa(int mesa)
        {
            NumeroMesa = mesa;
        }
        public int NumeroMesa { get; }
        public List<Pedido> Pedidos { get; set; } = new List<Pedido>();

        public void MostrarPedidosDaMesa()
        {
            Console.WriteLine($"A mesa {NumeroMesa} pediu: ");
            foreach (var pedido in Pedidos)
            {
                Console.WriteLine($"{pedido.Quantidade} {pedido.Produto.Nome}(s).");
            }
        }
        
    }
    public class Cardapio 
    {
        public List<ProdutoRestaurante> ItensCardapio { get; set; } = new List<ProdutoRestaurante>();

        public void MostrarCardapio()
        {
            Console.WriteLine("*****Cardapio****");
            foreach (var item in ItensCardapio)
            {
                Console.WriteLine($"--{item.Nome}/{item.Preco}R$");
            }
        }

    }
    public class Restaurante
    {
        public List <Mesa> Mesas { get; set; } = new List<Mesa>();
        public Cardapio Cardapio { get; set; } = new Cardapio();
    }
    public class ExercicioRestaurante
    {
        public void Executar()
        {
            Restaurante restaurante = new Restaurante();
            ProdutoRestaurante pizza = new ProdutoRestaurante("Pizza", 30.0); 
            ProdutoRestaurante suco = new ProdutoRestaurante("Suco", 5.0); 
            restaurante.Cardapio.ItensCardapio.Add(pizza); 
            restaurante.Cardapio.ItensCardapio.Add(suco);

            Mesa mesa1 = new Mesa(1); 
            mesa1.Pedidos.Add(new Pedido(pizza, 2)); 
            mesa1.Pedidos.Add(new Pedido(suco, 3)); 
            restaurante.Mesas.Add(mesa1);

            Mesa mesa2 = new Mesa(2); 
            mesa2.Pedidos.Add(new Pedido(pizza, 1));
            restaurante.Mesas.Add(mesa2);

            Console.WriteLine("Cardápio:"); 
            restaurante.Cardapio.MostrarCardapio();

            Console.WriteLine("\nPedidos das mesas:"); 
            foreach (var mesa in restaurante.Mesas) 
            { 
                mesa.MostrarPedidosDaMesa(); 
            }
        }
    }
}