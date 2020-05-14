using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace FFM.Utilitario
{
    class util_EnviarEmail
    {
        /*Instanciando client e mensagem biblioteca email*/
        SmtpClient cliente;
        MailMessage mensagem;

        /*variaveis para encapsular os dados*/
        private string email,
                nomeRemetente,
                destinatarioEmail,
                assuntoEmail,
                mensagemEmail;

        /*declarando variaveis e passando valores referente a utilização de cada uma, conexão com servidor e-mail*/
        private string serverSmtp = "smtp.gmail.com",
                serverPorta = "587",
                serverEmail = "5si.fofuxa.fashion.modas@gmail.com",
                serverSenha = "123456A@";

        public string Email { get => email; set => email = value; }
        public string NomeRemetente { get => nomeRemetente; set => nomeRemetente = value; }
        public string DestinatarioEmail { get => destinatarioEmail; set => destinatarioEmail = value; }
        public string AssuntoEmail { get => assuntoEmail; set => assuntoEmail = value; }
        public string MensagemEmail { get => mensagemEmail; set => mensagemEmail = value; }

        /*Passando variáveis para a configuração do email*/
        private void ConfiguracaoServidor()
        {
            cliente = new SmtpClient(serverSmtp, Int32.Parse(serverPorta));
            cliente.Host = serverSmtp;
            cliente.EnableSsl = true;
            cliente.Credentials = new System.Net.NetworkCredential(serverEmail, serverSenha);
        }

        private void ConfiguracaoMensagem()
        {
            mensagem = new MailMessage();
            mensagem.Sender = new MailAddress(serverEmail, nomeRemetente);
            mensagem.From = new MailAddress(serverEmail, nomeRemetente);
            mensagem.To.Add(new MailAddress(destinatarioEmail));
            mensagem.Subject = assuntoEmail;
            mensagem.Body = mensagemEmail;
            mensagem.IsBodyHtml = true;
            mensagem.Priority = MailPriority.Normal;
        }
        public bool EnviaEmailRecuperarSenha()
        {
            try
            {
                ConfiguracaoServidor();
                ConfiguracaoMensagem();

                cliente.Send(mensagem);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Envio e-mail", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            finally
            {
                mensagem = null;
            }

        }
    }
}
