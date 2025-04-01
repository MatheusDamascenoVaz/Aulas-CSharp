using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoListMVC.Model
{
    public class Tarefa
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public bool Concluida { get; set; }


        public Tarefa(int id, string descricao)
        {
            this.Id = id;
            this.Descricao = descricao;
            this.Concluida = false;
        }
    }
}
