//Modelar uma classe Conta, que tenha como atributos uma classe Titular, além de informações da conta, como agência, número da conta, saldo e limite, bem como um método que devolva as informações da conta de forma detalhada. Em seguida, instanciar um objeto do tipo Conta e um do tipo Titular e mostrar as informações de Titular, a partir da Conta.

namespace ContaBancaria
{
    public class Titular
    {
        public Titular (string nome, int cpf, string endereco)
        {
            Nome = nome;
            Cpf = cpf;
            Endereco = endereco;
        }
        public string Nome { get; }
        public int Cpf { get; }
        public string Endereco { get; }
    }
    public class Conta
    {
        public Conta(Titular titular, int agencia, int numconta, double saldo,int limite)
        {
            Titular = titular;
            Agência = agencia;
            NumeroDaConta = numconta;
            Saldo = saldo;
            Limite = limite;
        }
        public Titular Titular { get; }
        public int Agência { get;  }
        public int NumeroDaConta {get; }
        public double Saldo {get; }
        public int Limite { get; }
        public bool Status {get; }
        public string Informacoes => $"Agência/Conta: {Agência}/{NumeroDaConta}\n Titular: {Titular.Nome} \n Saldo: {Saldo}";

       
    }
}