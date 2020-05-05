using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FFM.Visual.Forms.Cadastros
{
    public partial class frmListarProdutos : Form
    {
        String sTitulo;
        String sDescricao;
        String sCor;
        String sTam;
        String iQuantidade;
        Double dValor;

        public frmListarProdutos()
        {
            InitializeComponent();
            Listar_Produtos();
        }
        private void Listar_Produtos()
        {
            //for (int i = 0; i < Produtos.Count; i++)
                for (int i = 0; i < 5; i++)
            {
                //Ucs.uc_ListaProdutos uc_Listar_Produtos = new Ucs.uc_ListaProdutos(pass the person object);
                Ucs.uc_ListaProdutos uc_Listar_Produtos = new Ucs.uc_ListaProdutos();
                pnl_ListarProdutos.Controls.Add(uc_Listar_Produtos);
                uc_Listar_Produtos.Location = new Point(0, i * 155);
            }
        }
    }
}