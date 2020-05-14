using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FFM.Visual.Ucs.Principais
{
    public partial class uc_Bem_Vindo : UserControl
    {
        Visual.Forms.Principais.frm_MenuPrincipal telaInicial;
        string licenca;
        public uc_Bem_Vindo(Forms.Principais.frm_MenuPrincipal telaInicial)
        {
            InitializeComponent();
            this.telaInicial = telaInicial;
            licenca = telaInicial.sLicenca;
            CarregarDados();
        }

        

        private void CarregarDados()
        {
                   
            licenca = telaInicial.sLicenca;
            if (licenca != "Visitante")
            {
                txtDescricao.Text = txtDescricao.Text.Replace("TA ESPERANDO OQUE???", "Parabens!!!"
                + "Vimos que você se cadastrou no sistema, a equipe da FOFUXA FASHION MODAS"
                + "Tem o enorme prazer em receber você."
                + ""
                + "Fique avontade e confira nossos produtos:");
            }
        }
    }
}
