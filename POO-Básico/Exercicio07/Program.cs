//Desenvolver uma classe que represente um estoque de produtos, e que tenha as funcionalidades de adicionar novos produtos,
//e exibir todos os produtos no estoque.

List<Estoque> produtosEmEstoque = new List<Estoque>();

do
{
    Estoque produto = new Estoque();

    produto.adicionarProduto(produto, produtosEmEstoque);
    
    Console.Write("\nSe não quiser adicionar outro produto digite 0: ");
    string continuar = Console.ReadLine()!;
    if (continuar == "0")
    {
        produto.exibirEstoque(produtosEmEstoque);
        break;
    }
} while (true);


class Estoque
{
    public string nome;
    public int quantidade;

    public void adicionarProduto(Estoque produto, List<Estoque> lista)
    {
        Console.WriteLine("\nADICIONAR PRODUTO:");
        Console.Write("Nome: ");
        produto.nome = Console.ReadLine()!;
        Console.Write("Quantidade: ");
        produto.quantidade = int.Parse(Console.ReadLine()!);

        lista.Add(produto);
    }

    public void exibirEstoque(List<Estoque> lista)
    {
        Console.Clear();
        Console.WriteLine("\nESTOQUE DISPONÍVEL: ");

        foreach (var produto in lista)
        {
            Console.WriteLine($"\nNome: {produto.nome}\nQuantidade disponível: {produto.quantidade}");
        }
    }
}