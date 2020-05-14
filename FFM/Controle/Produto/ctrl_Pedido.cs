using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FFM.Controle.Produto
{
    public class Pedido : Produto_Detalhes
    {
        private Int32 iID_Pedido;
        private Int32 iNumero_Pedido;

        public int IID_Pedido { get => iID_Pedido; set => iID_Pedido = value; }
        public int INumero_Pedido { get => iNumero_Pedido; set => iNumero_Pedido = value; }
    }
}