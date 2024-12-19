namespace Animais;

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