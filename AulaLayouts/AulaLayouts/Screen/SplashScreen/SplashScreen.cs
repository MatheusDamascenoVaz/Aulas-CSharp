using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AulaLayouts
{
    public partial class SplashScreen: Form
    {
        public SplashScreen()
        {
            InitializeComponent();
        }

        private void SplashScreen_Load(object sender, EventArgs e)
        {
            CloseSplashScreen();
        }

        private async void CloseSplashScreen()
        {
            await Task.Delay(3000);
            this.Close();
        }
    }
}
