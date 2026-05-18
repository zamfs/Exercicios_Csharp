//Escrever uma função que a partir de dois números de ponto flutuante a e b exiba no console o resultado de suas quatro operações básicas
//(adição, subtração, divisão e multiplicação), utilizando interpolação de strings.

double a = 2.1;
double b = 5.3;

Console.WriteLine($"Adição: {a} + {b} = {(a+b):F2}");
Console.WriteLine($"Subtração: {a} - {b} = {(a-b):F2}");
Console.WriteLine($"Divisão: {a} / {b} = {(a/b):F2}");
Console.WriteLine($"Multiplicação: {a} * {b} = {(a*b):F2}");