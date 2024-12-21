//Modelar um Pet Shop com classes como Pet, Dono, Consulta e médico.

namespace Exercicios;

internal class Pet
{
    public Pet(string especie, string nome,string raca, string porte, string cor, int idade)
    {
        Especie = especie;
        Nome = nome;
        Raça = raca;
        Porte = porte;
        Cor = cor;
        Idade = idade;
    }
    public string Especie { get; }
    public string Nome { get; }
    public string Raça { get; }
    public string Porte { get; }
    public string Cor { get; }
    public int Idade { get; }

    public void ExibirFichaPet()
    {
        Console.WriteLine($"*****Ficha do Pet*****");
        Console.WriteLine($"-Espécie: {Especie}");
        Console.WriteLine($"-Raça: {Raça}");
        Console.WriteLine($"-Nome: {Nome}");
        Console.WriteLine($"-Porte: {Porte}");
        Console.WriteLine($"-Cor: {Cor}");
        Console.WriteLine($"-Idade: {Idade}");
    }
}
internal class Dono
{
    public Dono(string nome, Pet pet, int tel, string endereco)
    {
        Nome = nome;
        Pet = pet;
        Telefone = tel;
        Endereco = endereco;
    }
    public string Nome { get;}
    public Pet Pet { get;}
    public int Telefone { get; }
    public string Endereco { get;}

    public void ExibirFichaDono()
    {
        Console.WriteLine($"***** Ficha do Dono *****");
        Console.WriteLine($"-Nome: {Nome}");
        Console.WriteLine($"-Pet: {Pet.Especie}-{Pet.Nome}");
        Console.WriteLine($"-Número de Contato: {Telefone}");
        Console.WriteLine($"-Endereço {Endereco}");
    }
}
internal class Medico
{
    public Medico(string nome, string especialidade)
    {
        Nome = nome;
        Especialidade = especialidade;
    }
    public string Nome { get; set; }
    public string Especialidade { get; set; }
}
internal class Consulta
{
    public Consulta(Pet paciente, Dono dono, string data, Medico medico)
    {
        Paciente = paciente;
        Dono = dono;
        DataConsulta = data;
        Medico = medico;
    }
    public Pet Paciente { get; }
    public Dono Dono { get; }
    public string DataConsulta { get; set; }
    public Medico Medico {get; }

    public void ExibirFichaConsulta()
    {
        Console.WriteLine($"*****Ficha Consulta*****");
        Console.WriteLine($"Paciente: {Paciente.Nome}/{Paciente.Especie}");
        Console.WriteLine($"Data: {DataConsulta}");
        Console.WriteLine($"Médico/Especialidade: {Medico.Nome}/{Medico.Especialidade}");
        Console.WriteLine($"Dono: {Dono.Nome}");
    }
}

public class ExercicioPetShop
{
    public void Executar()
    {
        Pet pet = new Pet("Cachorro", "Buddy", "Golden Retriever", "Grande", "Dourado", 3);
        Dono dono = new Dono("Ana Silva", pet, 999999999, "Rua dos Animais, 123");
        Medico medico = new Medico("Dr. Almeida", "Veterinário"); 
        Consulta consulta = new Consulta(pet, dono, "15/01/2025", medico);

        Console.WriteLine("\nInformações do Pet:"); 
        pet.ExibirFichaPet(); 
        Console.WriteLine("\nInformações do Dono:"); 
        dono.ExibirFichaDono(); 
        Console.WriteLine("\nInformações da Consulta:"); 
        consulta.ExibirFichaConsulta();

    }
}