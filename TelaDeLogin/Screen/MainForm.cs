using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TelaDeLogin
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            this.FormClosing += ApplicationClose;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
        private void ApplicationClose(object sender, FormClosingEventArgs e)
        {
            DialogResult resultadoAcao = MessageBox.Show("Você deseja realmente fechar a aplicação?", "Sair da aplicação?", MessageBoxButtons.YesNo);

            if (resultadoAcao == DialogResult.Yes)
            {
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
