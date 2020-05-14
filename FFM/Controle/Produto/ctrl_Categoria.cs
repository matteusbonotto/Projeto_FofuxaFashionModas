using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FFM.Controle.Produto
{
    public class Produto_Categoria : ctrl_Produto
    {
        private Int32 iID_Produto_Categoria;
        private String sProduto_Descricao_Categoria;

        public int IID_Produto_Categoria { get => iID_Produto_Categoria; set => iID_Produto_Categoria = value; }
        public string SProduto_Descricao_Categoria { get => sProduto_Descricao_Categoria; set => sProduto_Descricao_Categoria = value; }
    }
}