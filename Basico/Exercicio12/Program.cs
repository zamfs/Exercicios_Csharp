//Crie um programa que implemente um quiz simples de perguntas e respostas.
//Utilize um dicionário para armazenar as perguntas e as respostas corretas.

Dictionary<string, string> quiz = new Dictionary<string, string>
{
    {"O Brasil está em qual continente?", "América do sul" },
    {"Qual a capital do Brasil?", "Brasília" },
    {"Em que ano foi a Copa do Mundo no Brasil?", "2014" }
};

foreach (KeyValuePair<string, string> pergunta in quiz)
{
    Console.Write($"{pergunta.Key} ");
    string respostaUsuario = Console.ReadLine()!;
    
    if (respostaUsuario == pergunta.Value)
    {
        Console.WriteLine("Respota correta!!");
    }
    else
    {
        Console.WriteLine($"Respota Incorreta! Era: {pergunta.Value}");
    }
}

Console.WriteLine("Fim do quiz!");