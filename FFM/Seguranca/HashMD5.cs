using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FFM.Seguranca
{
    class HashMD5
    {
        public bool ComparaModificarMD5(string senha_digitada, string senha_banco, string salt_senha)
        {
            var verificar = RetornarMD5(RetornarMD5(senha_digitada) + salt_senha);
            using (MD5 md5Hash = MD5.Create())
                return VerificarHash(md5Hash, senha_banco, verificar);

            /*System.Windows.Forms.MessageBox.Show("Senha digitada: "+ senha_digitada + 
            *"\nSenha banco: " + senha_banco + "\nSenha salt: " + salt_senha + "\nSenha verificar: " + verificar);*/
        }

        public string[] ModificarMD5(string senha)
        {

            Random random = new Random();
            string[] retornoHash = new string[2];
            string saltSenha = senha;
            string[] aletorioLetra = {"A","a", "B", "b", "C", "c", "D", "d", "E", "e", "F", "f", "G", "g", "H", "h", "I", "i", "J", "j", "K", "k", "L", "l", "M", "m",
            "N","n", "O", "o", "P", "p", "Q", "q", "R", "r", "S", "s", "T", "t", "U", "u", "V", "v", "W", "w", "X", "x", "Y", "y", "Z", "z"};

            for (int i = 0; i < aletorioLetra.Length; i++)
            {
                int pos = random.Next(0, aletorioLetra.Length);
                saltSenha += aletorioLetra[pos] + random.Next(0, 999999999) + aletorioLetra[i] + senha;
            }
            senha = RetornarMD5(senha);
            saltSenha = RetornarMD5(saltSenha);

            retornoHash[0] = RetornarMD5(senha + saltSenha);
            retornoHash[1] = saltSenha;

            return retornoHash;
        }
        private string RetornarMD5(string Senha)
        {
            using (MD5 md5Hash = MD5.Create())
            {
                return RetonarHash(md5Hash, Senha);
            }
        }

        private bool ComparaMD5(string senhabanco, string Senha_MD5)
        {
            using (MD5 md5Hash = MD5.Create())
            {
                var senha = RetornarMD5(senhabanco);
                if (VerificarHash(md5Hash, Senha_MD5, senha))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        private string RetonarHash(MD5 md5Hash, string input)
        {
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));

            StringBuilder sBuilder = new StringBuilder();

            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }

        private bool VerificarHash(MD5 md5Hash, string input, string hash)
        {
            StringComparer compara = StringComparer.OrdinalIgnoreCase;

            if (0 == compara.Compare(input, hash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
