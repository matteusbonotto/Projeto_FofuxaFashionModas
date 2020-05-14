using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using FFM.Controle.Pessoa.Usuario;

namespace FFM.Modelo
{
    public class mdlo_Login
    {
        public String sLicenca;
        private String sQuery;
        private MySqlConnection con;
        private Conexao.clsConexao conexao;

        public DataTable Verifica_Acesso( String _sEmail, String _sSenha)
        {
            con = new MySqlConnection();
            conexao = new Conexao.clsConexao();
            con.ConnectionString = conexao.sGlob_Conexao;
            sQuery = "SELECT P.Nome, P.Email, PC.Descricao_Pessoas_Categoria, U.Senha, U.Salt_Senha, D.Descricao_licenca "
            + "FROM Pessoas P "
            + "INNER JOIN Usuarios_Acesso U "
            + "ON U.fk_id_Pessoa = P.id_Pessoa "
            + "LEFT JOIN Pessoas_Categoria PC "
            + "ON P.fk_id_Pessoas_Categoria = PC.id_Pessoas_Categoria "
            + "LEFT JOIN Departamentos D "
            + "ON PC.fk_id_Departamento = D.id_Departamento "
            + "WHERE Email = '" + _sEmail + "' AND Senha = '" + _sSenha + "'";

            try
            {
                con.Open();
                MySqlDataAdapter da = new MySqlDataAdapter(sQuery, con);
                DataTable dt = new DataTable();
                da.Fill(dt);


                if (dt.Rows.Count > 0)
                {
                    return dt;
                }
                else
                {
                    return null;
                }

            }
            catch (Exception ex)
            {
                Utilitario.util_Msgbox.Aviso("Erro:" + ex);
            }
            finally
            {
                con.Close();
            }
            return null;
        }
    }
}