// Criar um método que receba como parâmetro um array de double e retorne a média simples calculada.

namespace Exercicios;

public class ExercicioMediaArray
{
    double MediaDoArray(double[] array)
    {
        double media = 0;
        double acumulador = 0;

        if ((array == null) || (array.Length ==0))
        {
            Console.WriteLine("Amostra de dados vazia");
            return 0;
        }
        else
        {
            for (int i = 0; i < array.Length; i++)
            {
                acumulador = acumulador + array[i];

            }

            media = acumulador / array.Length;
        }
        return media;
    }

    public void Executar()
    {
        double[] notas = new double[5];
        notas[0] = 8.3;
        notas[1] = 4.8;
        notas[2] = 9.5;
        notas[3] = 6.2;
        notas[4] = 10;

        ExercicioMediaArray mediaArray = new();
        Console.WriteLine($"A média de notas é: {mediaArray.MediaDoArray(notas)}");
    }
}