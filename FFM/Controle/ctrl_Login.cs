using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FFM.Utilitario;

namespace FFM.Controle
{
    class ctrl_Login
    {
        private Seguranca.HashMD5 hash;
        private Modelo.Login loginModel;
        public void VerificarAcesso(string usuario, string senha)
        {
            if (usuario != "")
            {
                if (senha != "")
                {
                    loginModel = new Modelo.Login();
                    loginModel.Usuario = usuario;

                    if (loginModel.ListarUsuario())
                    {
                        hash = new Seguranca.HashMD5();
                        if (hash.ComparaModificarMD5(senha, loginModel.Senha, loginModel.Salt_senha))
                        {
                            util_Msgbox.Sucesso("Logado Com sucesso");
                        }
                        else
                        {
                            util_Msgbox.Aviso("Senha incorreta, tente novamente!");
                        }
                    }
                    else
                    {
                       util_Msgbox.Aviso( "Usuário não existe, tente novamente!");
                    }
                }
                else
                {
                    util_Msgbox.Aviso( "Digite uma senha válida!");
                }
            }
            else
            {
                util_Msgbox.Aviso( "Digite um usuário válido!");
            }

        }
    }
}

