//Escrever um programa que faça uam requisição para a API de games CheapShark e mostre na tela a lista de promoções cadastrada na ferramenta

namespace Exercicios;

public class CheapSharkAPI
{
    public async Task RequestAPI()
    {
        using (HttpClient client = new HttpClient())
        {
            try
            {
                string resposta = await client.GetStringAsync("https://www.cheapshark.com/api/1.0/deals");
                Console.WriteLine(resposta);
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erro constatado ! {ex}");
            }
    
        }
    }
}

public class ExercicioCheapSharkAPI 
{ 
    public async Task ExecutarAsync() 
    { 
        CheapSharkAPI api = new CheapSharkAPI(); 
        await api.RequestAPI(); 
    } 
}


