//Criar uma hierarquia de classes representando animais, como Mamifero, Ave e Peixe. Utilize herança e o conceito de métodos virtuais para implementar um método EmitirSom que represente o som característico de cada tipo de animal.

namespace Exercicios;

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

internal class Ave : Animais
{
    public Ave(string categoria, string especie) : base(categoria, especie)
    {
    }

    public override void EmitirSom()
    {
        base.EmitirSom();
        Console.WriteLine("-Ave");
        Console.WriteLine("-Som de Ave");
    }
}

internal class Mamifero : Animais
{
    public Mamifero(string categoria, string especie) : base(categoria, especie)
    {
    }

    public override void EmitirSom()
    {
        base.EmitirSom();
        Console.WriteLine("-Mamifero");
        Console.WriteLine("-Som de Mamífero");
    }
}

internal class Reptil : Animais
{
    public Reptil(string categoria, string especie) : base(categoria, especie)
    {
    }

    public override void EmitirSom()
    {
        base.EmitirSom();
        Console.WriteLine("-Réptil");
        Console.WriteLine("-Som de Réptil");
    }
}

public class ExercicioAnimais 
{ 
    public void Executar() 
    { 
        Animais animalGenerico = new Animais("Geral", "Animal"); 
        Ave ave = new Ave("Ave", "Pardal"); 
        Mamifero mamifero = new Mamifero("Mamifero", "Cachorro"); 
        Reptil reptil = new Reptil("Reptil", "Lagarto"); 
        Console.WriteLine("Informações e Sons dos Animais:"); 
        animalGenerico.EmitirSom(); 
        Console.WriteLine(); 
        ave.EmitirSom(); 
        Console.WriteLine(); 
        mamifero.EmitirSom(); 
        Console.WriteLine(); 
        reptil.EmitirSom(); 
    } 
}

