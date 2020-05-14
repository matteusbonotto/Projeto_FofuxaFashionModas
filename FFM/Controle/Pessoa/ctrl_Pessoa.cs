using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FFM.Controle.Pessoa
{
    public abstract class Pessoa : Modelo.CRUDPessoa
    {
        private Int32 iID_Pessoa;
        private String sPessoa_Nome;
        private String sPessoa_Email;
        private Int32 iPessoa_Telefone;
        private DateTime dtPessoa_DataNascimento;
        private String sPessoa_Sexo;

        public int IID_Pessoa { get => iID_Pessoa; set => iID_Pessoa = value; }
        public string SPessoa_Nome { get => sPessoa_Nome; set => sPessoa_Nome = value; }
        public string SPessoa_Email { get => sPessoa_Email; set => sPessoa_Email = value; }
        public int IPessoa_Telefone { get => iPessoa_Telefone; set => iPessoa_Telefone = value; }
        public DateTime DtPessoa_DataNascimento { get => dtPessoa_DataNascimento; set => dtPessoa_DataNascimento = value; }
        public string SPessoa_Sexo { get => sPessoa_Sexo; set => sPessoa_Sexo = value; }
    }
}