//Criar um programa que simule um sistema de login utilizando um dicionário para armazenar nomes de usuário e senhas.

Dictionary<string, string> usuarios = new Dictionary<string, string>();

do
{
    Console.WriteLine("Faça o cadastro do login do usuário. (Digite 'fim', no nome, para não continuar mais a cadastrar).");
    Console.Write("\nNome: ");
    string nome = Console.ReadLine()!;

    if (nome == "fim")
    {
        break;
    }

    Console.Write("\nSenha: ");
    string senha = Console.ReadLine()!;

    usuarios[nome] = senha;
} while (true);

Console.Clear();
Console.WriteLine("LOGIN");
Console.Write("\nNome: ");
string nomeLogin = Console.ReadLine()!;
Console.Write("\nSenha: ");
string senhaLogin = Console.ReadLine()!;

if (usuarios.ContainsKey(nomeLogin))
{
    if (senhaLogin == usuarios[nomeLogin])
    {
        Console.WriteLine("\nLogin realizado com sucesso!");
    }
    else
    {
        Console.WriteLine("\nSenha incorreta!");
    }
}
else
{
    Console.WriteLine("\nEsse login não existe!");
}