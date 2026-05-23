//No C#, uma função lambda pode ser aplicada em atributos, propriedades ou na forma como escrevemos funções.
//Abaixo, existe uma função que soma 2 valores inteiros e retorna o resultado da soma

int num1 = 2;
int num2 = 5;

Func<int, int, int> somar = (a, b) => a + b;

Console.WriteLine(somar(num1,num2));
