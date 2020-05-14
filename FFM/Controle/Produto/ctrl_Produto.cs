using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FFM.Conexao;
using FFM.Modelo;

namespace FFM.Controle.Produto
{
    public class ctrl_Produto : mdlo_Produto
    {
        private clsConexao conexao;
        private Int32 iID_Produto;
        private String sCodigo_Barras;
        private Int32 iQuantidade;
        private Double dPreco_Compra;
        private Double dPreco_Venda;
        private mdlo_Produto mdloProduto;
        private Produto_Categoria ctrlCategoria;
        private Produto_Detalhes ctrlDetalhes;

        public int IID_Produto { get => iID_Produto; set => iID_Produto = value; }
        public string SCodigo_Barras { get => sCodigo_Barras; set => sCodigo_Barras = value; }
        public int IQuantidade { get => iQuantidade; set => iQuantidade = value; }
        public double DPreco_Compra { get => dPreco_Compra; set => dPreco_Compra = value; }
        public double DPreco_Venda { get => dPreco_Venda; set => dPreco_Venda = value; }

        public void Cadastrar_Produtos(Int32 _iID_Produto, /*byte[] _imgImagem,*/ String _sNome_Produto, String _sDescricao_Produto, String _sCor, String _sCategoria, String _sTamanho, Int32 _iQuantidade, String _sCodigo_Barras, Double _dPreco_Compra, Double _dPreco_Venda)
        {
            mdloProduto = new mdlo_Produto();
            ctrlCategoria = new Produto_Categoria();
            ctrlDetalhes = new Produto_Detalhes();

            iID_Produto = _iID_Produto;
            //ctrlDetalhes.ImgImagem = _imgImagem;
            ctrlDetalhes.SNome_Produto = _sNome_Produto;
            ctrlDetalhes.SDescricao_Produto = _sDescricao_Produto;
            ctrlDetalhes.SCor = _sCor;
            ctrlCategoria.SProduto_Descricao_Categoria = _sCategoria;
            ctrlDetalhes.STamanho = _sTamanho;
            IQuantidade = _iQuantidade;
            sCodigo_Barras = _sCodigo_Barras;
            DPreco_Compra = _dPreco_Compra;
            dPreco_Venda = _dPreco_Venda;

            //mdloProduto.Cadastrar_Produto(_iID_Produto, _sNome_Produto, _sDescricao_Produto, _sCor, _sCategoria, _sTamanho, _iQuantidade, _sCodigo_Barras, _dPreco_Venda, _dPreco_Venda);

            mdloProduto.Cadastrar_Produto(
                iID_Produto,
                //ctrlDetalhes.ImgImagem,
                ctrlDetalhes.SNome_Produto,
                ctrlDetalhes.SDescricao_Produto,
                ctrlDetalhes.SCor,
                ctrlCategoria.SProduto_Descricao_Categoria,
                ctrlDetalhes.STamanho,
                IQuantidade,
                sCodigo_Barras,
                DPreco_Compra,
                dPreco_Venda
                );
        }
    }
}