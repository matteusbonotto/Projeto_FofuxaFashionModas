using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FFM
{
    public class Departamento : Pessoa_Categoria
    {
        private Int32 iID_Departamento;
        private String sDescricao_Departamento;
        private String sDescricao_Licenca;

        public int IID_Departamento { get => iID_Departamento; set => iID_Departamento = value; }
        public string SDescricao_Departamento { get => sDescricao_Departamento; set => sDescricao_Departamento = value; }
        public string SDescricao_Licenca { get => sDescricao_Licenca; set => sDescricao_Licenca = value; }
    }
}