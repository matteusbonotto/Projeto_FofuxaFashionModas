﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FFM.Controle;
using FFM.Conexao;
using FFM.Modelo;
using MySql.Data.MySqlClient;
using System.Data;

namespace FFM
{  
    public class CRUD
    {
        //Variaveis Globais
        private clsConexao Conexao;
        private String SqlQuery;
        #region "Funcionário"
        //###########################################################################################
        //############################       Classe Funcionário       ###############################
        //###########################################################################################
        #endregion

        #region "Pessoa"
        //###########################################################################################
        //############################       Classe Pessoa            ###############################
        //###########################################################################################
        public bool Cadastrar_Pessoa()
        {
            Conexao = new clsConexao();
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
            
        }

        public void Excluir_Pessoa()
        {

        }

        public void Listar_pessoa()
        {

        }

        public bool ExecutarProcedure(string nomeProcedure, string[] sqlProcedure)
        {
            bool retorno = false;
            MySqlTransaction trans = null;
            Conexao = new clsConexao();
            try
            {
                    trans = Conexao.con.BeginTransaction();  //INICIO

                Conexao.cmd = new MySqlCommand(nomeProcedure, Conexao.con);
                Conexao.cmd.Parameters.AddWithValue("NOME_PESSOA", sqlProcedure[0]);
                Conexao.cmd.Parameters.AddWithValue("TELEFONE_PESSOA", sqlProcedure[1]);
                Conexao.cmd.Parameters.AddWithValue("CPF_PESSOA", sqlProcedure[2]);
                Conexao.cmd.Parameters.AddWithValue("EMAIL_PESSOA", sqlProcedure[3]);
                Conexao.cmd.Parameters.AddWithValue("TIPO", sqlProcedure[4]);
                Conexao.cmd.Parameters.AddWithValue("RUA_PESSOA", sqlProcedure[5]);
                Conexao.cmd.Parameters.AddWithValue("NUMERO_PESSOA", sqlProcedure[6]);
                Conexao.cmd.Parameters.AddWithValue("BAIRRO_PESSOA", sqlProcedure[7]);
                Conexao.cmd.Parameters.AddWithValue("CEP_PESSOA", sqlProcedure[8]);
                Conexao.cmd.Parameters.AddWithValue("ID_CIDADE", sqlProcedure[9]);
                Conexao.cmd.Parameters.AddWithValue("USUARIO_PESSOA", sqlProcedure[10]);
                Conexao.cmd.Parameters.AddWithValue("SENHA_PESSOA", sqlProcedure[11]);
                Conexao.cmd.Parameters.AddWithValue("SALT_SENHA_PESSOA", sqlProcedure[12]);
                Conexao.cmd.CommandType = CommandType.StoredProcedure;
                    int resposta = Conexao.cmd.ExecuteNonQuery();

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
                Conexao.con.Close();
            }
            return retorno;
        }

        #endregion

        #region "Produto"
        //###########################################################################################
        //############################       Classe Produto           ###############################
        //###########################################################################################



