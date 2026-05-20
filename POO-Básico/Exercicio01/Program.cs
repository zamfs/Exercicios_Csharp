//Criar uma classe que representa uma conta bancária, com um número indicador, titular, saldo e senha
//Criar um objeto do tipo Conta, adicionar dados e mostrar as informações titular e saldo no console, utilizando interpolação de strings.
//Desenvolver um método da classe Conta que exibe suas informações.

ContaBancaria conta1 = new ContaBancaria();
conta1.id = 1234;
conta1.nomeTitular = "João da Silva";
conta1.saldoConta = 123.24;
conta1.senha = "minhasenha123";
conta1.exibirInformacoes();

ContaBancaria conta2 = new ContaBancaria();
conta2.id = 5678;
conta2.nomeTitular = "Pedro da Silva";
conta2.saldoConta = 1230.44;
conta2.senha = "121212";
conta2.exibirInformacoes();

class ContaBancaria
{
    public int id;
    public string nomeTitular;
    public double saldoConta;
    public string senha;

    public void exibirInformacoes()
    {
        Console.WriteLine($"\n\nIdentificador da conta: {id}");
        Console.WriteLine($"Nome do titular: {nomeTitular}");
        Console.WriteLine($"Saldo atual da conta: {saldoConta:F2}");
    }
}
