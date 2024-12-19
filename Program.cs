
using Animais;
using Eletronicos;
using Funcionarios;

namespace Principal
{
    public static class ProgramaPrincipal
    {
        public static void Main()
        {
            // ****Primeiro Exercicio
            //Titular t = new("Renan",0000000,"Rua do Zinga");
            //Conta c = new(t,2876,19392,2500.00,800);
            //Console.WriteLine(c.Informacoes);
            
            // ****Segundo Exercicio
            // Carro carro1 = new Carro("Honda Fit",2018,"Cinza");
            // Console.WriteLine(carro1.DescricaoDetalhada);
            // carro1.Buzinar();
            // carro1.Acelerar(35);
            // carro1.Frear(35);

            //****Terceiro Exercicio
            // Produto produto1 = new Produto("Sabonete","Dove",2.50);
            // produto1.Estoque = 500;
            // Estoque estoque1 = new Estoque();
            // estoque1.AdicionarProduto(produto1);
            // estoque1.ExibirProdutos();

            //****Quarto Exercicio
            // Aluno aluno1 = new Aluno("Maria",15);
            // aluno1.Notas = new List<double> {8,8,9};
            // Console.WriteLine(aluno1.FichaAluno);
            // Professor professor1 = new Professor("Pedro");
            // professor1.DisciplinasLecionadas = new List<string> {"Física","Química"};
            // Console.WriteLine(professor1.FichaProfessor);
            // Disciplina disciplina1 = new Disciplina("Química");
            // disciplina1.AdicionarAlunoNaDisciplina(aluno1);
            // Console.WriteLine(disciplina1.FichaDisciplina);

            //****Quinto Exercicio
            // ProdutoRestaurante produto1 = new ProdutoRestaurante("Pizza",39.90);
            // ProdutoRestaurante produto2 = new ProdutoRestaurante("Cheese Burguer",19.90);
            // Cardapio cardapio = new Cardapio();
            // cardapio.ItensCardapio = new List<ProdutoRestaurante>{produto1,produto2};
            // cardapio.MostrarCardapio();
            // Pedido pedido1 = new Pedido(produto1,2);
            // Mesa mesa1 = new Mesa(1);
            // mesa1.Pedidos = new List<Pedido>{pedido1};
            // mesa1.MostrarPedidosDaMesa();

            //****Sexto Exercicio
            // Jogo jogo1 = new Jogo("Rainbow Six","PS5","FPS",2015);
            // CatalogoJogos catalogo = new CatalogoJogos();
            // catalogo.AdicionarJogo("Rainbow Six","PS5","FPS",2015);
            // catalogo.ListarJogos();

            //****Sétimo Exercicio
            // Pet bulldog = new Pet("Cachorro","Johnny","Bulldog Inglês","Médio","Marrom",8);
            // bulldog.ExibirFichaPet();
            // Dono renan = new Dono("Renan",bulldog,997087748,"Rua das Ruas");
            // renan.ExibirFichaDono();
            // Medico joana = new Medico("Dra. Joana","Cachorros");
            // Consulta consulta = new Consulta(bulldog,renan,"17/12/2024",joana);
            // consulta.ExibirFichaConsulta();

            //****Oitavo Exercicio
            // Veiculo hondafit = new Veiculo("Carro","Honda","Fit","Cinza",2016,"ABC1234");
            // Cliente renan = new Cliente("Renan",hondafit,997087748);
            // renan.ExibirFichaCLiente();
            // Mecanico joao = new Mecanico("João");
            // Oficina oficina = new Oficina();
            // oficina.AgendarServico(hondafit,renan,joao,"17/12/2024");
            // oficina.RealizarServico(hondafit,joao);
            // oficina.ExibirVeiculosDaOficina();

            //****Nono Exercicio
            // Gerente gerente = new ("João",128594,9.800)
            // {
            //     Setor = "Compras",
            //     Equipe = 1,
            // };
            // gerente.Executar();
            // Programador programador = new("Pedro",458988,5.500)
            // {
            //     Nivel = "Junior",
            //     Linguagem = "C#",
            // };
            // programador.Executar();
            // Analista analista = new("Maria",865444,7.200)
            // {
            //      Nivel = "Pleno",
            //      Setor = "Marketing",
            // };
            // analista.Executar();

            //****Décimo Exercicio
            // Mamifero tigre = new("Felino","Tigre");
            // tigre.EmitirSom();
            // Reptil jacare = new("Alligatoridae","Jacaré");
            // jacare.EmitirSom();
            // Ave aguia = new("Ave de Rapina","Aguia");
            // aguia.EmitirSom();


            //****Décimo Primeiro Exercicio
            // Smartphone iphone15 = new("Iphone 15","Smartphone","Apple",6.800)
            //  {
            //      OS = "IOS"
            //  };
            // iphone15.ExibirInfo();

            // Videogame play5 = new ("PlayStation 5","Videogame","Sony",5.200)
            //  {
            //     Versão = "PRO 4K",
            //     Memoria = 256,
            //     Controles = 2
            //  };
            // play5.ExibirInfo();




        }
    }
}