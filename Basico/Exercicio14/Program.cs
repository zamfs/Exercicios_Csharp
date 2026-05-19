//Com base na lista de super carros fornecida acima, onde a chave é o nome do carro e os valores são quantas vezes esse
//carro foi vendido por ano, calcule a média de uma chave específica.

Dictionary<string, List<int>> vendasCarros = new Dictionary<string, List<int>> {
    { "Bugatti Veyron", new List<int> { 10, 15, 12, 8, 5 } },
    { "Koenigsegg Agera RS", new List<int> { 2, 3, 5, 6, 7 } },
    { "Lamborghini Aventador", new List<int> { 20, 18, 22, 24, 16 } },
    { "Pagani Huayra", new List<int> { 4, 5, 6, 5, 4 } },
    { "Ferrari LaFerrari", new List<int> { 7, 6, 5, 8, 10 } }
};

do
{
    Console.Write("\nDigite o nome do carro que deseja saber a média das vendas ('fim' para parar de pesquisar): ");
    string pesquisa = Console.ReadLine()!;
    if (pesquisa == "fim")
    {
        break;
    }
    else
    {
        if (vendasCarros.ContainsKey(pesquisa))
        {
            double mediaVendas = new double();
            foreach (int venda in vendasCarros[pesquisa])
            {
                mediaVendas += venda;
            }
            Console.WriteLine(vendasCarros[pesquisa].Count);
            mediaVendas /= vendasCarros[pesquisa].Count;
            Console.WriteLine($"\nA média das vendas foi igual a: {mediaVendas}");
        }
        else
        {
            Console.WriteLine("\nEsse carro não existe na loja!");
        }
    }
} while (true);

Console.WriteLine("Encerrando...");