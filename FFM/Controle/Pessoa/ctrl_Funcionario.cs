using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FFM.Controle.Pessoa
{
    public class Funcionario : Pessoa_Categoria
    {
        private Int32 iID_Funcionario;

        public int IID_Funcionario { get => iID_Funcionario; set => iID_Funcionario = value; }
    }
}