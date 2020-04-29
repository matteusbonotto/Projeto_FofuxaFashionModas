using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FFM
{
    public class Pessoa_Categoria : Pessoa
    {
        private Int32 iID_Pessoa_Categoria;
        private String sTipo_Cliente;
        private String sTipo_Funcionario;

        public int IID_Pessoa_Categoria { get => iID_Pessoa_Categoria; set => iID_Pessoa_Categoria = value; }
        public string STipo_Cliente { get => sTipo_Cliente; set => sTipo_Cliente = value; }
        public string STipo_Funcionario { get => sTipo_Funcionario; set => sTipo_Funcionario = value; }
    }
}