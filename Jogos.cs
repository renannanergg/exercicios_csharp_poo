//Desenvolver uma classe que representa um catálogo de jogos, com uma lista de Jogos e métodos para manipular essa lista, bem como um construtor que faça sua inicialização.

namespace Jogoteca
{
    public class Jogo
    {
        List<Jogo> Jogos = new List<Jogo>();
        public Jogo(string nome,string plataforma,string genero, int ano)
        {
            NomeDoJogo = nome;
            Plataforma = plataforma;
            Gênero = genero;
            AnoLancamento = ano;  
        }
        public string NomeDoJogo {get;}
        public string Plataforma {get;}
        public string Gênero {get;}
        public int AnoLancamento {get;}
        public string Descricao => $"O jogo do estilo {Gênero} chamado {NomeDoJogo} está disponível para {Plataforma}.";

    }
    public class CatalogoJogos
    {
        private List<Jogo> Jogos {get; set;}
        public bool CatalogoVazio => Jogos.Count ==0;
        
        public CatalogoJogos()
        {
            Jogos = new List<Jogo>();
        }
        public void AdicionarJogo(string nome,string plataforma, string genero, int anoLancamento)
        {
            Jogo novoJogo = new Jogo(nome,plataforma, genero, anoLancamento);
            Jogos.Add(novoJogo);
            Console.WriteLine($"Jogo \"{nome}\" adicionado ao catálogo.");

        }
        public void ListarJogos()
        {
            if (CatalogoVazio)
            {
                Console.WriteLine("Catálogo vazio");
            }
            else
            {
                Console.WriteLine("Catálogo de jogos: ");
                foreach (var jogo in Jogos)
                {
                    Console.WriteLine($"Nome: {jogo.NomeDoJogo}, Gênero: {jogo.Gênero}, Ano de Lançamento: {jogo.AnoLancamento}");
                }
            }
        }

    }
}