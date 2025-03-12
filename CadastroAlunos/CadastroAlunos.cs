using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroAlunos
{
    internal class Alunos
    {
        public string Nome;
        public int Idade;
        public string Curso;

        public Alunos(string nome, int idade, string curso)
        {
            Nome = nome;
            Idade = idade;
            Curso = curso;
        }

        public static List<Alunos> listaAlunos = new List<Alunos>();


           public static void AdicionarAluno() {

            Console.WriteLine("Digite o nome do aluno:");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite a idade do aluno:");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o curso do aluno:");
            string curso = Console.ReadLine();

            Alunos aluno = new Alunos(nome, idade, curso);

            listaAlunos.Add(aluno);
        }

        public static void VisualizarAlunos() {

            foreach (var aluno in listaAlunos)
            {
                Console.WriteLine($"Nome: {aluno.Nome}\nIdade: {aluno.Idade}\nCurso: {aluno.Curso}");
                Console.WriteLine();
            }

        }


    }
}





