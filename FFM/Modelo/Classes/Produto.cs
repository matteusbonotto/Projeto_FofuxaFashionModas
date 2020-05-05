using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FFM.Conexao;
// Recebe e Trata as informações para o banco de dados
namespace FFM
{
    public class Produto : CRUD
    {
        public Produto()
        {

        }
        private clsConexao conexao;
        private Int32 iID_Produto;
        private String sCodigo_Barras;
        private Int32 iQuantidade;
        private Double dPreco_Compra;
        private Double dPreco_Venda;

        public int IID_Produto { get => iID_Produto; set => iID_Produto = value; }
        public int IQuantidade { get => iQuantidade; set => iQuantidade = value; }
        public double DPreco_Compra { get => dPreco_Compra; set => dPreco_Compra = value; }
        public double DPreco_Venda { get => dPreco_Venda; set => dPreco_Venda = value; }
        public string SCodigo_Barras { get => sCodigo_Barras; set => sCodigo_Barras = value; }
    }
}