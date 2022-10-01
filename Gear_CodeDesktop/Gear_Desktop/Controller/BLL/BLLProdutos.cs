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

        public async Task<List<Produto_00>> GetAllProdutos()
        {
            List<Produto_00> listProdutos = new();
            DALProdutos objDALProdutos = new(restConnection);
            listProdutos = await objDALProdutos.GetAllProdutos();
            return listProdutos;
        }

        public async Task<Produto_00?> GetProduto(int proCodigo)
        {
            //Nome = Nome.Trim();
            //if (Nome.Length == 0)
            //{
            //    // resultar a exceção com a mensagem para o formulario
            //    throw new Exception("O campo Nome do Deposito/Fazenda não pode ficar em branco !!");
            //}

            DALProdutos objDALProduto = new(restConnection);
            return await objDALProduto.GetProduto(proCodigo);
        }

        public async Task<string> PutProdutos(Produto_00 ProdutoParameter)
        {
            if (ProdutoParameter.Pro_nome.Trim().Length == 0)
            {
                // resultar a exceção com a mensagem para o formulario
                throw new Exception("Favor inserir o nome do Produto !!");
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
            return await objDALProduto.PutProduto(ProdutoParameter);
        }

        public async Task<Produto_00?> PostProdutos(Produto_00 ProdutoParameter)
        {
            if (ProdutoParameter.Pro_nome.Trim().Length == 0)
            {
                // resultar a exceção com a mensagem para o formulario
                throw new Exception("Favor inserir o nome do Produto !!");
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
            return await objDALProduto.PostProduto(ProdutoParameter);
        }

        public async Task<string> DeleteProduto(int proCodigo)
        {
            if (Convert.ToString(proCodigo).Trim().Length == 0)
            {
                // resultar a exceção com a mensagem para o formulario
                throw new Exception("Favor inserir o Codigo do Produto!!");
            }
            DALProdutos objDALProdutos = new(restConnection);
            return await objDALProdutos.DeleteProduto(proCodigo);
        }

        ~BLLProdutos()
        {
            // Destroyer
        }
    }
}
