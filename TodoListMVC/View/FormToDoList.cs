using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TodoListMVC.Controller;

namespace TodoListMVC.View
{
    public partial class FormToDoList : Form
    {
      
private TodoController _controller;

        public FormTodoList()
        {
            InitializeComponent();
            _controller = new TodoController();
            AtualizarLista();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtTarefa.Text))
            {
                _controller.AdicionarTarefa(txtTarefa.Text);
                txtTarefa.Clear();
                AtualizarLista();
            }
        }

        private void AtualizarLista()
        {
            listBoxTarefas.DataSource = null;
            listBoxTarefas.DataSource = _controller.ObterTarefas();
            listBoxTarefas.DisplayMember = "Descricao";
        }
    }


}

