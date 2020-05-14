using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FFM.Visual.Ucs.Cadastros
{
    public partial class uc_ListarProdutos : UserControl
    {
        String sTitulo;
        String sDescricao;
        String sCor;
        String sTam;
        String iQuantidade;
        Double dValor;
        Visual.Forms.Principais.frm_MenuPrincipal telaInicial;
        public uc_ListarProdutos(Forms.Principais.frm_MenuPrincipal telaInicial)
        {
            InitializeComponent();
            this.telaInicial = telaInicial;
            Listar_Produtos();
        }

        private void Listar_Produtos()
        {
            for (int i = 0; i < 15; i++)
            {
                Ucs.Cadastros.uc_ListaProdutos uc_Listar_Produtos = new Ucs.Cadastros.uc_ListaProdutos();
                flowLayoutPanel1.Controls.Add(uc_Listar_Produtos);
                uc_Listar_Produtos.Location = new Point(0, i * 75);
            }
        }

        private void btnVoltar_Click(object sender, EventArgs e)
        {

        }

        private void btnBloco_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 15; i++)
            {
                flowLayoutPanel1.Controls.Clear();
               Ucs.Cadastros.uc_ListarProdutos_Pequeno uc_Listar_Produtos = new Ucs.Cadastros.uc_ListarProdutos_Pequeno();
                flowLayoutPanel1.Controls.Add(uc_Listar_Produtos);
                uc_Listar_Produtos.Location = new Point(0, i * 75);
            }
        }
    }
}

