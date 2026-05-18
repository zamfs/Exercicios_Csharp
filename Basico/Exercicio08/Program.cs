//Criar um programa que calcula a soma de todos os elementos inteiros em uma lista.

List<int> numeros = [2, 5, 6, 3, 5];

int soma = 0;

for (int i = 0; i < numeros.Count; i++)
{
    soma += numeros[i];
}

Console.WriteLine($"Soma de todos os elementos: {soma}");