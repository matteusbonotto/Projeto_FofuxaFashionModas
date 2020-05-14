using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FFM.Visual.Ucs
{
    public partial class uc_Painel_Principal : UserControl
    {
        Visual.Forms.Principais.frm_MenuPrincipal telaInicial;

        public uc_Painel_Principal()
        {
            InitializeComponent();
        }

        public uc_Painel_Principal(Visual.Forms.Principais.frm_MenuPrincipal telaInicial)
        {
            InitializeComponent();
            this.telaInicial = telaInicial;
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCadastro_Usuario_Click(object sender, EventArgs e)
        {
            
        }
    }
}