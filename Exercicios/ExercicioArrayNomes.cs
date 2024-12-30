// Dado uma lista de nomes, crie um método que verifica se um nome digitado pelo usuário está cadastrado na lista.

namespace Exercicios;

public class ExercicioArrayNomes
{
    public void BuscarNome(List<string> nomes, string nomeEscolhido)
    {
        for (int i = 0; i < nomes.Count; i++)
        {
            if (nomeEscolhido.Equals(nomes[i]))
            {
                Console.WriteLine($"O nome {nomeEscolhido} está listado !");
                
            }
            else
            {
                Console.WriteLine($"Nome {nomeEscolhido} não encontrado!");
            }
            return;
        }
        

    }

    public void Executar()
    {
        List<string> nomesDosEscolhidos = new List<string>()
        {
            "Bruce Wayne",
            "Carlos Vilagran",
            "Richard Grayson",
            "Bob Kane",
            "Will Farrel",
            "Lois Lane",
            "General Welling",
            "Perla Letícia",
            "Uxas",
            "Diana Prince",
            "Elisabeth Romanova",
            "Anakin Wayne"
        };

        Console.Write("Digite o nome que deseja buscar: ");
        string nomeABuscar = Console.ReadLine()!;

        BuscarNome(nomesDosEscolhidos,nomeABuscar);
       
    }
}
