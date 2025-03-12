
using CadastroAlunos;
using System;
using System.Data;

class Program
{
    static void Main(string[] args)
    {

string repeticao;

do
{
    Alunos.AdicionarAluno();
                
    Console.WriteLine("Deseja adicionar mais alunos? (s/n)");
    repeticao = Console.ReadLine().ToLower();
} while (repeticao == "s");

Console.WriteLine("\nAlunos cadastrados:");

        Alunos.VisualizarAlunos();
    }
}

    



