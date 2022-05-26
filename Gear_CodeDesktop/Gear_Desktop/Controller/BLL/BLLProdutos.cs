using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gear_Desktop.Models;
using Gear_Desktop.Controller.DAL;

namespace Gear_Desktop.Controller.BLL
{
    public class BLLProdutos
    {
        private readonly DALConnectionREST restConnection;

        public BLLProdutos(DALConnectionREST restConnectionParameter)
        {
            //Construtor
            restConnection = restConnectionParameter;
        }

        public Task<Produto_00?> GetProduto(int proCodigo)
        {
            //Nome = Nome.Trim();
            //if (Nome.Length == 0)
            //{
            //    // resultar a exceção com a mensagem para o formulario
            //    throw new Exception("O campo Nome do Deposito/Fazenda não pode ficar em branco !!");
            //}

            DALProdutos objDALProduto = new(restConnection);
            return objDALProduto.GetProduto(proCodigo);
        }

        public async Task<string> PostProdutos(Produto_00 ProdutoParameter)
        {
            var result = "";
            if (ProdutoParameter.Pro_nome.Trim().Length == 0)
            {
                // resultar a exceção com a mensagem para o formulario
                throw new Exception("Favor inserir o nome do Produto !!");
            }

            if (Convert.ToString(ProdutoParameter.Pro_valorcusto).Trim().Length == 0)
            {
                // resultar a exceção com a mensagem para o formulario
                throw new Exception("Favor inserir o Valor (R$) de Custo !!");
            }
            if (Convert.ToString(ProdutoParameter.Pro_Grupo).Trim().Length == 0)
            {
                // resultar a exceção com a mensagem para o formulario
                throw new Exception("Favor inserir o Grupo!!");
            }
            if (Convert.ToString(ProdutoParameter.Pro_Medida).Trim().Length == 0)
            {
                // resultar a exceção com a mensagem para o formulario
                throw new Exception("Favor inserir a Unidade de Medida !!");
            }

            DALProdutos objDALProduto = new(restConnection);
            result = await objDALProduto.PostProduto(ProdutoParameter);
            return Convert.ToString(result);
        }

    }
}
