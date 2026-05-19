//Criar um dicionário que represente um aluno, com uma lista de notas, e mostre a média de suas notas na tela
using System.Xml;

Dictionary<string, List<double>> alunos = new Dictionary<string, List<double>>
{
    {"Fernando", new List<double> { 5.2, 7.6, 8.7 } },
    {"Ana", new List<double> { 6.7, 9.8, 8.9 } },
    {"Lucas", new List<double> { 5.4, 6.7, 8.1 } }
};

foreach (KeyValuePair<string, List<double>> aluno in alunos)
{
    double media = new double();
    foreach(double nota in aluno.Value)
    {
        media += nota;
    }
    media /= aluno.Value.Count;

    Console.WriteLine($"\nAluno: {aluno.Key}\nMédia: {media:F2}\nNota 1: {aluno.Value[0]:F2} Nota 2: {aluno.Value[1]:F2} Nota 3: {aluno.Value[2]:F2}");
}

