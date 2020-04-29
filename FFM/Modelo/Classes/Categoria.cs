using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FFM
{
    public abstract class Produto_Categoria : Produto
    {
        private Int32 iID_Produto_Categoria;
        private String sRoupas;
        private String sCalças;
        private String sSapatos;

        public int IID_Produto_Categoria { get => iID_Produto_Categoria; set => iID_Produto_Categoria = value; }
        public string SRoupas { get => sRoupas; set => sRoupas = value; }
        public string SCalças { get => sCalças; set => sCalças = value; }
        public string SSapatos { get => sSapatos; set => sSapatos = value; }
    }
}