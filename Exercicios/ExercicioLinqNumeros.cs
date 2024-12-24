// Dada uma lista de números, criar uma consulta LINQ para retornar apenas os elementos únicos da lista.

namespace Exercicios;

internal class ExercicioLinqNumeros
{
    public void ConsultaLinq(List<int> numeros)
    {
        var numerosFiltrados = numeros.Distinct().ToList();
        foreach (var numero in numerosFiltrados)
        {
            Console.WriteLine($"-{numero}");
        }
    }

    public void Executar()
    {
        List<int> ints = [10,10,18,48,39,18,75,100];
        ExercicioLinqNumeros exercicioLinqNumeros = new();
        exercicioLinqNumeros.ConsultaLinq(ints);
    }
}



