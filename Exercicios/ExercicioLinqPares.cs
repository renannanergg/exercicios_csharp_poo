// Dada uma lista de inteiros, criar uma consulta LINQ para retornar apenas os números pares.

namespace Exercicios;


internal class ExercicioLinqPares
{
    public void ConultaLinq(List<int> numeros)
    {
        var numerosPares = numeros.Where(x => x % 2 ==0);
        Console.WriteLine("Numeros Pares: ");
        foreach(var numero in numerosPares)
        {
            Console.WriteLine($"-{numero}");
        }
    }

    public void Executar()
    {
        List<int> numeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

        ExercicioLinqPares exercicioLinqPares = new();
        exercicioLinqPares.ConultaLinq(numeros);

    }
}

