using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FFM.Controle.Pessoa.Usuario;
using FFM.Modelo;

namespace FFM.Visual.Ucs.Principais
{
    public partial class uc_Login : UserControl
    {
        private Forms.Principais.frm_MenuPrincipal telaInicial;
        public uc_Login(Forms.Principais.frm_MenuPrincipal telaInicial)
        {
            InitializeComponent();
            this.telaInicial = telaInicial;
        }

        private void Entrar()
        {
            //Instancio Minha Classe
            ctrl_Login ctrlLogin = new ctrl_Login();
            mdlo_Login mdloLogin = new mdlo_Login();
            ctrlLogin.Email = txtUsuario.Text;
            ctrlLogin.Senha = txtSenha.Text;

            if (ctrlLogin.Verifica_Acesso())
            {
                telaInicial.Autenticado(ctrlLogin.Nome, ctrlLogin.Licenca);
            }
        }
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            Entrar();
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {
            telaInicial.LimparPainel();
        }
    }
}
