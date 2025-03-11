using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CadastroAlunos
{
    internal class CadastroAlunos
    {
        public string Nome;
        public int Idade;
        public string Curso;
       

        public CadastroAlunos(string nome, int idade, string curso)
        {
            Nome = nome;
            Idade = idade;
            Curso = curso;
            
        }

        public string GetDetailedInfo()
        {
            return $"Aluno: {Nome} \n Idade: {Idade} \nCurso: {Curso} \n";
        }
        public string AdicionaAluno()
        {
            return "Insira o nome do Aluno";
            Nome = Console.ReadLine();
        }
    }
}
