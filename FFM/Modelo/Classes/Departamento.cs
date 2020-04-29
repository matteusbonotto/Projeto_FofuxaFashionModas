using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FFM
{
    public class Departamento : Pessoa_Categoria
    {
        private Int32 iID_Departamento;
        private String sDepartamento;

        public int IID_Departamento { get => iID_Departamento; set => iID_Departamento = value; }
        public string SDepartamento { get => sDepartamento; set => sDepartamento = value; }
    }
}