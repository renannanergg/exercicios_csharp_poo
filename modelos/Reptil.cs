namespace Animais;

internal class Reptil : Animais
{
    public Reptil(string categoria, string especie) : base(categoria, especie)
    {
    }

    public override void EmitirSom()
    {
        base.EmitirSom();
        Console.WriteLine("-Réptil");
        Console.WriteLine("Som de Réptil");
    }
}