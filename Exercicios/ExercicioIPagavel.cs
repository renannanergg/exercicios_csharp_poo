//Criar uma interface chamada IPagavel com um método CalcularPagamento. Implemente essa interface em duas classes, Produto e Servico. O método CalcularPagamento deve retornar o valor total a ser pago, levando em consideração a quantidade para produtos e a taxa horária para serviços.

namespace Exercicios;

internal interface IPagavel
{
    decimal CalculoPagamento();
}

public class ProdutoIPagavel : IPagavel
{
    public ProdutoIPagavel(string nome, decimal preco, int qntd)
    {
        NomeProduto = nome;
        PrecoUnt = preco;
        Quantidade = qntd;
    }
    public string? NomeProduto { get; set; }
    public decimal PrecoUnt { get; set; }
    public int Quantidade { get; set; }

    public decimal CalculoPagamento()
    {
        return PrecoUnt * Quantidade;
    }

    public void RegistroPedido()
    {
        Console.WriteLine(" ****REGISTRO PEDIDO**** ");
        Console.WriteLine($"-Produto: {NomeProduto}");
        Console.WriteLine($"-Preço por Unidade: {PrecoUnt} R$");
        Console.WriteLine($"-Quantidade: {Quantidade}");
        Console.WriteLine($"-TOTAL: {CalculoPagamento()} R$");
        
    }
}

public class ServicoIPagavel : IPagavel
{
    public ServicoIPagavel(string nome, int hrtrabalhadas, decimal taxahoraria)
    {
        Nome = nome;
        HorasTrabalhadas = hrtrabalhadas;
        TaxaHoraria = taxahoraria;
    }

    public int HorasTrabalhadas { get; set; }
    public string Nome { get; set; }
    public decimal TaxaHoraria { get; set; }

    public decimal CalculoPagamento()
    {
        return TaxaHoraria * HorasTrabalhadas;
    }

    public void NotaFiscalServico()
    {
        Console.WriteLine(" *** NF SERVICO PRESTADO *** ");
        Console.WriteLine($"-Nome: {Nome}");
        Console.WriteLine($"-Horas Trabalhadas: {HorasTrabalhadas}");
        Console.WriteLine($"-Taxa por Hora: {TaxaHoraria}");
        Console.WriteLine($"-Total: {CalculoPagamento()} R$");
    }

}

public class ExercicioIPagavel 
{ 
    public void Executar() 
    { 
        ProdutoIPagavel produto = new ProdutoIPagavel("Notebook", 3000m, 2); 
        ServicoIPagavel servico = new ServicoIPagavel("Desenvolvimento Web", 40, 50m); 
        
        Console.WriteLine("Informações do Produto:"); 
        produto.RegistroPedido(); 
        Console.WriteLine(); 
        Console.WriteLine("Informações do Serviço:"); 
        servico.NotaFiscalServico(); 
    } 
}