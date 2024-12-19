//Criar uma hierarquia de classes representando animais, como Mamifero, Ave e Peixe. Utilize herança e o conceito de métodos virtuais para implementar um método EmitirSom que represente o som característico de cada tipo de animal.

namespace Animais;

internal class Animais
{
    public Animais(string categoria, string especie)
    {
        Categoria = categoria;
        Especie = especie;
    }

    public string Categoria { get; set; }
    public string Especie { get; set; }

    public virtual void EmitirSom()
    {
        Console.WriteLine($" ANIMAl ");
        Console.WriteLine($"-Categoria: {Categoria}");
        Console.WriteLine($"-Especie: {Especie}");

    }
}