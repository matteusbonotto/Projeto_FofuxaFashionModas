using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FFM.Visual.Forms
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }
        private void Entrar()
        {
            Controle.ctrl_Login ctrlLogin = new Controle.ctrl_Login();
            //ctrlLogin.VerificarAcesso(txtUsuario.Text, txtSenha.text);
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Entrar();
        }
    }
}
