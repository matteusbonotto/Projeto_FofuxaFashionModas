using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FFM.Visual
{
    public partial class sc : Form
    {
        public sc(string msg)
        {
            Mensagem = msg;
            InitializeComponent();
        }
        private int img;
        private string Mensagem;

        private void timerLoop_Tick(object sender, EventArgs e)
        {
            if (img == 15)
            {
                img = 0;
            }
            else
            {
                img++;
            }
            imgLoop.ImageLocation = string.Format("../../Repositorio/{0}.png", img);
        }

        private void ScreenSplash_Load(object sender, EventArgs e)
        {
            img = 0;
            lblMensagem.Text = Mensagem;
            timerLoop.Start();
        }
    }
}

