using FFM.Conexao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFM.Modelo
{
    class EnviarEmail
    {
        private Conexao.clsConexao conexao;
        private string usuario, nome, email, senha, salt_senha;
        private int id_usuario;

        public string Usuario { get => usuario; set => usuario = value; }
        public string Nome { get => nome; set => nome = value; }
        public string Email { get => email; set => email = value; }
        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
        public string Senha { get => senha; set => senha = value; }
        public string Salt_senha { get => salt_senha; set => salt_senha = value; }

        public bool VerificarEmailCadastrado()
        {
            conexao = new Conexao.clsConexao();

            string sqlQuery = string.Format("SELECT U.ID_USUARIO,U.USUARIO, P.NOME FROM USUARIO U INNER JOIN PESSOA P " +
                "ON P.ID_PESSOA=U.FK_ID_PESSOA WHERE P.EMAIL='{0}'", email);

            DataTable table = conexao.ListarTabela(sqlQuery);

            if (table.Rows.Count > 0)
            {
                id_usuario = Convert.ToInt32(table.Rows[0][0].ToString());
                usuario = table.Rows[0][1].ToString();
                nome = table.Rows[0][2].ToString();

                return true;
            }
            else
            {
                return false;
            }

        }

        public bool AtualizarSenha()
        {
            conexao = new Conexao.clsConexao();
            string sqlQuery = string.Format("UPDATE USUARIO SET SENHA='{0}', SALT_SENHA='{1}' WHERE ID_USUARIO={2}",
                senha, salt_senha, id_usuario);

            return conexao.ExecutarQuery(sqlQuery);
        }
    }
}
