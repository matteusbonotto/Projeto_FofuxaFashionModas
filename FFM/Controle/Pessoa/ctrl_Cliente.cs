using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FFM.Controle.Pessoa
{
    public class Cliente : Pessoa_Categoria
    {
        private Int32 iID_Cliente;

        public int IID_Cliente { get => iID_Cliente; set => iID_Cliente = value; }
    }
}