using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FFM
{
    public abstract class Endereço : CRUD
    {
        private Int32 iID_Endereco;
        private String sTipo_Logradouro;
        private String sLougradoro;
        private Int32 iNumero;
        private String sComplemento;
        private String sBairro;
        private String sCidade;
        private String sEstado;
        private String sCEP;
        private String sUF;

        public int IID_Endereco { get => iID_Endereco; set => iID_Endereco = value; }
        public string STipo_Logradouro { get => sTipo_Logradouro; set => sTipo_Logradouro = value; }
        public string SLougradoro { get => sLougradoro; set => sLougradoro = value; }
        public int INumero { get => iNumero; set => iNumero = value; }
        public string SComplemento { get => sComplemento; set => sComplemento = value; }
        public string SBairro { get => sBairro; set => sBairro = value; }
        public string SCidade { get => sCidade; set => sCidade = value; }
        public string SEstado { get => sEstado; set => sEstado = value; }
        public string SCEP { get => sCEP; set => sCEP = value; }
        public string SUF { get => sUF; set => sUF = value; }
    }
}