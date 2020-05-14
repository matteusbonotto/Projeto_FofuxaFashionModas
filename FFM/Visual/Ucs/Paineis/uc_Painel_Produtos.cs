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
    public partial class uc_Painel_Produtos : UserControl
    {
        Visual.Forms.Principais.frm_MenuPrincipal telaInicial;

        public uc_Painel_Produtos(Visual.Forms.Principais.frm_MenuPrincipal telaInicial)
        {
            InitializeComponent();
            this.telaInicial = telaInicial;
        }

        private void btnBlusas_Click(object sender, EventArgs e)
        {
            telaInicial.AbrirTela("blusas");
        }

        private void btnCalcas_Click(object sender, EventArgs e)
        {
            telaInicial.AbrirTela("calcas");
        }

        private void btnIntimas_Click(object sender, EventArgs e)
        {
            telaInicial.AbrirTela("intimas");
        }

        private void btnSapatos_Click(object sender, EventArgs e)
        {
            telaInicial.AbrirTela("sapatos");
        }

        private void btnCadastro_Click(object sender, EventArgs e)
        {
            telaInicial.AbrirTela("cadastrarProdutos");
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            telaInicial.AbrirTela("estoque");
        }

        private void btnRelatórios_Click(object sender, EventArgs e)
        {
            telaInicial.AbrirTela("relatorioProdutos");
        }

        
    }
}

