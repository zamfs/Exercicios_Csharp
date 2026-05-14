//Criar um programa que, dado a entrada de dados de um número n inteiro, a partir do teclado, exibir a n-ésima posição de uma lista.
List<int> listaExemplo = new List<int>() { 21, 43, 54, 3 };

Console.Write("Escolha um índice de uma lista que vai de 0-3: ");
int num = int.Parse(Console.ReadLine());

Console.WriteLine($"O número nesse índice é: {listaExemplo[num]}");

