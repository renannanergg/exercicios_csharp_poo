namespace Animais;

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