using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FFM.Controle
{
    class ctrl_Login
    {
        private Seguranca.HashMD5 hash;
        private Modelo.mdlo_Login loginModel;
        public void VerificarAcesso(string usuario, string senha)
        {
            if (usuario != "" && usuario != "usuario")
            {
                if (senha != "" && senha != "senha")
                {
                    loginModel = new Modelo.mdlo_Login();
                    loginModel.Usuario = usuario;

                    if (loginModel.ListarUsuario())
                    {
                        hash = new Seguranca.HashMD5();
                        if (hash.ComparaModificarMD5(senha, loginModel.Senha, loginModel.Salt_senha))
                        {
                            //Msgbox.show("Sucesso");
                        }
                        else
                        {
                            //Msgbox.show("Senha incorreta, tente novamente!");
                        }
                    }
                    else
                    {
                        //Msgbox.show( "Usuário não existe, tente novamente!");
                    }
                }
                else
                {
                    //Msgbox.show( "Digite uma senha válida!");
                }
            }
            else
            {
                //Msgbox.show( "Digite um usuário válido!");
            }

        }
    }
}

