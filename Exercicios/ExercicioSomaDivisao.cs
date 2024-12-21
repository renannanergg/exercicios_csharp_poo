//Escrever um programa que solicite dois números a e b lidos do teclado e realize a divisão de a por b. Caso essa operação não seja possível, mostrar uma mensagem no console que deixe claro o erro ocorrido.

namespace Exercicios;

public class Divisao
{
    public void Dividir()
    {
        try
        {
            Console.Write("Digite um numerador: ");
            int numerador = int.Parse(Console.ReadLine()!);

            Console.Write("Digite um denominador: ");
            int denominador = int.Parse(Console.ReadLine()!);

            int resultado = numerador / denominador;
            Console.WriteLine($"{numerador} dividido por {denominador} resulta em: {resultado}");
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine($"Erro ao gerar resultado: {ex}");
        }
    }
}

public class ExercicioDivisao
{
    public void Executar()
    {
        Divisao divisao = new();
        divisao.Dividir();
    }
}


