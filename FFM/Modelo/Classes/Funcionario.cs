using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FFM
{
    public class Funcionario : Departamento
    {
        private Int32 iID_Funcionario;

        public int IID_Funcionario { get => iID_Funcionario; set => iID_Funcionario = value; }
    }
}