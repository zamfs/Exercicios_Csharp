//Reescrever a classe Conta, criada no ultimo desafio, utilizando properties.
ContaBancaria conta1 = new ContaBancaria();
conta1.Id = 1234;
conta1.NomeTitular = "João da Silva";
conta1.SaldoConta = 123.24;
conta1.Senha = "minhasenha123";
conta1.exibirInformacoes();

ContaBancaria conta2 = new ContaBancaria();
conta2.Id = 5678;
conta2.NomeTitular = "Pedro da Silva";
conta2.SaldoConta = 1230.44;
conta2.Senha = "121212";
conta2.exibirInformacoes();

class ContaBancaria
{
    public int Id { get; set; }
    public string NomeTitular { get; set; }
    public double SaldoConta { get; set; }
    public string Senha { get; set; }

    public void exibirInformacoes()
    {
        Console.WriteLine($"\n\nIdentificador da conta: {Id}");
        Console.WriteLine($"Nome do titular: {NomeTitular}");
        Console.WriteLine($"Saldo atual da conta: {SaldoConta:F2}");
    }
}