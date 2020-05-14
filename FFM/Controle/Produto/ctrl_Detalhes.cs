using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FFM.Controle.Produto
{
    public class Produto_Detalhes : Produto_Categoria
    {
        private String sNome_Produto;
        private String sNome_Arquivo;
        private String sDescricao_Produto;
        private String sTamanho;
        private String sCor;
        private Byte[] imgImagem;

        public string SNome_Produto { get => sNome_Produto; set => sNome_Produto = value; }
        public string STamanho { get => sTamanho; set => sTamanho = value; }
        public string SCor { get => sCor; set => sCor = value; }
        public string SNome_Arquivo { get => sNome_Arquivo; set => sNome_Arquivo = value; }
        public byte[] ImgImagem { get => imgImagem; set => imgImagem = value; }
        public string SDescricao_Produto { get => sDescricao_Produto; set => sDescricao_Produto = value; }
    }
}