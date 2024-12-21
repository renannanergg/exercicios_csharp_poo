// Criar uma interface chamada INotificavel com um método EnviarNotificacao. Implemente essa interface em duas classes, Email e SMS. O método EnviarNotificacao deve exibir mensagens diferentes para cada tipo de notificação.

namespace Exercicios;

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

public class ExercicioINotificavel 
{ 
    public void Executar() 
    { 
        Email email = new Email("exemplo@dominio.com", "Olá, este é um teste de notificação por email."); 
        SMS sms = new SMS(123456789, "Olá, este é um teste de notificação por SMS.");

        Console.WriteLine("Notificação por Email:"); 
        email.EnviarNotificacao(); 
        Console.WriteLine(); 
        Console.WriteLine("Notificação por SMS:"); 
        sms.EnviarNotificacao(); 
    } 
}