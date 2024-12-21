// Desenvolver uma classe que modele um carro, e que contenha os métodos acelerar, frear e buzinar

namespace Exercicios
{
    public class Carro
    {
        public Carro(string modelo, int ano, string cor)
        {
            Modelo = modelo;
            Ano = ano;
            Cor = cor;
        }
        public string Modelo {get;}
        public int Ano{get;}
        public string Cor{get;}
        public int Velocidade{get;set;}
        public string DescricaoDetalhada => $"{Modelo}/{Cor} fabricado em {Ano}";
        public void Buzinar()
        {
            Console.WriteLine("BI BIIIIIIIIIIIIIIIIIP !!!");
        }

        public void Acelerar(int incremento)
        {
            Velocidade += incremento;
            Console.WriteLine($"Acelerando... Nova velocidade: {Velocidade} km/h");
        }

        public void Frear(int decremento)
        {
            Velocidade -= decremento;
            if (Velocidade < 0)
            {
                Velocidade = 0;
            }
            Console.WriteLine($"Freando... Nova velocidade: {Velocidade} km/h");
        }
    }

    public class ExercicioCarro
    {
        public void Executar()
        {
            Carro carro = new("Jeep Compass",2024,"Branco Perolado");

            Console.WriteLine("Informações do Carro:"); 
            Console.WriteLine(carro.DescricaoDetalhada);

            carro.Buzinar(); 
            carro.Acelerar(20); 
            carro.Frear(10);
        }
    }
}