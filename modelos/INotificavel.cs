// Criar uma interface chamada INotificavel com um método EnviarNotificacao. Implemente essa interface em duas classes, Email e SMS. O método EnviarNotificacao deve exibir mensagens diferentes para cada tipo de notificação.

namespace INotificavel;

internal interface INotificavel
{
    public void EnviarNotificacao();
}

public class Email : INotificavel
{
    public Email(string endereco,string msg)
    {
        EnderecoEmail = endereco;
        Mensagem = msg;
    }

    public string EnderecoEmail { get; set; }
    public string Mensagem {get; set;}

    public void EnviarNotificacao()
    {
        Console.WriteLine($"Email enviado para {EnderecoEmail}");
        Console.WriteLine($"Conteúdo: {Mensagem}");
    }
}

public class SMS : INotificavel
{
    public SMS(int tel, string msg)
    {
        Telefone = tel;
        Mensagem = msg;
    }

    public int Telefone { get; set; }
    public string Mensagem { get; set; }

    public void EnviarNotificacao()
    {
        Console.WriteLine($"SMS enviado para: {Telefone}");
        Console.WriteLine($"Conteúdo: {Mensagem}");
    }
}