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

namespace FFM.Visual.Forms.Cadastros
{
    public partial class frm_Cadastrar_Produtos : Form
    {
        private String sTitulo;
        private String sDescricao;
        private String sCor;
        private String sTam;
        private String iQuantidade;
        private Double dValor;
        private long tamanhoArquivoImagem = 0;
        public byte[] vetorImagens;
        private clsConexao Conexao;
        

        public frm_Cadastrar_Produtos()
        {
            InitializeComponent();
            
        }

        private void Listar_Produtos()
        {
            pnl_Listar_Produtos.Controls.Clear();
            //for (int i = 0; i < Produtos.Count; i++)
            for (int i = 0; i < 5; i++)
            {
                //Ucs.uc_ListaProdutos uc_Listar_Produtos = new Ucs.uc_ListaProdutos(pass the person object);
                Ucs.uc_ListarProdutos_Pequeno uc_Listar_Produtos = new Ucs.uc_ListarProdutos_Pequeno();
                pnl_Listar_Produtos.Controls.Add(uc_Listar_Produtos);
                uc_Listar_Produtos.Location = new Point(0, i * 94);
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

        public void Carregaimgem_DB()
        {
            if (txtId.Text == string.Empty)
            {
                Utilitario.util_Msgbox.Aviso("Informe o código da imagem no Banco de dados");
                return;
            }
            Conexao = new clsConexao();
            MySqlConnection con = new MySqlConnection(Conexao.sGlob_Conexao);
            try
            {


                con.Open();
                MySqlCommand cmdSelect = new MySqlCommand("select Imagem_Produto from Produtos where id_Produto=@ID", con);
                cmdSelect.Parameters.AddWithValue("@ID", txtId.Text);
                byte[] vetorImagem = (byte[])cmdSelect.ExecuteScalar();
                string strNomeArquivo = Convert.ToString(DateTime.Now.ToFileTime());
                FileStream fs = new FileStream(strNomeArquivo, FileMode.CreateNew, FileAccess.Write);
                fs.Write(vetorImagem, 0, vetorImagem.Length);
                fs.Flush();
                fs.Close();

                pictureBox1.Image = Image.FromFile(strNomeArquivo);
            }
            catch (Exception ex)
            {
                Utilitario.util_Msgbox.Aviso(ex.Message);
            }
            finally
            {
                con.Clone();
            }
        }

        private void Salvar_imgem_DB()
        {
            if (txtId.Text == string.Empty)
            {
                Utilitario.util_Msgbox.Aviso("Informe o código da imagem no Banco de dados");
                return;
            }
            Conexao = new clsConexao();
            MySqlConnection con = new MySqlConnection(Conexao.sGlob_Conexao);
            try
            {
                con.Open();
                MySqlCommand sqlcmd = new MySqlCommand();
                sqlcmd.Connection = con;
                sqlcmd.CommandText = "INSERT INTO Produtos(Imagem_Produto) values(@Imagem)";
                sqlcmd.Parameters.AddWithValue("@Imagem", vetorImagens);

                int iresultado = sqlcmd.ExecuteNonQuery();
                if (iresultado <= 0)
                    MessageBox.Show("Falha ao incluir imagem no banco de dados.");
            }
            catch (Exception ex)
            {
                Utilitario.util_Msgbox.Aviso(ex.Message);
            }
            finally
            {
                con.Clone();
            }
        }
        private void button2_Click(object sender, EventArgs e)
        {
            CarregaImagem();
        }

        private void btnCadastrarProduto_Click(object sender, EventArgs e)
        {
            CRUD crud = new CRUD();
            ctrl_Cadastro_Produto Cadastro_Produtos = new ctrl_Cadastro_Produto();
            Salvar_imgem_DB();
            Cadastro_Produtos.Cadastrar_Produto(Convert.ToInt32(txtId.Text), txtNomeArquivo.Text, txtNomeProduto.Text, txtDescricao_Produto.Text, txtCor.Text, cboCategoria.Text, cboTamanho.Text, txtCodigo_Barras.Text, Convert.ToDouble(txtPreco_Conpra_Produto.Text), Convert.ToDouble(txtPreco_Venda_Produto.Text)); //Colocar dados para cadastrar produto
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //Carregaimgem_DB();
            Listar_Produtos();
        }
    }
}

