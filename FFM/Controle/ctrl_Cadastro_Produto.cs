using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace FFM.Controle
{
    //class ctrl_Cadastro_Produto
    //{
    //    private long tamanhoArquivoImagem = 0;
    //    private byte[] vetorImagens;
    //    Conexao.clsConexao conexao = new Conexao.clsConexao();
    //    protected void CarregaImagem()
    //    {
    //        try
    //        {
    //            this.openFileDialog1.ShowDialog(this);
    //            string strFn = this.openFileDialog1.FileName;

    //            if (string.IsNullOrEmpty(strFn))
    //                return;

    //            this.picImagem.Image = Image.FromFile(strFn);
    //            FileInfo arqImagem = new FileInfo(strFn);
    //            tamanhoArquivoImagem = arqImagem.Length;
    //            FileStream fs = new FileStream(strFn, FileMode.Open, FileAccess.Read, FileShare.Read);
    //            vetorImagens = new byte[Convert.ToInt32(this.tamanhoArquivoImagem)];
    //            int iBytesRead = fs.Read(vetorImagens, 0, Convert.ToInt32(this.tamanhoArquivoImagem));
    //            fs.Close();
    //        }
    //        catch (Exception ex)
    //        {
    //            MessageBox.Show(ex.Message);
    //        }
    //    }

    //    public void Retorna_Img_Db()
    //    {
    //        if (txtCodigoImagem.Text == string.Empty)
    //        {
    //            MessageBox.Show("Informe o código da imagem no Banco de dados", "Código da Imagem", MessageBoxButtons.OK, MessageBoxIcon.Information);
    //            return;
    //        }

    //        try
    //        {
    //            SqlCommand cmdSelect = new SqlCommand("select imagem from Imagens where id=@ID", this.conexaoSQLServer);
    //            cmdSelect.Parameters.Add("@ID", SqlDbType.Int, 4);
    //            cmdSelect.Parameters["@ID"].Value = this.txtCodigoImagem.Text;

    //            this.conexaoSQLServer.Open();
    //            byte[] vetorImagem = (byte[])cmdSelect.ExecuteScalar();
    //            string strNomeArquivo = Convert.ToString(DateTime.Now.ToFileTime());
    //            FileStream fs = new FileStream(strNomeArquivo, FileMode.CreateNew, FileAccess.Write);
    //            fs.Write(vetorImagem, 0, vetorImagem.Length);
    //            fs.Flush();
    //            fs.Close();

    //            picImagem.Image = Image.FromFile(strNomeArquivo);
    //        }
    //        catch (Exception ex)
    //        {
    //            MessageBox.Show(ex.Message);

    //        }
    //        finally
    //        {
    //            this.conexaoSQLServer.Close();

    //        }
    //    }
    //}
}
