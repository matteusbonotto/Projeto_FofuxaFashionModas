using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace FFM.Modelo
{
    public class mdlo_Produto : mdlo_Cadastro_Simples
    {
        private Conexao.clsConexao conexao;
        private MySqlCommand cmd;

        public bool Cadastrar_Produto(Int32 _iID_Produto, /*byte[] _imgImagem, */String _sNome_Produto, String _sDescricao_Produto, String _sCor, String _sCategoria, String _sTamanho, Int32 _iQuantidade, String _sCodigo_Barras, Double _dPreco_Compra, Double _dPreco_Venda)
        {
            Visual.Ucs.Cadastros.uc_Cadastro_Produtos cadastroProdutos = new Visual.Ucs.Cadastros.uc_Cadastro_Produtos();
            conexao = new Conexao.clsConexao();
            cmd = new MySqlCommand();
            try
            {
                if (conexao.OpenConnection())
                {
                    cmd = new MySqlCommand("Adicionar_Produto", conexao.con);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("DESCRICAO_CATEGORIA_PRODUTO", _sCategoria);
                    cmd.Parameters.AddWithValue("CODIGO_BARRAS_PRODUTO", _sCodigo_Barras);
                    cmd.Parameters.AddWithValue("PRECO_VENDA_PRODUTO", _dPreco_Venda);
                    cmd.Parameters.AddWithValue("PRECO_COMPRA_PRODUTO", _dPreco_Compra);
                    cmd.Parameters.AddWithValue("QUANTIDADE_PRODUTO", _iQuantidade);
                    cmd.Parameters.AddWithValue("NOME_PRODUTO_DETALHES", _sNome_Produto);
                    cmd.Parameters.AddWithValue("DESCRICAO_PRODUTO_DETALHES", _sDescricao_Produto);
                    cmd.Parameters.AddWithValue("COR_PRODUTO_DETALHES", _sCor);
                    cmd.Parameters.AddWithValue("TAMANHO_PRODUTO_DETALHES", _sTamanho);
                    //conexao.cmd.Parameters.AddWithValue("IMAGEM_PRODUTO_DETALHES", ctrlDetalhe.ImgImagem);
                    cmd.ExecuteNonQuery();


                    int Retorno = cmd.ExecuteNonQuery();
                    if (Retorno != 0)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                Utilitario.util_Msgbox.Aviso("Erro em:" + ex);
                return false;

            }
            finally
            {
                conexao.CloseConnection();
            }
            return true;
        }
        public bool Editar_Produto(Int32 _iID_Produto, byte[] _imgImagem, String _sNome_Produto, String _sDescricao_Produto, String _sCor, String _sCategoria, String _sTamanho, Int32 _iQuantidade, String _sCodigo_Barras, Double _dPreco_Compra, Double _dPreco_Venda)
        {
            try
            {

            }
            catch
            {

            }
            return true;
        }
        public bool Excluir_Produto(Int32 _iID_Produto, byte[] _imgImagem, String _sNome_Produto, String _sDescricao_Produto, String _sCor, String _sCategoria, String _sTamanho, Int32 _iQuantidade, String _sCodigo_Barras, Double _dPreco_Compra, Double _dPreco_Venda)
        {
            try
            {

            }
            catch
            {

            }
            return true;
        }
        public bool Listar_Produto(Int32 _iID_Produto, byte[] _imgImagem, String _sNome_Produto, String _sDescricao_Produto, String _sCor, String _sCategoria, String _sTamanho, Int32 _iQuantidade, String _sCodigo_Barras, Double _dPreco_Compra, Double _dPreco_Venda)
        {
            try
            {

            }
            catch
            {

            }
            return true;
        }
    }
}