// Criar uma função que receba um número inteiro como parâmetro e retorne se ele é positivo, negativo ou zero.
string VerificarNumero(int numero)
{
    if (numero > 0)
    {
        return "Número positivo!";
    }
    else if (numero < 0)
    {
        return "Número negativo!";
    }
    else
    {
        return "Número 0!";
    }
}

Console.Write("Digite um número: ");
string num = Console.ReadLine();
int numInt = int.Parse(num);

Console.WriteLine(VerificarNumero(numInt));