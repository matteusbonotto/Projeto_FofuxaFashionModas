using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FFM.Conexao;
using FFM.Controle;
using MySql.Data.MySqlClient;
namespace FFM.Visual.Ucs.Cadastros
{
    public partial class uc_Cadastro_Produtos : UserControl
    {
        private long tamanhoArquivoImagem = 0;
        public byte[] vetorImagens;
        private clsConexao Conexao;
        private Controle.Produto.ctrl_Produto ctrlProduto;
        public uc_Cadastro_Produtos()
        {
            InitializeComponent();
        }
        private void Listar_Produtos()
        {
            pnl_Listar_Produtos.Controls.Clear();
            for (int i = 0; i < 5; i++)
            {
                uc_ListarProdutos_Pequeno uc_Listar_Produtos_Pequeno = new uc_ListarProdutos_Pequeno();
                pnl_Listar_Produtos.Controls.Add(uc_Listar_Produtos_Pequeno);
                uc_Listar_Produtos_Pequeno.Location = new Point(0, i * 94);
            }

        }
        public void CarregaImagem()
        {
            try
            {
                this.openFileDialog1.ShowDialog(this);
                string strFn = this.openFileDialog1.FileName;

                if (string.IsNullOrEmpty(strFn))
                    return;

                this.pictureBox1.Image = Image.FromFile(strFn);
                FileInfo arqImagem = new FileInfo(strFn);
                tamanhoArquivoImagem = arqImagem.Length;
                FileStream fs = new FileStream(strFn, FileMode.Open, FileAccess.Read, FileShare.Read);
                vetorImagens = new byte[Convert.ToInt32(this.tamanhoArquivoImagem)];
                int iBytesRead = fs.Read(vetorImagens, 0, Convert.ToInt32(this.tamanhoArquivoImagem));
                fs.Close();
                txtNomeArquivo.Text = strFn;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCadastrarProduto_Click(object sender, EventArgs e)
        {
            try
            {
                ctrlProduto = new Controle.Produto.ctrl_Produto();
                ctrlProduto.Cadastrar_Produtos(Convert.ToInt32(null), /*Convert.ToByte(txtNomeArquivo.Text),*/ txtNomeProduto.Text, txtDescricao_Produto.Text, txtCor.Text,
                cboCategoria.Text, cboTamanho.Text, Convert.ToInt32(txtQuantidade.Text), txtCodigo_Barras.Text, Convert.ToDouble(txtCompra.Text), Convert.ToDouble(txtVenda.Text));
                Utilitario.util_Msgbox.Sucesso("Produto Cadastrado Com Sucesso!");
            }
            catch(Exception ex)
            {
                Utilitario.util_Msgbox.Aviso("Erro: " + ex);
            }
            finally
            {

            }
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Listar_Produtos();
        }

        private void btnPesquisarImagem_Click(object sender, EventArgs e)
        {
            CarregaImagem();
        }

        private void btnListar_Produtos_Click(object sender, EventArgs e)
        {
            Listar_Produtos();
        }
    }
}
