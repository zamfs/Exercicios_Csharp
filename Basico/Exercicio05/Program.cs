// Chegou a hora de você seguir todos os passos realizados durante esta aula e criar um jogo com os conhecimentos adquiridos.

//Neste jogo, o programa gera um número aleatório entre 1 e 100 e o usuário deve adivinhar qual é esse número.
//O programa utiliza o if-else e switch case para verificar se o número digitado pelo usuário é maior ou menor do que o
//número gerado pelo programa.

//O programa também utiliza o conceito de laço de repetição do-while para permitir que o usuário faça várias
//tentativas até acertar o número. Quando o usuário acertar o número, o jogo acaba e o programa exibe uma
//mensagem indicando que o jogo acabou.

Random random = new Random();

int numeroSecreto = random.Next(1, 101);


do
{
    Console.Write("Tente adivinhar o número secreto: ");
    int num = int.Parse(Console.ReadLine());


    if (num > numeroSecreto)
    {
        Console.WriteLine("Seu número foi maior que o número secreto!");
    }
    else if (num < numeroSecreto)
    {
        Console.WriteLine("Seu número foi menor do que o número secreto!");
    }
    else
    {
        Console.WriteLine("Acertou!!");
        break;
    }
} while (true);

Console.WriteLine("Você acertou e o jogo acabou! Parabéns!!");