using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FFM
{
    public abstract class Produto : CRUD
    {
        private Int32 iID_Produto;
        private Int32 iCodigo_Barras;
        private Int32 iQuantidade;
        private String dPreco_Compra;
        private String dPreco_Venda;

        public int IID_Produto { get => iID_Produto; set => iID_Produto = value; }
        public int ICodigo_Barras { get => iCodigo_Barras; set => iCodigo_Barras = value; }
        public int IQuantidade { get => iQuantidade; set => iQuantidade = value; }
        public string DPreco_Compra { get => dPreco_Compra; set => dPreco_Compra = value; }
        public string DPreco_Venda { get => dPreco_Venda; set => dPreco_Venda = value; }
    }
}