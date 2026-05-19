//Crie uma lista de inteiros utilizando o List<int> e
//utilize o for e o foreach para iterar sobre essa lista e exibir apenas os números pares.

List<int> numeros = [3, 4, 6, 1, 11, 45, 34];

Console.WriteLine("Usando apenas for: \n");
for (int i = 0; i < numeros.Count; i++)
{
    if (numeros[i] % 2 == 0)
    {
        Console.WriteLine(numeros[i]);
    }
}

Console.WriteLine("\nUsando foreach: \n");
foreach (int numero in numeros)
{
    if (numero % 2 == 0) 
    {
        Console.WriteLine(numero);
    }
}