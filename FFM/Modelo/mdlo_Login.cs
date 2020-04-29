using FFM.Visual;
using FFM.Modelo;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace FFM.Modelo
{
    class mdlo_Login
    {
        private Conexao.clsConexao conexao;


        private string usuario, senha, nome_usuario, salt_senha;
        private int tipo_usuario;

        public string Usuario { get => usuario; set => usuario = value; }
        public string Senha { get => senha; set => senha = value; }
        public string Nome_usuario { get => nome_usuario; set => nome_usuario = value; }
        public string Salt_senha { get => salt_senha; set => salt_senha = value; }
        public int Tipo_usuario { get => tipo_usuario; set => tipo_usuario = value; }


        public bool ListarUsuario()
        {
            conexao = new Conexao.clsConexao();
            string sqlQuery = string.Format("SELECT U.ID_USUARIO,U.USUARIO, P.NOME,P.TIPO_PESSOA,U.SENHA,U.SALT_SENHA FROM USUARIO U INNER JOIN PESSOA P " +
                "ON P.ID_PESSOA = U.FK_ID_PESSOA WHERE USUARIO='{0}'", usuario);

            DataTable table = new DataTable();
            table = conexao.ListarTabela(sqlQuery);

            if (table.Rows.Count > 0)
            {
                nome_usuario = table.Rows[0][2].ToString();
                tipo_usuario = Convert.ToInt32(table.Rows[0][3].ToString());
                senha = table.Rows[0][4].ToString();
                salt_senha = table.Rows[0][5].ToString();

                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
