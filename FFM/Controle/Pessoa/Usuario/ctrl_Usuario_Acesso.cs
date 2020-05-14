using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FFM.Controle.Pessoa.Usuario
{
    public class Usuario_Acesso : Pessoa
    {
        private Int32 iID_Usuairo_Acesso;
        private String sSenha;
        private String sSenha_Hash;
        private String sSalt_Henha_Hash;
        
        public int IID_Usuairo_Acesso { get => iID_Usuairo_Acesso; set => iID_Usuairo_Acesso = value; }
        public string SSenha { get => sSenha; set => sSenha = value; }
        public string SSenha_Hash { get => sSenha_Hash; set => sSenha_Hash = value; }
        public string SSalt_Henha_Hash { get => sSalt_Henha_Hash; set => sSalt_Henha_Hash = value; }
    }
}