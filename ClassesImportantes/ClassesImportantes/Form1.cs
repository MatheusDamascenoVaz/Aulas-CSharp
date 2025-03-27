using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassesImportantes
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        // //////////////////////////////////////////////////////////////////// USO DA MESSAGE BOX 
        private void btnMessageBox_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Olá, sou um botão exibindo uma mensagem");
            //MessageBox.Show("Olá, sou um botão exibindo uma mensagem","Imagine um aviso bem legal aqui");
            //MessageBox.Show("Olá, sou um botão exibindo uma mensagem", "Imagine um aviso bem legal aqui2",MessageBoxButtons.YesNoCancel);
            DialogResult resultadoJanela = MessageBox.Show("Olá, sou um botão exibindo uma mensagem", "Imagine um aviso bem legal aqui3", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning,MessageBoxDefaultButton.Button2);
            if (resultadoJanela == DialogResult.Yes)
            {
                labelResult.Text = "Você selecionou a opção sim";
            }
            else if (resultadoJanela == DialogResult.No)
            {
                labelResult.Text = "Você selecionou a opção não";
            }
            else
            {
                labelResult.Text = string.Empty;
            }

                labelResult2.Text = resultadoJanela.ToString();
        }
        // //////////////////////////////////////////////////////////////// CLASSE RANDOM PARA TRATAR NUMEROS ALEATORIOS
        private void btnRandom_Click(object sender, EventArgs e)
        {
            Random numeroAleatorio = new Random(DateTime.Now.Millisecond);
            labelResult.Text = numeroAleatorio.Next(50,9999).ToString();
            labelResult2.Text = numeroAleatorio.NextDouble().ToString();
        }

        private void btnDateTime_Click(object sender, EventArgs e)
        {
            DateTime dateTime = new DateTime();

            //labelResult.Text = DateTime.Now.ToString();
            labelResult2.Text = DateTime.Now.ToLongDateString();
            labelResult3.Text = DateTime.Now.ToShortDateString();
            labelResult.Text = DateTime.Now.ToLongTimeString();


        }
        // ///////////////////////////////////////////////////////////////////  CLASSE RELACIONADA A CALCULOS COM TEMPO
        private void btnTimeSpam_Click(object sender, EventArgs e)
        {
            //TimeSpan time1 = new TimeSpan(3,30,0);
            TimeSpan time2 = TimeSpan.FromHours(2.7);
            TimeSpan time3 = TimeSpan.FromMinutes(693);
            labelResult.Text = time2.ToString();
            labelResult2.Text = time3.ToString();

            DateTime inicio = DateTime.Now;
            DateTime fim = inicio.AddHours(3);

            TimeSpan time1 = new TimeSpan(3, 30, 0);
            TimeSpan time4 = new TimeSpan(2, 25, 32);

            TimeSpan time5 = time1.Subtract(time4);

            
            labelResult3.Text = time5.ToString();

        }
    }
}
