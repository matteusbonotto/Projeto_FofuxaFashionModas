using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FFM.Utilitario;

namespace FFM.Controle.Pessoa.Usuario
{
    class ctrl_Login
    {

        private string nome, email, senha, licenca, salt_senha, tipo_usuario;

        public string Email { get => email; set => email = value; }
        public string Senha { get => senha; set => senha = value; }
        public string Licenca { get => licenca; set => licenca = value; }
        public string Salt_senha { get => salt_senha; set => salt_senha = value; }
        public string Tipo_usuario { get => tipo_usuario; set => tipo_usuario = value; }
        public string Nome { get => nome; set => nome = value; }


        //Verificações

        public bool Verifica_Acesso()
        {
            Modelo.mdlo_Login mdloLogin = new Modelo.mdlo_Login();
            DataTable dt = new DataTable();
            dt = mdloLogin.Verifica_Acesso(email, senha);
            if (dt.Rows.Count > 0)
            {
                nome = Convert.ToString(dt.Rows[0][0]);
                licenca = Convert.ToString(dt.Rows[0][2]);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}

