using Exercicios;
class Program
{
    static void Main()
    {
        MainAsync().GetAwaiter().GetResult();
    }
    static async Task MainAsync()
    {
        Console.WriteLine("Selecione o exercício para executar:");
        Console.WriteLine("1 - Exercício Conta");
        Console.WriteLine("2 - Exercício Carro");
        Console.WriteLine("3 - Exercício Produto");
        Console.WriteLine("4 - Exercício Escola");
        Console.WriteLine("5 - Exercício Restaurante");
        Console.WriteLine("6 - Exercício Jogos");
        Console.WriteLine("7 - Exercício PetShop");
        Console.WriteLine("8 - Exercício Oficina");
        Console.WriteLine("9 - Exercício Animais");
        Console.WriteLine("10 - Exercício Funcionário");
        Console.WriteLine("11 - Exercício Eletronicos");
        Console.WriteLine("12 - Exercício IPagavel");
        Console.WriteLine("13 - Exercício INotificável");
        Console.WriteLine("14 - Exercício IArmazenavél");
        Console.WriteLine("15 - Exercício API CheapShark");
        Console.WriteLine("16 - Exercício Divisão");
        Console.WriteLine("17 - Exercício API Filmes");
        Console.WriteLine("18 - Exercício API Países");
        Console.WriteLine("19 - Exercício API Livros");
        Console.WriteLine("20 - Exercício Consulta LINQ Numeros");
        Console.WriteLine("21 - Exercício Consulta LINQ Livros");
        Console.WriteLine("22 - Exercício Consulta LINQ Preços");
        Console.WriteLine("23 - Exercício Consulta LINQ Pares");

        Console.WriteLine("\n0 - Sair");

        Console.Write("Digite a opção: ");
        int opcao = int.Parse(Console.ReadLine()!);

        switch (opcao)
        {
            case 1:
                Console.Clear();
                ExercicioConta exercicioConta = new();
                exercicioConta.Executar();
                break;
            case 2:
                Console.Clear();
                ExercicioCarro exercicioCarro = new();
                exercicioCarro.Executar();
                break;
            case 3:
                Console.Clear();
                ExercicioProduto exercicioProduto = new();
                exercicioProduto.Executar();
                break;
            case 4:
                Console.Clear();
                ExercicioEscola exercicioEscola = new();
                exercicioEscola.Executar();
                break;
            case 5:
                Console.Clear();
                ExercicioRestaurante exercicioRestaurante = new();
                exercicioRestaurante.Executar();
                break;
            case 6:
                Console.Clear();
                ExercicioJogo exercicioJogo = new();
                exercicioJogo.Executar();
                break;
            case 7:
                Console.Clear();
                ExercicioPetShop exercicioPetShop = new();
                exercicioPetShop.Executar();
                break;
            case 8:
                Console.Clear();
                ExercicioOficina exercicioOficina = new();
                exercicioOficina.Executar();
                break;
            case 9:
                Console.Clear();
                ExercicioAnimais exercicioAnimais = new();
                exercicioAnimais.Executar();
                break;
            case 10:
                Console.Clear();
                ExercicioFuncionario exercicioFuncionario = new();
                exercicioFuncionario.Executar();
                break;
            case 11:
                Console.Clear();
                ExercicioEletronicos exercicioEletronicos = new();
                exercicioEletronicos.Executar();
                break;
            case 12:
                Console.Clear();
                ExercicioIPagavel exercicioIPagavel = new();
                exercicioIPagavel.Executar();
                break;
            case 13:
                Console.Clear();
                ExercicioINotificavel exercicioINotificavel = new();
                exercicioINotificavel.Executar();
                break;
            case 14:
                Console.Clear();
                ExercicioIArmazenavel exercicioIArmazenavel = new();
                exercicioIArmazenavel.Executar();
                break;
            case 15:
                Console.Clear();
                ExercicioCheapSharkAPI aPI = new();
                await aPI.ExecutarAsync();
                break;
            case 16:
                Console.Clear();
                ExercicioDivisao exercicioDivisao = new();
                exercicioDivisao.Executar();
                break;
            case 17:
                Console.Clear();
                ExercicioAPIFilmes exercicioAPIFilmes = new();
                await exercicioAPIFilmes.ExecutarAsync();
                break;
            case 18:
                Console.Clear();
                ExercicioAPIPaises exercicioAPIPaises = new();
                await exercicioAPIPaises.ExecutarAsync();
                break;
            case 19:
                Console.Clear();
                ExercicioAPILivros exercicioAPILivros = new();
                await exercicioAPILivros.ExecutarAsync();
                break;
            case 20:
                Console.Clear();
                ExercicioLinqNumeros exercicioLinqNumeros = new();
                exercicioLinqNumeros.Executar();
                break;
            case 21:
                Console.Clear();
                ExercicioLinqLivros exercicioLinqLivros = new();
                exercicioLinqLivros.Executar();
                break;
            case 22:
                Console.Clear();
                ExercicioLinqPrecos exercicioLinqPrecos = new();
                exercicioLinqPrecos.Executar();
                break;
            case 23:
                Console.Clear();
                ExercicioLinqPares exercicioLinqPares = new();
                exercicioLinqPares.Executar();
                break;
            case 0:
                return;
            default:
                Console.WriteLine("Opção Inválida, tente novamente.");
                break;
        }
    }
}