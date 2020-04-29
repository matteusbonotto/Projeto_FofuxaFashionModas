using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FFM.Controle
{
    class ctrl_EnviarEmail
    {
        private Modelo.mdlo_EnviarEmail emailModelo;
        private Utilitario.util_EnviarEmail enviarEmail;
        private Seguranca.HashMD5 hash;
        private string MensagemSplashScreen;
        public string EnviarEmailRecuperarSenha(string emailUsuario)
        {

            // System.Windows.Forms.MessageBox.Show(emailUsuario);
            if (emailUsuario != "" && emailUsuario != "E-mail")
            {
                emailModelo = new Modelo.mdlo_EnviarEmail();
                emailModelo.Email = emailUsuario;

                MensagemSplashScreen = "Enviando e-mail";
                Thread thread = new Thread(new ThreadStart(IniciarSplashScreen));
                thread.Start();
                Thread.Sleep(2000);

                if (emailModelo.VerificarEmailCadastrado())
                {

                    int id_usuario = emailModelo.Id_usuario;
                    string nomeUsuario = emailModelo.Nome;

                    var novaSenha = CadastrarNovaSenha(id_usuario);
                    if (novaSenha != "")
                    {
                        enviarEmail = new Utilitario.util_EnviarEmail();
                        enviarEmail.AssuntoEmail = "Recuperação de senha";
                        enviarEmail.DestinatarioEmail = emailUsuario;
                        enviarEmail.NomeRemetente = "Fofuxa Fashion Modas - Roupas Plus Size";
                        enviarEmail.MensagemEmail = string.Format("Caro(a) {0}, <br/><br/>" +
                         "Você solicitou a recuperação de sua senha de acesso ao sistema da nossa Loja. Abaixo as informações para acesso:<br/><br/>" +
                         "Senha: {1}" +
                         "<br/><br/>Favor não responder à este e-mail. Esta mensagem é gerada automática. <br/> Lojas Fofuxa Fashion Modas -Roupas Plus Size",
                        nomeUsuario, novaSenha);

                        if (enviarEmail.EnviaEmailRecuperarSenha())
                        {
                            thread.Abort();
                            MessageBox.Show("Sucesso ao enviar e-mail!", "Recuperar senha", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            return "Sucesso";
                        }
                        else
                        {
                            thread.Abort();
                            return "Não foi possível enviar e-mail.";
                        }
                    }
                    else
                    {
                        thread.Abort();
                        return "Não foi possível gerar nova senha!";
                    }

                }
                else
                {
                    thread.Abort();
                    return "E-mail não cadastrado, verifique e tente novamente!";
                }

            }
            else
            {
                return "E-mail inválido, verifique e tente novamente!";
            }
        }
        public void IniciarSplashScreen()
        {
            //Application.Run(new ScreenSplash(MensagemSplashScreen));
        }
        private string CadastrarNovaSenha(int id_usuario)
        {
            hash = new Seguranca.HashMD5();
            emailModelo = new Modelo.mdlo_EnviarEmail();
            Random random = new Random();

            string novaSenha = null;

            string[] aletorioLetra = {"A","a", "B", "b", "C", "c", "D", "d", "E", "e", "F", "f", "G", "g", "H", "h", "I", "i", "J", "j", "K", "k", "L", "l", "M", "m",
            "N","n", "O", "o", "P", "p", "Q", "q", "R", "r", "S", "s", "T", "t", "U", "u", "V", "v", "W", "w", "X", "x", "Y", "y", "Z", "z"};

            for (int i = 0; i < 8; i++)
            {
                int p = random.Next(0, aletorioLetra.Length);
                novaSenha += aletorioLetra[p] + random.Next(0, 9).ToString();
            }

            string[] novaSenhaHash = hash.ModificarMD5(novaSenha);

            /*COM RETORNO DO VETOR novaSenhaHash É ENVIADO PARA BANCO PARA CADASTRAR A SENHA
             * NA POSIÇÃO VETOR[0] = HASH DA SENHA
             * NA POSIÇÃO VETOR[1] = HASH SALT DA SENHA
             */
            emailModelo.Id_usuario = id_usuario;
            emailModelo.Senha = novaSenhaHash[0];
            emailModelo.Salt_senha = novaSenhaHash[1];

            if (emailModelo.AtualizarSenha())
            {
                return novaSenha;
            }
            else
            {
                return null;
            }
        }
    }
}
