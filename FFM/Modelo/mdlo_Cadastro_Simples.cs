using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FFM.Modelo
{
    public class mdlo_Cadastro_Simples
    {
        private String sTabela;
        private Controle.Produto.Produto_Categoria ProdutoCategoria;
        public void Cadastrar_Descricao()
        {
            ProdutoCategoria = new Controle.Produto.Produto_Categoria();
            try
            {
                // ProdutoCategoria.SProduto_Descricao_Categoria

            }
            catch
            {

            }
        }
        public void Editar_Descricao()
        {

        }

        public void Excluir_Descricao()
        {

        }

        public void Listar_Descricao()
        {

        }


//        con = new MySqlConnection();
//        crudv = new VIRTUAL.Virtual_Produto();
//            conexao = new CONEXAO.conexao();
//            con.ConnectionString = conexao.getConnectionString();
//            String query = "INSERT INTO produtos(nome, empresa, preco_compra, preco_venda, quantidade,codigo, vencimento)";
//        query += " VALUES (?nome, ?empresa, ?preco_compra, ?preco_venda, ?quantidade, codigo, vencimento)";
//            try
//            {
//                con.Open();
//                MySqlCommand cmd = new MySqlCommand(query, con);
//        cmd.Parameters.AddWithValue("?nome", _sNome);
//                cmd.Parameters.AddWithValue("?empresa", _sEmpresa);
//                cmd.Parameters.AddWithValue("?categoria", _sCategoria);
//                cmd.Parameters.AddWithValue("?preco_compra", _dPreco_compra);
//                cmd.Parameters.AddWithValue("?preco_venda", _dPreco_venda);
//                cmd.Parameters.AddWithValue("?quantidade", _iQuantidade);
//                cmd.Parameters.AddWithValue("?codigo", _sCodigo);
//                cmd.Parameters.AddWithValue("?vencimento", _sVencimento);
//                cmd.ExecuteNonQuery();
//                cmd.Dispose();
//                Utilitarios.MsgSucesso("Cadastrado com Sucesso!!!");
//            }

//            catch (Exception ex)
//            {
//                Utilitarios.MsgErro("DAO.CRUD_Produto.InserirDados" + ex);
//            }

//            finally
//            {
//                con.Close();
//            }
//        }
//        public void AtualizarDados(String _sNome, String _sEmpresa, String _sCategoria, Double _fPreco_compra, Double _fPreco_venda, Int32 _iQuantidade, String _sCodigo, String _sVencimento, Int32 _iID)
//{
//    con = new MySqlConnection();
//    crudv = new VIRTUAL.Virtual_Produto();
//    conexao = new CONEXAO.conexao();
//    con.ConnectionString = conexao.getConnectionString();
//    String query = "UPDATE produtos SET nome = ?nome, empresa = ?empresa, categoria = ?categoria, preco_compra = ?preco_compra, preco_venda = ?preco_venda, quantidade = ?quantidade, codigo = ?codigo, vencimento = ?vencimento  WHERE id = ?id";

//    try
//    {
//        con.Open();
//        MySqlCommand cmd = new MySqlCommand(query, con);
//        cmd.Parameters.AddWithValue("?nome", _sNome);
//        cmd.Parameters.AddWithValue("?empresa", _sEmpresa);
//        cmd.Parameters.AddWithValue("?categoria", _sCategoria);
//        cmd.Parameters.AddWithValue("?preco_compra", _sNome);
//        cmd.Parameters.AddWithValue("?preco_venda", _sNome);
//        cmd.Parameters.AddWithValue("?quantidade", _sNome);
//        cmd.Parameters.AddWithValue("?codigo", _sNome);
//        cmd.Parameters.AddWithValue("?vencimento", _sNome);
//        cmd.Parameters.AddWithValue("?id", _iID);
//        cmd.ExecuteNonQuery();
//        cmd.Dispose();
//        Utilitarios.MsgSucesso("Alterado com Sucesso!!!");
//    }
//    catch (Exception ex)
//    {
//        Utilitarios.MsgErro("Erro ao Alterar dados" + ex);
//    }
//    finally
//    {
//        con.Close();
//    }
//}
//public void RemoverDados(Int32 _iID)
//{
//    Utilitarios.MsgAviso("Tem certeza que deseja continuar?");
//    con = new MySqlConnection();
//    crudv = new VIRTUAL.Virtual_Produto();
//    conexao = new CONEXAO.conexao();
//    con.ConnectionString = conexao.getConnectionString();
//    string query = "DELETE FROM produtos WHERE id = ?id";

//    try
//    {
//        con.Open();
//        MySqlCommand cmd = new MySqlCommand(query, con);
//        cmd.Parameters.AddWithValue("?id", _iID);
//        cmd.ExecuteNonQuery();
//        cmd.Dispose();
//        Utilitarios.MsgSucesso("Removido com Sucesso!!!");
//    }
//    catch (Exception ex)
//    {
//        Utilitarios.MsgErro("DAO.CRUD_Produto.RemoverDados" + ex);
//    }
//}


    }
}