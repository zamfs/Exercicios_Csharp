//Criar um programa que gerencie o estoque de uma loja.
//Utilize um dicionário para armazenar produtos e suas quantidades em estoque e mostre,
//a partir do nome de um produto, sua quantidade em estoque.

Dictionary<string, int> produtos = new Dictionary<string, int>
{
    { "Panela", 110 },
    { "Faca", 50 },
    { "Prato", 67},
    { "Mesa", 10},
    { "Armário", 5 }
};

Console.Write("Digite o nome de um produto para pesquisa: ");
string pesquisa = Console.ReadLine()!;

if (produtos.ContainsKey(pesquisa))
{
    Console.WriteLine($"\n\nO produto {pesquisa} possui {produtos[pesquisa]} produtos em estoque");
}
else
{
    Console.WriteLine("Esse produto não está em estoque!");
}