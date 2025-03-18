using LayoutTelaPI.Screen;

namespace LayoutTelaPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void buttonNewWindow_Click(object sender, EventArgs e)
        {
            MenuInicialScreen menuInicialScreen = new MenuInicialScreen();
            menuInicialScreen.Show();
        }

        private void buttonJanela2_Click(object sender, EventArgs e)
        {
            MenuOpcional menuOpcional = new MenuOpcional();
            menuOpcional.Show();
        }
    }
}
