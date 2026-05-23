//Desenvolver a classe Produto, com os atributos nome, marca, preco e estoque.
//Além disso, garantir que o preço e o estoque do produto sejam valores positivos e criar uma propriedade que mostra
//detalhadamente as informações do produto,

Produto leite = new Produto();
leite.Nome = "Leite";
leite.Marca = "Itambé";
leite.Preco = 23.65;
leite.Estoque = 500;
Console.WriteLine(leite.InformacoesProduto);

Produto acucar = new Produto();
acucar.Nome = "Açúcar";
acucar.Marca = "Cristal";
acucar.Preco = 5.33;
acucar.Estoque = 0;
Console.WriteLine(acucar.InformacoesProduto);

Produto pao = new Produto();
pao.Nome = "Pão";
pao.Marca = "Puma";
pao.Preco = -2.43;
pao.Estoque = 120;
Console.WriteLine(pao.InformacoesProduto);

Produto refrigerante = new Produto();
refrigerante.Nome = "Refrigerante";
refrigerante.Marca = "Coca-Cola";
refrigerante.Preco = 0.00;
refrigerante.Estoque = -23;
Console.WriteLine(refrigerante.InformacoesProduto);

class Produto
{
    public string Nome { get; set; }
    public string Marca { get; set; }
    private double preco;
    public double Preco 
    {
        get { return preco; }
        set
        {
            if (value > 0)
            {
                preco = value;
            }
            else
            {
                Console.WriteLine("\nApenas valores positivos são aceitos!");
            }
        } 
    }
    private int estoque;
    public int Estoque 
    {
        get { return estoque; }
        set
        {
            if (value > 0)
            {
                estoque = value;
            }
            else
            {
                Console.WriteLine("\nApenas valores positivos são aceitos!");
            }
        } 
    }

    public string InformacoesProduto 
    {
        get
        {
            if (preco <= 0 && estoque <= 0)
            {
                return $"\n\nNome: {Nome}\nMarca: {Marca}\nPreço: Valor Inválido!\nQuantidade em estoque: Valor Inválido!";
            } else if (preco > 0 && estoque <= 0)
            {
                return $"\n\nNome: {Nome}\nMarca: {Marca}\nPreço: {Preco}\nQuantidade em estoque: Valor Inválido!";
            } else if (preco <= 0 && estoque > 0)
            {
                return $"\n\nNome: {Nome}\nMarca: {Marca}\nPreço: Valor Inválido!\nQuantidade em estoque: {Estoque}";
            } else
            {
                return $"\n\nNome: {Nome}\nMarca: {Marca}\nPreço: {Preco}\nQuantidade em estoque: {Estoque}";
            }
        } 
    }
}