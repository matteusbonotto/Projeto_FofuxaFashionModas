using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FFM.Controle;
using FFM.Conexao;
using MySql.Data.MySqlClient;

namespace FFM
{
    public abstract class CRUD
    {      
        #region "Funcionário"
        //###########################################################################################
        //############################       Classe Funcionário       ###############################
        //###########################################################################################
        #endregion

        #region "Produto"
        //###########################################################################################
        //############################       Classe Produto           ###############################
        //###########################################################################################
        public void Cadastrar_Produto()
        {

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