using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace FFM.Modelo
{
    public class CRUDPessoa : mdlo_Cadastro_Simples
    {
        Conexao.clsConexao conexao = new Conexao.clsConexao();
        public bool Cadastrar_Pessoa()
        {
            conexao = new Conexao.clsConexao();
            String[] parametros = new string[13];
            String nomeProcedure = "Cadastrar_Pessoa";
            parametros[0] = ""; //Valor Recebida da Controle, ""Textbox""
            parametros[1] = "";
            parametros[2] = "";
            parametros[3] = "";
            parametros[4] = "";
            parametros[5] = "";
            parametros[6] = "";
            parametros[7] = "";
            parametros[8] = "";
            parametros[9] = "";
            parametros[10] = "";
            parametros[11] = "";
            parametros[12] = "";
            return ExecutarProcedure(nomeProcedure, parametros);
        }

        public void Editar_Pessoa()
        {
            try
            {

            }
            catch
            {

            }
        }

        public void Excluir_Pessoa()
        {
            try
            {

            }
            catch
            {

            }
        }

        public void Listar_pessoa()
        {
            try
            {

            }
            catch
            {

            }
        }

        public bool ExecutarProcedure(string nomeProcedure, string[] sqlProcedure)
        {
            bool retorno = false;
            MySqlTransaction trans = null;

            try
            {
                trans = conexao.con.BeginTransaction();  //INICIO

                conexao.cmd = new MySqlCommand(nomeProcedure, conexao.con);
                conexao.cmd.Parameters.AddWithValue("NOME", sqlProcedure[0]);
                conexao.cmd.Parameters.AddWithValue("TELEFONE", sqlProcedure[1]);
                conexao.cmd.Parameters.AddWithValue("DOCUMENTO", sqlProcedure[2]);
                conexao.cmd.Parameters.AddWithValue("EMAIL", sqlProcedure[3]);
                conexao.cmd.Parameters.AddWithValue("TIPO", sqlProcedure[4]);
                conexao.cmd.Parameters.AddWithValue("ENDERECO", sqlProcedure[5]);
                conexao.cmd.Parameters.AddWithValue("NUMERO", sqlProcedure[6]);
                conexao.cmd.Parameters.AddWithValue("BAIRRO", sqlProcedure[7]);
                conexao.cmd.Parameters.AddWithValue("CEP", sqlProcedure[8]);
                conexao.cmd.Parameters.AddWithValue("CIDADE", sqlProcedure[9]);
                conexao.cmd.Parameters.AddWithValue("USUARIO", sqlProcedure[10]);
                conexao.cmd.Parameters.AddWithValue("SENHA", sqlProcedure[11]);
                conexao.cmd.Parameters.AddWithValue("SALT_SENHA", sqlProcedure[12]);
                conexao.cmd.CommandType = CommandType.StoredProcedure;
                int resposta = conexao.cmd.ExecuteNonQuery();

                if (resposta != 0)
                {
                    retorno = true;
                    trans.Commit();
                }
            }
            catch (Exception ex)
            {
                trans.Rollback();
                Utilitario.util_Msgbox.Aviso("Erro ao executar Query: " + ex.Message.ToString());
            }
            finally
            {
                conexao.con.Close();
            }
            return retorno;
        }
    }
}