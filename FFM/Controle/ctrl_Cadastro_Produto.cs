using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
// Validações
namespace FFM.Controle
{
    class ctrl_Cadastro_Produto
    {
        public ctrl_Cadastro_Produto()
        {

        }

        public void Cadastrar_Produto(Int32 _iID_Produto, String _sNome_Arquivo, String _sNome_Produto, String _sDescricao_Produto, String _sCor, String _sCategoria, String _sTamanho, String _sCodigo_Barras, Double _dPreco_Compra, Double _dPreco_Venda)
        {
            Produto csp = new Produto();
            Produto_Categoria csc = new Produto_Categoria();
            Produto_Detalhes csd = new Produto_Detalhes();
            CRUD crud = new CRUD();
            try
            {
                if (_iID_Produto != 0)
                {
                    //Passo oque veio do Controle para as Variaveis Encapsuladas do Modelo
                    csp.IID_Produto = _iID_Produto;
                    csp.DPreco_Compra = _dPreco_Compra;
                    csp.DPreco_Venda = _dPreco_Venda;
                    csc.SProduto_Descricao_Categoria = _sCategoria;
                    csd.SNome_Arquivo = _sNome_Arquivo;
                    csd.SNome_Produto = _sNome_Produto;
                    csd.SDescricao_Produto = _sDescricao_Produto;
                    csd.SCor = _sCor;
                    csd.STamanho = _sTamanho;

                    //Passo as Variaveis do Modelo para os parametros do CRUD para Cadastrar os dados
                    crud.Cadastrar_Produto(csp.IID_Produto, csd.SNome_Arquivo, csd.SNome_Produto, csd.SDescricao_Produto, csd.SCor, csc.SProduto_Descricao_Categoria, csd.STamanho,csp.IQuantidade, csp.SCodigo_Barras, csp.DPreco_Compra, csp.DPreco_Venda);
                }
                else
                {
                    Utilitario.util_Msgbox.Aviso("Não foi Possivel Cadastrar o produto, verifique se você o selecionou, ou se algum dado esta incorreto.");
                }
            }
            finally
            {
                //Destruo os objetos para não ocupar memoria
                csp = null;
                csc = null;
                csd = null;
                crud = null;
            }
        }
    }
}
