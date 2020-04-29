using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FFM
{
    public class Produto_Detalhes : Produto_Categoria
    {
        private String sNome_Produto;
        private String sTamanho;
        private String sCor;

        public string SNome_Produto { get => sNome_Produto; set => sNome_Produto = value; }
        public string STamanho { get => sTamanho; set => sTamanho = value; }
        public string SCor { get => sCor; set => sCor = value; }
    }
}