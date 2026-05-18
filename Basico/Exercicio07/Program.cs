// Criar uma lista de comidas vazia e adicionar suas comidas prediletas em seguida.

using System.ComponentModel.DataAnnotations;

List<string> comidas = new List<string>();

do
{
    Console.WriteLine("Digite uma comida predileta (digite parar para não continuar)");
    Console.Write("Digite: ");
    string comida = Console.ReadLine()!;

    if (comida == "parar") break;

    comidas.Add(comida);

} while (true);

for (int i = 0; i < comidas.Count; i++)
{
    Console.WriteLine("\n{0}: {1}",i+1, comidas[i]);
}
