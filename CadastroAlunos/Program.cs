
using CadastroAlunos;
using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {

        List<Alunos>listaAlunos = new List<Alunos>();
string repeticao;

do
{
    Console.WriteLine("Digite o nome do aluno:");
    string nome = Console.ReadLine();

    Console.WriteLine("Digite a idade do aluno:");
    int idade = int.Parse(Console.ReadLine());

    Console.WriteLine("Digite o curso do aluno:");
    string curso = Console.ReadLine();

    Alunos aluno = new Alunos(nome, idade, curso);
    listaAlunos.Add(aluno);

    Console.WriteLine("Deseja adicionar mais alunos? (s/n)");
    repeticao = Console.ReadLine().ToLower();
} while (repeticao == "s");

Console.WriteLine("\nAlunos cadastrados:");
foreach (var aluno in listaAlunos)
{
    Console.WriteLine($"Nome: {aluno.Nome}\nIdade: {aluno.Idade}\nCurso: {aluno.Curso}");
    Console.WriteLine();
}
    }
}

    



