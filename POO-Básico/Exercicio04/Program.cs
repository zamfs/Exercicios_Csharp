//Reescrever os atributos da classe Carro, de modo que eles sejam properties, e adicionar uma nova propertie DescricaoDetalhada,
//que mostra o fabricante, modelo e ano do carro.
//Reescrever a propriedade Ano da classe carro, para que ela apenas aceite valores entre 1960 e 2023.

Carro uno = new Carro();
uno.Fabricante = "Fiat";
uno.Ano = 2000;
Console.WriteLine(uno.DescricaoCompleta);

Carro celta = new Carro();
celta.Fabricante = "Chevrolet";
celta.Ano = 2006;
Console.WriteLine(celta.DescricaoCompleta);

Carro bmw = new Carro();
bmw.Fabricante = "BMW";
bmw.Ano = 2026;
Console.WriteLine(bmw.DescricaoCompleta);

class Carro
{
    public string Fabricante { get; set; }
    private int ano;
    public int Ano 
    {
        get { return ano; }
        set 
        {
            if (value >= 1960 && value <= 2023)
            {
                ano = value;
            }   else
            {
                Console.WriteLine("\nAno do carro não aceito!");
            }
        } 
    }
    public string DescricaoCompleta 
    { 
        get 
        {
            if (ano != 0)
            {
                return $"\nFabricante do carro: {Fabricante}. Ano: {Ano}";
            } else
            {
                return $"\nFabricante do carro: {Fabricante}. Ano: Inválido!";
            }
            
        } 
    }
}