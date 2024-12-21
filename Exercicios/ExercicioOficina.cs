// Modelar o funcionamento de uma oficina automobilistica.

namespace Exercicios;

internal class Veiculo
{
    public Veiculo(string tipo, string marca, string modelo, string cor, int ano, string placa)
    {
        Tipo = tipo;
        Marca = marca;
        Modelo = modelo;
        Cor = cor;
        Ano = ano;
        Placa = placa;
    }
    public string Tipo { get; }
    public string Marca { get; }
    public string Modelo { get; }
    public string Cor { get; }
    public int Ano { get; }
    public string Placa { get; }

}
internal class Mecanico
{
    public Mecanico(string nome)
    {
        Nome = nome;
    }
    public string Nome { get; }
}
internal class Cliente
{
    public Cliente(string nome, Veiculo veiculo, int contato)
    {
        Nome = nome;
        Veiculo = veiculo;
        Contato = contato;
    }

    public string Nome { get; }
    public Veiculo Veiculo { get; }
    public int Contato { get; }

    public void ExibirFichaCLiente()
    {
        Console.WriteLine($"***** FICHA *****");
        Console.WriteLine($"Veículo/Placa: {Veiculo.Marca} {Veiculo.Modelo}/{Veiculo.Placa}");
        Console.WriteLine($"Cor/Ano: {Veiculo.Cor}/{Veiculo.Ano}");   
        Console.WriteLine($"Cliente: {Nome}");
        Console.WriteLine($"Contato: {Contato}");
    }
}
internal class Oficina
{
    private List<Veiculo> veiculosNaOficina = new List<Veiculo>();

    public Oficina()
    {
        veiculosNaOficina = new List<Veiculo>();

    }

    public void AgendarServico(Veiculo veiculo, Cliente cliente, Mecanico mecanico, string data)
    {
        veiculosNaOficina.Add(veiculo);
        Console.WriteLine($"Serviço agendado para {veiculo.Modelo}/{veiculo.Placa} em {data} com o mecânico {mecanico.Nome}.");
    }

    public void RealizarServico(Veiculo veiculo, Mecanico mecanico)
    {
        if (veiculosNaOficina.Contains(veiculo))
        {
            Console.WriteLine($"Serviço realizado no veículo {veiculo.Modelo}/{veiculo.Placa} pelo mecânico {mecanico.Nome}");
            veiculosNaOficina.Remove(veiculo);
        }
        else
        {
            Console.WriteLine($"O veículo {veiculo.Modelo}/{veiculo.Placa} não foi localizado na nossa oficina");
        }

    }

    public void ExibirVeiculosDaOficina()
    {
        if (veiculosNaOficina.Count == 0)
        {
            Console.WriteLine("Não há veículos na oficina");
        }
        else
        {
            Console.WriteLine("*****Veículos na Oficina*****");
            foreach (var veiculo in veiculosNaOficina)
            {
                Console.WriteLine($"--{veiculo.Marca} {veiculo.Modelo}");
            }
        }
    }

}

public class ExercicioOficina
    {
        public void Executar()
        {
            Oficina oficina = new Oficina();
            Veiculo veiculo1 = new Veiculo("Carro", "Toyota", "Corolla", "Preto", 2019, "ABC-1234");
            Cliente cliente1 = new Cliente("João Santos", veiculo1, 99887766);
            Mecanico mecanico1 = new Mecanico("Carlos Souza");

            oficina.AgendarServico(veiculo1, cliente1, mecanico1, "20/12/2024");

            Console.WriteLine("\nInformações do Cliente e Veículo:"); 
            cliente1.ExibirFichaCLiente();

            oficina.ExibirVeiculosDaOficina();

            oficina.RealizarServico(veiculo1, mecanico1);


        }   
    }