        public bool Cadastrar_Produto(Int32 _iID_Produto, String _sNome_Arquivo, String _sNome_Produto, String _sDescricao_Produto, String _sCor, String _sCategoria, String _sTamanho, Int32 _iQuantidade, String _sCodigo_Barras, Double _dPreco_Compra, Double _dPreco_Venda)
        {
            ctrl_Cadastro_Produto Cadastro_Produtos = new ctrl_Cadastro_Produto();
            Visual.Forms.Cadastros.frm_Cadastrar_Produtos cadastroProdutos = new Visual.Forms.Cadastros.frm_Cadastrar_Produtos();
            try
            {
                /*Legenda e ordem das variaveis na String de Conexão
                    * {0} = _iID_Produto
                    * {1} = _sNome_Arquivo
                    * {2} = _sNome_Produto
                    * {3} = _sDescricao_Produto
                    * {4} = _sCor
                    * {5} = _sCategoria
                    * {6} = _sTamanho
                    * {7} = _dPreco_Compra
                    * {8} = _dPreco_Venda
                */
                //1 Linha da query é a Insert, Delete, update, Select
                SqlQuery = "INSERT INTO ";

                //Tabela do Banco de dados
                SqlQuery += "Produtos";

                //Colunas Produtos
                SqlQuery += "(";
                SqlQuery += "id_Produto, ";
                SqlQuery += "codigo_Barras, ";
                SqlQuery += "preco_Venda, ";
                SqlQuery += "preco_Compra, ";
                SqlQuery += "quantidade";
                SqlQuery += ")";

                //Valores
                SqlQuery += " VALUES"; //, IID_Produto, ImgImagem); 
                SqlQuery  += "(";
                SqlQuery  += "{0}, ";
                SqlQuery += "'{1}', ";
                SqlQuery  += "{2}, ";
                SqlQuery  += "{3}, ";
                SqlQuery  += "{4}";
                SqlQuery  += "), ";


                // Parametros                                        
                SqlQuery += _iID_Produto;
                SqlQuery += _sCodigo_Barras;
                SqlQuery += _dPreco_Venda;
                SqlQuery += _dPreco_Compra;
                SqlQuery += _iQuantidade;

                //1 Linha da query é a Insert, Delete, update, Select
                SqlQuery = "INSERT INTO ";

                //Tabela Produtos_Categoria
                SqlQuery += "Produtos_Categoria";

                //Coluna Categoria
                SqlQuery += "(";
                SqlQuery += " Descricao_Categoria_Produto";
                SqlQuery += "),";

                //Valores
                SqlQuery += " VALUES";
                SqlQuery += "(";
                SqlQuery += "'{0}'";
                SqlQuery += ")";

                // Parametros                                        
                SqlQuery += _sCategoria;




                //Colunas Detalhes
                SqlQuery += "Imagem_Produto)";



                //Valores
                SqlQuery += " VALUES(";//, IID_Produto, ImgImagem);
                SqlQuery += "{0},";
                SqlQuery += "{1},";
                SqlQuery += "{2},";
                SqlQuery += "{3},";
                SqlQuery += "{4},";
                SqlQuery += "{5},";
                SqlQuery += "{6},";
                SqlQuery += "{7},";
                SqlQuery += "{8})";

                // Parametros

                cadastroProdutos.CarregaImagem();

                ;//Abro a Conexão
                Conexao.con.Open();

                //Preparo o comando MySql
                Conexao.cmd.Connection = Conexao.con;

                //Executo o comando MySql
                Conexao.cmd.CommandText = SqlQuery;

                //Adicionando ao Banco de dados
                Conexao.cmd.Parameters.AddWithValue("",_dPreco_Compra);

                //Executa a Query
                Conexao.ExecutarQuery(SqlQuery);

            }
            finally
            {

            }


            
            return true;
        }

        public void Editar_Produto()
        {

        }

        public void Excluir_Produto()
        {

        }

        public void Listar_Produto()
        {

        }
        #endregion

        #region "Categoria"
        //###########################################################################################
        //############################       Classe Categoria       ###############################
        //###########################################################################################
        #endregion

        #region "Item"
        //###########################################################################################
        //############################           Classe Item          ###############################
        //###########################################################################################



        #endregion

        #region "Pedido"
        //###########################################################################################
        //############################       Classe Pedido       ####################################
        //###########################################################################################
        #endregion

        #region "Departamento"
        //###########################################################################################
        //############################       Classe Departamento       ##############################
        //###########################################################################################
        public void Cadastrar_Departamento()
        {

        }

        public void Editar_Departamento()
        {

        }

        public void Excluir_Departamento()
        {

        }

        public void Listar_Departamento()
        {

        }
        #endregion

        #region "Cliente"
        //###########################################################################################
        //############################       Classe Cliente       ###################################
        //###########################################################################################
        #endregion

        #region "Licenca"
        //###########################################################################################
        //############################       Classe Licenca           ###############################
        //###########################################################################################
        public void Cadastrar_Licenca()
        {

        }

        public void Editar_Licenca()
        {

        }

        public void Excluir_Licenca()
        {

        }

        public void Listar_Licenca()
        {

        }

    //    public bool VerificaLicenca(String _sUsuario)
    //    {
    //    //private VIRTUAL.Virtual_Login LoginV;
    //    private MySqlConnection con;
    //    //private CONEXAO.conexao Conexao;

    //    con = new MySqlConnection();

    //        LoginV = new VIRTUAL.Virtual_Login();
    //        Conexao = new CONEXAO.conexao();
    //        Conexao.clsConexao.
    //        String query = "SELECT licenca FROM usuarios where usuario = ?usuario";

    //        try
    //        {
    //            con.Open();
    //            MySqlCommand cmd = new MySqlCommand(query, con);
    //            cmd.Parameters.AddWithValue("?usuario", _sUsuario);
    //            MySqlDataReader oDR = cmd.ExecuteReader();
    //            while (oDR.Read())
    //            {
    //                LoginV.Licenca1 = oDR.GetString(0);
    //            }
    //            return oDR.Read();
    //        }


    //        catch (Exception ex)
    //        {
    //            return false;
    //            Utilitarios.MsgErro("SistemaMercado.DAO.DAO_Login" + ex);
    //        }
    //        finally
    //        {
    //            con.Close();
    //        }
    //}


    #endregion

    #region "Funcionário"
    //###########################################################################################
    //############################       Classe Funcionário       ###############################
    //###########################################################################################
    #endregion

    #region "Endereco"
    //###########################################################################################
    //############################       Classe Endereco          ###############################
    //###########################################################################################
    #endregion

}
}