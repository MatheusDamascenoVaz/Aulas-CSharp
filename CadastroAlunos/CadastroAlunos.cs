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
        public int Matrícula;
        public int AnoLetivo;
       

        public CadastroAlunos(string nome, int matrícula, int anoLetivo, string email, string telefoneDeEmergencia)
        {
            Nome = nome;
            Matrícula = matrícula;
            AnoLetivo = anoLetivo;
            
        }

        public string GetDetailedInfo()
        {
            return $"Aluno: {Nome} \n Matrícula: {Matrícula} \nAno letivo: {AnoLetivo} \n";
        }
            
    }
}
