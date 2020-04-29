using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FFM
{
    public abstract class Pessoa : CRUD
    {
        private Int32 iID_Pessoa;
        private String sPessoa_Cpf_Cnpj;
        private String sPessoa_Nome;
        private String sPessoa_Email;
        private String sPessoa_Telefone;
        private DateTime sPessoa_DataNascimento;
        private String sSexo;

        public int IID_Pessoa { get => iID_Pessoa; set => iID_Pessoa = value; }
        public string SPessoa_Cpf_Cnpj { get => sPessoa_Cpf_Cnpj; set => sPessoa_Cpf_Cnpj = value; }
        public string SPessoa_Nome { get => sPessoa_Nome; set => sPessoa_Nome = value; }
        public string SPessoa_Email { get => sPessoa_Email; set => sPessoa_Email = value; }
        public string SPessoa_Telefone { get => sPessoa_Telefone; set => sPessoa_Telefone = value; }
        public DateTime SPessoa_DataNascimento { get => sPessoa_DataNascimento; set => sPessoa_DataNascimento = value; }
        public string SSexo { get => sSexo; set => sSexo = value; }
    }
}