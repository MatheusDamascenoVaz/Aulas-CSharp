namespace Calculadora_V4
{
    public partial class Form1 : Form
    {
        public decimal Resultado;
        public decimal Valor;

        private Operacao OperacaoSelecionada;
        private enum Operacao                                                                      
        {                                                                               //\\  
            Adicao,                                                                    //  \\
            Subtracao,                                                                //    \\     
            Multiplicacao,                                                           //      \\
            Divisao                                                                 //        \\
                                                                                   //          \\         
        }                                                                         //            \\    
                                                                                 /////////\\\\\\\\\              
        public Form1()                                                          
        {
            InitializeComponent();
        }



        private void Button0_Click(object sender, EventArgs e)
        {
            textBox1.Text += "0";
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += "1";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += "2";
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += "3";
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += "4";
        }

        private void Button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += "5";
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += "6";
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            textBox1.Text += "7";
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += "8";
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += "9";
        }

        private void ButtonDiv_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Divisao;
            Valor = Convert.ToDecimal(textBox1.Text);
            textBox1.Text = "";
            label1.Text = "/";
        }
        
        private void ButtonMult_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Multiplicacao;
            Valor = Convert.ToDecimal(textBox1.Text);
            textBox1.Text = "";
            label1.Text = "*";
        }

        private void ButtonSub_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Subtracao;
            Valor = Convert.ToDecimal(textBox1.Text);
            textBox1.Text = "";
            label1.Text = "-";
        }

        private void ButtonSoma_Click(object sender, EventArgs e)
        {
            OperacaoSelecionada = Operacao.Adicao;
            Valor = Convert.ToDecimal(textBox1.Text);
            textBox1.Text = "";
            label1.Text = "+";
        }

        private void ButtonIgual_Click(object sender, EventArgs e)
        {
            switch (OperacaoSelecionada)
            {
                case Operacao.Adicao:
                    Resultado = Valor + Convert.ToDecimal(textBox1.Text);
                    break;
                case Operacao.Subtracao:
                    Resultado = Valor - Convert.ToDecimal(textBox1.Text);
                    break;
                case Operacao.Multiplicacao:
                    Resultado = Valor * Convert.ToDecimal(textBox1.Text);
                    break;
                case Operacao.Divisao:
                    Resultado = Valor / Convert.ToDecimal(textBox1.Text);
                    break;
            }
            textBox1.Text = Convert.ToString(Resultado);
        }

        private void ButtonVirg_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains(","))
                textBox1.Text += ",";
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            label1.Text = "";
        }
    }
}
