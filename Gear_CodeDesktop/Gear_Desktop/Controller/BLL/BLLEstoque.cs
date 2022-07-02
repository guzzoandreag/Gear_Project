using Gear_Desktop.Controller.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gear_Desktop.Models;

namespace Gear_Desktop.Controller.BLL
{
    internal class BLLEstoque
    {
        private readonly DALConnectionREST restConnection;

        public BLLEstoque(DALConnectionREST restConnectionParameter)
        {
            //Construtor
            restConnection = restConnectionParameter;
        }

        public async Task<List<Estoque_00>> GetAllEstoque()
        {
            List<Estoque_00> listEstoque = new();
            DALEstoque objDALEstoque = new(restConnection);
            listEstoque = await objDALEstoque.GetAllEstoque();
            return listEstoque;
        }

        public Task<Estoque_00?> GetEstoque(int etqCodigo)
        {
            //Nome = Nome.Trim();
            //if (Nome.Length == 0)
            //{
            //    // resultar a exceção com a mensagem para o formulario
            //    throw new Exception("O campo Nome do Deposito/Fazenda não pode ficar em branco !!");
            //}

            DALEstoque objDALEstoque = new(restConnection);
            return objDALEstoque.GetEstoque(etqCodigo);
        }

        public async Task<string> PostEstoque(Estoque_00 EstoqueParameter)
        {
            var result = "";
            if (Convert.ToString(EstoqueParameter.Pro_codigo).Trim().Length == 0)
            {
                // resultar a exceção com a mensagem para o formulario
                throw new Exception("Favor inserir o codigo do Produto !!");
            }
            if (Convert.ToString(EstoqueParameter.Dep_codigo).Trim().Length == 0)
            {
                // resultar a exceção com a mensagem para o formulario
                throw new Exception("Favor inserir o codigo do Deposito !!");
            }
            if (Convert.ToString(EstoqueParameter.Etq_quantidade).Trim().Length == 0)
            {
                // resultar a exceção com a mensagem para o formulario
                throw new Exception("Favor inserir a quantidade de estoque do Produto !!");
            }
            if (Convert.ToString(EstoqueParameter.Etq_valorcusto).Trim().Length == 0)
            {
                // resultar a exceção com a mensagem para o formulario
                throw new Exception("Favor inserir o custo do Produto !!");
            }
            if (Convert.ToString(EstoqueParameter.Etq_validade).Trim().Length == 0)
            {
                // resultar a exceção com a mensagem para o formulario
                throw new Exception("Favor inserir a data de validade do Produto !!");
            }

            DALEstoque objDALEstoque = new(restConnection);
            result = await objDALEstoque.PostEstoque(EstoqueParameter);
            return Convert.ToString(result);
        }

    }
}
